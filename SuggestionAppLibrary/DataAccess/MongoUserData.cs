using MongoDB.Driver;
using System.Security.Cryptography.X509Certificates;

namespace SuggestionAppLibrary.DataAccess;

public class MongoUserData : IUserData
{
    private readonly IMongoCollection<UserModel> _users;
    // ask DbConnection for user collection
    public MongoUserData(IDbConnection db)
    {
        _users = db.UserCollection;
    }

    // methods
    public async Task<List<UserModel>> GetUsersAsync()
    {
        // return every record (every collection will be true)
        var results = await _users.FindAsync(_ => true);
        return results.ToList();
    }

    // get one user
    public async Task<UserModel> GetUser(string id)
    {
        var results = await _users.FindAsync(u => u.Id == id);
        return results.FirstOrDefault();
    }
    // to look up user from Azure login
    public async Task<UserModel> GetUserFromAuthentication(string objectId)
    {
        var results = await _users.FindAsync(u => u.ObjectIdentifier == objectId);
        return results.FirstOrDefault();
    }
    public Task CreateUser(UserModel user)
    {
        return _users.InsertOneAsync(user);
    }
    public Task UpdateUser(UserModel user)
    {
        // if it finds item through filter it updates it, if not it inserts it
        var filter = Builders<UserModel>.Filter.Eq("Id", user.Id);
        return _users.ReplaceOneAsync(filter, user, new ReplaceOptions { IsUpsert = true });
    }
}

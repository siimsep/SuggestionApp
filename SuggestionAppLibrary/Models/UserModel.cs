namespace SuggestionAppLibrary.Models;

public class UserModel
{
    // Mongodb identifier
    [BsonId]
    // object id
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    // next one is for Azure ID
    public string ObjectIdentifier { get; set; }    
    public string FirstName { get; set; }  
    public string LastName { get; set; }    
    public string DisplayName { get; set; }
    public string EmailAddress { get; set; }
    // list of suggestions what user has created
    // Basic to limit data what is stored, no need for everything
    public List<BasicSuggestionModel> AuthoredSuggestions { get; set; } = new();
    // list of suggestions what user has voted
    public List<BasicSuggestionModel> VotedOnSuggestions { get; set; } = new();
}


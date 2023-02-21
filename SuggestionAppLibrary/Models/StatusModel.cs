namespace SuggestionAppLibrary.Models
{
public class StatusModel
{
        // Mongodb identifier
        [BsonId]
        // object id
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string StatusName { get; set; }  
        public string StatusDescription { get; set; }
    }
}

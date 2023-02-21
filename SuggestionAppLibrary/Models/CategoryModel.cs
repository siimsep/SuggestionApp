namespace SuggestionAppLibrary.Models
{
    public class CategoryModel
    {
        // Mongodb identifier
        [BsonId]
        // object id
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }
} 

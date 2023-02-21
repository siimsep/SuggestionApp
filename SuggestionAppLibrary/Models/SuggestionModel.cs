namespace SuggestionAppLibrary.Models;

public class SuggestionModel
{
    // Mongodb identifier
    [BsonId]
    // object id
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Suggestion { get; set; }  
    public string Description { get; set; }
    // would be wise to change time in the future, universal atm
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    public CategoryModel Category { get; set; } 
    public BasicUserModel Author { get; set; }
    // a list of unique values, so that one user cannot vote more than once, new means its initialized, makes it more compact
    public HashSet<string> UserVotes { get; set; } = new();
    public StatusModel SuggestionStatus { get; set; }
    public string OwnerNotes { get; set; }
    // by default false just to be very clear
    public bool ApprovedForRelease { get; set; } = false;
    public bool Archived { get; set; } = false;
    public bool Rejected { get; set; } = false;
} 

using System.Reflection;

namespace SuggestionAppLibrary.Models;

// this will not be stoed in a collection, will be a subobject of usermodel
public class BasicSuggestionModel
{

    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }  
    public string Suggestion { get; set; }
    

public BasicSuggestionModel()
{
// this is just incase, implicit
}
public BasicSuggestionModel(SuggestionModel suggestion)
{
    Id = suggestion.Id;
    Suggestion = suggestion.Suggestion;
}
}


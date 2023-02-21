using Microsoft.Extensions.DependencyInjection;

namespace SuggestionAppUI
{
    public static class RegisterServices
    {
        // moved dependency injection configuration into new extension method
        public static void ConfigureServices(this WebApplicationBuilder builder) {
            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            // add memory cache
            builder.Services.AddMemoryCache();

            builder.Services.AddSingleton<IDbConnection, DbConnection>();
            builder.Services.AddSingleton<ICategoryData, MongoCategoryData>();
            builder.Services.AddSingleton<IStatusData, MongoStatusData>(); 
            builder.Services.AddSingleton<ISuggestionData, MongoSuggestionData>();
            builder.Services.AddSingleton<IUserData, MongoUserData>();
        }
    }
}

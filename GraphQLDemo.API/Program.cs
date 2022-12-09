using GraphQLDemo.API.Schema.Mutations;
using GraphQLDemo.API.Schema.Queries;
using GraphQLDemo.API.Schema.Subscriptions;
using GraphQLDemo.API.Services;


internal class Program
{
    private readonly IConfiguration _configuration;

    internal Program(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    private static void Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);
        builder.Services
            .AddGraphQLServer()
            .AddQueryType<Query>()
            .AddMutationType<Mutation>()
            .AddSubscriptionType<Subscription>()

            .AddInMemorySubscriptions();

            //.AddPooledDBContextFactory<SchoolDbContext>(o => o.UseSqlite(connectionString));

        var app = builder.Build();

        app.UseWebSockets();

        app.MapGraphQL();

        app.Run();
    }
}


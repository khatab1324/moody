var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGraphQLServer().AddQueryType<UserQuery>();
builder.Services.AddSingleton<UserRepo>();
var app = builder.Build();

app.MapGet("/", () => "this QraphQl server and this is the only rest api to open the nitro -> /graphql ");
app.MapGraphQL("/graphql");
app.Run();

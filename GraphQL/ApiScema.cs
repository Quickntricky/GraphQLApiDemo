using GraphQL;
using GraphQL.Types;

namespace GraphQLApi.GraphQL
{
    public class ApiSchema : Schema
    {
        public ApiSchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<Query>();
        }
    }
}
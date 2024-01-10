using GraphQL.Types;
using GraphQLApi.Models;

namespace GraphQLApi.GraphQL
{
    public class RawDataType : ObjectGraphType<RawData>
    {
        public RawDataType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the RawData.");
            Field(x => x.OpenTime).Description("The OpenTime of the RawData");
            Field(x => x.Open).Description("The Open of the RawData");
            Field(x => x.Close).Description("The Close of the RawData");
            Field(x => x.High).Description("The High of the RawData");
            Field(x => x.Low).Description("The Low of the RawData");
            Field(x => x.SymbolName).Description("The SymbolName of the RawData");

        }
    }

}
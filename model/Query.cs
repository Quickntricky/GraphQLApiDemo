using GraphQL;
using GraphQL.Types;
using GraphQLApi.Models;

namespace GraphQLApi.GraphQL
{

    public class Query : ObjectGraphType
    {
        private List<RawData> _rawcandeldata = new List<RawData> {
        new RawData { Id = "1", Close = 1.0,  High = 1.0, Low = 1.0, Open = 1.0, OpenTime = DateTime.Now, SymbolName = "EURUSD" },
        new RawData { Id = "2", Close = 1.0,  High = 1.0, Low = 1.0, Open = 1.0, OpenTime = DateTime.Now, SymbolName = "EURUSD" }
        };
        public Query()
        {
            Field<ListGraphType<RawDataType>>("rawdata").Argument<StringGraphType>("Id").Resolve(
                context => new RawData[] {
                    new RawData { Id = "1", Close = 1.0,  High = 1.0, Low = 1.0, Open = 1.0, OpenTime = DateTime.Now, SymbolName = "EURUSD" },
                    new RawData { Id = "2", Close = 1.0,  High = 1.0, Low = 1.0, Open = 1.0, OpenTime = DateTime.Now, SymbolName = "EURUSD" }

                });
        }
        /*
                [GraphQLMetadata("rawcandeldata")]
                public IEnumerable<RawData> GetRawCandelDatas()
                {
                    return _rawcandeldata;
                }

                [GraphQLMetadata("rawcandel")]
                public RawData GetRawCandelDataBy(string id)
                {
                    return _rawcandeldata.FirstOrDefault(x => x.Id == id);
                }
        */

    }
}
namespace UKParliament
{
    using UKParliament.Model;
    using VDS.RDF;

    public class UKParliamentDataView
    {
        public UKParliamentDataView(IGraph graph, QueryParameters queryParameters)
        {
            this.Graph = new UKParliamentDynamicGraph(graph);
            this.QueryParameters = queryParameters;
        }

        public UKParliamentDynamicGraph Graph;

        public QueryParameters QueryParameters;
    }
}

namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class IndexingAndSearchThing : ExternalThing
    {
        public IndexingAndSearchThing(INode node) : base(node) { }

        public ICollection<string> IndexingAndSearchUri => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.IndexingAndSearchUri));
    }
}

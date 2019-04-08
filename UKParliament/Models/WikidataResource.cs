namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class WikidataResource : UKParliamentDynamicNode
    {
        public WikidataResource(INode node) : base(node) { }

        public ICollection<WikidataThing> WikidataResourceHasEquivalentWikidataThing => new DynamicObjectCollection<WikidataThing>(this, Property(UKParliamentOntology.WikidataResourceHasEquivalentWikidataThing));
    }
}

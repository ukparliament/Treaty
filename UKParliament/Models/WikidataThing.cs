namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class WikidataThing : ExternalThing
    {
        public WikidataThing(INode node) : base(node) { }

        public ICollection<WikidataResource> WikidataThingHasEquivalentWikidataResource => new DynamicObjectCollection<WikidataResource>(this, Property(UKParliamentOntology.WikidataThingHasEquivalentWikidataResource));
    }
}

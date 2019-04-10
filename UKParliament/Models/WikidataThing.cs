namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class WikidataThing : ExternalThing
    {
        public WikidataThing(INode node) : base(node) { }

        public ICollection<WikidataResource> WikidataThingHasEquivalentWikidataResource => new DynamicObjectCollection<WikidataResource>(this, Property(UKParliamentOntology.WikidataThingHasEquivalentWikidataResource.Uri));
    }
}

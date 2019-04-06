namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class WebsiteLabelledThing : UKParliamentDynamicNode
    {
        public WebsiteLabelledThing(INode node) : base(node) { }

        public ICollection<string> WebsiteLabel => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.WebsiteLabel));
    }
}

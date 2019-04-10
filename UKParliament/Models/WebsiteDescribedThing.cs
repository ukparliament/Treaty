namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class WebsiteDescribedThing : UKParliamentDynamicNode
    {
        public WebsiteDescribedThing(INode node) : base(node) { }

        public ICollection<string> WebsiteDescription => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.WebsiteDescription.Uri));
    }
}

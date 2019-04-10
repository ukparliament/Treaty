namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class WebLink : UKParliamentDynamicNode
    {
        public WebLink(INode node) : base(node) { }

        public ICollection<WebLinkedThing> WebLinkHasWebLinkedThing => new DynamicObjectCollection<WebLinkedThing>(this, Property(UKParliamentOntology.WebLinkHasWebLinkedThing.Uri));
    }
}

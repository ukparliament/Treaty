namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class BusinessItemWebLink : UKParliamentDynamicNode
    {
        public BusinessItemWebLink(INode node) : base(node) { }

        public ICollection<BusinessItem> BusinessItemWebLinkHasBusinessItem => new DynamicObjectCollection<BusinessItem>(this, Property(UKParliamentOntology.BusinessItemWebLinkHasBusinessItem));
    }
}

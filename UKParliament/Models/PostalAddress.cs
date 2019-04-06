namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PostalAddress : UKParliamentDynamicNode
    {
        public PostalAddress(INode node) : base(node) { }

        public ICollection<ContactPoint> PostalAddressHasContactPoint => new DynamicObjectCollection<ContactPoint>(this, Property(UKParliamentOntology.PostalAddressHasContactPoint));

        public ICollection<string> AddressLine1 => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.AddressLine1));

        public ICollection<string> AddressLine2 => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.AddressLine2));

        public ICollection<string> AddressLine3 => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.AddressLine3));

        public ICollection<string> AddressLine4 => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.AddressLine4));

        public ICollection<string> AddressLine5 => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.AddressLine5));

        public ICollection<string> PostCode => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.PostCode));
    }
}

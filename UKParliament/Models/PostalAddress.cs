namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PostalAddress : UKParliamentDynamicNode
    {
        public PostalAddress(INode node) : base(node) { }

        public ICollection<ContactPoint> PostalAddressHasContactPoint => new DynamicObjectCollection<ContactPoint>(this, Property(UKParliamentOntology.PostalAddressHasContactPoint));

        public string AddressLine1 => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.AddressLine1))).SingleOrDefault();

        public string AddressLine2 => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.AddressLine2))).SingleOrDefault();

        public string AddressLine3 => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.AddressLine3))).SingleOrDefault();

        public string AddressLine4 => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.AddressLine4))).SingleOrDefault();

        public string AddressLine5 => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.AddressLine5))).SingleOrDefault();

        public string PostCode => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.PostCode))).SingleOrDefault();
    }
}

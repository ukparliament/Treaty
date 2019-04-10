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

        public ICollection<ContactPoint> PostalAddressHasContactPoint => new DynamicObjectCollection<ContactPoint>(this, Property(UKParliamentOntology.PostalAddressHasContactPoint.Uri));

        public string AddressLine1 => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.AddressLine1.Uri))).SingleOrDefault();

        public string AddressLine2 => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.AddressLine2.Uri))).SingleOrDefault();

        public string AddressLine3 => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.AddressLine3.Uri))).SingleOrDefault();

        public string AddressLine4 => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.AddressLine4.Uri))).SingleOrDefault();

        public string AddressLine5 => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.AddressLine5.Uri))).SingleOrDefault();

        public string PostCode => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.PostCode.Uri))).SingleOrDefault();
    }
}

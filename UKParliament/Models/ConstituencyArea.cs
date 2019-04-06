namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ConstituencyArea : Place
    {
        public ConstituencyArea(INode node) : base(node) { }

        public ICollection<ConstituencyGroup> ConstituencyAreaHasConstituencyGroup => new DynamicObjectCollection<ConstituencyGroup>(this, Property(UKParliamentOntology.ConstituencyAreaHasConstituencyGroup));

        public ICollection<Country> ConstituencyAreaHasCountry => new DynamicObjectCollection<Country>(this, Property(UKParliamentOntology.ConstituencyAreaHasCountry));

        public ICollection<string> ConstituencyAreaExtent => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ConstituencyAreaExtent));

        public ICollection<string> ConstituencyAreaLatitude => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ConstituencyAreaLatitude));

        public ICollection<string> ConstituencyAreaLongitude => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ConstituencyAreaLongitude));
    }
}

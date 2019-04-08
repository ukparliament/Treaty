namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ConstituencyArea : Place
    {
        public ConstituencyArea(INode node) : base(node) { }

        public ICollection<ConstituencyGroup> ConstituencyAreaHasConstituencyGroup => new DynamicObjectCollection<ConstituencyGroup>(this, Property(UKParliamentOntology.ConstituencyAreaHasConstituencyGroup));

        public Country ConstituencyAreaHasCountry => ((IEnumerable<Country>)new DynamicObjectCollection<Country>(this, Property(UKParliamentOntology.ConstituencyAreaHasCountry))).SingleOrDefault();

        public ICollection<string> ConstituencyAreaExtent => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ConstituencyAreaExtent));

        public string ConstituencyAreaLatitude => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ConstituencyAreaLatitude))).SingleOrDefault();

        public string ConstituencyAreaLongitude => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ConstituencyAreaLongitude))).SingleOrDefault();
    }
}

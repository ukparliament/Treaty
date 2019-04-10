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

        public ICollection<ConstituencyGroup> ConstituencyAreaHasConstituencyGroup => new DynamicObjectCollection<ConstituencyGroup>(this, Property(UKParliamentOntology.ConstituencyAreaHasConstituencyGroup.Uri));

        public Country ConstituencyAreaHasCountry => ((IEnumerable<Country>)new DynamicObjectCollection<Country>(this, Property(UKParliamentOntology.ConstituencyAreaHasCountry.Uri))).SingleOrDefault();

        public ICollection<string> ConstituencyAreaExtent => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ConstituencyAreaExtent.Uri));

        public string ConstituencyAreaLatitude => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ConstituencyAreaLatitude.Uri))).SingleOrDefault();

        public string ConstituencyAreaLongitude => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ConstituencyAreaLongitude.Uri))).SingleOrDefault();
    }
}

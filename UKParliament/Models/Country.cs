namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Country : Place
    {
        public Country(INode node) : base(node) { }

        public ICollection<ConstituencyArea> CountryHasConstituencyArea => new DynamicObjectCollection<ConstituencyArea>(this, Property(UKParliamentOntology.CountryHasConstituencyArea.Uri));

        public ICollection<string> CountryName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.CountryName.Uri));

        public ICollection<string> CountryOfficialName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.CountryOfficialName.Uri));

        public ICollection<string> CountryCitizenNames => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.CountryCitizenNames.Uri));
    }
}

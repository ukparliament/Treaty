namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Country : Place
    {
        public Country(INode node) : base(node) { }

        public ICollection<ConstituencyArea> CountryHasConstituencyArea => new DynamicObjectCollection<ConstituencyArea>(this, Property(UKParliamentOntology.CountryHasConstituencyArea));

        public ICollection<string> CountryName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.CountryName));

        public ICollection<string> CountryOfficialName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.CountryOfficialName));

        public ICollection<string> CountryCitizenNames => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.CountryCitizenNames));
    }
}

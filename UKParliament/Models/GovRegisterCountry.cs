namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class GovRegisterCountry : Country
    {
        public GovRegisterCountry(INode node) : base(node) { }

        public ICollection<string> CountryGovRegisterId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.CountryGovRegisterId));

        public ICollection<DateTimeOffset> GovRegisterCountryStartDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.GovRegisterCountryStartDate));

        public ICollection<DateTimeOffset> GovRegisterCountryEndDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.GovRegisterCountryEndDate));
    }
}

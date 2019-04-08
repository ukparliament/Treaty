namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class GovRegisterCountry : Country
    {
        public GovRegisterCountry(INode node) : base(node) { }

        public string CountryGovRegisterId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.CountryGovRegisterId))).SingleOrDefault();

        public ICollection<DateTimeOffset> GovRegisterCountryStartDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.GovRegisterCountryStartDate));

        public ICollection<DateTimeOffset> GovRegisterCountryEndDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.GovRegisterCountryEndDate));
    }
}

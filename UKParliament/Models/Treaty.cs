namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Treaty : LaidThing
    {
        public Treaty(INode node) : base(node) { }

        public GovernmentOrganisation TreatyHasLeadGovernmentOrganisation => ((IEnumerable<GovernmentOrganisation>)new DynamicObjectCollection<GovernmentOrganisation>(this, Property(UKParliamentOntology.TreatyHasLeadGovernmentOrganisation))).SingleOrDefault();

        public ICollection<SeriesMembership> TreatyHasSeriesMembership => new DynamicObjectCollection<SeriesMembership>(this, Property(UKParliamentOntology.TreatyHasSeriesMembership));

        public CountrySeriesMembership TreatyHasCountrySeriesMembership => ((IEnumerable<CountrySeriesMembership>)new DynamicObjectCollection<CountrySeriesMembership>(this, Property(UKParliamentOntology.TreatyHasCountrySeriesMembership))).SingleOrDefault();

        public EuropeanUnionSeriesMembership TreatyHasEuropeanUnionSeriesMembership => ((IEnumerable<EuropeanUnionSeriesMembership>)new DynamicObjectCollection<EuropeanUnionSeriesMembership>(this, Property(UKParliamentOntology.TreatyHasEuropeanUnionSeriesMembership))).SingleOrDefault();

        public MiscellaneousSeriesMembership TreatyHasMiscellaneousSeriesMembership => ((IEnumerable<MiscellaneousSeriesMembership>)new DynamicObjectCollection<MiscellaneousSeriesMembership>(this, Property(UKParliamentOntology.TreatyHasMiscellaneousSeriesMembership))).SingleOrDefault();

        public string TreatyName => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.TreatyName))).SingleOrDefault();

        public ICollection<DateTimeOffset> TreatyComingIntoForceDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.TreatyComingIntoForceDate));

        public ICollection<string> TreatyComingIntoForceNote => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.TreatyComingIntoForceNote));

        public string TreatyCommandPaperPrefix => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.TreatyCommandPaperPrefix))).SingleOrDefault();

        public int TreatyCommandPaperNumber => ((IEnumerable<int>)new DynamicObjectCollection<int>(this, Property(UKParliamentOntology.TreatyCommandPaperNumber))).SingleOrDefault();
    }
}

namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Treaty : LaidThing
    {
        public Treaty(INode node) : base(node) { }

        public ICollection<GovernmentOrganisation> TreatyHasLeadGovernmentOrganisation => new DynamicObjectCollection<GovernmentOrganisation>(this, Property(UKParliamentOntology.TreatyHasLeadGovernmentOrganisation));

        public ICollection<SeriesMembership> TreatyHasSeriesMembership => new DynamicObjectCollection<SeriesMembership>(this, Property(UKParliamentOntology.TreatyHasSeriesMembership));

        public ICollection<CountrySeriesMembership> TreatyHasCountrySeriesMembership => new DynamicObjectCollection<CountrySeriesMembership>(this, Property(UKParliamentOntology.TreatyHasCountrySeriesMembership));

        public ICollection<EuropeanUnionSeriesMembership> TreatyHasEuropeanUnionSeriesMembership => new DynamicObjectCollection<EuropeanUnionSeriesMembership>(this, Property(UKParliamentOntology.TreatyHasEuropeanUnionSeriesMembership));

        public ICollection<MiscellaneousSeriesMembership> TreatyHasMiscellaneousSeriesMembership => new DynamicObjectCollection<MiscellaneousSeriesMembership>(this, Property(UKParliamentOntology.TreatyHasMiscellaneousSeriesMembership));

        public ICollection<string> TreatyName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.TreatyName));

        public ICollection<DateTimeOffset> TreatyComingIntoForceDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.TreatyComingIntoForceDate));

        public ICollection<string> TreatyComingIntoForceNote => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.TreatyComingIntoForceNote));

        public ICollection<string> TreatyCommandPaperPrefix => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.TreatyCommandPaperPrefix));

        public ICollection<int> TreatyCommandPaperNumber => new DynamicObjectCollection<int>(this, Property(UKParliamentOntology.TreatyCommandPaperNumber));
    }
}

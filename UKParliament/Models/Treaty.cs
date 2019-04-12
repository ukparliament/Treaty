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

        public GovernmentOrganisation TreatyHasLeadGovernmentOrganisation => ((IEnumerable<GovernmentOrganisation>)new DynamicObjectCollection<GovernmentOrganisation>(this, Property(UKParliamentOntology.TreatyHasLeadGovernmentOrganisation.Uri))).SingleOrDefault();

        public ICollection<SeriesMembership> TreatyHasSeriesMembership => new DynamicObjectCollection<SeriesMembership>(this, Property(UKParliamentOntology.TreatyHasSeriesMembership.Uri));

        public CountrySeriesMembership TreatyHasCountrySeriesMembership => ((IEnumerable<CountrySeriesMembership>)new DynamicObjectCollection<CountrySeriesMembership>(this, Property(UKParliamentOntology.TreatyHasCountrySeriesMembership.Uri))).SingleOrDefault();

        public EuropeanUnionSeriesMembership TreatyHasEuropeanUnionSeriesMembership => ((IEnumerable<EuropeanUnionSeriesMembership>)new DynamicObjectCollection<EuropeanUnionSeriesMembership>(this, Property(UKParliamentOntology.TreatyHasEuropeanUnionSeriesMembership.Uri))).SingleOrDefault();

        public MiscellaneousSeriesMembership TreatyHasMiscellaneousSeriesMembership => ((IEnumerable<MiscellaneousSeriesMembership>)new DynamicObjectCollection<MiscellaneousSeriesMembership>(this, Property(UKParliamentOntology.TreatyHasMiscellaneousSeriesMembership.Uri))).SingleOrDefault();

        public string TreatyName => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.TreatyName.Uri))).SingleOrDefault();

        public ICollection<DateTimeOffset> TreatyComingIntoForceDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.TreatyComingIntoForceDate.Uri));

        public ICollection<string> TreatyComingIntoForceNote => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.TreatyComingIntoForceNote.Uri));

        public string TreatyCommandPaperPrefix => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.TreatyCommandPaperPrefix.Uri))).SingleOrDefault();

        public System.Int64 TreatyCommandPaperNumber => ((IEnumerable<System.Int64>)new DynamicObjectCollection<System.Int64>(this, Property(UKParliamentOntology.TreatyCommandPaperNumber.Uri))).SingleOrDefault();
    }
}

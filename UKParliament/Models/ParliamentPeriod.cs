namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ParliamentPeriod : UKParliamentDynamicNode
    {
        public ParliamentPeriod(INode node) : base(node) { }

        public ICollection<BusinessItem> ParliamentPeriodHasBusinessItem => new DynamicObjectCollection<BusinessItem>(this, Property(UKParliamentOntology.ParliamentPeriodHasBusinessItem.Uri));

        public ParliamentPeriod ParliamentPeriodHasImmediatelyPreviousParliamentPeriod => ((IEnumerable<ParliamentPeriod>)new DynamicObjectCollection<ParliamentPeriod>(this, Property(UKParliamentOntology.ParliamentPeriodHasImmediatelyPreviousParliamentPeriod.Uri))).SingleOrDefault();

        public ICollection<ParliamentPeriod> ParliamentPeriodHasImmediatelyFollowingParliamentPeriod => new DynamicObjectCollection<ParliamentPeriod>(this, Property(UKParliamentOntology.ParliamentPeriodHasImmediatelyFollowingParliamentPeriod.Uri));

        public ICollection<SeatIncumbency> ParliamentPeriodHasSeatIncumbency => new DynamicObjectCollection<SeatIncumbency>(this, Property(UKParliamentOntology.ParliamentPeriodHasSeatIncumbency.Uri));

        public DateTimeOffset ParliamentPeriodStartDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.ParliamentPeriodStartDate.Uri))).SingleOrDefault();

        public System.Int64 ParliamentPeriodNumber => ((IEnumerable<System.Int64>)new DynamicObjectCollection<System.Int64>(this, Property(UKParliamentOntology.ParliamentPeriodNumber.Uri))).SingleOrDefault();
    }
}

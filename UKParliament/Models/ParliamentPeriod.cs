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

        public ICollection<BusinessItem> ParliamentPeriodHasBusinessItem => new DynamicObjectCollection<BusinessItem>(this, Property(UKParliamentOntology.ParliamentPeriodHasBusinessItem));

        public ParliamentPeriod ParliamentPeriodHasImmediatelyPreviousParliamentPeriod => ((IEnumerable<ParliamentPeriod>)new DynamicObjectCollection<ParliamentPeriod>(this, Property(UKParliamentOntology.ParliamentPeriodHasImmediatelyPreviousParliamentPeriod))).SingleOrDefault();

        public ICollection<ParliamentPeriod> ParliamentPeriodHasImmediatelyFollowingParliamentPeriod => new DynamicObjectCollection<ParliamentPeriod>(this, Property(UKParliamentOntology.ParliamentPeriodHasImmediatelyFollowingParliamentPeriod));

        public ICollection<SeatIncumbency> ParliamentPeriodHasSeatIncumbency => new DynamicObjectCollection<SeatIncumbency>(this, Property(UKParliamentOntology.ParliamentPeriodHasSeatIncumbency));

        public DateTimeOffset ParliamentPeriodStartDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.ParliamentPeriodStartDate))).SingleOrDefault();

        public int ParliamentPeriodNumber => ((IEnumerable<int>)new DynamicObjectCollection<int>(this, Property(UKParliamentOntology.ParliamentPeriodNumber))).SingleOrDefault();
    }
}

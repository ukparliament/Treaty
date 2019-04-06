namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ParliamentPeriod : UKParliamentDynamicNode
    {
        public ParliamentPeriod(INode node) : base(node) { }

        public ICollection<BusinessItem> ParliamentPeriodHasBusinessItem => new DynamicObjectCollection<BusinessItem>(this, Property(UKParliamentOntology.ParliamentPeriodHasBusinessItem));

        public ICollection<ParliamentPeriod> ParliamentPeriodHasImmediatelyPreviousParliamentPeriod => new DynamicObjectCollection<ParliamentPeriod>(this, Property(UKParliamentOntology.ParliamentPeriodHasImmediatelyPreviousParliamentPeriod));

        public ICollection<ParliamentPeriod> ParliamentPeriodHasImmediatelyFollowingParliamentPeriod => new DynamicObjectCollection<ParliamentPeriod>(this, Property(UKParliamentOntology.ParliamentPeriodHasImmediatelyFollowingParliamentPeriod));

        public ICollection<SeatIncumbency> ParliamentPeriodHasSeatIncumbency => new DynamicObjectCollection<SeatIncumbency>(this, Property(UKParliamentOntology.ParliamentPeriodHasSeatIncumbency));

        public ICollection<DateTimeOffset> ParliamentPeriodStartDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.ParliamentPeriodStartDate));

        public ICollection<int> ParliamentPeriodNumber => new DynamicObjectCollection<int>(this, Property(UKParliamentOntology.ParliamentPeriodNumber));
    }
}

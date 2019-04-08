namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class FocusPeriod : UKParliamentDynamicNode
    {
        public FocusPeriod(INode node) : base(node) { }

        public ICollection<FormalBody> FocusPeriodHasFormalBody => new DynamicObjectCollection<FormalBody>(this, Property(UKParliamentOntology.FocusPeriodHasFormalBody));

        public ICollection<Focus> FocusPeriodHasFocus => new DynamicObjectCollection<Focus>(this, Property(UKParliamentOntology.FocusPeriodHasFocus));

        public DateTimeOffset FocusPeriodStartDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.FocusPeriodStartDate))).SingleOrDefault();

        public DateTimeOffset FocusPeriodEndDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.FocusPeriodEndDate))).SingleOrDefault();
    }
}

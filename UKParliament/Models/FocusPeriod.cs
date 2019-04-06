namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class FocusPeriod : UKParliamentDynamicNode
    {
        public FocusPeriod(INode node) : base(node) { }

        public ICollection<FormalBody> FocusPeriodHasFormalBody => new DynamicObjectCollection<FormalBody>(this, Property(UKParliamentOntology.FocusPeriodHasFormalBody));

        public ICollection<Focus> FocusPeriodHasFocus => new DynamicObjectCollection<Focus>(this, Property(UKParliamentOntology.FocusPeriodHasFocus));

        public ICollection<DateTimeOffset> FocusPeriodStartDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.FocusPeriodStartDate));

        public ICollection<DateTimeOffset> FocusPeriodEndDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.FocusPeriodEndDate));
    }
}

namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class IncumbencyInterruption : UKParliamentDynamicNode
    {
        public IncumbencyInterruption(INode node) : base(node) { }

        public ICollection<Incumbency> IncumbencyInterruptionHasIncumbency => new DynamicObjectCollection<Incumbency>(this, Property(UKParliamentOntology.IncumbencyInterruptionHasIncumbency));

        public ICollection<DateTimeOffset> IncumbencyInterruptionStartDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.IncumbencyInterruptionStartDate));
    }
}

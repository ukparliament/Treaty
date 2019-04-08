namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class IncumbencyInterruption : UKParliamentDynamicNode
    {
        public IncumbencyInterruption(INode node) : base(node) { }

        public Incumbency IncumbencyInterruptionHasIncumbency => ((IEnumerable<Incumbency>)new DynamicObjectCollection<Incumbency>(this, Property(UKParliamentOntology.IncumbencyInterruptionHasIncumbency))).SingleOrDefault();

        public DateTimeOffset IncumbencyInterruptionStartDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.IncumbencyInterruptionStartDate))).SingleOrDefault();
    }
}

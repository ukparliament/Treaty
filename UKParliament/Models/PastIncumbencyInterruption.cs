namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PastIncumbencyInterruption : IncumbencyInterruption
    {
        public PastIncumbencyInterruption(INode node) : base(node) { }

        public DateTimeOffset IncumbencyInterruptionEndDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.IncumbencyInterruptionEndDate))).SingleOrDefault();
    }
}

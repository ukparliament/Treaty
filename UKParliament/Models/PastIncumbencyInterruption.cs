namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PastIncumbencyInterruption : IncumbencyInterruption
    {
        public PastIncumbencyInterruption(INode node) : base(node) { }

        public ICollection<DateTimeOffset> IncumbencyInterruptionEndDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.IncumbencyInterruptionEndDate));
    }
}

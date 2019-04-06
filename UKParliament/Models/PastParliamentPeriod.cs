namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PastParliamentPeriod : ParliamentPeriod
    {
        public PastParliamentPeriod(INode node) : base(node) { }

        public ICollection<DateTimeOffset> ParliamentPeriodEndDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.ParliamentPeriodEndDate));
    }
}

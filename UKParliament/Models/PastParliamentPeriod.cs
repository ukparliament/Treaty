namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PastParliamentPeriod : ParliamentPeriod
    {
        public PastParliamentPeriod(INode node) : base(node) { }

        public DateTimeOffset ParliamentPeriodEndDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.ParliamentPeriodEndDate.Uri))).SingleOrDefault();
    }
}

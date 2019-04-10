namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PastParliamentaryIncumbency : ParliamentaryIncumbency
    {
        public PastParliamentaryIncumbency(INode node) : base(node) { }

        public DateTimeOffset ParliamentaryIncumbencyEndDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.ParliamentaryIncumbencyEndDate.Uri))).SingleOrDefault();
    }
}

namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PastParliamentaryIncumbency : ParliamentaryIncumbency
    {
        public PastParliamentaryIncumbency(INode node) : base(node) { }

        public ICollection<DateTimeOffset> ParliamentaryIncumbencyEndDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.ParliamentaryIncumbencyEndDate));
    }
}

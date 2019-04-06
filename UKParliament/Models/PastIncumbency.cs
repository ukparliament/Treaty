namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PastIncumbency : Incumbency
    {
        public PastIncumbency(INode node) : base(node) { }

        public ICollection<DateTimeOffset> IncumbencyEndDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.IncumbencyEndDate));
    }
}

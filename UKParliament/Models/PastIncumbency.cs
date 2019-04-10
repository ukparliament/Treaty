namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PastIncumbency : Incumbency
    {
        public PastIncumbency(INode node) : base(node) { }

        public DateTimeOffset IncumbencyEndDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.IncumbencyEndDate.Uri))).SingleOrDefault();
    }
}

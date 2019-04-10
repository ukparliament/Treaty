namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PastFormalBody : FormalBody
    {
        public PastFormalBody(INode node) : base(node) { }

        public DateTimeOffset FormalBodyEndDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.FormalBodyEndDate.Uri))).SingleOrDefault();
    }
}

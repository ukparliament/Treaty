namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PastFormalBody : FormalBody
    {
        public PastFormalBody(INode node) : base(node) { }

        public ICollection<DateTimeOffset> FormalBodyEndDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.FormalBodyEndDate));
    }
}

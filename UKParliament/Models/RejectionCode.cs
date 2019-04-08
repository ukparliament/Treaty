namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class RejectionCode : UKParliamentDynamicNode
    {
        public RejectionCode(INode node) : base(node) { }

        public ICollection<Rejection> RejectionCodeHasRejection => new DynamicObjectCollection<Rejection>(this, Property(UKParliamentOntology.RejectionCodeHasRejection));

        public ICollection<string> RejectionCodeName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.RejectionCodeName));
    }
}

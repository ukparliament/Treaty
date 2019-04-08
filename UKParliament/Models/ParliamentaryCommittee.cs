namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ParliamentaryCommittee : FormalBody
    {
        public ParliamentaryCommittee(INode node) : base(node) { }
    }
}

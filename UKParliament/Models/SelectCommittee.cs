namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class SelectCommittee : ParliamentaryCommittee
    {
        public SelectCommittee(INode node) : base(node) { }
    }
}

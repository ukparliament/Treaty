namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class NonSelectCommittee : ParliamentaryCommittee
    {
        public NonSelectCommittee(INode node) : base(node) { }
    }
}

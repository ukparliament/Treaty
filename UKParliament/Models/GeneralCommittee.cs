namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class GeneralCommittee : ParliamentaryCommittee
    {
        public GeneralCommittee(INode node) : base(node) { }
    }
}

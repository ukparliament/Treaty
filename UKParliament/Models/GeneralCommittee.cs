namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class GeneralCommittee : ParliamentaryCommittee
    {
        public GeneralCommittee(INode node) : base(node) { }
    }
}

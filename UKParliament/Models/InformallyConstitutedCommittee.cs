namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class InformallyConstitutedCommittee : FormalBody
    {
        public InformallyConstitutedCommittee(INode node) : base(node) { }
    }
}

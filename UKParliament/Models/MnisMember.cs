namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisMember : Member
    {
        public MnisMember(INode node) : base(node) { }

        public ICollection<string> MemberMnisId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.MemberMnisId));
    }
}

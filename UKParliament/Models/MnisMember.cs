namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisMember : Member
    {
        public MnisMember(INode node) : base(node) { }

        public string MemberMnisId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.MemberMnisId))).SingleOrDefault();
    }
}

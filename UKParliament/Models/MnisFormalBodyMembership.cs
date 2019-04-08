namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisFormalBodyMembership : FormalBodyMembership
    {
        public MnisFormalBodyMembership(INode node) : base(node) { }

        public string FormalBodyMembershipMnisId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.FormalBodyMembershipMnisId))).SingleOrDefault();
    }
}

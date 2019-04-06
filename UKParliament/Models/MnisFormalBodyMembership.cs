namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisFormalBodyMembership : FormalBodyMembership
    {
        public MnisFormalBodyMembership(INode node) : base(node) { }

        public ICollection<string> FormalBodyMembershipMnisId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.FormalBodyMembershipMnisId));
    }
}

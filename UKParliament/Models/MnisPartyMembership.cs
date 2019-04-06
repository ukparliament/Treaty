namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisPartyMembership : PartyMembership
    {
        public MnisPartyMembership(INode node) : base(node) { }

        public ICollection<string> PartyMembershipMnisId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.PartyMembershipMnisId));
    }
}

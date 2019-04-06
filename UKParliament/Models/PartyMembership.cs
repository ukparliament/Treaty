namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PartyMembership : UKParliamentDynamicNode
    {
        public PartyMembership(INode node) : base(node) { }

        public ICollection<PartyMember> PartyMembershipHasPartyMember => new DynamicObjectCollection<PartyMember>(this, Property(UKParliamentOntology.PartyMembershipHasPartyMember));

        public ICollection<Party> PartyMembershipHasParty => new DynamicObjectCollection<Party>(this, Property(UKParliamentOntology.PartyMembershipHasParty));

        public ICollection<DateTimeOffset> PartyMembershipStartDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.PartyMembershipStartDate));
    }
}

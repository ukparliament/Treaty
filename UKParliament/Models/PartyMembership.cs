namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PartyMembership : UKParliamentDynamicNode
    {
        public PartyMembership(INode node) : base(node) { }

        public PartyMember PartyMembershipHasPartyMember => ((IEnumerable<PartyMember>)new DynamicObjectCollection<PartyMember>(this, Property(UKParliamentOntology.PartyMembershipHasPartyMember.Uri))).SingleOrDefault();

        public Party PartyMembershipHasParty => ((IEnumerable<Party>)new DynamicObjectCollection<Party>(this, Property(UKParliamentOntology.PartyMembershipHasParty.Uri))).SingleOrDefault();

        public DateTimeOffset PartyMembershipStartDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.PartyMembershipStartDate.Uri))).SingleOrDefault();
    }
}

namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PastPartyMembership : PartyMembership
    {
        public PastPartyMembership(INode node) : base(node) { }

        public ICollection<DateTimeOffset> PartyMembershipEndDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.PartyMembershipEndDate));
    }
}

namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PastPartyMembership : PartyMembership
    {
        public PastPartyMembership(INode node) : base(node) { }

        public DateTimeOffset PartyMembershipEndDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.PartyMembershipEndDate))).SingleOrDefault();
    }
}

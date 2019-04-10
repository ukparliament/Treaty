namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisPartyMembership : PartyMembership
    {
        public MnisPartyMembership(INode node) : base(node) { }

        public string PartyMembershipMnisId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.PartyMembershipMnisId.Uri))).SingleOrDefault();
    }
}

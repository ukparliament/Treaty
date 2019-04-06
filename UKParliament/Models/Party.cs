namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Party : UKParliamentDynamicNode
    {
        public Party(INode node) : base(node) { }

        public ICollection<PartyMembership> PartyHasPartyMembership => new DynamicObjectCollection<PartyMembership>(this, Property(UKParliamentOntology.PartyHasPartyMembership));

        public ICollection<Candidacy> PartyhasCandidacy => new DynamicObjectCollection<Candidacy>(this, Property(UKParliamentOntology.PartyhasCandidacy));

        public ICollection<string> PartyName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.PartyName));
    }
}

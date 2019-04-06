namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Candidacy : UKParliamentDynamicNode
    {
        public Candidacy(INode node) : base(node) { }

        public ICollection<Candidate> CandidacyHasCandidate => new DynamicObjectCollection<Candidate>(this, Property(UKParliamentOntology.CandidacyHasCandidate));

        public ICollection<Party> CandidacyHasParty => new DynamicObjectCollection<Party>(this, Property(UKParliamentOntology.CandidacyHasParty));

        public ICollection<CandidacyResult> CandidacyHasCandidacyResult => new DynamicObjectCollection<CandidacyResult>(this, Property(UKParliamentOntology.CandidacyHasCandidacyResult));

        public ICollection<Election> CandidacyHasElection => new DynamicObjectCollection<Election>(this, Property(UKParliamentOntology.CandidacyHasElection));
    }
}

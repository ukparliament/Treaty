namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Candidacy : UKParliamentDynamicNode
    {
        public Candidacy(INode node) : base(node) { }

        public Candidate CandidacyHasCandidate => ((IEnumerable<Candidate>)new DynamicObjectCollection<Candidate>(this, Property(UKParliamentOntology.CandidacyHasCandidate))).SingleOrDefault();

        public Party CandidacyHasParty => ((IEnumerable<Party>)new DynamicObjectCollection<Party>(this, Property(UKParliamentOntology.CandidacyHasParty))).SingleOrDefault();

        public CandidacyResult CandidacyHasCandidacyResult => ((IEnumerable<CandidacyResult>)new DynamicObjectCollection<CandidacyResult>(this, Property(UKParliamentOntology.CandidacyHasCandidacyResult))).SingleOrDefault();

        public Election CandidacyHasElection => ((IEnumerable<Election>)new DynamicObjectCollection<Election>(this, Property(UKParliamentOntology.CandidacyHasElection))).SingleOrDefault();
    }
}

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

        public Candidate CandidacyHasCandidate => ((IEnumerable<Candidate>)new DynamicObjectCollection<Candidate>(this, Property(UKParliamentOntology.CandidacyHasCandidate.Uri))).SingleOrDefault();

        public Party CandidacyHasParty => ((IEnumerable<Party>)new DynamicObjectCollection<Party>(this, Property(UKParliamentOntology.CandidacyHasParty.Uri))).SingleOrDefault();

        public CandidacyResult CandidacyHasCandidacyResult => ((IEnumerable<CandidacyResult>)new DynamicObjectCollection<CandidacyResult>(this, Property(UKParliamentOntology.CandidacyHasCandidacyResult.Uri))).SingleOrDefault();

        public Election CandidacyHasElection => ((IEnumerable<Election>)new DynamicObjectCollection<Election>(this, Property(UKParliamentOntology.CandidacyHasElection.Uri))).SingleOrDefault();
    }
}

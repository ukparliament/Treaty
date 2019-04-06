namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class CandidacyResult : UKParliamentDynamicNode
    {
        public CandidacyResult(INode node) : base(node) { }

        public ICollection<Candidacy> CandidacyResultHasCandidacy => new DynamicObjectCollection<Candidacy>(this, Property(UKParliamentOntology.CandidacyResultHasCandidacy));

        public ICollection<ElectoralIncumbency> CandidacyResultHasElectoralIncumbency => new DynamicObjectCollection<ElectoralIncumbency>(this, Property(UKParliamentOntology.CandidacyResultHasElectoralIncumbency));

        public ICollection<int> VoteCount => new DynamicObjectCollection<int>(this, Property(UKParliamentOntology.VoteCount));

        public ICollection<int> ResultPosition => new DynamicObjectCollection<int>(this, Property(UKParliamentOntology.ResultPosition));
    }
}

namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class CandidacyResult : UKParliamentDynamicNode
    {
        public CandidacyResult(INode node) : base(node) { }

        public Candidacy CandidacyResultHasCandidacy => ((IEnumerable<Candidacy>)new DynamicObjectCollection<Candidacy>(this, Property(UKParliamentOntology.CandidacyResultHasCandidacy))).SingleOrDefault();

        public ICollection<ElectoralIncumbency> CandidacyResultHasElectoralIncumbency => new DynamicObjectCollection<ElectoralIncumbency>(this, Property(UKParliamentOntology.CandidacyResultHasElectoralIncumbency));

        public int VoteCount => ((IEnumerable<int>)new DynamicObjectCollection<int>(this, Property(UKParliamentOntology.VoteCount))).SingleOrDefault();

        public int ResultPosition => ((IEnumerable<int>)new DynamicObjectCollection<int>(this, Property(UKParliamentOntology.ResultPosition))).SingleOrDefault();
    }
}

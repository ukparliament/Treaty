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

        public Candidacy CandidacyResultHasCandidacy => ((IEnumerable<Candidacy>)new DynamicObjectCollection<Candidacy>(this, Property(UKParliamentOntology.CandidacyResultHasCandidacy.Uri))).SingleOrDefault();

        public ICollection<ElectoralIncumbency> CandidacyResultHasElectoralIncumbency => new DynamicObjectCollection<ElectoralIncumbency>(this, Property(UKParliamentOntology.CandidacyResultHasElectoralIncumbency.Uri));

        public System.Int64 VoteCount => ((IEnumerable<System.Int64>)new DynamicObjectCollection<System.Int64>(this, Property(UKParliamentOntology.VoteCount.Uri))).SingleOrDefault();

        public System.Int64 ResultPosition => ((IEnumerable<System.Int64>)new DynamicObjectCollection<System.Int64>(this, Property(UKParliamentOntology.ResultPosition.Uri))).SingleOrDefault();
    }
}

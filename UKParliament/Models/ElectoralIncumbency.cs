namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ElectoralIncumbency : SeatIncumbency
    {
        public ElectoralIncumbency(INode node) : base(node) { }

        public CandidacyResult ElectoralIncumbencyHasCandidacyResult => ((IEnumerable<CandidacyResult>)new DynamicObjectCollection<CandidacyResult>(this, Property(UKParliamentOntology.ElectoralIncumbencyHasCandidacyResult.Uri))).SingleOrDefault();

        public ICollection<ContactPoint> ElectoralIncumbencyHasContactPoint => new DynamicObjectCollection<ContactPoint>(this, Property(UKParliamentOntology.ElectoralIncumbencyHasContactPoint.Uri));
    }
}

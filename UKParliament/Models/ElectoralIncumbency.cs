namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ElectoralIncumbency : SeatIncumbency
    {
        public ElectoralIncumbency(INode node) : base(node) { }

        public ICollection<CandidacyResult> ElectoralIncumbencyHasCandidacyResult => new DynamicObjectCollection<CandidacyResult>(this, Property(UKParliamentOntology.ElectoralIncumbencyHasCandidacyResult));

        public ICollection<ContactPoint> ElectoralIncumbencyHasContactPoint => new DynamicObjectCollection<ContactPoint>(this, Property(UKParliamentOntology.ElectoralIncumbencyHasContactPoint));
    }
}

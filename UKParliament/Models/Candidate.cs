namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Candidate : Person
    {
        public Candidate(INode node) : base(node) { }

        public ICollection<Candidacy> CandidateHasCandidacy => new DynamicObjectCollection<Candidacy>(this, Property(UKParliamentOntology.CandidateHasCandidacy.Uri));
    }
}

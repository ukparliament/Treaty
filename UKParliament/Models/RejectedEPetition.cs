namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class RejectedEPetition : EPetition
    {
        public RejectedEPetition(INode node) : base(node) { }

        public ICollection<Rejection> RejectedEPetitionHasRejection => new DynamicObjectCollection<Rejection>(this, Property(UKParliamentOntology.RejectedEPetitionHasRejection));
    }
}

namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Rejection : Moderation
    {
        public Rejection(INode node) : base(node) { }

        public ICollection<RejectedEPetition> RejectionHasRejectedEPetition => new DynamicObjectCollection<RejectedEPetition>(this, Property(UKParliamentOntology.RejectionHasRejectedEPetition));

        public ICollection<RejectionCode> RejectionHasRejectionCode => new DynamicObjectCollection<RejectionCode>(this, Property(UKParliamentOntology.RejectionHasRejectionCode));

        public ICollection<string> RejectedAt => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.RejectedAt));

        public ICollection<string> RejectionDetails => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.RejectionDetails));
    }
}

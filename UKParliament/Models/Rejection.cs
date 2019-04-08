namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Rejection : Moderation
    {
        public Rejection(INode node) : base(node) { }

        public ICollection<RejectedEPetition> RejectionHasRejectedEPetition => new DynamicObjectCollection<RejectedEPetition>(this, Property(UKParliamentOntology.RejectionHasRejectedEPetition));

        public RejectionCode RejectionHasRejectionCode => ((IEnumerable<RejectionCode>)new DynamicObjectCollection<RejectionCode>(this, Property(UKParliamentOntology.RejectionHasRejectionCode))).SingleOrDefault();

        public string RejectedAt => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.RejectedAt))).SingleOrDefault();

        public ICollection<string> RejectionDetails => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.RejectionDetails));
    }
}

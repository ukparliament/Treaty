namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Approval : Moderation
    {
        public Approval(INode node) : base(node) { }

        public ICollection<ApprovedEPetition> ApprovalHasApprovedEPetition => new DynamicObjectCollection<ApprovedEPetition>(this, Property(UKParliamentOntology.ApprovalHasApprovedEPetition));

        public ICollection<string> ApprovedAt => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ApprovedAt));
    }
}

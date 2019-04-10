namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Approval : Moderation
    {
        public Approval(INode node) : base(node) { }

        public ICollection<ApprovedEPetition> ApprovalHasApprovedEPetition => new DynamicObjectCollection<ApprovedEPetition>(this, Property(UKParliamentOntology.ApprovalHasApprovedEPetition.Uri));

        public string ApprovedAt => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ApprovedAt.Uri))).SingleOrDefault();
    }
}

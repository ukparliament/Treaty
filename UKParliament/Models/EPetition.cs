namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class EPetition : UKParliamentDynamicNode
    {
        public EPetition(INode node) : base(node) { }

        public ICollection<ThresholdAttainment> EPetitionHasThresholdAttainment => new DynamicObjectCollection<ThresholdAttainment>(this, Property(UKParliamentOntology.EPetitionHasThresholdAttainment.Uri));

        public ICollection<Debate> EPetitionHasDebate => new DynamicObjectCollection<Debate>(this, Property(UKParliamentOntology.EPetitionHasDebate.Uri));

        public ICollection<GovernmentResponse> EPetitionHasGovernmentResponse => new DynamicObjectCollection<GovernmentResponse>(this, Property(UKParliamentOntology.EPetitionHasGovernmentResponse.Uri));

        public ICollection<Moderation> EPetitionHasModeration => new DynamicObjectCollection<Moderation>(this, Property(UKParliamentOntology.EPetitionHasModeration.Uri));

        public ICollection<LocatedSignatureCount> EPetitionHasLocatedSignatureCount => new DynamicObjectCollection<LocatedSignatureCount>(this, Property(UKParliamentOntology.EPetitionHasLocatedSignatureCount.Uri));

        public ICollection<string> Action => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.Action.Uri));

        public ICollection<string> Background => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.Background.Uri));

        public ICollection<string> AdditionalDetails => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.AdditionalDetails.Uri));

        public ICollection<string> CreatedAt => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.CreatedAt.Uri));

        public ICollection<string> UpdatedAt => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.UpdatedAt.Uri));

        public ICollection<string> ClosedAt => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ClosedAt.Uri));
    }
}

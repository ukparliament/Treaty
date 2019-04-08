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

        public ICollection<ThresholdAttainment> EPetitionHasThresholdAttainment => new DynamicObjectCollection<ThresholdAttainment>(this, Property(UKParliamentOntology.EPetitionHasThresholdAttainment));

        public ICollection<Debate> EPetitionHasDebate => new DynamicObjectCollection<Debate>(this, Property(UKParliamentOntology.EPetitionHasDebate));

        public ICollection<GovernmentResponse> EPetitionHasGovernmentResponse => new DynamicObjectCollection<GovernmentResponse>(this, Property(UKParliamentOntology.EPetitionHasGovernmentResponse));

        public ICollection<Moderation> EPetitionHasModeration => new DynamicObjectCollection<Moderation>(this, Property(UKParliamentOntology.EPetitionHasModeration));

        public ICollection<LocatedSignatureCount> EPetitionHasLocatedSignatureCount => new DynamicObjectCollection<LocatedSignatureCount>(this, Property(UKParliamentOntology.EPetitionHasLocatedSignatureCount));

        public ICollection<string> Action => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.Action));

        public ICollection<string> Background => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.Background));

        public ICollection<string> AdditionalDetails => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.AdditionalDetails));

        public ICollection<string> CreatedAt => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.CreatedAt));

        public ICollection<string> UpdatedAt => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.UpdatedAt));

        public ICollection<string> ClosedAt => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ClosedAt));
    }
}

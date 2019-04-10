namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Debate : UKParliamentDynamicNode
    {
        public Debate(INode node) : base(node) { }

        public ICollection<EPetition> DebateHasEPetition => new DynamicObjectCollection<EPetition>(this, Property(UKParliamentOntology.DebateHasEPetition.Uri));

        public ICollection<DateTimeOffset> DebateDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.DebateDate.Uri));

        public ICollection<DateTimeOffset> DebateProposedDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.DebateProposedDate.Uri));

        public ICollection<string> DebateTranscriptUrl => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.DebateTranscriptUrl.Uri));

        public ICollection<string> DebateVideoUrl => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.DebateVideoUrl.Uri));

        public ICollection<string> DebateOverview => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.DebateOverview.Uri));
    }
}

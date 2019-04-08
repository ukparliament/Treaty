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

        public ICollection<EPetition> DebateHasEPetition => new DynamicObjectCollection<EPetition>(this, Property(UKParliamentOntology.DebateHasEPetition));

        public ICollection<DateTimeOffset> DebateDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.DebateDate));

        public ICollection<DateTimeOffset> DebateProposedDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.DebateProposedDate));

        public ICollection<string> DebateTranscriptUrl => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.DebateTranscriptUrl));

        public ICollection<string> DebateVideoUrl => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.DebateVideoUrl));

        public ICollection<string> DebateOverview => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.DebateOverview));
    }
}

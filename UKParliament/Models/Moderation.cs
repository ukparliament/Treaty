namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Moderation : UKParliamentDynamicNode
    {
        public Moderation(INode node) : base(node) { }

        public ICollection<EPetition> ModerationHasEPetition => new DynamicObjectCollection<EPetition>(this, Property(UKParliamentOntology.ModerationHasEPetition));

        public string ModeratedAt => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ModeratedAt))).SingleOrDefault();
    }
}

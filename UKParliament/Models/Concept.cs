namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Concept : UKParliamentDynamicNode
    {
        public Concept(INode node) : base(node) { }

        public ICollection<ConceptualisedThing> ConceptHasConceptualisedThing => new DynamicObjectCollection<ConceptualisedThing>(this, Property(UKParliamentOntology.ConceptHasConceptualisedThing));

        public ICollection<SubjectTaggedThing> ConceptHasSubjectTaggedThing => new DynamicObjectCollection<SubjectTaggedThing>(this, Property(UKParliamentOntology.ConceptHasSubjectTaggedThing));

        public ICollection<Concept> ConceptHasBroaderConcept => new DynamicObjectCollection<Concept>(this, Property(UKParliamentOntology.ConceptHasBroaderConcept));

        public ICollection<Concept> ConceptHasNarrowerConcept => new DynamicObjectCollection<Concept>(this, Property(UKParliamentOntology.ConceptHasNarrowerConcept));

        public string ConceptLabel => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ConceptLabel))).SingleOrDefault();

        public ICollection<string> ConceptScopeNote => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ConceptScopeNote));

        public ICollection<string> ConceptDefinition => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ConceptDefinition));
    }
}

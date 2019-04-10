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

        public ICollection<ConceptualisedThing> ConceptHasConceptualisedThing => new DynamicObjectCollection<ConceptualisedThing>(this, Property(UKParliamentOntology.ConceptHasConceptualisedThing.Uri));

        public ICollection<SubjectTaggedThing> ConceptHasSubjectTaggedThing => new DynamicObjectCollection<SubjectTaggedThing>(this, Property(UKParliamentOntology.ConceptHasSubjectTaggedThing.Uri));

        public ICollection<Concept> ConceptHasBroaderConcept => new DynamicObjectCollection<Concept>(this, Property(UKParliamentOntology.ConceptHasBroaderConcept.Uri));

        public ICollection<Concept> ConceptHasNarrowerConcept => new DynamicObjectCollection<Concept>(this, Property(UKParliamentOntology.ConceptHasNarrowerConcept.Uri));

        public string ConceptLabel => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ConceptLabel.Uri))).SingleOrDefault();

        public ICollection<string> ConceptScopeNote => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ConceptScopeNote.Uri));

        public ICollection<string> ConceptDefinition => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ConceptDefinition.Uri));
    }
}

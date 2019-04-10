namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ConceptualisedThing : UKParliamentDynamicNode
    {
        public ConceptualisedThing(INode node) : base(node) { }

        public ICollection<Concept> ConceptualisedThingHasConcept => new DynamicObjectCollection<Concept>(this, Property(UKParliamentOntology.ConceptualisedThingHasConcept.Uri));
    }
}

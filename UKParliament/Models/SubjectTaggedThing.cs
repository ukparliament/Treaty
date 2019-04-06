namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class SubjectTaggedThing : UKParliamentDynamicNode
    {
        public SubjectTaggedThing(INode node) : base(node) { }

        public ICollection<Concept> SubjectTaggedThingHasConcept => new DynamicObjectCollection<Concept>(this, Property(UKParliamentOntology.SubjectTaggedThingHasConcept));
    }
}

namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PursuedThing : UKParliamentDynamicNode
    {
        public PursuedThing(INode node) : base(node) { }

        public ICollection<Question> PursuedThingHasQuestion => new DynamicObjectCollection<Question>(this, Property(UKParliamentOntology.PursuedThingHasQuestion));
    }
}

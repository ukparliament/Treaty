namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PursuedThing : UKParliamentDynamicNode
    {
        public PursuedThing(INode node) : base(node) { }

        public ICollection<Question> PursuedThingHasQuestion => new DynamicObjectCollection<Question>(this, Property(UKParliamentOntology.PursuedThingHasQuestion));
    }
}

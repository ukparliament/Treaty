namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class LaidThing : WorkPackagedThing
    {
        public LaidThing(INode node) : base(node) { }

        public ICollection<Laying> LaidThingHasLaying => new DynamicObjectCollection<Laying>(this, Property(UKParliamentOntology.LaidThingHasLaying));

        public ICollection<string> LaidThingName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.LaidThingName));
    }
}

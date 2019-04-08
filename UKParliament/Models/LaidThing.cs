namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class LaidThing : WorkPackagedThing
    {
        public LaidThing(INode node) : base(node) { }

        public ICollection<Laying> LaidThingHasLaying => new DynamicObjectCollection<Laying>(this, Property(UKParliamentOntology.LaidThingHasLaying));

        public string LaidThingName => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.LaidThingName))).SingleOrDefault();
    }
}

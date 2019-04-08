namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class OnsThing : ExternalThing
    {
        public OnsThing(INode node) : base(node) { }

        public string OnsCode => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.OnsCode))).SingleOrDefault();
    }
}

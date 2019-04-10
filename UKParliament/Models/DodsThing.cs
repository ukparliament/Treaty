namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class DodsThing : ExternalThing
    {
        public DodsThing(INode node) : base(node) { }

        public string DodsId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.DodsId.Uri))).SingleOrDefault();
    }
}

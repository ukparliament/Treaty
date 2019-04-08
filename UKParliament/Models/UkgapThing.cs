namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class UkgapThing : ExternalThing
    {
        public UkgapThing(INode node) : base(node) { }

        public string UkgapId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.UkgapId))).SingleOrDefault();
    }
}

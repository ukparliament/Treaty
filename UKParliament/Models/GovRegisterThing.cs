namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class GovRegisterThing : ExternalThing
    {
        public GovRegisterThing(INode node) : base(node) { }

        public string GovRegisterId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.GovRegisterId))).SingleOrDefault();
    }
}

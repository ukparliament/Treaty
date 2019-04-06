namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class GovRegisterThing : ExternalThing
    {
        public GovRegisterThing(INode node) : base(node) { }

        public ICollection<string> GovRegisterId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.GovRegisterId));
    }
}

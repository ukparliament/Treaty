namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisThing : ExternalThing
    {
        public MnisThing(INode node) : base(node) { }

        public ICollection<string> MnisId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.MnisId));
    }
}

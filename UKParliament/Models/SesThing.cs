namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class SesThing : ExternalThing
    {
        public SesThing(INode node) : base(node) { }

        public ICollection<string> SesId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.SesId.Uri));
    }
}

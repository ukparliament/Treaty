namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PimsThing : ExternalThing
    {
        public PimsThing(INode node) : base(node) { }

        public string PimsId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.PimsId.Uri))).SingleOrDefault();
    }
}

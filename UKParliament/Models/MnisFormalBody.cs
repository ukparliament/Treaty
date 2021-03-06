namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisFormalBody : FormalBody
    {
        public MnisFormalBody(INode node) : base(node) { }

        public string FormalBodyMnisId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.FormalBodyMnisId.Uri))).SingleOrDefault();
    }
}

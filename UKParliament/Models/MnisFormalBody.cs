namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisFormalBody : FormalBody
    {
        public MnisFormalBody(INode node) : base(node) { }

        public ICollection<string> FormalBodyMnisId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.FormalBodyMnisId));
    }
}

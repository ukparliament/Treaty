namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisAnsweringBody : AnsweringBody
    {
        public MnisAnsweringBody(INode node) : base(node) { }

        public ICollection<string> AnsweringBodyMnisId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.AnsweringBodyMnisId));
    }
}

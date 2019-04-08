namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisAnsweringBody : AnsweringBody
    {
        public MnisAnsweringBody(INode node) : base(node) { }

        public string AnsweringBodyMnisId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.AnsweringBodyMnisId))).SingleOrDefault();
    }
}

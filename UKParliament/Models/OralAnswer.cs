namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class OralAnswer : Answer
    {
        public OralAnswer(INode node) : base(node) { }

        public ICollection<AnsweringBody> OralAnswerHasAnsweringBody => new DynamicObjectCollection<AnsweringBody>(this, Property(UKParliamentOntology.OralAnswerHasAnsweringBody));
    }
}

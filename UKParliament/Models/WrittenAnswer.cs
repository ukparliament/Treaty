namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class WrittenAnswer : Answer
    {
        public WrittenAnswer(INode node) : base(node) { }

        public ICollection<AnsweringBody> WrittenAnswerHasAnsweringBody => new DynamicObjectCollection<AnsweringBody>(this, Property(UKParliamentOntology.WrittenAnswerHasAnsweringBody));
    }
}

namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class WrittenAnswer : Answer
    {
        public WrittenAnswer(INode node) : base(node) { }

        public ICollection<AnsweringBody> WrittenAnswerHasAnsweringBody => new DynamicObjectCollection<AnsweringBody>(this, Property(UKParliamentOntology.WrittenAnswerHasAnsweringBody.Uri));
    }
}

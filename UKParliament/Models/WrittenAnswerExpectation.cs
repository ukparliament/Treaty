namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class WrittenAnswerExpectation : AnswerExpectation
    {
        public WrittenAnswerExpectation(INode node) : base(node) { }

        public ICollection<Question> WrittenAnswerExpectationHasQuestion => new DynamicObjectCollection<Question>(this, Property(UKParliamentOntology.WrittenAnswerExpectationHasQuestion));
    }
}

namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class OralAnswerExpectation : AnswerExpectation
    {
        public OralAnswerExpectation(INode node) : base(node) { }

        public ICollection<Question> OralAnswerExpectationHasQuestion => new DynamicObjectCollection<Question>(this, Property(UKParliamentOntology.OralAnswerExpectationHasQuestion));

        public ICollection<DateTimeOffset> OralAnswerExpectationSurrenderedAt => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.OralAnswerExpectationSurrenderedAt));

        public ICollection<DateTimeOffset> OralAnswerExpectationTimedOutAt => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.OralAnswerExpectationTimedOutAt));
    }
}

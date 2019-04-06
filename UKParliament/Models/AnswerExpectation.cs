namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class AnswerExpectation : UKParliamentDynamicNode
    {
        public AnswerExpectation(INode node) : base(node) { }

        public ICollection<Question> AnswerExpectationHasQuestion => new DynamicObjectCollection<Question>(this, Property(UKParliamentOntology.AnswerExpectationHasQuestion));

        public ICollection<DateTimeOffset> AnswerExpectationStartDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.AnswerExpectationStartDate));

        public ICollection<DateTimeOffset> AnswerExpectationEndDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.AnswerExpectationEndDate));
    }
}

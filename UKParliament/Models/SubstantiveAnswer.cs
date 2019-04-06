namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class SubstantiveAnswer : Answer
    {
        public SubstantiveAnswer(INode node) : base(node) { }

        public ICollection<HoldingAnswer> SubstantiveAnswerReplacesHoldingAnswer => new DynamicObjectCollection<HoldingAnswer>(this, Property(UKParliamentOntology.SubstantiveAnswerReplacesHoldingAnswer));

        public ICollection<Question> SubstantiveAnswerHasQuestion => new DynamicObjectCollection<Question>(this, Property(UKParliamentOntology.SubstantiveAnswerHasQuestion));
    }
}

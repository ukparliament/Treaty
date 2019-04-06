namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class HoldingAnswer : Answer
    {
        public HoldingAnswer(INode node) : base(node) { }

        public ICollection<SubstantiveAnswer> HoldingAnswerIsReplacedBySubstantiveAnswer => new DynamicObjectCollection<SubstantiveAnswer>(this, Property(UKParliamentOntology.HoldingAnswerIsReplacedBySubstantiveAnswer));

        public ICollection<Question> HoldingAnswerHasQuestion => new DynamicObjectCollection<Question>(this, Property(UKParliamentOntology.HoldingAnswerHasQuestion));
    }
}

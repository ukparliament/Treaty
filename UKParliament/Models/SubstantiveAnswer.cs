namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class SubstantiveAnswer : Answer
    {
        public SubstantiveAnswer(INode node) : base(node) { }

        public HoldingAnswer SubstantiveAnswerReplacesHoldingAnswer => ((IEnumerable<HoldingAnswer>)new DynamicObjectCollection<HoldingAnswer>(this, Property(UKParliamentOntology.SubstantiveAnswerReplacesHoldingAnswer))).SingleOrDefault();

        public ICollection<Question> SubstantiveAnswerHasQuestion => new DynamicObjectCollection<Question>(this, Property(UKParliamentOntology.SubstantiveAnswerHasQuestion));
    }
}

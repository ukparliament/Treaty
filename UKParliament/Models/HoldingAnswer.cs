namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class HoldingAnswer : Answer
    {
        public HoldingAnswer(INode node) : base(node) { }

        public SubstantiveAnswer HoldingAnswerIsReplacedBySubstantiveAnswer => ((IEnumerable<SubstantiveAnswer>)new DynamicObjectCollection<SubstantiveAnswer>(this, Property(UKParliamentOntology.HoldingAnswerIsReplacedBySubstantiveAnswer.Uri))).SingleOrDefault();

        public ICollection<Question> HoldingAnswerHasQuestion => new DynamicObjectCollection<Question>(this, Property(UKParliamentOntology.HoldingAnswerHasQuestion.Uri));
    }
}

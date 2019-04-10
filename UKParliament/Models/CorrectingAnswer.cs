namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class CorrectingAnswer : Answer
    {
        public CorrectingAnswer(INode node) : base(node) { }

        public SinceCorrectedAnswer CorrectingAnswerReplacesSinceCorrectedAnswer => ((IEnumerable<SinceCorrectedAnswer>)new DynamicObjectCollection<SinceCorrectedAnswer>(this, Property(UKParliamentOntology.CorrectingAnswerReplacesSinceCorrectedAnswer.Uri))).SingleOrDefault();

        public ICollection<Question> CorrectingAnswerHasQuestion => new DynamicObjectCollection<Question>(this, Property(UKParliamentOntology.CorrectingAnswerHasQuestion.Uri));
    }
}

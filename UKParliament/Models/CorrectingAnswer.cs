namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class CorrectingAnswer : Answer
    {
        public CorrectingAnswer(INode node) : base(node) { }

        public ICollection<SinceCorrectedAnswer> CorrectingAnswerReplacesSinceCorrectedAnswer => new DynamicObjectCollection<SinceCorrectedAnswer>(this, Property(UKParliamentOntology.CorrectingAnswerReplacesSinceCorrectedAnswer));

        public ICollection<Question> CorrectingAnswerHasQuestion => new DynamicObjectCollection<Question>(this, Property(UKParliamentOntology.CorrectingAnswerHasQuestion));
    }
}

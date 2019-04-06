namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Answer : UKParliamentDynamicNode
    {
        public Answer(INode node) : base(node) { }

        public ICollection<Answer> AnswerReplacesAnswer => new DynamicObjectCollection<Answer>(this, Property(UKParliamentOntology.AnswerReplacesAnswer));

        public ICollection<Answer> AnswerIsReplacedByAnswer => new DynamicObjectCollection<Answer>(this, Property(UKParliamentOntology.AnswerIsReplacedByAnswer));

        public ICollection<AnsweringBody> AnswerHasAnsweringBody => new DynamicObjectCollection<AnsweringBody>(this, Property(UKParliamentOntology.AnswerHasAnsweringBody));

        public ICollection<Question> AnswerHasQuestion => new DynamicObjectCollection<Question>(this, Property(UKParliamentOntology.AnswerHasQuestion));

        public ICollection<Person> AnswerHasAnsweringPerson => new DynamicObjectCollection<Person>(this, Property(UKParliamentOntology.AnswerHasAnsweringPerson));

        public ICollection<string> AnswerText => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.AnswerText));

        public ICollection<DateTimeOffset> AnswerGivenDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.AnswerGivenDate));
    }
}

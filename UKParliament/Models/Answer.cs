namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Answer : UKParliamentDynamicNode
    {
        public Answer(INode node) : base(node) { }

        public Answer AnswerReplacesAnswer => ((IEnumerable<Answer>)new DynamicObjectCollection<Answer>(this, Property(UKParliamentOntology.AnswerReplacesAnswer))).SingleOrDefault();

        public Answer AnswerIsReplacedByAnswer => ((IEnumerable<Answer>)new DynamicObjectCollection<Answer>(this, Property(UKParliamentOntology.AnswerIsReplacedByAnswer))).SingleOrDefault();

        public ICollection<AnsweringBody> AnswerHasAnsweringBody => new DynamicObjectCollection<AnsweringBody>(this, Property(UKParliamentOntology.AnswerHasAnsweringBody));

        public ICollection<Question> AnswerHasQuestion => new DynamicObjectCollection<Question>(this, Property(UKParliamentOntology.AnswerHasQuestion));

        public ICollection<Person> AnswerHasAnsweringPerson => new DynamicObjectCollection<Person>(this, Property(UKParliamentOntology.AnswerHasAnsweringPerson));

        public ICollection<string> AnswerText => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.AnswerText));

        public DateTimeOffset AnswerGivenDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.AnswerGivenDate))).SingleOrDefault();
    }
}

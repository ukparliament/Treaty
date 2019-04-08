namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Question : UKParliamentDynamicNode
    {
        public Question(INode node) : base(node) { }

        public ICollection<PursuedThing> QuestionHasPursuedThing => new DynamicObjectCollection<PursuedThing>(this, Property(UKParliamentOntology.QuestionHasPursuedThing));

        public ICollection<RoundRobin> QuestionHasRoundRobin => new DynamicObjectCollection<RoundRobin>(this, Property(UKParliamentOntology.QuestionHasRoundRobin));

        public ICollection<AnswerExpectation> QuestionHasAnswerExpectation => new DynamicObjectCollection<AnswerExpectation>(this, Property(UKParliamentOntology.QuestionHasAnswerExpectation));

        public ICollection<AnsweringBodyAllocation> QuestionHasAnsweringBodyAllocation => new DynamicObjectCollection<AnsweringBodyAllocation>(this, Property(UKParliamentOntology.QuestionHasAnsweringBodyAllocation));

        public ICollection<OralAnswerExpectation> QuestionHasOralAnswerExpectation => new DynamicObjectCollection<OralAnswerExpectation>(this, Property(UKParliamentOntology.QuestionHasOralAnswerExpectation));

        public ICollection<WrittenAnswerExpectation> QuestionHasWrittenAnswerExpectation => new DynamicObjectCollection<WrittenAnswerExpectation>(this, Property(UKParliamentOntology.QuestionHasWrittenAnswerExpectation));

        public ICollection<Answer> QuestionHasAnswer => new DynamicObjectCollection<Answer>(this, Property(UKParliamentOntology.QuestionHasAnswer));

        public ICollection<CorrectingAnswer> QuestionHasCorrectingAnswer => new DynamicObjectCollection<CorrectingAnswer>(this, Property(UKParliamentOntology.QuestionHasCorrectingAnswer));

        public ICollection<ProrogationAnswer> QuestionHasProrogationAnswer => new DynamicObjectCollection<ProrogationAnswer>(this, Property(UKParliamentOntology.QuestionHasProrogationAnswer));

        public ICollection<SubstantiveAnswer> QuestionHasSubstantiveAnswer => new DynamicObjectCollection<SubstantiveAnswer>(this, Property(UKParliamentOntology.QuestionHasSubstantiveAnswer));

        public ICollection<HoldingAnswer> QuestionHasHoldingAnswer => new DynamicObjectCollection<HoldingAnswer>(this, Property(UKParliamentOntology.QuestionHasHoldingAnswer));

        public ICollection<Person> QuestionHasAskingPerson => new DynamicObjectCollection<Person>(this, Property(UKParliamentOntology.QuestionHasAskingPerson));

        public string QuestionText => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.QuestionText))).SingleOrDefault();

        public string QuestionHeading => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.QuestionHeading))).SingleOrDefault();

        public DateTimeOffset QuestionAskedAt => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.QuestionAskedAt))).SingleOrDefault();
    }
}

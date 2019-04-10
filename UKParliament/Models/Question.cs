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

        public ICollection<PursuedThing> QuestionHasPursuedThing => new DynamicObjectCollection<PursuedThing>(this, Property(UKParliamentOntology.QuestionHasPursuedThing.Uri));

        public ICollection<RoundRobin> QuestionHasRoundRobin => new DynamicObjectCollection<RoundRobin>(this, Property(UKParliamentOntology.QuestionHasRoundRobin.Uri));

        public ICollection<AnswerExpectation> QuestionHasAnswerExpectation => new DynamicObjectCollection<AnswerExpectation>(this, Property(UKParliamentOntology.QuestionHasAnswerExpectation.Uri));

        public ICollection<AnsweringBodyAllocation> QuestionHasAnsweringBodyAllocation => new DynamicObjectCollection<AnsweringBodyAllocation>(this, Property(UKParliamentOntology.QuestionHasAnsweringBodyAllocation.Uri));

        public ICollection<OralAnswerExpectation> QuestionHasOralAnswerExpectation => new DynamicObjectCollection<OralAnswerExpectation>(this, Property(UKParliamentOntology.QuestionHasOralAnswerExpectation.Uri));

        public ICollection<WrittenAnswerExpectation> QuestionHasWrittenAnswerExpectation => new DynamicObjectCollection<WrittenAnswerExpectation>(this, Property(UKParliamentOntology.QuestionHasWrittenAnswerExpectation.Uri));

        public ICollection<Answer> QuestionHasAnswer => new DynamicObjectCollection<Answer>(this, Property(UKParliamentOntology.QuestionHasAnswer.Uri));

        public ICollection<CorrectingAnswer> QuestionHasCorrectingAnswer => new DynamicObjectCollection<CorrectingAnswer>(this, Property(UKParliamentOntology.QuestionHasCorrectingAnswer.Uri));

        public ICollection<ProrogationAnswer> QuestionHasProrogationAnswer => new DynamicObjectCollection<ProrogationAnswer>(this, Property(UKParliamentOntology.QuestionHasProrogationAnswer.Uri));

        public ICollection<SubstantiveAnswer> QuestionHasSubstantiveAnswer => new DynamicObjectCollection<SubstantiveAnswer>(this, Property(UKParliamentOntology.QuestionHasSubstantiveAnswer.Uri));

        public ICollection<HoldingAnswer> QuestionHasHoldingAnswer => new DynamicObjectCollection<HoldingAnswer>(this, Property(UKParliamentOntology.QuestionHasHoldingAnswer.Uri));

        public ICollection<Person> QuestionHasAskingPerson => new DynamicObjectCollection<Person>(this, Property(UKParliamentOntology.QuestionHasAskingPerson.Uri));

        public string QuestionText => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.QuestionText.Uri))).SingleOrDefault();

        public string QuestionHeading => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.QuestionHeading.Uri))).SingleOrDefault();

        public DateTimeOffset QuestionAskedAt => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.QuestionAskedAt.Uri))).SingleOrDefault();
    }
}

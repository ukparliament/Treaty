namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ProrogationAnswer : Answer
    {
        public ProrogationAnswer(INode node) : base(node) { }

        public ICollection<Question> ProrogationAnswerHasQuestion => new DynamicObjectCollection<Question>(this, Property(UKParliamentOntology.ProrogationAnswerHasQuestion.Uri));
    }
}

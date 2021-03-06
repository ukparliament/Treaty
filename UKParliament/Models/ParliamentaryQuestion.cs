namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ParliamentaryQuestion : Question
    {
        public ParliamentaryQuestion(INode node) : base(node) { }

        public ICollection<DateTimeOffset> ParliamentaryQuestionWithdrawnOn => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.ParliamentaryQuestionWithdrawnOn.Uri));
    }
}

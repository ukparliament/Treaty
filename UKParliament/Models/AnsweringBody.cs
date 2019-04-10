namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class AnsweringBody : Group
    {
        public AnsweringBody(INode node) : base(node) { }

        public ICollection<AnsweringBodyAllocation> AnsweringBodyHasAnsweringBodyAllocation => new DynamicObjectCollection<AnsweringBodyAllocation>(this, Property(UKParliamentOntology.AnsweringBodyHasAnsweringBodyAllocation.Uri));

        public ICollection<Answer> AnsweringBodyHasAnswer => new DynamicObjectCollection<Answer>(this, Property(UKParliamentOntology.AnsweringBodyHasAnswer.Uri));

        public ICollection<OralAnswer> AnsweringBodyHasOralAnswer => new DynamicObjectCollection<OralAnswer>(this, Property(UKParliamentOntology.AnsweringBodyHasOralAnswer.Uri));

        public ICollection<WrittenAnswer> AnsweringBodyHasWrittenAnswer => new DynamicObjectCollection<WrittenAnswer>(this, Property(UKParliamentOntology.AnsweringBodyHasWrittenAnswer.Uri));
    }
}

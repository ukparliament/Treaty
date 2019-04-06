namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class AnsweringBody : Group
    {
        public AnsweringBody(INode node) : base(node) { }

        public ICollection<AnsweringBodyAllocation> AnsweringBodyHasAnsweringBodyAllocation => new DynamicObjectCollection<AnsweringBodyAllocation>(this, Property(UKParliamentOntology.AnsweringBodyHasAnsweringBodyAllocation));

        public ICollection<Answer> AnsweringBodyHasAnswer => new DynamicObjectCollection<Answer>(this, Property(UKParliamentOntology.AnsweringBodyHasAnswer));

        public ICollection<OralAnswer> AnsweringBodyHasOralAnswer => new DynamicObjectCollection<OralAnswer>(this, Property(UKParliamentOntology.AnsweringBodyHasOralAnswer));

        public ICollection<WrittenAnswer> AnsweringBodyHasWrittenAnswer => new DynamicObjectCollection<WrittenAnswer>(this, Property(UKParliamentOntology.AnsweringBodyHasWrittenAnswer));
    }
}

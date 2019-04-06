namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class AnsweringBodyAllocation : UKParliamentDynamicNode
    {
        public AnsweringBodyAllocation(INode node) : base(node) { }

        public ICollection<Question> AnsweringBodyAllocationHasQuestion => new DynamicObjectCollection<Question>(this, Property(UKParliamentOntology.AnsweringBodyAllocationHasQuestion));

        public ICollection<AnsweringBody> AnsweringBodyAllocationHasAnsweringBody => new DynamicObjectCollection<AnsweringBody>(this, Property(UKParliamentOntology.AnsweringBodyAllocationHasAnsweringBody));

        public ICollection<AnsweringBodyAllocation> AnsweringBodyAllocationReplacesAnsweringBodyAllocation => new DynamicObjectCollection<AnsweringBodyAllocation>(this, Property(UKParliamentOntology.AnsweringBodyAllocationReplacesAnsweringBodyAllocation));

        public ICollection<AnsweringBodyAllocation> AnsweringBodyAllocationReplacedByAnsweringBodyAllocation => new DynamicObjectCollection<AnsweringBodyAllocation>(this, Property(UKParliamentOntology.AnsweringBodyAllocationReplacedByAnsweringBodyAllocation));
    }
}

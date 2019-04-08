namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class AnsweringBodyAllocation : UKParliamentDynamicNode
    {
        public AnsweringBodyAllocation(INode node) : base(node) { }

        public Question AnsweringBodyAllocationHasQuestion => ((IEnumerable<Question>)new DynamicObjectCollection<Question>(this, Property(UKParliamentOntology.AnsweringBodyAllocationHasQuestion))).SingleOrDefault();

        public AnsweringBody AnsweringBodyAllocationHasAnsweringBody => ((IEnumerable<AnsweringBody>)new DynamicObjectCollection<AnsweringBody>(this, Property(UKParliamentOntology.AnsweringBodyAllocationHasAnsweringBody))).SingleOrDefault();

        public ICollection<AnsweringBodyAllocation> AnsweringBodyAllocationReplacesAnsweringBodyAllocation => new DynamicObjectCollection<AnsweringBodyAllocation>(this, Property(UKParliamentOntology.AnsweringBodyAllocationReplacesAnsweringBodyAllocation));

        public ICollection<AnsweringBodyAllocation> AnsweringBodyAllocationReplacedByAnsweringBodyAllocation => new DynamicObjectCollection<AnsweringBodyAllocation>(this, Property(UKParliamentOntology.AnsweringBodyAllocationReplacedByAnsweringBodyAllocation));
    }
}

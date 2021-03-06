namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class RoundRobin : UKParliamentDynamicNode
    {
        public RoundRobin(INode node) : base(node) { }

        public ICollection<Question> RoundRobinHasQuestion => new DynamicObjectCollection<Question>(this, Property(UKParliamentOntology.RoundRobinHasQuestion.Uri));
    }
}

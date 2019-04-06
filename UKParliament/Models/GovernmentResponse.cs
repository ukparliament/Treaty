namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class GovernmentResponse : UKParliamentDynamicNode
    {
        public GovernmentResponse(INode node) : base(node) { }

        public ICollection<EPetition> GovernmentResponseHasEPetition => new DynamicObjectCollection<EPetition>(this, Property(UKParliamentOntology.GovernmentResponseHasEPetition));

        public ICollection<string> GovernmentResponseSummary => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.GovernmentResponseSummary));

        public ICollection<string> GovernmentResponseDetails => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.GovernmentResponseDetails));

        public ICollection<string> GovernmentResponseCreatedAt => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.GovernmentResponseCreatedAt));

        public ICollection<string> GovernmentResponseUpdatedAt => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.GovernmentResponseUpdatedAt));
    }
}

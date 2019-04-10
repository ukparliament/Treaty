namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class GovernmentResponse : UKParliamentDynamicNode
    {
        public GovernmentResponse(INode node) : base(node) { }

        public ICollection<EPetition> GovernmentResponseHasEPetition => new DynamicObjectCollection<EPetition>(this, Property(UKParliamentOntology.GovernmentResponseHasEPetition.Uri));

        public ICollection<string> GovernmentResponseSummary => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.GovernmentResponseSummary.Uri));

        public ICollection<string> GovernmentResponseDetails => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.GovernmentResponseDetails.Uri));

        public ICollection<string> GovernmentResponseCreatedAt => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.GovernmentResponseCreatedAt.Uri));

        public ICollection<string> GovernmentResponseUpdatedAt => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.GovernmentResponseUpdatedAt.Uri));
    }
}

namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ProcedureStepPublication : UKParliamentDynamicNode
    {
        public ProcedureStepPublication(INode node) : base(node) { }

        public ICollection<ProcedureStep> ProcedureStepPublicationHasProcedureStep => new DynamicObjectCollection<ProcedureStep>(this, Property(UKParliamentOntology.ProcedureStepPublicationHasProcedureStep.Uri));

        public ICollection<string> ProcedureStepPublicationName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ProcedureStepPublicationName.Uri));

        public ICollection<string> ProcedureStepPublicationUrl => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ProcedureStepPublicationUrl.Uri));
    }
}

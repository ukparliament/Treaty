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

        public ICollection<ProcedureStep> ProcedureStepPublicationHasProcedureStep => new DynamicObjectCollection<ProcedureStep>(this, Property(UKParliamentOntology.ProcedureStepPublicationHasProcedureStep));

        public ICollection<string> ProcedureStepPublicationName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ProcedureStepPublicationName));

        public ICollection<string> ProcedureStepPublicationUrl => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ProcedureStepPublicationUrl));
    }
}

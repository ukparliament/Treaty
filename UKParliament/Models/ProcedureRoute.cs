namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ProcedureRoute : UKParliamentDynamicNode
    {
        public ProcedureRoute(INode node) : base(node) { }

        public ICollection<ProcedureStep> ProcedureRouteIsToProcedureStep => new DynamicObjectCollection<ProcedureStep>(this, Property(UKParliamentOntology.ProcedureRouteIsToProcedureStep));

        public ICollection<ProcedureStep> ProcedureRouteIsFromProcedureStep => new DynamicObjectCollection<ProcedureStep>(this, Property(UKParliamentOntology.ProcedureRouteIsFromProcedureStep));

        public ICollection<Procedure> ProcedureRouteHasProcedure => new DynamicObjectCollection<Procedure>(this, Property(UKParliamentOntology.ProcedureRouteHasProcedure));
    }
}

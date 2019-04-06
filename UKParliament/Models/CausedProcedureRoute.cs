namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class CausedProcedureRoute : ProcedureRoute
    {
        public CausedProcedureRoute(INode node) : base(node) { }

        public ICollection<ProcedureStep> CausedProcedureRouteIsCausedByProcedureStep => new DynamicObjectCollection<ProcedureStep>(this, Property(UKParliamentOntology.CausedProcedureRouteIsCausedByProcedureStep));
    }
}

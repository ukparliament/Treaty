namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class AllowedProcedureRoute : ProcedureRoute
    {
        public AllowedProcedureRoute(INode node) : base(node) { }

        public ICollection<ProcedureStep> AllowedProcedureRouteIsAllowedByProcedureStep => new DynamicObjectCollection<ProcedureStep>(this, Property(UKParliamentOntology.AllowedProcedureRouteIsAllowedByProcedureStep));
    }
}

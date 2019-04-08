namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class RequiredProcedureRoute : ProcedureRoute
    {
        public RequiredProcedureRoute(INode node) : base(node) { }

        public ICollection<ProcedureStep> RequiredProcedureRouteIsRequiredByProcedureStep => new DynamicObjectCollection<ProcedureStep>(this, Property(UKParliamentOntology.RequiredProcedureRouteIsRequiredByProcedureStep));
    }
}

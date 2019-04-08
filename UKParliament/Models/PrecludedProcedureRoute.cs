namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PrecludedProcedureRoute : ProcedureRoute
    {
        public PrecludedProcedureRoute(INode node) : base(node) { }

        public ICollection<ProcedureStep> PrecludedProcedureRouteIsPrecludedByProcedureStep => new DynamicObjectCollection<ProcedureStep>(this, Property(UKParliamentOntology.PrecludedProcedureRouteIsPrecludedByProcedureStep));
    }
}

namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Procedure : UKParliamentDynamicNode
    {
        public Procedure(INode node) : base(node) { }

        public ICollection<WorkPackage> ProcedureHasWorkPackage => new DynamicObjectCollection<WorkPackage>(this, Property(UKParliamentOntology.ProcedureHasWorkPackage.Uri));

        public ICollection<ProcedureRoute> ProcedureHasProcedureRoute => new DynamicObjectCollection<ProcedureRoute>(this, Property(UKParliamentOntology.ProcedureHasProcedureRoute.Uri));

        public string ProcedureName => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ProcedureName.Uri))).SingleOrDefault();

        public string ProcedureDescription => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ProcedureDescription.Uri))).SingleOrDefault();
    }
}

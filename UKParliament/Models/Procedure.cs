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

        public ICollection<WorkPackage> ProcedureHasWorkPackage => new DynamicObjectCollection<WorkPackage>(this, Property(UKParliamentOntology.ProcedureHasWorkPackage));

        public ICollection<ProcedureRoute> ProcedureHasProcedureRoute => new DynamicObjectCollection<ProcedureRoute>(this, Property(UKParliamentOntology.ProcedureHasProcedureRoute));

        public string ProcedureName => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ProcedureName))).SingleOrDefault();

        public string ProcedureDescription => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ProcedureDescription))).SingleOrDefault();
    }
}

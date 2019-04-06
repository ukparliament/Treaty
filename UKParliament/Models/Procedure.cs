namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Procedure : UKParliamentDynamicNode
    {
        public Procedure(INode node) : base(node) { }

        public ICollection<WorkPackage> ProcedureHasWorkPackage => new DynamicObjectCollection<WorkPackage>(this, Property(UKParliamentOntology.ProcedureHasWorkPackage));

        public ICollection<ProcedureRoute> ProcedureHasProcedureRoute => new DynamicObjectCollection<ProcedureRoute>(this, Property(UKParliamentOntology.ProcedureHasProcedureRoute));

        public ICollection<string> ProcedureName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ProcedureName));

        public ICollection<string> ProcedureDescription => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ProcedureDescription));
    }
}

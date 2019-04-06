namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class WorkPackage : UKParliamentDynamicNode
    {
        public WorkPackage(INode node) : base(node) { }

        public ICollection<Procedure> WorkPackageHasProcedure => new DynamicObjectCollection<Procedure>(this, Property(UKParliamentOntology.WorkPackageHasProcedure));

        public ICollection<BusinessItem> WorkPackageHasBusinessItem => new DynamicObjectCollection<BusinessItem>(this, Property(UKParliamentOntology.WorkPackageHasBusinessItem));

        public ICollection<WorkPackagedThing> WorkPackageHasWorkPackagedThing => new DynamicObjectCollection<WorkPackagedThing>(this, Property(UKParliamentOntology.WorkPackageHasWorkPackagedThing));
    }
}

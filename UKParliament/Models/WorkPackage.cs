namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class WorkPackage : UKParliamentDynamicNode
    {
        public WorkPackage(INode node) : base(node) { }

        public Procedure WorkPackageHasProcedure => ((IEnumerable<Procedure>)new DynamicObjectCollection<Procedure>(this, Property(UKParliamentOntology.WorkPackageHasProcedure.Uri))).SingleOrDefault();

        public ICollection<BusinessItem> WorkPackageHasBusinessItem => new DynamicObjectCollection<BusinessItem>(this, Property(UKParliamentOntology.WorkPackageHasBusinessItem.Uri));

        public WorkPackagedThing WorkPackageHasWorkPackagedThing => ((IEnumerable<WorkPackagedThing>)new DynamicObjectCollection<WorkPackagedThing>(this, Property(UKParliamentOntology.WorkPackageHasWorkPackagedThing.Uri))).SingleOrDefault();
    }
}

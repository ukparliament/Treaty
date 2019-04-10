namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class WorkPackagedThing : UKParliamentDynamicNode
    {
        public WorkPackagedThing(INode node) : base(node) { }

        public ICollection<WorkPackagedThingWebLink> WorkPackagedThingHasWorkPackagedThingWebLink => new DynamicObjectCollection<WorkPackagedThingWebLink>(this, Property(UKParliamentOntology.WorkPackagedThingHasWorkPackagedThingWebLink.Uri));

        public WorkPackage WorkPackagedThingHasWorkPackage => ((IEnumerable<WorkPackage>)new DynamicObjectCollection<WorkPackage>(this, Property(UKParliamentOntology.WorkPackagedThingHasWorkPackage.Uri))).SingleOrDefault();

        public string WorkPackagedThingName => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.WorkPackagedThingName.Uri))).SingleOrDefault();
    }
}

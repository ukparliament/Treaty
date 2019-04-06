namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class WorkPackagedThing : UKParliamentDynamicNode
    {
        public WorkPackagedThing(INode node) : base(node) { }

        public ICollection<WorkPackagedThingWebLink> WorkPackagedThingHasWorkPackagedThingWebLink => new DynamicObjectCollection<WorkPackagedThingWebLink>(this, Property(UKParliamentOntology.WorkPackagedThingHasWorkPackagedThingWebLink));

        public ICollection<WorkPackage> WorkPackagedThingHasWorkPackage => new DynamicObjectCollection<WorkPackage>(this, Property(UKParliamentOntology.WorkPackagedThingHasWorkPackage));

        public ICollection<string> WorkPackagedThingName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.WorkPackagedThingName));
    }
}

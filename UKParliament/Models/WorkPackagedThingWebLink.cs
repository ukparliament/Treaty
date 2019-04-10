namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class WorkPackagedThingWebLink : UKParliamentDynamicNode
    {
        public WorkPackagedThingWebLink(INode node) : base(node) { }

        public ICollection<WorkPackagedThing> WorkPackagedThingWebLinkHasWorkPackagedThing => new DynamicObjectCollection<WorkPackagedThing>(this, Property(UKParliamentOntology.WorkPackagedThingWebLinkHasWorkPackagedThing.Uri));
    }
}

namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class BusinessItem : UKParliamentDynamicNode
    {
        public BusinessItem(INode node) : base(node) { }

        public ParliamentPeriod BusinessItemHasParliamentPeriod => ((IEnumerable<ParliamentPeriod>)new DynamicObjectCollection<ParliamentPeriod>(this, Property(UKParliamentOntology.BusinessItemHasParliamentPeriod.Uri))).SingleOrDefault();

        public ICollection<BusinessItemWebLink> BusinessItemHasBusinessItemWebLink => new DynamicObjectCollection<BusinessItemWebLink>(this, Property(UKParliamentOntology.BusinessItemHasBusinessItemWebLink.Uri));

        public ICollection<ProcedureStep> BusinessItemHasProcedureStep => new DynamicObjectCollection<ProcedureStep>(this, Property(UKParliamentOntology.BusinessItemHasProcedureStep.Uri));

        public WorkPackage BusinessItemHasWorkPackage => ((IEnumerable<WorkPackage>)new DynamicObjectCollection<WorkPackage>(this, Property(UKParliamentOntology.BusinessItemHasWorkPackage.Uri))).SingleOrDefault();

        public ICollection<DateTimeOffset> BusinessItemDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.BusinessItemDate.Uri));
    }
}

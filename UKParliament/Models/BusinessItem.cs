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

        public ParliamentPeriod BusinessItemHasParliamentPeriod => ((IEnumerable<ParliamentPeriod>)new DynamicObjectCollection<ParliamentPeriod>(this, Property(UKParliamentOntology.BusinessItemHasParliamentPeriod))).SingleOrDefault();

        public ICollection<BusinessItemWebLink> BusinessItemHasBusinessItemWebLink => new DynamicObjectCollection<BusinessItemWebLink>(this, Property(UKParliamentOntology.BusinessItemHasBusinessItemWebLink));

        public ICollection<ProcedureStep> BusinessItemHasProcedureStep => new DynamicObjectCollection<ProcedureStep>(this, Property(UKParliamentOntology.BusinessItemHasProcedureStep));

        public WorkPackage BusinessItemHasWorkPackage => ((IEnumerable<WorkPackage>)new DynamicObjectCollection<WorkPackage>(this, Property(UKParliamentOntology.BusinessItemHasWorkPackage))).SingleOrDefault();

        public ICollection<DateTimeOffset> BusinessItemDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.BusinessItemDate));
    }
}

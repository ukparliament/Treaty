namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class BusinessItem : UKParliamentDynamicNode
    {
        public BusinessItem(INode node) : base(node) { }

        public ICollection<ParliamentPeriod> BusinessItemHasParliamentPeriod => new DynamicObjectCollection<ParliamentPeriod>(this, Property(UKParliamentOntology.BusinessItemHasParliamentPeriod));

        public ICollection<BusinessItemWebLink> BusinessItemHasBusinessItemWebLink => new DynamicObjectCollection<BusinessItemWebLink>(this, Property(UKParliamentOntology.BusinessItemHasBusinessItemWebLink));

        public ICollection<ProcedureStep> BusinessItemHasProcedureStep => new DynamicObjectCollection<ProcedureStep>(this, Property(UKParliamentOntology.BusinessItemHasProcedureStep));

        public ICollection<WorkPackage> BusinessItemHasWorkPackage => new DynamicObjectCollection<WorkPackage>(this, Property(UKParliamentOntology.BusinessItemHasWorkPackage));

        public ICollection<DateTimeOffset> BusinessItemDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.BusinessItemDate));
    }
}

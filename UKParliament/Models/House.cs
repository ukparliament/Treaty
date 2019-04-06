namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class House : UKParliamentDynamicNode
    {
        public House(INode node) : base(node) { }

        public ICollection<ContactPoint> HouseHasContactPoint => new DynamicObjectCollection<ContactPoint>(this, Property(UKParliamentOntology.HouseHasContactPoint));

        public ICollection<FormalBody> HouseHasFormalBody => new DynamicObjectCollection<FormalBody>(this, Property(UKParliamentOntology.HouseHasFormalBody));

        public ICollection<FormalBody> LeadHouseHasFormalBody => new DynamicObjectCollection<FormalBody>(this, Property(UKParliamentOntology.LeadHouseHasFormalBody));

        public ICollection<HouseSeat> HouseHasHouseSeat => new DynamicObjectCollection<HouseSeat>(this, Property(UKParliamentOntology.HouseHasHouseSeat));

        public ICollection<ProcedureStep> HouseHasProcedureStep => new DynamicObjectCollection<ProcedureStep>(this, Property(UKParliamentOntology.HouseHasProcedureStep));

        public ICollection<string> HouseName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.HouseName));
    }
}

namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class House : UKParliamentDynamicNode
    {
        public House(INode node) : base(node) { }

        public ICollection<ContactPoint> HouseHasContactPoint => new DynamicObjectCollection<ContactPoint>(this, Property(UKParliamentOntology.HouseHasContactPoint.Uri));

        public ICollection<FormalBody> HouseHasFormalBody => new DynamicObjectCollection<FormalBody>(this, Property(UKParliamentOntology.HouseHasFormalBody.Uri));

        public ICollection<FormalBody> LeadHouseHasFormalBody => new DynamicObjectCollection<FormalBody>(this, Property(UKParliamentOntology.LeadHouseHasFormalBody.Uri));

        public ICollection<HouseSeat> HouseHasHouseSeat => new DynamicObjectCollection<HouseSeat>(this, Property(UKParliamentOntology.HouseHasHouseSeat.Uri));

        public ICollection<ProcedureStep> HouseHasProcedureStep => new DynamicObjectCollection<ProcedureStep>(this, Property(UKParliamentOntology.HouseHasProcedureStep.Uri));

        public string HouseName => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.HouseName.Uri))).SingleOrDefault();
    }
}

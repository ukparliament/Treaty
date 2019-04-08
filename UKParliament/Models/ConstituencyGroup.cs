namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ConstituencyGroup : UKParliamentDynamicNode
    {
        public ConstituencyGroup(INode node) : base(node) { }

        public ICollection<HouseSeat> ConstituencyGroupHasHouseSeat => new DynamicObjectCollection<HouseSeat>(this, Property(UKParliamentOntology.ConstituencyGroupHasHouseSeat));

        public ICollection<Electorate> ConstituencyGroupHasElectorate => new DynamicObjectCollection<Electorate>(this, Property(UKParliamentOntology.ConstituencyGroupHasElectorate));

        public ConstituencyArea ConstituencyGroupHasConstituencyArea => ((IEnumerable<ConstituencyArea>)new DynamicObjectCollection<ConstituencyArea>(this, Property(UKParliamentOntology.ConstituencyGroupHasConstituencyArea))).SingleOrDefault();

        public DateTimeOffset ConstituencyGroupStartDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.ConstituencyGroupStartDate))).SingleOrDefault();

        public string ConstituencyGroupName => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ConstituencyGroupName))).SingleOrDefault();
    }
}

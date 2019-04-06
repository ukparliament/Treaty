namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ConstituencyGroup : UKParliamentDynamicNode
    {
        public ConstituencyGroup(INode node) : base(node) { }

        public ICollection<HouseSeat> ConstituencyGroupHasHouseSeat => new DynamicObjectCollection<HouseSeat>(this, Property(UKParliamentOntology.ConstituencyGroupHasHouseSeat));

        public ICollection<Electorate> ConstituencyGroupHasElectorate => new DynamicObjectCollection<Electorate>(this, Property(UKParliamentOntology.ConstituencyGroupHasElectorate));

        public ICollection<ConstituencyArea> ConstituencyGroupHasConstituencyArea => new DynamicObjectCollection<ConstituencyArea>(this, Property(UKParliamentOntology.ConstituencyGroupHasConstituencyArea));

        public ICollection<DateTimeOffset> ConstituencyGroupStartDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.ConstituencyGroupStartDate));

        public ICollection<string> ConstituencyGroupName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ConstituencyGroupName));
    }
}

namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Group : UKParliamentDynamicNode
    {
        public Group(INode node) : base(node) { }

        public ICollection<Position> GroupHasPosition => new DynamicObjectCollection<Position>(this, Property(UKParliamentOntology.GroupHasPosition));

        public DateTimeOffset GroupStartDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.GroupStartDate))).SingleOrDefault();

        public string GroupName => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.GroupName))).FirstOrDefault();
    }
}

namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Group : UKParliamentDynamicNode
    {
        public Group(INode node) : base(node) { }

        public ICollection<Position> GroupHasPosition => new DynamicObjectCollection<Position>(this, Property(UKParliamentOntology.GroupHasPosition));

        public ICollection<DateTimeOffset> GroupStartDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.GroupStartDate));

        public ICollection<string> GroupName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.GroupName));
    }
}

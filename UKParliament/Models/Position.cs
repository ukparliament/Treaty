namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Position : UKParliamentDynamicNode
    {
        public Position(INode node) : base(node) { }

        public ICollection<Incumbency> PositionHasIncumbency => new DynamicObjectCollection<Incumbency>(this, Property(UKParliamentOntology.PositionHasIncumbency));

        public ICollection<Group> PositionHasGroup => new DynamicObjectCollection<Group>(this, Property(UKParliamentOntology.PositionHasGroup));

        public ICollection<string> PositionName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.PositionName));
    }
}

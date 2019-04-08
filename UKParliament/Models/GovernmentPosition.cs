namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class GovernmentPosition : Position
    {
        public GovernmentPosition(INode node) : base(node) { }

        public ICollection<GovernmentIncumbency> GovernmentPositionHasGovernmentIncumbency => new DynamicObjectCollection<GovernmentIncumbency>(this, Property(UKParliamentOntology.GovernmentPositionHasGovernmentIncumbency));
    }
}

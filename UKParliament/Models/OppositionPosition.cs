namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class OppositionPosition : Position
    {
        public OppositionPosition(INode node) : base(node) { }

        public ICollection<OppositionIncumbency> OppositionPositionHasOppositionIncumbency => new DynamicObjectCollection<OppositionIncumbency>(this, Property(UKParliamentOntology.OppositionPositionHasOppositionIncumbency.Uri));
    }
}

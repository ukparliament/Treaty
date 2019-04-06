namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisOppositionPosition : OppositionPosition
    {
        public MnisOppositionPosition(INode node) : base(node) { }

        public ICollection<string> OppositionPositionMnisId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.OppositionPositionMnisId));
    }
}

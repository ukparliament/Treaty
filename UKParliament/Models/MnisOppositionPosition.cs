namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisOppositionPosition : OppositionPosition
    {
        public MnisOppositionPosition(INode node) : base(node) { }

        public string OppositionPositionMnisId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.OppositionPositionMnisId))).SingleOrDefault();
    }
}

namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisOppositionIncumbency : OppositionIncumbency
    {
        public MnisOppositionIncumbency(INode node) : base(node) { }

        public ICollection<string> OppositionIncumbencyMnisId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.OppositionIncumbencyMnisId));
    }
}

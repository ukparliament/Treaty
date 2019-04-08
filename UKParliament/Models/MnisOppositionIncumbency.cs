namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisOppositionIncumbency : OppositionIncumbency
    {
        public MnisOppositionIncumbency(INode node) : base(node) { }

        public string OppositionIncumbencyMnisId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.OppositionIncumbencyMnisId))).SingleOrDefault();
    }
}

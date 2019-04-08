namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class OppositionPerson : Person
    {
        public OppositionPerson(INode node) : base(node) { }

        public ICollection<OppositionIncumbency> OppositionPersonHasOppositionIncumbency => new DynamicObjectCollection<OppositionIncumbency>(this, Property(UKParliamentOntology.OppositionPersonHasOppositionIncumbency));
    }
}

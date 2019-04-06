namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class OppositionIncumbency : Incumbency
    {
        public OppositionIncumbency(INode node) : base(node) { }

        public ICollection<OppositionPosition> OppositionIncumbencyHasOppositionPosition => new DynamicObjectCollection<OppositionPosition>(this, Property(UKParliamentOntology.OppositionIncumbencyHasOppositionPosition));

        public ICollection<OppositionPerson> OppositionIncumbencyHasOppositionPerson => new DynamicObjectCollection<OppositionPerson>(this, Property(UKParliamentOntology.OppositionIncumbencyHasOppositionPerson));
    }
}

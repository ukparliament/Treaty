namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class OppositionIncumbency : Incumbency
    {
        public OppositionIncumbency(INode node) : base(node) { }

        public OppositionPosition OppositionIncumbencyHasOppositionPosition => ((IEnumerable<OppositionPosition>)new DynamicObjectCollection<OppositionPosition>(this, Property(UKParliamentOntology.OppositionIncumbencyHasOppositionPosition))).SingleOrDefault();

        public OppositionPerson OppositionIncumbencyHasOppositionPerson => ((IEnumerable<OppositionPerson>)new DynamicObjectCollection<OppositionPerson>(this, Property(UKParliamentOntology.OppositionIncumbencyHasOppositionPerson))).SingleOrDefault();
    }
}

namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class FormalBodyChair : FormalBodyPosition
    {
        public FormalBodyChair(INode node) : base(node) { }

        public ICollection<FormalBody> FormalBodyChairHasFormalBody => new DynamicObjectCollection<FormalBody>(this, Property(UKParliamentOntology.FormalBodyChairHasFormalBody));
    }
}

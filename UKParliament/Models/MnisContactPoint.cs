namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisContactPoint : ContactPoint
    {
        public MnisContactPoint(INode node) : base(node) { }

        public ICollection<string> ContactPointMnisId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ContactPointMnisId));
    }
}

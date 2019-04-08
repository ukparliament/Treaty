namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisContactPoint : ContactPoint
    {
        public MnisContactPoint(INode node) : base(node) { }

        public string ContactPointMnisId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ContactPointMnisId))).SingleOrDefault();
    }
}

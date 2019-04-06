namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisFormalBodyChairIncumbency : Incumbency
    {
        public MnisFormalBodyChairIncumbency(INode node) : base(node) { }

        public ICollection<string> FormalBodyChairIncumbencyMnisId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.FormalBodyChairIncumbencyMnisId));
    }
}

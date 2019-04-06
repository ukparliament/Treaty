namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class FormalBodyPosition : Position
    {
        public FormalBodyPosition(INode node) : base(node) { }
    }
}

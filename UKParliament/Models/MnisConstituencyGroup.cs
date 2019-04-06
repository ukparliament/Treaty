namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisConstituencyGroup : ConstituencyGroup
    {
        public MnisConstituencyGroup(INode node) : base(node) { }

        public ICollection<string> ConstituencyGroupMnisId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ConstituencyGroupMnisId));
    }
}

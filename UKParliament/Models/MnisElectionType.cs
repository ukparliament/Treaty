namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisElectionType : ElectionType
    {
        public MnisElectionType(INode node) : base(node) { }

        public ICollection<string> ElectionTypeMnisId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ElectionTypeMnisId));
    }
}

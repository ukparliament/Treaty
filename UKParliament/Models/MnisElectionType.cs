namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisElectionType : ElectionType
    {
        public MnisElectionType(INode node) : base(node) { }

        public string ElectionTypeMnisId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ElectionTypeMnisId.Uri))).SingleOrDefault();
    }
}

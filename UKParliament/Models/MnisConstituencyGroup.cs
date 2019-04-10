namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisConstituencyGroup : ConstituencyGroup
    {
        public MnisConstituencyGroup(INode node) : base(node) { }

        public string ConstituencyGroupMnisId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ConstituencyGroupMnisId.Uri))).SingleOrDefault();
    }
}

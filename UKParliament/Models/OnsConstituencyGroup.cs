namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class OnsConstituencyGroup : ConstituencyGroup
    {
        public OnsConstituencyGroup(INode node) : base(node) { }

        public string ConstituencyGroupOnsCode => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ConstituencyGroupOnsCode.Uri))).SingleOrDefault();
    }
}

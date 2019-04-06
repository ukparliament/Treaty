namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class OnsConstituencyGroup : ConstituencyGroup
    {
        public OnsConstituencyGroup(INode node) : base(node) { }

        public ICollection<string> ConstituencyGroupOnsCode => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ConstituencyGroupOnsCode));
    }
}

namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PastConstituencyGroup : ConstituencyGroup
    {
        public PastConstituencyGroup(INode node) : base(node) { }

        public ICollection<DateTimeOffset> ConstituencyGroupEndDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.ConstituencyGroupEndDate));
    }
}

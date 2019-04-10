namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PastConstituencyGroup : ConstituencyGroup
    {
        public PastConstituencyGroup(INode node) : base(node) { }

        public DateTimeOffset ConstituencyGroupEndDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.ConstituencyGroupEndDate.Uri))).SingleOrDefault();
    }
}

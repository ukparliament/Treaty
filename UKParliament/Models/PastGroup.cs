namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PastGroup : Group
    {
        public PastGroup(INode node) : base(node) { }

        public DateTimeOffset GroupEndDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.GroupEndDate.Uri))).SingleOrDefault();
    }
}

namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PastGroup : Group
    {
        public PastGroup(INode node) : base(node) { }

        public ICollection<DateTimeOffset> GroupEndDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.GroupEndDate));
    }
}
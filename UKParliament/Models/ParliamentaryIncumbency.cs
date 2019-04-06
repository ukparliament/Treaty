namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ParliamentaryIncumbency : UKParliamentDynamicNode
    {
        public ParliamentaryIncumbency(INode node) : base(node) { }

        public ICollection<Member> ParliamentaryIncumbencyHasMember => new DynamicObjectCollection<Member>(this, Property(UKParliamentOntology.ParliamentaryIncumbencyHasMember));

        public ICollection<ContactPoint> ParliamentaryIncumbencyHasContactPoint => new DynamicObjectCollection<ContactPoint>(this, Property(UKParliamentOntology.ParliamentaryIncumbencyHasContactPoint));

        public ICollection<DateTimeOffset> ParliamentaryIncumbencyStartDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.ParliamentaryIncumbencyStartDate));
    }
}

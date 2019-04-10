namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ParliamentaryIncumbency : UKParliamentDynamicNode
    {
        public ParliamentaryIncumbency(INode node) : base(node) { }

        public Member ParliamentaryIncumbencyHasMember => ((IEnumerable<Member>)new DynamicObjectCollection<Member>(this, Property(UKParliamentOntology.ParliamentaryIncumbencyHasMember.Uri))).SingleOrDefault();

        public ICollection<ContactPoint> ParliamentaryIncumbencyHasContactPoint => new DynamicObjectCollection<ContactPoint>(this, Property(UKParliamentOntology.ParliamentaryIncumbencyHasContactPoint.Uri));

        public DateTimeOffset ParliamentaryIncumbencyStartDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.ParliamentaryIncumbencyStartDate.Uri))).SingleOrDefault();
    }
}

namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class AlternateMembership : FormalBodyMembership
    {
        public AlternateMembership(INode node) : base(node) { }

        public Member AlternateMembershipHasMember => ((IEnumerable<Member>)new DynamicObjectCollection<Member>(this, Property(UKParliamentOntology.AlternateMembershipHasMember))).SingleOrDefault();
    }
}

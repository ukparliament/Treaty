namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class AlternateMembership : FormalBodyMembership
    {
        public AlternateMembership(INode node) : base(node) { }

        public ICollection<Member> AlternateMembershipHasMember => new DynamicObjectCollection<Member>(this, Property(UKParliamentOntology.AlternateMembershipHasMember));
    }
}

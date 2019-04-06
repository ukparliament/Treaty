namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ExOfficioMembership : FormalBodyMembership
    {
        public ExOfficioMembership(INode node) : base(node) { }

        public ICollection<Member> ExOfficioMembershipHasMember => new DynamicObjectCollection<Member>(this, Property(UKParliamentOntology.ExOfficioMembershipHasMember));
    }
}

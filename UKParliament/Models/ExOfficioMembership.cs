namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ExOfficioMembership : FormalBodyMembership
    {
        public ExOfficioMembership(INode node) : base(node) { }

        public Member ExOfficioMembershipHasMember => ((IEnumerable<Member>)new DynamicObjectCollection<Member>(this, Property(UKParliamentOntology.ExOfficioMembershipHasMember))).SingleOrDefault();
    }
}

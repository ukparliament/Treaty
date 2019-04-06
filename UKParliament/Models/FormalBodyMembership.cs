namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class FormalBodyMembership : UKParliamentDynamicNode
    {
        public FormalBodyMembership(INode node) : base(node) { }

        public ICollection<Person> FormalBodyMembershipHasPerson => new DynamicObjectCollection<Person>(this, Property(UKParliamentOntology.FormalBodyMembershipHasPerson));

        public ICollection<FormalBody> FormalBodyMembershipHasFormalBody => new DynamicObjectCollection<FormalBody>(this, Property(UKParliamentOntology.FormalBodyMembershipHasFormalBody));

        public ICollection<DateTimeOffset> FormalBodyMembershipStartDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.FormalBodyMembershipStartDate));
    }
}

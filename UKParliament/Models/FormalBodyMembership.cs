namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class FormalBodyMembership : UKParliamentDynamicNode
    {
        public FormalBodyMembership(INode node) : base(node) { }

        public Person FormalBodyMembershipHasPerson => ((IEnumerable<Person>)new DynamicObjectCollection<Person>(this, Property(UKParliamentOntology.FormalBodyMembershipHasPerson))).SingleOrDefault();

        public FormalBody FormalBodyMembershipHasFormalBody => ((IEnumerable<FormalBody>)new DynamicObjectCollection<FormalBody>(this, Property(UKParliamentOntology.FormalBodyMembershipHasFormalBody))).SingleOrDefault();

        public DateTimeOffset FormalBodyMembershipStartDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.FormalBodyMembershipStartDate))).SingleOrDefault();
    }
}

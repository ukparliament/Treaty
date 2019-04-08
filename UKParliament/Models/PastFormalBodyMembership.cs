namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PastFormalBodyMembership : FormalBodyMembership
    {
        public PastFormalBodyMembership(INode node) : base(node) { }

        public DateTimeOffset FormalBodyMembershipEndDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.FormalBodyMembershipEndDate))).SingleOrDefault();
    }
}

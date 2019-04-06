namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class GenderIdentity : UKParliamentDynamicNode
    {
        public GenderIdentity(INode node) : base(node) { }

        public ICollection<Person> GenderIdentityHasPerson => new DynamicObjectCollection<Person>(this, Property(UKParliamentOntology.GenderIdentityHasPerson));

        public ICollection<Gender> GenderIdentityHasGender => new DynamicObjectCollection<Gender>(this, Property(UKParliamentOntology.GenderIdentityHasGender));
    }
}

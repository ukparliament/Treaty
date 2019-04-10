namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class GenderIdentity : UKParliamentDynamicNode
    {
        public GenderIdentity(INode node) : base(node) { }

        public Person GenderIdentityHasPerson => ((IEnumerable<Person>)new DynamicObjectCollection<Person>(this, Property(UKParliamentOntology.GenderIdentityHasPerson.Uri))).SingleOrDefault();

        public Gender GenderIdentityHasGender => ((IEnumerable<Gender>)new DynamicObjectCollection<Gender>(this, Property(UKParliamentOntology.GenderIdentityHasGender.Uri))).SingleOrDefault();
    }
}

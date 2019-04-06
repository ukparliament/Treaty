namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ContactPoint : UKParliamentDynamicNode
    {
        public ContactPoint(INode node) : base(node) { }

        public ICollection<FormalBody> ContactPointHasFormalBody => new DynamicObjectCollection<FormalBody>(this, Property(UKParliamentOntology.ContactPointHasFormalBody));

        public ICollection<House> ContactPointHasHouse => new DynamicObjectCollection<House>(this, Property(UKParliamentOntology.ContactPointHasHouse));

        public ICollection<ContactableThing> ContactPointHasContactableThing => new DynamicObjectCollection<ContactableThing>(this, Property(UKParliamentOntology.ContactPointHasContactableThing));

        public ICollection<PostalAddress> ContactPointHasPostalAddress => new DynamicObjectCollection<PostalAddress>(this, Property(UKParliamentOntology.ContactPointHasPostalAddress));

        public ICollection<ParliamentaryIncumbency> ContactPointHasParliamentaryIncumbency => new DynamicObjectCollection<ParliamentaryIncumbency>(this, Property(UKParliamentOntology.ContactPointHasParliamentaryIncumbency));

        public ICollection<ElectoralIncumbency> ContactPointHasElectoralIncumbency => new DynamicObjectCollection<ElectoralIncumbency>(this, Property(UKParliamentOntology.ContactPointHasElectoralIncumbency));

        public ICollection<Person> ContactPointHasPerson => new DynamicObjectCollection<Person>(this, Property(UKParliamentOntology.ContactPointHasPerson));

        public ICollection<string> FaxNumber => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.FaxNumber));

        public ICollection<string> Email => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.Email));

        public ICollection<string> PhoneNumber => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.PhoneNumber));

        public ICollection<string> ContactForm => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ContactForm));
    }
}

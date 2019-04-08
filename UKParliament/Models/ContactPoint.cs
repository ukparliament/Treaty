namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ContactPoint : UKParliamentDynamicNode
    {
        public ContactPoint(INode node) : base(node) { }

        public ICollection<FormalBody> ContactPointHasFormalBody => new DynamicObjectCollection<FormalBody>(this, Property(UKParliamentOntology.ContactPointHasFormalBody));

        public ICollection<House> ContactPointHasHouse => new DynamicObjectCollection<House>(this, Property(UKParliamentOntology.ContactPointHasHouse));

        public ICollection<ContactableThing> ContactPointHasContactableThing => new DynamicObjectCollection<ContactableThing>(this, Property(UKParliamentOntology.ContactPointHasContactableThing));

        public PostalAddress ContactPointHasPostalAddress => ((IEnumerable<PostalAddress>)new DynamicObjectCollection<PostalAddress>(this, Property(UKParliamentOntology.ContactPointHasPostalAddress))).SingleOrDefault();

        public ICollection<ParliamentaryIncumbency> ContactPointHasParliamentaryIncumbency => new DynamicObjectCollection<ParliamentaryIncumbency>(this, Property(UKParliamentOntology.ContactPointHasParliamentaryIncumbency));

        public ICollection<ElectoralIncumbency> ContactPointHasElectoralIncumbency => new DynamicObjectCollection<ElectoralIncumbency>(this, Property(UKParliamentOntology.ContactPointHasElectoralIncumbency));

        public ICollection<Person> ContactPointHasPerson => new DynamicObjectCollection<Person>(this, Property(UKParliamentOntology.ContactPointHasPerson));

        public string FaxNumber => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.FaxNumber))).SingleOrDefault();

        public string Email => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.Email))).SingleOrDefault();

        public string PhoneNumber => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.PhoneNumber))).SingleOrDefault();

        public string ContactForm => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ContactForm))).SingleOrDefault();
    }
}

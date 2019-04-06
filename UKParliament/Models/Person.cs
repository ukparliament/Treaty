namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Person : UKParliamentDynamicNode
    {
        public Person(INode node) : base(node) { }

        public ICollection<Incumbency> PersonHasIncumbency => new DynamicObjectCollection<Incumbency>(this, Property(UKParliamentOntology.PersonHasIncumbency));

        public ICollection<FormalBodyMembership> PersonHasFormalBodyMembership => new DynamicObjectCollection<FormalBodyMembership>(this, Property(UKParliamentOntology.PersonHasFormalBodyMembership));

        public ICollection<PersonImage> PersonHasPersonImage => new DynamicObjectCollection<PersonImage>(this, Property(UKParliamentOntology.PersonHasPersonImage));

        public ICollection<GenderIdentity> PersonHasGenderIdentity => new DynamicObjectCollection<GenderIdentity>(this, Property(UKParliamentOntology.PersonHasGenderIdentity));

        public ICollection<ContactPoint> PersonHasContactPoint => new DynamicObjectCollection<ContactPoint>(this, Property(UKParliamentOntology.PersonHasContactPoint));

        public ICollection<PersonWebLink> PersonHasPersonWebLink => new DynamicObjectCollection<PersonWebLink>(this, Property(UKParliamentOntology.PersonHasPersonWebLink));

        public ICollection<Question> AskingPersonHasQuestion => new DynamicObjectCollection<Question>(this, Property(UKParliamentOntology.AskingPersonHasQuestion));

        public ICollection<Answer> AnsweringPersonHasAnswer => new DynamicObjectCollection<Answer>(this, Property(UKParliamentOntology.AnsweringPersonHasAnswer));

        public ICollection<DateTimeOffset> PersonDateOfBirth => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.PersonDateOfBirth));

        public ICollection<string> PersonFamilyName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.PersonFamilyName));

        public ICollection<string> PersonGivenName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.PersonGivenName));

        public ICollection<string> PersonOtherNames => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.PersonOtherNames));
    }
}

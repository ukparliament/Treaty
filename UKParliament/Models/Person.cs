namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
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

        public DateTimeOffset PersonDateOfBirth => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.PersonDateOfBirth))).SingleOrDefault();

        public string PersonFamilyName => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.PersonFamilyName))).SingleOrDefault();

        public string PersonGivenName => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.PersonGivenName))).SingleOrDefault();

        public string PersonOtherNames => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.PersonOtherNames))).SingleOrDefault();
    }
}

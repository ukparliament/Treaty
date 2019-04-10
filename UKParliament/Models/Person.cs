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

        public ICollection<Incumbency> PersonHasIncumbency => new DynamicObjectCollection<Incumbency>(this, Property(UKParliamentOntology.PersonHasIncumbency.Uri));

        public ICollection<FormalBodyMembership> PersonHasFormalBodyMembership => new DynamicObjectCollection<FormalBodyMembership>(this, Property(UKParliamentOntology.PersonHasFormalBodyMembership.Uri));

        public ICollection<PersonImage> PersonHasPersonImage => new DynamicObjectCollection<PersonImage>(this, Property(UKParliamentOntology.PersonHasPersonImage.Uri));

        public ICollection<GenderIdentity> PersonHasGenderIdentity => new DynamicObjectCollection<GenderIdentity>(this, Property(UKParliamentOntology.PersonHasGenderIdentity.Uri));

        public ICollection<ContactPoint> PersonHasContactPoint => new DynamicObjectCollection<ContactPoint>(this, Property(UKParliamentOntology.PersonHasContactPoint.Uri));

        public ICollection<PersonWebLink> PersonHasPersonWebLink => new DynamicObjectCollection<PersonWebLink>(this, Property(UKParliamentOntology.PersonHasPersonWebLink.Uri));

        public ICollection<Question> AskingPersonHasQuestion => new DynamicObjectCollection<Question>(this, Property(UKParliamentOntology.AskingPersonHasQuestion.Uri));

        public ICollection<Answer> AnsweringPersonHasAnswer => new DynamicObjectCollection<Answer>(this, Property(UKParliamentOntology.AnsweringPersonHasAnswer.Uri));

        public DateTimeOffset PersonDateOfBirth => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.PersonDateOfBirth.Uri))).SingleOrDefault();

        public string PersonFamilyName => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.PersonFamilyName.Uri))).SingleOrDefault();

        public string PersonGivenName => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.PersonGivenName.Uri))).SingleOrDefault();

        public string PersonOtherNames => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.PersonOtherNames.Uri))).SingleOrDefault();
    }
}

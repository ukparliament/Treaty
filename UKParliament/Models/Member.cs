namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Member : Person
    {
        public Member(INode node) : base(node) { }

        public ICollection<ExOfficioMembership> MemberHasExOfficioMembership => new DynamicObjectCollection<ExOfficioMembership>(this, Property(UKParliamentOntology.MemberHasExOfficioMembership.Uri));

        public ICollection<AlternateMembership> MemberHasAlternateMembership => new DynamicObjectCollection<AlternateMembership>(this, Property(UKParliamentOntology.MemberHasAlternateMembership.Uri));

        public ICollection<MemberImage> MemberHasMemberImage => new DynamicObjectCollection<MemberImage>(this, Property(UKParliamentOntology.MemberHasMemberImage.Uri));

        public ICollection<ParliamentaryIncumbency> MemberHasParliamentaryIncumbency => new DynamicObjectCollection<ParliamentaryIncumbency>(this, Property(UKParliamentOntology.MemberHasParliamentaryIncumbency.Uri));
    }
}

namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MemberImage : PersonImage
    {
        public MemberImage(INode node) : base(node) { }

        public ICollection<Member> MemberImageHasMember => new DynamicObjectCollection<Member>(this, Property(UKParliamentOntology.MemberImageHasMember.Uri));
    }
}

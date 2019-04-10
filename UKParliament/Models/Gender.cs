namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Gender : UKParliamentDynamicNode
    {
        public Gender(INode node) : base(node) { }

        public ICollection<GenderIdentity> GenderHasGenderIdentity => new DynamicObjectCollection<GenderIdentity>(this, Property(UKParliamentOntology.GenderHasGenderIdentity.Uri));

        public string GenderName => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.GenderName.Uri))).SingleOrDefault();
    }
}

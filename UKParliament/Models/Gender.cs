namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Gender : UKParliamentDynamicNode
    {
        public Gender(INode node) : base(node) { }

        public ICollection<GenderIdentity> GenderHasGenderIdentity => new DynamicObjectCollection<GenderIdentity>(this, Property(UKParliamentOntology.GenderHasGenderIdentity));

        public ICollection<string> GenderName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.GenderName));
    }
}

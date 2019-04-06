namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class LocatedSignatureCount : UKParliamentDynamicNode
    {
        public LocatedSignatureCount(INode node) : base(node) { }

        public ICollection<EPetition> LocatedSignatureCountHasEPetition => new DynamicObjectCollection<EPetition>(this, Property(UKParliamentOntology.LocatedSignatureCountHasEPetition));

        public ICollection<Place> LocatedSignatureCountHasPlace => new DynamicObjectCollection<Place>(this, Property(UKParliamentOntology.LocatedSignatureCountHasPlace));

        public ICollection<int> SignatureCount => new DynamicObjectCollection<int>(this, Property(UKParliamentOntology.SignatureCount));

        public ICollection<string> SignatureCountRetrievedAt => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.SignatureCountRetrievedAt));
    }
}

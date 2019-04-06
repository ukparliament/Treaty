namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class FormalBodyType : UKParliamentDynamicNode
    {
        public FormalBodyType(INode node) : base(node) { }

        public ICollection<FormalBody> FormalBodyTypeHasFormalBody => new DynamicObjectCollection<FormalBody>(this, Property(UKParliamentOntology.FormalBodyTypeHasFormalBody));

        public ICollection<string> FormalBodyTypeName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.FormalBodyTypeName));
    }
}

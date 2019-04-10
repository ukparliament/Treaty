namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class FormalBodyType : UKParliamentDynamicNode
    {
        public FormalBodyType(INode node) : base(node) { }

        public ICollection<FormalBody> FormalBodyTypeHasFormalBody => new DynamicObjectCollection<FormalBody>(this, Property(UKParliamentOntology.FormalBodyTypeHasFormalBody.Uri));

        public string FormalBodyTypeName => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.FormalBodyTypeName.Uri))).SingleOrDefault();
    }
}

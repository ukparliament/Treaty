namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ElectionType : UKParliamentDynamicNode
    {
        public ElectionType(INode node) : base(node) { }

        public ICollection<Election> ElectionTypeHasElection => new DynamicObjectCollection<Election>(this, Property(UKParliamentOntology.ElectionTypeHasElection.Uri));

        public string ElectionTypeName => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ElectionTypeName.Uri))).SingleOrDefault();
    }
}

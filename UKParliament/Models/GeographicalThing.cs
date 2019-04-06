namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class GeographicalThing : UKParliamentDynamicNode
    {
        public GeographicalThing(INode node) : base(node) { }

        public ICollection<string> Latitude => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.Latitude));

        public ICollection<string> Longitude => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.Longitude));
    }
}

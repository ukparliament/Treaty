namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class GeographicalThing : UKParliamentDynamicNode
    {
        public GeographicalThing(INode node) : base(node) { }

        public string Latitude => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.Latitude.Uri))).SingleOrDefault();

        public string Longitude => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.Longitude.Uri))).SingleOrDefault();
    }
}

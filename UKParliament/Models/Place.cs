namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Place : GeographicalThing
    {
        public Place(INode node) : base(node) { }

        public ICollection<LocatedSignatureCount> PlaceHasLocatedSignatureCount => new DynamicObjectCollection<LocatedSignatureCount>(this, Property(UKParliamentOntology.PlaceHasLocatedSignatureCount));

        public ICollection<Place> ContainedByPlace => new DynamicObjectCollection<Place>(this, Property(UKParliamentOntology.ContainedByPlace));

        public ICollection<Place> ContainsPlace => new DynamicObjectCollection<Place>(this, Property(UKParliamentOntology.ContainsPlace));
    }
}

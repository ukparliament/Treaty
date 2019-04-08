namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Image : UKParliamentDynamicNode
    {
        public Image(INode node) : base(node) { }

        public ICollection<ImageSubject> ImageHasImageSubject => new DynamicObjectCollection<ImageSubject>(this, Property(UKParliamentOntology.ImageHasImageSubject));
    }
}

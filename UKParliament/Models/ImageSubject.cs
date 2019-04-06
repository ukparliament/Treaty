namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ImageSubject : UKParliamentDynamicNode
    {
        public ImageSubject(INode node) : base(node) { }

        public ICollection<Image> ImageSubjectHasImage => new DynamicObjectCollection<Image>(this, Property(UKParliamentOntology.ImageSubjectHasImage));
    }
}

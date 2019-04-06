namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PersonImage : Image
    {
        public PersonImage(INode node) : base(node) { }

        public ICollection<Person> PersonImageHasPerson => new DynamicObjectCollection<Person>(this, Property(UKParliamentOntology.PersonImageHasPerson));

        public ICollection<string> PersonImageFaceCentrePoint => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.PersonImageFaceCentrePoint));
    }
}

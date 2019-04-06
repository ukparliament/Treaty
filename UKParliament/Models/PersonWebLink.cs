namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PersonWebLink : UKParliamentDynamicNode
    {
        public PersonWebLink(INode node) : base(node) { }

        public ICollection<Person> PersonWebLinkHasPerson => new DynamicObjectCollection<Person>(this, Property(UKParliamentOntology.PersonWebLinkHasPerson));
    }
}

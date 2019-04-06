namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class DodsPerson : Person
    {
        public DodsPerson(INode node) : base(node) { }

        public ICollection<string> PersonDodsId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.PersonDodsId));
    }
}

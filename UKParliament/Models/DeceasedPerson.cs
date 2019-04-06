namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class DeceasedPerson : Person
    {
        public DeceasedPerson(INode node) : base(node) { }

        public ICollection<DateTimeOffset> PersonDateOfDeath => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.PersonDateOfDeath));
    }
}

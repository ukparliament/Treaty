namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class DeceasedPerson : Person
    {
        public DeceasedPerson(INode node) : base(node) { }

        public DateTimeOffset PersonDateOfDeath => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.PersonDateOfDeath))).SingleOrDefault();
    }
}

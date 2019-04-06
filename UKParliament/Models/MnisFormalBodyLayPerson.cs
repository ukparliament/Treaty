namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisFormalBodyLayPerson : Person
    {
        public MnisFormalBodyLayPerson(INode node) : base(node) { }

        public ICollection<string> FormalBodyLayPersonMnisId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.FormalBodyLayPersonMnisId));
    }
}

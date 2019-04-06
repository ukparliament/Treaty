namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PimsPerson : Person
    {
        public PimsPerson(INode node) : base(node) { }

        public ICollection<string> PersonPimsId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.PersonPimsId));
    }
}

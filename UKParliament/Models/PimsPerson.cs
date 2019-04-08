namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PimsPerson : Person
    {
        public PimsPerson(INode node) : base(node) { }

        public string PersonPimsId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.PersonPimsId))).SingleOrDefault();
    }
}

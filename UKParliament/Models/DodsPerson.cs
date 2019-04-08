namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class DodsPerson : Person
    {
        public DodsPerson(INode node) : base(node) { }

        public string PersonDodsId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.PersonDodsId))).SingleOrDefault();
    }
}

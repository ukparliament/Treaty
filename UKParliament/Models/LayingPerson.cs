namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class LayingPerson : Person
    {
        public LayingPerson(INode node) : base(node) { }

        public ICollection<Laying> LayingPersonHasLaying => new DynamicObjectCollection<Laying>(this, Property(UKParliamentOntology.LayingPersonHasLaying.Uri));
    }
}

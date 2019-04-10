namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisFormalBodyLayPerson : Person
    {
        public MnisFormalBodyLayPerson(INode node) : base(node) { }

        public string FormalBodyLayPersonMnisId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.FormalBodyLayPersonMnisId.Uri))).SingleOrDefault();
    }
}

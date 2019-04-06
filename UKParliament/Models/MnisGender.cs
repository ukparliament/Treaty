namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisGender : Gender
    {
        public MnisGender(INode node) : base(node) { }

        public ICollection<string> GenderMnisId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.GenderMnisId));
    }
}

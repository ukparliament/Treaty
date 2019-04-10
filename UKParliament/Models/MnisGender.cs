namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisGender : Gender
    {
        public MnisGender(INode node) : base(node) { }

        public string GenderMnisId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.GenderMnisId.Uri))).SingleOrDefault();
    }
}

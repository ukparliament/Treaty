namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisGovernmentIncumbency : GovernmentIncumbency
    {
        public MnisGovernmentIncumbency(INode node) : base(node) { }

        public string GovernmentIncumbencyMnisId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.GovernmentIncumbencyMnisId.Uri))).SingleOrDefault();
    }
}

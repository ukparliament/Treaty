namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisFormalBodyChairIncumbency : Incumbency
    {
        public MnisFormalBodyChairIncumbency(INode node) : base(node) { }

        public string FormalBodyChairIncumbencyMnisId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.FormalBodyChairIncumbencyMnisId.Uri))).SingleOrDefault();
    }
}

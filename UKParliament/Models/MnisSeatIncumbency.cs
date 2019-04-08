namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisSeatIncumbency : SeatIncumbency
    {
        public MnisSeatIncumbency(INode node) : base(node) { }

        public string CommonsSeatIncumbencyMnisId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.CommonsSeatIncumbencyMnisId))).SingleOrDefault();

        public string LordsSeatIncumbencyMnisId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.LordsSeatIncumbencyMnisId))).SingleOrDefault();
    }
}

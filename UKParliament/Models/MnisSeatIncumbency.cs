namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisSeatIncumbency : SeatIncumbency
    {
        public MnisSeatIncumbency(INode node) : base(node) { }

        public ICollection<string> CommonsSeatIncumbencyMnisId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.CommonsSeatIncumbencyMnisId));

        public ICollection<string> LordsSeatIncumbencyMnisId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.LordsSeatIncumbencyMnisId));
    }
}

namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisHouseSeatType : HouseSeatType
    {
        public MnisHouseSeatType(INode node) : base(node) { }

        public string HouseSeatTypeMnisId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.HouseSeatTypeMnisId.Uri))).SingleOrDefault();
    }
}

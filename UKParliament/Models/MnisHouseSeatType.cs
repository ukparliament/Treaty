namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisHouseSeatType : HouseSeatType
    {
        public MnisHouseSeatType(INode node) : base(node) { }

        public ICollection<string> HouseSeatTypeMnisId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.HouseSeatTypeMnisId));
    }
}

namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisGovernmentPosition : GovernmentPosition
    {
        public MnisGovernmentPosition(INode node) : base(node) { }

        public string GovernmentPositionMnisId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.GovernmentPositionMnisId))).SingleOrDefault();
    }
}

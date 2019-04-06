namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisGovernmentPosition : GovernmentPosition
    {
        public MnisGovernmentPosition(INode node) : base(node) { }

        public ICollection<string> GovernmentPositionMnisId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.GovernmentPositionMnisId));
    }
}

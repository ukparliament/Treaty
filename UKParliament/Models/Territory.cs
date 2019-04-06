namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Territory : Place
    {
        public Territory(INode node) : base(node) { }

        public ICollection<string> TerritoryName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.TerritoryName));

        public ICollection<string> TerritoryOfficialName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.TerritoryOfficialName));
    }
}

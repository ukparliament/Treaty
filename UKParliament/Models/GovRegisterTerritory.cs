namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class GovRegisterTerritory : Territory
    {
        public GovRegisterTerritory(INode node) : base(node) { }

        public ICollection<string> TerritoryGovRegisterId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.TerritoryGovRegisterId));

        public ICollection<DateTimeOffset> GovRegisterTerritoryStartDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.GovRegisterTerritoryStartDate));

        public ICollection<DateTimeOffset> GovRegisterTerritoryEndDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.GovRegisterTerritoryEndDate));
    }
}

namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class GovRegisterTerritory : Territory
    {
        public GovRegisterTerritory(INode node) : base(node) { }

        public string TerritoryGovRegisterId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.TerritoryGovRegisterId.Uri))).SingleOrDefault();

        public ICollection<DateTimeOffset> GovRegisterTerritoryStartDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.GovRegisterTerritoryStartDate.Uri));

        public ICollection<DateTimeOffset> GovRegisterTerritoryEndDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.GovRegisterTerritoryEndDate.Uri));
    }
}

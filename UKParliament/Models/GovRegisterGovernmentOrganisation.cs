namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class GovRegisterGovernmentOrganisation : GovernmentOrganisation
    {
        public GovRegisterGovernmentOrganisation(INode node) : base(node) { }

        public string GovernmentOrganisationGovRegisterId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.GovernmentOrganisationGovRegisterId))).SingleOrDefault();
    }
}

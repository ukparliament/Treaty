namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class GovRegisterGovernmentOrganisation : GovernmentOrganisation
    {
        public GovRegisterGovernmentOrganisation(INode node) : base(node) { }

        public ICollection<string> GovernmentOrganisationGovRegisterId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.GovernmentOrganisationGovRegisterId));
    }
}

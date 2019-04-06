namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class GovernmentOrganisation : Group
    {
        public GovernmentOrganisation(INode node) : base(node) { }

        public ICollection<Treaty> LeadGovernmentOrganisationHasTreaty => new DynamicObjectCollection<Treaty>(this, Property(UKParliamentOntology.LeadGovernmentOrganisationHasTreaty));
    }
}

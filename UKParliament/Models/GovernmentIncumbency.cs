namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class GovernmentIncumbency : Incumbency
    {
        public GovernmentIncumbency(INode node) : base(node) { }

        public ICollection<GovernmentPosition> GovernmentIncumbencyHasGovernmentPosition => new DynamicObjectCollection<GovernmentPosition>(this, Property(UKParliamentOntology.GovernmentIncumbencyHasGovernmentPosition));

        public ICollection<GovernmentPerson> GovernmentIncumbencyHasGovernmentPerson => new DynamicObjectCollection<GovernmentPerson>(this, Property(UKParliamentOntology.GovernmentIncumbencyHasGovernmentPerson));
    }
}

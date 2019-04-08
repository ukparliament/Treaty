namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class GovernmentIncumbency : Incumbency
    {
        public GovernmentIncumbency(INode node) : base(node) { }

        public GovernmentPosition GovernmentIncumbencyHasGovernmentPosition => ((IEnumerable<GovernmentPosition>)new DynamicObjectCollection<GovernmentPosition>(this, Property(UKParliamentOntology.GovernmentIncumbencyHasGovernmentPosition))).SingleOrDefault();

        public GovernmentPerson GovernmentIncumbencyHasGovernmentPerson => ((IEnumerable<GovernmentPerson>)new DynamicObjectCollection<GovernmentPerson>(this, Property(UKParliamentOntology.GovernmentIncumbencyHasGovernmentPerson))).SingleOrDefault();
    }
}

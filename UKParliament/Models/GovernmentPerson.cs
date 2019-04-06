namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class GovernmentPerson : Person
    {
        public GovernmentPerson(INode node) : base(node) { }

        public ICollection<GovernmentIncumbency> GovernmentPersonHasGovernmentIncumbency => new DynamicObjectCollection<GovernmentIncumbency>(this, Property(UKParliamentOntology.GovernmentPersonHasGovernmentIncumbency));
    }
}

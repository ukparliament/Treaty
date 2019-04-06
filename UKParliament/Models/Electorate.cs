namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Electorate : UKParliamentDynamicNode
    {
        public Electorate(INode node) : base(node) { }

        public ICollection<Election> ElectorateHasElection => new DynamicObjectCollection<Election>(this, Property(UKParliamentOntology.ElectorateHasElection));

        public ICollection<ConstituencyGroup> ElectorateHasConstitutencyGroup => new DynamicObjectCollection<ConstituencyGroup>(this, Property(UKParliamentOntology.ElectorateHasConstitutencyGroup));
    }
}

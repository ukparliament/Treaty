namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Electorate : UKParliamentDynamicNode
    {
        public Electorate(INode node) : base(node) { }

        public ICollection<Election> ElectorateHasElection => new DynamicObjectCollection<Election>(this, Property(UKParliamentOntology.ElectorateHasElection.Uri));

        public ConstituencyGroup ElectorateHasConstitutencyGroup => ((IEnumerable<ConstituencyGroup>)new DynamicObjectCollection<ConstituencyGroup>(this, Property(UKParliamentOntology.ElectorateHasConstitutencyGroup.Uri))).SingleOrDefault();
    }
}

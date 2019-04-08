namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Election : UKParliamentDynamicNode
    {
        public Election(INode node) : base(node) { }

        public ICollection<Candidacy> ElectionHasCandidacy => new DynamicObjectCollection<Candidacy>(this, Property(UKParliamentOntology.ElectionHasCandidacy));

        public Electorate ElectionHasElectorate => ((IEnumerable<Electorate>)new DynamicObjectCollection<Electorate>(this, Property(UKParliamentOntology.ElectionHasElectorate))).SingleOrDefault();

        public ElectionType ElectionHasElectionType => ((IEnumerable<ElectionType>)new DynamicObjectCollection<ElectionType>(this, Property(UKParliamentOntology.ElectionHasElectionType))).SingleOrDefault();

        public string ElectionName => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ElectionName))).SingleOrDefault();
    }
}

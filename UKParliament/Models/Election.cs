namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Election : UKParliamentDynamicNode
    {
        public Election(INode node) : base(node) { }

        public ICollection<Candidacy> ElectionHasCandidacy => new DynamicObjectCollection<Candidacy>(this, Property(UKParliamentOntology.ElectionHasCandidacy));

        public ICollection<Electorate> ElectionHasElectorate => new DynamicObjectCollection<Electorate>(this, Property(UKParliamentOntology.ElectionHasElectorate));

        public ICollection<ElectionType> ElectionHasElectionType => new DynamicObjectCollection<ElectionType>(this, Property(UKParliamentOntology.ElectionHasElectionType));

        public ICollection<string> ElectionName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ElectionName));
    }
}

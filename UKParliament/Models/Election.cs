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

        public ICollection<Candidacy> ElectionHasCandidacy => new DynamicObjectCollection<Candidacy>(this, Property(UKParliamentOntology.ElectionHasCandidacy.Uri));

        public Electorate ElectionHasElectorate => ((IEnumerable<Electorate>)new DynamicObjectCollection<Electorate>(this, Property(UKParliamentOntology.ElectionHasElectorate.Uri))).SingleOrDefault();

        public ElectionType ElectionHasElectionType => ((IEnumerable<ElectionType>)new DynamicObjectCollection<ElectionType>(this, Property(UKParliamentOntology.ElectionHasElectionType.Uri))).SingleOrDefault();

        public string ElectionName => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ElectionName.Uri))).SingleOrDefault();
    }
}

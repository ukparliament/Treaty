namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class UkgapEPetition : EPetition
    {
        public UkgapEPetition(INode node) : base(node) { }

        public string EPetitionUkgapId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.EPetitionUkgapId))).SingleOrDefault();
    }
}

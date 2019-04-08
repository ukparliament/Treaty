namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisParty : Party
    {
        public MnisParty(INode node) : base(node) { }

        public string PartyMnisId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.PartyMnisId))).SingleOrDefault();
    }
}

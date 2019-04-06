namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class UkgapEPetition : EPetition
    {
        public UkgapEPetition(INode node) : base(node) { }

        public ICollection<string> EPetitionUkgapId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.EPetitionUkgapId));
    }
}

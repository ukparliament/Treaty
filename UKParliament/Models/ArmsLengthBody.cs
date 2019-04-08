namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ArmsLengthBody : Group
    {
        public ArmsLengthBody(INode node) : base(node) { }

        public ICollection<DelegatedAnswer> ArmsLengthBodyHasDelegatedAnswer => new DynamicObjectCollection<DelegatedAnswer>(this, Property(UKParliamentOntology.ArmsLengthBodyHasDelegatedAnswer));
    }
}

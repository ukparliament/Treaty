namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ArmsLengthBody : Group
    {
        public ArmsLengthBody(INode node) : base(node) { }

        public ICollection<DelegatedAnswer> ArmsLengthBodyHasDelegatedAnswer => new DynamicObjectCollection<DelegatedAnswer>(this, Property(UKParliamentOntology.ArmsLengthBodyHasDelegatedAnswer));
    }
}

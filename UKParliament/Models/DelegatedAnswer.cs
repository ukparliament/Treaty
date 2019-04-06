namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class DelegatedAnswer : SubstantiveAnswer
    {
        public DelegatedAnswer(INode node) : base(node) { }

        public ICollection<ArmsLengthBody> DelegatedAnswerHasArmsLengthBody => new DynamicObjectCollection<ArmsLengthBody>(this, Property(UKParliamentOntology.DelegatedAnswerHasArmsLengthBody));
    }
}

namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class DelegatedAnswer : SubstantiveAnswer
    {
        public DelegatedAnswer(INode node) : base(node) { }

        public ICollection<ArmsLengthBody> DelegatedAnswerHasArmsLengthBody => new DynamicObjectCollection<ArmsLengthBody>(this, Property(UKParliamentOntology.DelegatedAnswerHasArmsLengthBody));
    }
}

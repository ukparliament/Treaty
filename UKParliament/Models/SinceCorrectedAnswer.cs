namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class SinceCorrectedAnswer : Answer
    {
        public SinceCorrectedAnswer(INode node) : base(node) { }

        public ICollection<CorrectingAnswer> SinceCorrectedAnswerIsReplacedByCorrectingAnswer => new DynamicObjectCollection<CorrectingAnswer>(this, Property(UKParliamentOntology.SinceCorrectedAnswerIsReplacedByCorrectingAnswer));
    }
}

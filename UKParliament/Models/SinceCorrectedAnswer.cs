namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class SinceCorrectedAnswer : Answer
    {
        public SinceCorrectedAnswer(INode node) : base(node) { }

        public CorrectingAnswer SinceCorrectedAnswerIsReplacedByCorrectingAnswer => ((IEnumerable<CorrectingAnswer>)new DynamicObjectCollection<CorrectingAnswer>(this, Property(UKParliamentOntology.SinceCorrectedAnswerIsReplacedByCorrectingAnswer))).SingleOrDefault();
    }
}

namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class IndexingAndSearchWrittenQuestion : Question
    {
        public IndexingAndSearchWrittenQuestion(INode node) : base(node) { }

        public ICollection<string> WrittenQuestionIndexingAndSearchUin => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.WrittenQuestionIndexingAndSearchUin));
    }
}

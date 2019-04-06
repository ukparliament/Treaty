namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MadeStatutoryInstrumentPaper : StatutoryInstrumentPaper
    {
        public MadeStatutoryInstrumentPaper(INode node) : base(node) { }

        public ICollection<DateTimeOffset> StatutoryInstrumentPaperMadeDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.StatutoryInstrumentPaperMadeDate));
    }
}

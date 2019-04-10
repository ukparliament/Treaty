namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MadeStatutoryInstrumentPaper : StatutoryInstrumentPaper
    {
        public MadeStatutoryInstrumentPaper(INode node) : base(node) { }

        public DateTimeOffset StatutoryInstrumentPaperMadeDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.StatutoryInstrumentPaperMadeDate.Uri))).SingleOrDefault();
    }
}

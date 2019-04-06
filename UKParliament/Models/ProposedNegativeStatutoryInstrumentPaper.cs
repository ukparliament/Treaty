namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ProposedNegativeStatutoryInstrumentPaper : LaidThing
    {
        public ProposedNegativeStatutoryInstrumentPaper(INode node) : base(node) { }

        public ICollection<StatutoryInstrumentPaper> ProposedNegativeStatutoryInstrumentPaperPrecedesStatutoryInstrumentPaper => new DynamicObjectCollection<StatutoryInstrumentPaper>(this, Property(UKParliamentOntology.ProposedNegativeStatutoryInstrumentPaperPrecedesStatutoryInstrumentPaper));

        public ICollection<string> ProposedNegativeStatutoryInstrumentPaperName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ProposedNegativeStatutoryInstrumentPaperName));
    }
}

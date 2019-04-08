namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ProposedNegativeStatutoryInstrumentPaper : LaidThing
    {
        public ProposedNegativeStatutoryInstrumentPaper(INode node) : base(node) { }

        public ICollection<StatutoryInstrumentPaper> ProposedNegativeStatutoryInstrumentPaperPrecedesStatutoryInstrumentPaper => new DynamicObjectCollection<StatutoryInstrumentPaper>(this, Property(UKParliamentOntology.ProposedNegativeStatutoryInstrumentPaperPrecedesStatutoryInstrumentPaper));

        public string ProposedNegativeStatutoryInstrumentPaperName => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ProposedNegativeStatutoryInstrumentPaperName))).SingleOrDefault();
    }
}

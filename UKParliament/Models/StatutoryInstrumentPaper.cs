namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class StatutoryInstrumentPaper : LaidThing
    {
        public StatutoryInstrumentPaper(INode node) : base(node) { }

        public ICollection<ProposedNegativeStatutoryInstrumentPaper> StatutoryInstrumentPaperFollowsProposedNegativeStatutoryInstrumentPaper => new DynamicObjectCollection<ProposedNegativeStatutoryInstrumentPaper>(this, Property(UKParliamentOntology.StatutoryInstrumentPaperFollowsProposedNegativeStatutoryInstrumentPaper));

        public ICollection<string> StatutoryInstrumentPaperName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.StatutoryInstrumentPaperName));

        public ICollection<string> StatutoryInstrumentPaperPrefix => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.StatutoryInstrumentPaperPrefix));

        public ICollection<string> StatutoryInstrumentPaperYear => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.StatutoryInstrumentPaperYear));

        public ICollection<int> StatutoryInstrumentPaperNumber => new DynamicObjectCollection<int>(this, Property(UKParliamentOntology.StatutoryInstrumentPaperNumber));

        public ICollection<DateTimeOffset> StatutoryInstrumentPaperComingIntoForceDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.StatutoryInstrumentPaperComingIntoForceDate));

        public ICollection<string> StatutoryInstrumentPaperComingIntoForceNote => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.StatutoryInstrumentPaperComingIntoForceNote));
    }
}

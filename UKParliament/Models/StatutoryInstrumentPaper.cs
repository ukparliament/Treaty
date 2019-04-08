namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class StatutoryInstrumentPaper : LaidThing
    {
        public StatutoryInstrumentPaper(INode node) : base(node) { }

        public ICollection<ProposedNegativeStatutoryInstrumentPaper> StatutoryInstrumentPaperFollowsProposedNegativeStatutoryInstrumentPaper => new DynamicObjectCollection<ProposedNegativeStatutoryInstrumentPaper>(this, Property(UKParliamentOntology.StatutoryInstrumentPaperFollowsProposedNegativeStatutoryInstrumentPaper));

        public string StatutoryInstrumentPaperName => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.StatutoryInstrumentPaperName))).SingleOrDefault();

        public string StatutoryInstrumentPaperPrefix => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.StatutoryInstrumentPaperPrefix))).SingleOrDefault();

        public string StatutoryInstrumentPaperYear => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.StatutoryInstrumentPaperYear))).SingleOrDefault();

        public int StatutoryInstrumentPaperNumber => ((IEnumerable<int>)new DynamicObjectCollection<int>(this, Property(UKParliamentOntology.StatutoryInstrumentPaperNumber))).SingleOrDefault();

        public DateTimeOffset StatutoryInstrumentPaperComingIntoForceDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.StatutoryInstrumentPaperComingIntoForceDate))).SingleOrDefault();

        public string StatutoryInstrumentPaperComingIntoForceNote => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.StatutoryInstrumentPaperComingIntoForceNote))).SingleOrDefault();
    }
}

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

        public ICollection<ProposedNegativeStatutoryInstrumentPaper> StatutoryInstrumentPaperFollowsProposedNegativeStatutoryInstrumentPaper => new DynamicObjectCollection<ProposedNegativeStatutoryInstrumentPaper>(this, Property(UKParliamentOntology.StatutoryInstrumentPaperFollowsProposedNegativeStatutoryInstrumentPaper.Uri));

        public string StatutoryInstrumentPaperName => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.StatutoryInstrumentPaperName.Uri))).SingleOrDefault();

        public string StatutoryInstrumentPaperPrefix => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.StatutoryInstrumentPaperPrefix.Uri))).SingleOrDefault();

        public string StatutoryInstrumentPaperYear => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.StatutoryInstrumentPaperYear.Uri))).SingleOrDefault();

        public System.Int64 StatutoryInstrumentPaperNumber => ((IEnumerable<System.Int64>)new DynamicObjectCollection<System.Int64>(this, Property(UKParliamentOntology.StatutoryInstrumentPaperNumber.Uri))).SingleOrDefault();

        public DateTimeOffset StatutoryInstrumentPaperComingIntoForceDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.StatutoryInstrumentPaperComingIntoForceDate.Uri))).SingleOrDefault();

        public string StatutoryInstrumentPaperComingIntoForceNote => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.StatutoryInstrumentPaperComingIntoForceNote.Uri))).SingleOrDefault();
    }
}

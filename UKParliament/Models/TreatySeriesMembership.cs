namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class TreatySeriesMembership : SeriesMembership
    {
        public TreatySeriesMembership(INode node) : base(node) { }

        public InForceTreaty TreatySeriesMembershipHasInForceTreaty => ((IEnumerable<InForceTreaty>)new DynamicObjectCollection<InForceTreaty>(this, Property(UKParliamentOntology.TreatySeriesMembershipHasInForceTreaty.Uri))).SingleOrDefault();

        public string TreatySeriesItemCitation => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.TreatySeriesItemCitation.Uri))).SingleOrDefault();
    }
}

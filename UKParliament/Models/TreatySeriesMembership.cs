namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class TreatySeriesMembership : SeriesMembership
    {
        public TreatySeriesMembership(INode node) : base(node) { }

        public ICollection<InForceTreaty> TreatySeriesMembershipHasInForceTreaty => new DynamicObjectCollection<InForceTreaty>(this, Property(UKParliamentOntology.TreatySeriesMembershipHasInForceTreaty));

        public ICollection<string> TreatySeriesItemCitation => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.TreatySeriesItemCitation));
    }
}

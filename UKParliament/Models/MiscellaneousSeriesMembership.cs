namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MiscellaneousSeriesMembership : SeriesMembership
    {
        public MiscellaneousSeriesMembership(INode node) : base(node) { }

        public ICollection<Treaty> MiscellaneousSeriesMembershipHasTreaty => new DynamicObjectCollection<Treaty>(this, Property(UKParliamentOntology.MiscellaneousSeriesMembershipHasTreaty));

        public ICollection<string> MiscellaneousSeriesItemCitation => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.MiscellaneousSeriesItemCitation));
    }
}

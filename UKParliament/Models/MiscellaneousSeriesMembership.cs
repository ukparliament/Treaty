namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MiscellaneousSeriesMembership : SeriesMembership
    {
        public MiscellaneousSeriesMembership(INode node) : base(node) { }

        public Treaty MiscellaneousSeriesMembershipHasTreaty => ((IEnumerable<Treaty>)new DynamicObjectCollection<Treaty>(this, Property(UKParliamentOntology.MiscellaneousSeriesMembershipHasTreaty.Uri))).SingleOrDefault();

        public string MiscellaneousSeriesItemCitation => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.MiscellaneousSeriesItemCitation.Uri))).SingleOrDefault();
    }
}

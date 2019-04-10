namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class CountrySeriesMembership : SeriesMembership
    {
        public CountrySeriesMembership(INode node) : base(node) { }

        public Treaty CountrySeriesMembershipHasTreaty => ((IEnumerable<Treaty>)new DynamicObjectCollection<Treaty>(this, Property(UKParliamentOntology.CountrySeriesMembershipHasTreaty.Uri))).SingleOrDefault();

        public string CountrySeriesItemCitation => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.CountrySeriesItemCitation.Uri))).SingleOrDefault();
    }
}

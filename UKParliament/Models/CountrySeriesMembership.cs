namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class CountrySeriesMembership : SeriesMembership
    {
        public CountrySeriesMembership(INode node) : base(node) { }

        public ICollection<Treaty> CountrySeriesMembershipHasTreaty => new DynamicObjectCollection<Treaty>(this, Property(UKParliamentOntology.CountrySeriesMembershipHasTreaty));

        public ICollection<string> CountrySeriesItemCitation => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.CountrySeriesItemCitation));
    }
}

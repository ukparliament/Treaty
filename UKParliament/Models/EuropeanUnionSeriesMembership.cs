namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class EuropeanUnionSeriesMembership : SeriesMembership
    {
        public EuropeanUnionSeriesMembership(INode node) : base(node) { }

        public ICollection<Treaty> EuropeanUnionSeriesMembershipHasTreaty => new DynamicObjectCollection<Treaty>(this, Property(UKParliamentOntology.EuropeanUnionSeriesMembershipHasTreaty));

        public ICollection<string> EuropeanUnionSeriesItemCitation => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.EuropeanUnionSeriesItemCitation));
    }
}

namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class EuropeanUnionSeriesMembership : SeriesMembership
    {
        public EuropeanUnionSeriesMembership(INode node) : base(node) { }

        public Treaty EuropeanUnionSeriesMembershipHasTreaty => ((IEnumerable<Treaty>)new DynamicObjectCollection<Treaty>(this, Property(UKParliamentOntology.EuropeanUnionSeriesMembershipHasTreaty.Uri))).SingleOrDefault();

        public string EuropeanUnionSeriesItemCitation => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.EuropeanUnionSeriesItemCitation.Uri))).SingleOrDefault();
    }
}

namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class SeriesMembership : UKParliamentDynamicNode
    {
        public SeriesMembership(INode node) : base(node) { }

        public ICollection<Treaty> SeriesMembershipHasTreaty => new DynamicObjectCollection<Treaty>(this, Property(UKParliamentOntology.SeriesMembershipHasTreaty));

        public ICollection<string> SeriesItemCitation => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.SeriesItemCitation));
    }
}

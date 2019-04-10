namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class SeriesMembership : UKParliamentDynamicNode
    {
        public SeriesMembership(INode node) : base(node) { }

        public Treaty SeriesMembershipHasTreaty => ((IEnumerable<Treaty>)new DynamicObjectCollection<Treaty>(this, Property(UKParliamentOntology.SeriesMembershipHasTreaty.Uri))).SingleOrDefault();

        public string SeriesItemCitation => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.SeriesItemCitation.Uri))).SingleOrDefault();
    }
}

namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class InForceTreaty : Treaty
    {
        public InForceTreaty(INode node) : base(node) { }

        public TreatySeriesMembership InForceTreatyHasTreatySeriesMembership => ((IEnumerable<TreatySeriesMembership>)new DynamicObjectCollection<TreatySeriesMembership>(this, Property(UKParliamentOntology.InForceTreatyHasTreatySeriesMembership.Uri))).SingleOrDefault();
    }
}

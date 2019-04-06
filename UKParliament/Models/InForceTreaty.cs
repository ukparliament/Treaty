namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class InForceTreaty : Treaty
    {
        public InForceTreaty(INode node) : base(node) { }

        public ICollection<TreatySeriesMembership> InForceTreatyHasTreatySeriesMembership => new DynamicObjectCollection<TreatySeriesMembership>(this, Property(UKParliamentOntology.InForceTreatyHasTreatySeriesMembership));
    }
}

namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ThingWithLogo : UKParliamentDynamicNode
    {
        public ThingWithLogo(INode node) : base(node) { }

        public ICollection<Logo> ThingWithLogoHasLogo => new DynamicObjectCollection<Logo>(this, Property(UKParliamentOntology.ThingWithLogoHasLogo));
    }
}

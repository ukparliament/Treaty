namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Logo : UKParliamentDynamicNode
    {
        public Logo(INode node) : base(node) { }

        public ICollection<LogoImage> LogoHasLogoImage => new DynamicObjectCollection<LogoImage>(this, Property(UKParliamentOntology.LogoHasLogoImage));

        public ICollection<ThingWithLogo> LogoHasThingWithLogo => new DynamicObjectCollection<ThingWithLogo>(this, Property(UKParliamentOntology.LogoHasThingWithLogo));
    }
}

namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Logo : UKParliamentDynamicNode
    {
        public Logo(INode node) : base(node) { }

        public ICollection<LogoImage> LogoHasLogoImage => new DynamicObjectCollection<LogoImage>(this, Property(UKParliamentOntology.LogoHasLogoImage.Uri));

        public ICollection<ThingWithLogo> LogoHasThingWithLogo => new DynamicObjectCollection<ThingWithLogo>(this, Property(UKParliamentOntology.LogoHasThingWithLogo.Uri));
    }
}

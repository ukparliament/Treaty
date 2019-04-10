namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class LogoImage : Image
    {
        public LogoImage(INode node) : base(node) { }

        public ICollection<Logo> LogoImageHasLogo => new DynamicObjectCollection<Logo>(this, Property(UKParliamentOntology.LogoImageHasLogo.Uri));
    }
}

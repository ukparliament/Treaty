namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Focus : UKParliamentDynamicNode
    {
        public Focus(INode node) : base(node) { }

        public ICollection<FocusPeriod> FocusHasFocusPeriod => new DynamicObjectCollection<FocusPeriod>(this, Property(UKParliamentOntology.FocusHasFocusPeriod.Uri));
    }
}

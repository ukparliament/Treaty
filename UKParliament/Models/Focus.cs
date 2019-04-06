namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Focus : UKParliamentDynamicNode
    {
        public Focus(INode node) : base(node) { }

        public ICollection<FocusPeriod> FocusHasFocusPeriod => new DynamicObjectCollection<FocusPeriod>(this, Property(UKParliamentOntology.FocusHasFocusPeriod));
    }
}

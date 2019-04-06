namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ThresholdAttainment : UKParliamentDynamicNode
    {
        public ThresholdAttainment(INode node) : base(node) { }

        public ICollection<EPetition> ThresholdAttainmentHasEPetition => new DynamicObjectCollection<EPetition>(this, Property(UKParliamentOntology.ThresholdAttainmentHasEPetition));

        public ICollection<Threshold> ThresholdAttainmentHasThreshold => new DynamicObjectCollection<Threshold>(this, Property(UKParliamentOntology.ThresholdAttainmentHasThreshold));

        public ICollection<string> ThresholdAttainmentAt => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ThresholdAttainmentAt));
    }
}

namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ThresholdAttainment : UKParliamentDynamicNode
    {
        public ThresholdAttainment(INode node) : base(node) { }

        public ICollection<EPetition> ThresholdAttainmentHasEPetition => new DynamicObjectCollection<EPetition>(this, Property(UKParliamentOntology.ThresholdAttainmentHasEPetition));

        public Threshold ThresholdAttainmentHasThreshold => ((IEnumerable<Threshold>)new DynamicObjectCollection<Threshold>(this, Property(UKParliamentOntology.ThresholdAttainmentHasThreshold))).SingleOrDefault();

        public string ThresholdAttainmentAt => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ThresholdAttainmentAt))).SingleOrDefault();
    }
}

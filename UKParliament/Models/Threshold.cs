namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Threshold : UKParliamentDynamicNode
    {
        public Threshold(INode node) : base(node) { }

        public ICollection<ThresholdAttainment> ThresholdHasThresholdAttainment => new DynamicObjectCollection<ThresholdAttainment>(this, Property(UKParliamentOntology.ThresholdHasThresholdAttainment.Uri));

        public ICollection<string> ThresholdName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ThresholdName.Uri));

        public ICollection<int> ThresholdSignatureNumber => new DynamicObjectCollection<int>(this, Property(UKParliamentOntology.ThresholdSignatureNumber.Uri));
    }
}

namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ProcedureStep : UKParliamentDynamicNode
    {
        public ProcedureStep(INode node) : base(node) { }

        public ICollection<ProcedureStepPublication> ProcedureStepHasProcedureStepPublication => new DynamicObjectCollection<ProcedureStepPublication>(this, Property(UKParliamentOntology.ProcedureStepHasProcedureStepPublication));

        public ICollection<ProcedureStep> ProcedureStepCommonlyActualisedAlongsideProcedureStep => new DynamicObjectCollection<ProcedureStep>(this, Property(UKParliamentOntology.ProcedureStepCommonlyActualisedAlongsideProcedureStep));

        public ICollection<BusinessItem> ProcedureStepHasBusinessItem => new DynamicObjectCollection<BusinessItem>(this, Property(UKParliamentOntology.ProcedureStepHasBusinessItem));

        public ICollection<ProcedureRoute> ProcedureStepIsFromProcedureRoute => new DynamicObjectCollection<ProcedureRoute>(this, Property(UKParliamentOntology.ProcedureStepIsFromProcedureRoute));

        public ICollection<ProcedureRoute> ProcedureStepIsToProcedureRoute => new DynamicObjectCollection<ProcedureRoute>(this, Property(UKParliamentOntology.ProcedureStepIsToProcedureRoute));

        public ICollection<CausedProcedureRoute> ProcedureStepCausesCausedProcedureRoute => new DynamicObjectCollection<CausedProcedureRoute>(this, Property(UKParliamentOntology.ProcedureStepCausesCausedProcedureRoute));

        public ICollection<AllowedProcedureRoute> ProcedureStepAllowsAllowedProcedureRoute => new DynamicObjectCollection<AllowedProcedureRoute>(this, Property(UKParliamentOntology.ProcedureStepAllowsAllowedProcedureRoute));

        public ICollection<RequiredProcedureRoute> ProcedureStepRequiresRequiredProcedureRoute => new DynamicObjectCollection<RequiredProcedureRoute>(this, Property(UKParliamentOntology.ProcedureStepRequiresRequiredProcedureRoute));

        public ICollection<PrecludedProcedureRoute> ProcedureStepPrecludesPrecludedProcedureRoute => new DynamicObjectCollection<PrecludedProcedureRoute>(this, Property(UKParliamentOntology.ProcedureStepPrecludesPrecludedProcedureRoute));

        public ICollection<House> ProcedureStepHasHouse => new DynamicObjectCollection<House>(this, Property(UKParliamentOntology.ProcedureStepHasHouse));

        public ICollection<string> ProcedureStepName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ProcedureStepName));

        public ICollection<string> ProcedureStepDescription => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ProcedureStepDescription));

        public ICollection<string> ProcedureStepScopeNote => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ProcedureStepScopeNote));

        public ICollection<string> ProcedureStepLinkNote => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ProcedureStepLinkNote));

        public ICollection<string> ProcedureStepDateNote => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ProcedureStepDateNote));
    }
}

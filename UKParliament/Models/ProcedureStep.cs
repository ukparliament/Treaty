namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ProcedureStep : UKParliamentDynamicNode
    {
        public ProcedureStep(INode node) : base(node) { }

        public ICollection<ProcedureStepPublication> ProcedureStepHasProcedureStepPublication => new DynamicObjectCollection<ProcedureStepPublication>(this, Property(UKParliamentOntology.ProcedureStepHasProcedureStepPublication.Uri));

        public ICollection<ProcedureStep> ProcedureStepIsCommonlyActualisedAlongsideProcedureStep => new DynamicObjectCollection<ProcedureStep>(this, Property(UKParliamentOntology.ProcedureStepIsCommonlyActualisedAlongsideProcedureStep.Uri));

        public ICollection<BusinessItem> ProcedureStepHasBusinessItem => new DynamicObjectCollection<BusinessItem>(this, Property(UKParliamentOntology.ProcedureStepHasBusinessItem.Uri));

        public ICollection<ProcedureRoute> ProcedureStepIsFromProcedureRoute => new DynamicObjectCollection<ProcedureRoute>(this, Property(UKParliamentOntology.ProcedureStepIsFromProcedureRoute.Uri));

        public ICollection<ProcedureRoute> ProcedureStepIsToProcedureRoute => new DynamicObjectCollection<ProcedureRoute>(this, Property(UKParliamentOntology.ProcedureStepIsToProcedureRoute.Uri));

        public ICollection<CausedProcedureRoute> ProcedureStepCausesCausedProcedureRoute => new DynamicObjectCollection<CausedProcedureRoute>(this, Property(UKParliamentOntology.ProcedureStepCausesCausedProcedureRoute.Uri));

        public ICollection<AllowedProcedureRoute> ProcedureStepAllowsAllowedProcedureRoute => new DynamicObjectCollection<AllowedProcedureRoute>(this, Property(UKParliamentOntology.ProcedureStepAllowsAllowedProcedureRoute.Uri));

        public ICollection<RequiredProcedureRoute> ProcedureStepRequiresRequiredProcedureRoute => new DynamicObjectCollection<RequiredProcedureRoute>(this, Property(UKParliamentOntology.ProcedureStepRequiresRequiredProcedureRoute.Uri));

        public ICollection<PrecludedProcedureRoute> ProcedureStepPrecludesPrecludedProcedureRoute => new DynamicObjectCollection<PrecludedProcedureRoute>(this, Property(UKParliamentOntology.ProcedureStepPrecludesPrecludedProcedureRoute.Uri));

        public ICollection<House> ProcedureStepHasHouse => new DynamicObjectCollection<House>(this, Property(UKParliamentOntology.ProcedureStepHasHouse.Uri));

        public string ProcedureStepName => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ProcedureStepName.Uri))).SingleOrDefault();

        public string ProcedureStepDescription => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ProcedureStepDescription.Uri))).SingleOrDefault();

        public ICollection<string> ProcedureStepScopeNote => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ProcedureStepScopeNote.Uri));

        public ICollection<string> ProcedureStepLinkNote => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ProcedureStepLinkNote.Uri));

        public ICollection<string> ProcedureStepDateNote => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ProcedureStepDateNote.Uri));
    }
}

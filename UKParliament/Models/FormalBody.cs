namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class FormalBody : Group
    {
        public FormalBody(INode node) : base(node) { }

        public ICollection<FocusPeriod> FormalBodyHasFocusPeriod => new DynamicObjectCollection<FocusPeriod>(this, Property(UKParliamentOntology.FormalBodyHasFocusPeriod));

        public ICollection<FormalBodyType> FormalBodyHasFormalBodyType => new DynamicObjectCollection<FormalBodyType>(this, Property(UKParliamentOntology.FormalBodyHasFormalBodyType));

        public ICollection<ContactPoint> FormalBodyHasContactPoint => new DynamicObjectCollection<ContactPoint>(this, Property(UKParliamentOntology.FormalBodyHasContactPoint));

        public ICollection<FormalBodyChair> FormalBodyHasFormalBodyChair => new DynamicObjectCollection<FormalBodyChair>(this, Property(UKParliamentOntology.FormalBodyHasFormalBodyChair));

        public ICollection<House> FormalBodyHasHouse => new DynamicObjectCollection<House>(this, Property(UKParliamentOntology.FormalBodyHasHouse));

        public ICollection<House> FormalBodyHasLeadHouse => new DynamicObjectCollection<House>(this, Property(UKParliamentOntology.FormalBodyHasLeadHouse));

        public ICollection<FormalBody> FormalBodyHasParentFormalBody => new DynamicObjectCollection<FormalBody>(this, Property(UKParliamentOntology.FormalBodyHasParentFormalBody));

        public ICollection<FormalBody> FormalBodyHasChildFormalBody => new DynamicObjectCollection<FormalBody>(this, Property(UKParliamentOntology.FormalBodyHasChildFormalBody));

        public ICollection<FormalBodyMembership> FormalBodyHasFormalBodyMembership => new DynamicObjectCollection<FormalBodyMembership>(this, Property(UKParliamentOntology.FormalBodyHasFormalBodyMembership));

        public ICollection<string> FormalBodyName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.FormalBodyName));

        public ICollection<string> FormalBodyRemit => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.FormalBodyRemit));

        public ICollection<DateTimeOffset> FormalBodyStartDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.FormalBodyStartDate));
    }
}

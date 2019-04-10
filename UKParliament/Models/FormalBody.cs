namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class FormalBody : Group
    {
        public FormalBody(INode node) : base(node) { }

        public ICollection<FocusPeriod> FormalBodyHasFocusPeriod => new DynamicObjectCollection<FocusPeriod>(this, Property(UKParliamentOntology.FormalBodyHasFocusPeriod.Uri));

        public ICollection<FormalBodyType> FormalBodyHasFormalBodyType => new DynamicObjectCollection<FormalBodyType>(this, Property(UKParliamentOntology.FormalBodyHasFormalBodyType.Uri));

        public ICollection<ContactPoint> FormalBodyHasContactPoint => new DynamicObjectCollection<ContactPoint>(this, Property(UKParliamentOntology.FormalBodyHasContactPoint.Uri));

        public FormalBodyChair FormalBodyHasFormalBodyChair => ((IEnumerable<FormalBodyChair>)new DynamicObjectCollection<FormalBodyChair>(this, Property(UKParliamentOntology.FormalBodyHasFormalBodyChair.Uri))).SingleOrDefault();

        public ICollection<House> FormalBodyHasHouse => new DynamicObjectCollection<House>(this, Property(UKParliamentOntology.FormalBodyHasHouse.Uri));

        public House FormalBodyHasLeadHouse => ((IEnumerable<House>)new DynamicObjectCollection<House>(this, Property(UKParliamentOntology.FormalBodyHasLeadHouse.Uri))).SingleOrDefault();

        public ICollection<FormalBody> FormalBodyHasParentFormalBody => new DynamicObjectCollection<FormalBody>(this, Property(UKParliamentOntology.FormalBodyHasParentFormalBody.Uri));

        public ICollection<FormalBody> FormalBodyHasChildFormalBody => new DynamicObjectCollection<FormalBody>(this, Property(UKParliamentOntology.FormalBodyHasChildFormalBody.Uri));

        public ICollection<FormalBodyMembership> FormalBodyHasFormalBodyMembership => new DynamicObjectCollection<FormalBodyMembership>(this, Property(UKParliamentOntology.FormalBodyHasFormalBodyMembership.Uri));

        public string FormalBodyName => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.FormalBodyName.Uri))).SingleOrDefault();

        public string FormalBodyRemit => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.FormalBodyRemit.Uri))).SingleOrDefault();

        public DateTimeOffset FormalBodyStartDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.FormalBodyStartDate.Uri))).SingleOrDefault();
    }
}

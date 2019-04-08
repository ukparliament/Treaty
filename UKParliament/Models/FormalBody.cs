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

        public ICollection<FocusPeriod> FormalBodyHasFocusPeriod => new DynamicObjectCollection<FocusPeriod>(this, Property(UKParliamentOntology.FormalBodyHasFocusPeriod));

        public ICollection<FormalBodyType> FormalBodyHasFormalBodyType => new DynamicObjectCollection<FormalBodyType>(this, Property(UKParliamentOntology.FormalBodyHasFormalBodyType));

        public ICollection<ContactPoint> FormalBodyHasContactPoint => new DynamicObjectCollection<ContactPoint>(this, Property(UKParliamentOntology.FormalBodyHasContactPoint));

        public FormalBodyChair FormalBodyHasFormalBodyChair => ((IEnumerable<FormalBodyChair>)new DynamicObjectCollection<FormalBodyChair>(this, Property(UKParliamentOntology.FormalBodyHasFormalBodyChair))).SingleOrDefault();

        public ICollection<House> FormalBodyHasHouse => new DynamicObjectCollection<House>(this, Property(UKParliamentOntology.FormalBodyHasHouse));

        public House FormalBodyHasLeadHouse => ((IEnumerable<House>)new DynamicObjectCollection<House>(this, Property(UKParliamentOntology.FormalBodyHasLeadHouse))).SingleOrDefault();

        public ICollection<FormalBody> FormalBodyHasParentFormalBody => new DynamicObjectCollection<FormalBody>(this, Property(UKParliamentOntology.FormalBodyHasParentFormalBody));

        public ICollection<FormalBody> FormalBodyHasChildFormalBody => new DynamicObjectCollection<FormalBody>(this, Property(UKParliamentOntology.FormalBodyHasChildFormalBody));

        public ICollection<FormalBodyMembership> FormalBodyHasFormalBodyMembership => new DynamicObjectCollection<FormalBodyMembership>(this, Property(UKParliamentOntology.FormalBodyHasFormalBodyMembership));

        public string FormalBodyName => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.FormalBodyName))).SingleOrDefault();

        public string FormalBodyRemit => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.FormalBodyRemit))).SingleOrDefault();

        public DateTimeOffset FormalBodyStartDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.FormalBodyStartDate))).SingleOrDefault();
    }
}

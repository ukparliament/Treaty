namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Laying : BusinessItem
    {
        public Laying(INode node) : base(node) { }

        public ICollection<LayingPerson> LayingHasLayingPerson => new DynamicObjectCollection<LayingPerson>(this, Property(UKParliamentOntology.LayingHasLayingPerson));

        public ICollection<LayingBody> LayingHasLayingBody => new DynamicObjectCollection<LayingBody>(this, Property(UKParliamentOntology.LayingHasLayingBody));

        public ICollection<LaidThing> LayingHasLaidThing => new DynamicObjectCollection<LaidThing>(this, Property(UKParliamentOntology.LayingHasLaidThing));

        public ICollection<DateTimeOffset> LayingDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.LayingDate));
    }
}

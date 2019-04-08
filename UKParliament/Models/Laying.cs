namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Laying : BusinessItem
    {
        public Laying(INode node) : base(node) { }

        public LayingPerson LayingHasLayingPerson => ((IEnumerable<LayingPerson>)new DynamicObjectCollection<LayingPerson>(this, Property(UKParliamentOntology.LayingHasLayingPerson))).SingleOrDefault();

        public LayingBody LayingHasLayingBody => ((IEnumerable<LayingBody>)new DynamicObjectCollection<LayingBody>(this, Property(UKParliamentOntology.LayingHasLayingBody))).SingleOrDefault();

        public LaidThing LayingHasLaidThing => ((IEnumerable<LaidThing>)new DynamicObjectCollection<LaidThing>(this, Property(UKParliamentOntology.LayingHasLaidThing))).SingleOrDefault();

        public DateTimeOffset LayingDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.LayingDate))).SingleOrDefault();
    }
}

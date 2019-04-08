namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Incumbency : UKParliamentDynamicNode
    {
        public Incumbency(INode node) : base(node) { }

        public ICollection<IncumbencyInterruption> IncumbencyHasIncumbencyInterruption => new DynamicObjectCollection<IncumbencyInterruption>(this, Property(UKParliamentOntology.IncumbencyHasIncumbencyInterruption));

        public Position IncumbencyHasPosition => ((IEnumerable<Position>)new DynamicObjectCollection<Position>(this, Property(UKParliamentOntology.IncumbencyHasPosition))).SingleOrDefault();

        public Person IncumbencyHasPerson => ((IEnumerable<Person>)new DynamicObjectCollection<Person>(this, Property(UKParliamentOntology.IncumbencyHasPerson))).SingleOrDefault();

        public DateTimeOffset IncumbencyStartDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.IncumbencyStartDate))).SingleOrDefault();
    }
}

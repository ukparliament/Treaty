namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Incumbency : UKParliamentDynamicNode
    {
        public Incumbency(INode node) : base(node) { }

        public ICollection<IncumbencyInterruption> IncumbencyHasIncumbencyInterruption => new DynamicObjectCollection<IncumbencyInterruption>(this, Property(UKParliamentOntology.IncumbencyHasIncumbencyInterruption));

        public ICollection<Position> IncumbencyHasPosition => new DynamicObjectCollection<Position>(this, Property(UKParliamentOntology.IncumbencyHasPosition));

        public ICollection<Person> IncumbencyHasPerson => new DynamicObjectCollection<Person>(this, Property(UKParliamentOntology.IncumbencyHasPerson));

        public ICollection<DateTimeOffset> IncumbencyStartDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.IncumbencyStartDate));
    }
}

namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class WithdrawnThing : LaidThing
    {
        public WithdrawnThing(INode node) : base(node) { }

        public Withdrawal WithdrawnThingHasWithdrawal => ((IEnumerable<Withdrawal>)new DynamicObjectCollection<Withdrawal>(this, Property(UKParliamentOntology.WithdrawnThingHasWithdrawal))).SingleOrDefault();
    }
}

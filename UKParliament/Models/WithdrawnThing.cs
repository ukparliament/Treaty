namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class WithdrawnThing : LaidThing
    {
        public WithdrawnThing(INode node) : base(node) { }

        public ICollection<Withdrawal> WithdrawnThingHasWithdrawal => new DynamicObjectCollection<Withdrawal>(this, Property(UKParliamentOntology.WithdrawnThingHasWithdrawal));
    }
}

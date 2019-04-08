namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Withdrawal : BusinessItem
    {
        public Withdrawal(INode node) : base(node) { }

        public ICollection<WithdrawnThing> WithdrawalHasWithdrawnThing => new DynamicObjectCollection<WithdrawnThing>(this, Property(UKParliamentOntology.WithdrawalHasWithdrawnThing));

        public DateTimeOffset WithdrawalDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.WithdrawalDate))).SingleOrDefault();
    }
}

namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisDepartmentGroup : Group
    {
        public MnisDepartmentGroup(INode node) : base(node) { }

        public ICollection<string> MnisDepartmentId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.MnisDepartmentId));
    }
}

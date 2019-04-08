namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class MnisDepartmentGroup : Group
    {
        public MnisDepartmentGroup(INode node) : base(node) { }

        public string MnisDepartmentId => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.MnisDepartmentId))).SingleOrDefault();
    }
}

// MIT License
//
// Copyright (c) 2019 UK Parliament
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

namespace OntologyHelper
{
    /// <summary>
    /// Static Helper class for the UK Parliament Ontology
    /// </summary>
    public static class UKParliament
    {
        /// <summary>
        /// Base URI for things in the UK Parliament Knowledge Graph
        /// </summary>
        public const string Base = "https://id.parliament.uk/";

        /// <summary>
        /// UK Parliament namespace URI
        /// </summary>
        public const string Namespace = Base + "schema/";

        /// <summary>
        /// Constant URIs for classes in the UK Parliament Ontology
        /// </summary>
        public const string
            LaidThing = Namespace + "LaidThing",
            Laying = Namespace + "Laying",
            LayingBody = Namespace + "LayingBody",
            Treaty = Namespace + "Treaty",
            WorkPackage = Namespace + "WorkPackage",
            WorkPackagedThing = Namespace + "WorkPackagedThing";

        /// <summary>
        /// Constant URIs for properties in the UK Parliament Ontology
        /// </summary>
        public const string
            GroupName = Namespace + "groupName",
            LayingDate = Namespace + "layingDate",
            LaidThingHasLaying = Namespace + "laidThingHasLaying",
            LaidThingName = Namespace + "laidThingName",
            LayingHasLayingBody = Namespace + "layingHasLayingBody",
            PersonFamilyName = Namespace + "personFamilyName",
            ProcedureName = Namespace + "procedureName",
            WorkPackageHasProcedure = Namespace + "workPackageHasProcedure",
            WorkPackagedThingHasWorkPackage = Namespace + "workPackagedThingHasWorkPackage";
    }
}
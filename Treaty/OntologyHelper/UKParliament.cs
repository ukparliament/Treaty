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
        /// UK Parliament Ontology base URL and schema namespace URL
        /// </summary>
        public const string
            Base = "https://id.parliament.uk/",
            Namespace = "https://id.parliament.uk/schema/",
            SKOSBase = "http://data.parliament.uk/terms/";

        /// <summary>
        /// Constant URIs for classes in the UK Parliament Ontology
        /// </summary>
        public const string
            Person = Namespace + "Person",
            Treaty = Namespace + "Treaty";

        /// <summary>
        /// Constant URIs for properties in the UK Parliament Ontology
        /// </summary>
        public const string
            LaidThingName = Namespace + "laidThingName",
            PersonFamilyName = Namespace + "personFamilyName";
    }
}
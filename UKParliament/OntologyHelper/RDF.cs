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
    /// Static Helper class for the RDFS Ontology
    /// </summary>
    public static class RDF
    {
        /// <summary>
        /// RDFS namespace URI
        /// </summary>
        public const string Namespace = "http://www.w3.org/1999/02/22-rdf-syntax-ns#";

        /// <summary>
        /// Constant URIs for classes in the RDFS Ontology
        /// </summary>

        /// <summary>
        /// Constant URIs for properties in the RDFS Ontology
        /// </summary>
        public const string
            Type = Namespace + "type";
    }
}
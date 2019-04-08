// MIT License
//
// Copyright (c) 2019 UK Parliament
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

namespace UKParliament
{
    using OntologyHelper;
    using System.Collections.Generic;

    /// <summary>
    /// Static Helper class for instance data in the UK Parliament Graph
    /// </summary>
    public static class GraphHelper
    {
        /// <summary>
        /// Constant URIs for the Houses of Parliament
        /// </summary>
        public const string
            HouseOfCommons = UKParliamentOntology.Base + "1AFu55Hs",
            HouseOfLords = UKParliamentOntology.Base + "WkUWUBMx";

        /// <summary>
        /// Constant URIs for instances in the UK Parliament Graph
        /// </summary>
        public const string
            DraftAffirmativeProcedure = UKParliamentOntology.Base + "H5YJQsK2",
            DraftNegativeProcedure = UKParliamentOntology.Base + "gTgidljI",
            MadeAffirmativeProcedure = UKParliamentOntology.Base + "iWugpxMn",
            MadeNegativeProcedure = UKParliamentOntology.Base + "5S6p4YsP",
            ProposedNegativeStatutoryInstrumentProcedure = UKParliamentOntology.Base + "iCdMN1MW",
            TreatyProcedure = UKParliamentOntology.Base + "D00dsjR2";

        /// <summary>
        /// Lists of URI instances in the UK Parliament Graph
        /// </summary>
        public static List<string>
            TreatyProcedureEndStep = new List<string>() { "ypryR1wZ", "qkrlv9rh" };

        /// <summary>
        /// Constant mapping of resource URIs to controllers
        /// </summary>
        public static readonly Dictionary<string, string>
            ControllerMap = new Dictionary<string, string> {
                { DraftAffirmativeProcedure, "Treaty" },
                { DraftNegativeProcedure, "Treaty" },
                { MadeAffirmativeProcedure, "Treaty" },
                { MadeNegativeProcedure, "Treaty" },
                { ProposedNegativeStatutoryInstrumentProcedure, "Treaty" },
                { TreatyProcedure, "Treaty" }
            };
    }
}
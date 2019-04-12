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
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Static Helper class for instance data in the UK Parliament Graph
    /// </summary>
    public static class GraphHelper
    {
        /// <summary>
        /// Constant URIs for the Houses of Parliament
        /// </summary>
        public static readonly Uri
            HouseOfCommons = new Uri(UKParliamentOntology.BaseUri, "1AFu55Hs"),
            HouseOfLords = new Uri(UKParliamentOntology.BaseUri, "WkUWUBMx");

        /// <summary>
        /// Constant URIs for instances in the UK Parliament Graph
        /// </summary>
        public static readonly Uri
            DraftAffirmativeProcedure = new Uri(UKParliamentOntology.BaseUri, "H5YJQsK2"),
            DraftNegativeProcedure = new Uri(UKParliamentOntology.BaseUri, "gTgidljI"),
            MadeAffirmativeProcedure = new Uri(UKParliamentOntology.BaseUri, "iWugpxMn"),
            MadeNegativeProcedure = new Uri(UKParliamentOntology.BaseUri, "5S6p4YsP"),
            ProposedNegativeStatutoryInstrumentProcedure = new Uri(UKParliamentOntology.BaseUri, "iCdMN1MW"),
            TreatyProcedure = new Uri(UKParliamentOntology.BaseUri, "D00dsjR2");

        /// <summary>
        /// Lists of string ID in the UK Parliament Graph
        /// </summary>
        public static readonly string
            ProcedureStepTreatyCreated = "H6GOB6yX",
            ProcedureStepLaidBeforeTheHouseOfCommons = "cspzmb6w",
            ProcedureStepLaidBeforeTheHouseOfLords = "puVMaN7t",
            ProcedureStepAllocatedToTheEUJusticeSubCommittee = "ljni7FvY",
            ProcedureStepObjectionPeriodABegins = "NnizWAGU";

        /// <summary>
        /// Lists of URI instances in the UK Parliament Graph
        /// </summary>
        public static List<string>
            TreatyProcedureEndStep = new List<string>() { "ypryR1wZ", "qkrlv9rh" },
            TreatyProcedureScheduledDebateStep = new List<string>() { "WdiOAL9I", "bEzmXakv", "M28y2NsI", "uwTqgHE3", "bNQUaV4J" },
            TreatyProcedureMotionToNotRatifyStep = new List<string>() { "3wIKRs06", "443aMXaZ" },
            TreatyProcedureStepOrder = new List<string>() { ProcedureStepTreatyCreated, ProcedureStepLaidBeforeTheHouseOfCommons, ProcedureStepLaidBeforeTheHouseOfLords, ProcedureStepAllocatedToTheEUJusticeSubCommittee };

        /// <summary>
        /// Constant mapping of resource URIs to controllers
        /// </summary>
        public static readonly Dictionary<string, string>
            ControllerMap = new Dictionary<string, string> {
                { "D00dsjR2", "Treaty" }
            };
    }
}
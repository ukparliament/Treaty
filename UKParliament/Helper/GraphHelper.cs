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
    using System;
    using System.Collections.Generic;
    using OntologyHelper;

    /// <summary>
    /// Static Helper class for instance data in the UK Parliament Graph
    /// </summary>
    public static class GraphHelper
    {
        /// <summary>
        /// Constant URIs for the Houses of Parliament
        /// </summary>
        public static readonly Uri HouseOfCommons = new Uri(UKParliamentOntology.BaseUri, "1AFu55Hs");
        public static readonly Uri HouseOfLords = new Uri(UKParliamentOntology.BaseUri, "WkUWUBMx");

        /// <summary>
        /// Constant URIs for instances in the UK Parliament Graph
        /// </summary>
        public static readonly Uri DraftAffirmativeProcedure = new Uri(UKParliamentOntology.BaseUri, "H5YJQsK2");
        public static readonly Uri DraftNegativeProcedure = new Uri(UKParliamentOntology.BaseUri, "gTgidljI");
        public static readonly Uri MadeAffirmativeProcedure = new Uri(UKParliamentOntology.BaseUri, "iWugpxMn");
        public static readonly Uri MadeNegativeProcedure = new Uri(UKParliamentOntology.BaseUri, "5S6p4YsP");
        public static readonly Uri ProposedNegativeStatutoryInstrumentProcedure = new Uri(UKParliamentOntology.BaseUri, "iCdMN1MW");
        public static readonly Uri TreatyProcedure = new Uri(UKParliamentOntology.BaseUri, "D00dsjR2");

        /// <summary>
        /// Lists of string ID in the UK Parliament Graph
        /// </summary>
        public static readonly string ProcedureStepTreatyCreated = "H6GOB6yX";
        public static readonly string ProcedureStepLaidBeforeTheHouseOfCommons = "cspzmb6w";
        public static readonly string ProcedureStepLaidBeforeTheHouseOfLords = "puVMaN7t";
        public static readonly string ProcedureStepAllocatedToTheEUJusticeSubCommittee = "ljni7FvY";
        public static readonly string ProcedureStepAllocatedToTheEUInternalMarketSubCommittee = "dsfJmPVy";
        public static readonly string ProcedureStepObjectionPeriodABegins = "NnizWAGU";
        public static readonly string ProcedureStepObjectionPeriodAEnds = "y3MuaSK6";

        /// <summary>
        /// Lists of URI instances in the UK Parliament Graph
        /// </summary>
        public static List<string> TreatyProcedureEndStep = new List<string>() { "ypryR1wZ", "qkrlv9rh" };
        public static List<string> TreatyProcedureScheduledDebateStep = new List<string>() { "WdiOAL9I", "bEzmXakv", "M28y2NsI", "uwTqgHE3", "bNQUaV4J" };
        public static List<string> TreatyProcedureMotionToNotRatifyStep = new List<string>() { "3wIKRs06", "443aMXaZ" };
        public static List<string> TreatyProcedureStepOrder = new List<string>() { ProcedureStepTreatyCreated, ProcedureStepLaidBeforeTheHouseOfCommons, ProcedureStepLaidBeforeTheHouseOfLords, ProcedureStepAllocatedToTheEUJusticeSubCommittee, ProcedureStepAllocatedToTheEUInternalMarketSubCommittee };

        /// <summary>
        /// Constant mapping of resource URIs to controllers
        /// </summary>
        public static Dictionary<string, string> ControllerMap = new Dictionary<string, string> { { "D00dsjR2", "Treaty" }, { "H5YJQsK2", "Procedure" } };
    }
}
﻿namespace UKParliament
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;

    public class ProcedureQueryParameters : QueryParameters
    {
        [FromQuery(Name = "current")]
        public bool Current { get; set; }

        [FromQuery(Name = "leadGovernmentOrganisation")]
        public IEnumerable<string> LeadGovernmentOrganisation { get; set; }

        [FromQuery(Name = "seriesMembershipType")]
        public IEnumerable<string> SeriesMembershipType { get; set; }

        [FromQuery(Name = "procedureStep")]
        public IEnumerable<string> ProcedureStep { get; set; }
    }
}

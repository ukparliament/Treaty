namespace UKParliament
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Mvc;

    public class ProcedureQueryParameters : QueryParameters
    {
        [FromQuery(Name = "current")]
        public bool Current { get; set; }

        [FromQuery(Name = "leadGovernmentOrganisation")]
        public IEnumerable<string> LeadGovernmentOrganisation { get; set; }

        [FromQuery(Name = "procedureStep")]
        public IEnumerable<string> ProcedureStep { get; set; }

        [FromQuery(Name = "seriesMembershipType")]
        [Range(0, 2)]
        public SeriesMembershipTypeEnum? SeriesMembershipType { get; set; }

        public enum SeriesMembershipTypeEnum
        {
            CountrySeriesMembership, EuropeanUnionSeriesMembership, MiscellaneousSeriesMembership
        }
    }
}

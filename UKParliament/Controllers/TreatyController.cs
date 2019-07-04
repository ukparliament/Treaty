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
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
    using OntologyHelper;
    using Services;
    using UKParliament.Model;

    [Route("/view/treaty")]
    public class TreatyController : BaseController
    {
        public TreatyController(SparqlService sparqlService)
            : base(sparqlService)
        {
        }

        [HttpGet]
        public ActionResult Index(ProcedureQueryParameters parameters)
        {
            // TODO: rewrite Treaty query use model binding
            // change the way parameters are bound to UI
            // Note the materialisation of type is computationally intensive (it takes 2s to run query with type, 0.4 without).
            if (!this.ModelState.IsValid)
            {
                return new BadRequestResult();
            }

            var graph = this.SparqlService.Execute("UKParliament.SPARQL.treaty.sparql");

            var filters = new List<string>() { "current", "leadGovernmentOrganisation", "seriesMembershipType", "procedureStep" };

            this.ViewBag.Filter = false;

            if (filters.Any(x => this.Request.Query.ContainsKey(x)))
            {
                this.ViewBag.Filter = true;
                this.ViewBag.Current = this.Request.Query["current"];
                this.ViewBag.LeadGovernmentOrganisation = this.Request.Query["leadGovernmentOrganisation"];
                this.ViewBag.SeriesMembershipType = this.Request.Query["seriesMembershipType"];
                this.ViewBag.ProcedureStep = this.Request.Query["procedureStep"];
            }

            return this.View(new UKParliamentDynamicGraph(graph));
        }

        [HttpGet("{id}")]
        public ActionResult Item(string id)
        {
            var uris = new[] { new Uri(UKParliamentOntology.BaseUri, id) };
            var sparqlParameters = new Dictionary<string, IEnumerable<object>> { { "id", uris } };
            var graph = this.SparqlService.Execute("UKParliament.SPARQL.treaty_by_id.sparql", sparqlParameters);
            return this.View(new UKParliamentDynamicGraph(graph));
        }
    }
}

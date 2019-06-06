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
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Services;
    using UKParliament.Model;

    public class BaseController : Controller
    {
        protected BaseController(SparqlService sparqlService)
        {
            this.SparqlService = sparqlService;
        }

        protected SparqlService SparqlService { get; set; }

        protected ViewResult GetView(string query)
        {
            return this.View(this.GetGraph(query));
        }

        protected ViewResult GetView(string query, Dictionary<string, IEnumerable<object>> sparqlParameters)
        {
            return this.View(this.GetGraph(query, sparqlParameters));
        }

        protected ViewResult GetView(string query, List<string> filters)
        {
            this.SetViewFilters(filters);

            return this.GetView(query);
        }

        protected ViewResult GetView(string query, List<string> filters, Dictionary<string, IEnumerable<object>> sparqlParameters)
        {
            this.SetViewFilters(filters);

            return this.GetView(query, sparqlParameters);
        }

        private UKParliamentDynamicGraph GetGraph(string query) => new UKParliamentDynamicGraph(this.SparqlService.Execute($"UKParliament.SPARQL.{query}"));

        private UKParliamentDynamicGraph GetGraph(string query, Dictionary<string, IEnumerable<object>> sparqlParameters) => new UKParliamentDynamicGraph(this.SparqlService.Execute($"UKParliament.SPARQL.{query}", sparqlParameters));

        private void SetViewFilters(List<string> filters)
        {
            this.ViewBag.Filter = filters.ToDictionary(filter => filter, filter => this.Request.Query.ContainsKey(filter) ? this.Request.Query[filter].ToList() : new List<string>() { });
        }
    }
}

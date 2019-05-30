// MIT License
//
// Copyright (c) 2019 UK Parliament
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

namespace Services
{
    using Microsoft.Extensions.Configuration;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using VDS.RDF;

    public class QueryService
    {
        private Uri baseUrl;

        public QueryService(IConfiguration config)
        {
            this.baseUrl = new Uri(config.GetSection("QueryService")["BaseUrl"]);
        }

        internal IGraph Execute(string name, IDictionary<string, IEnumerable<string>> parameters = null)
        {
            var g = new Graph();

            var builder = new UriBuilder(baseUrl);
            builder.Path = name;
            builder.Query = parameters is null ? string.Empty : string.Join('&', parameters.SelectMany(parameter => parameter.Value.Select(value => $"{parameter.Key}={value.ToString()}")));

            using (var client = new HttpClient())
            {
                var rdf = client.GetStringAsync(builder.Uri).Result;
                g.LoadFromString(rdf);
            }

            return g;
        }
    }
}

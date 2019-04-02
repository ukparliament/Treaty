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
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using VDS.RDF;
    using VDS.RDF.Query;
    using VDS.RDF.Storage;
    using VDS.RDF.Writing.Formatting;

    public class SparqlService : IDisposable
    {
        private readonly SparqlConnector connector;
        private readonly SecureSparqlRemoteEndpoint endpoint;

        public SparqlService(IConfiguration config)
        {
            this.endpoint = new SecureSparqlRemoteEndpoint(new Uri(new Uri(config.GetSection("SparqlService")["BaseUrl"]), config.GetSection("SparqlService")["Repository"]), config);
            this.connector = new SparqlConnector(this.endpoint);
        }

        internal IGraph Execute(string name)
        {
            return this.Execute(GetResource(name)) as IGraph;
        }

        internal IGraph Execute(string name, IDictionary<string, IEnumerable<object>> parameters)
        {
            var sparql = GetResource(name);

            return this.Execute(sparql, parameters);
        }

        internal IGraph Execute(SparqlParameterizedString sparql, IDictionary<string, IEnumerable<object>> parameters)
        {
            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    if (parameter.Value is IEnumerable<string> stringValues)
                    {
                        SetLiterals(sparql, parameter.Key, stringValues);
                    }
                    else if (parameter.Value is IEnumerable<Uri> uriValues)
                    {
                        SetUris(sparql, parameter.Key, uriValues);
                    }
                    else if (parameter.Value is null)
                    {
                        SetUndef(sparql, parameter.Key);
                    }
                }
            }

            return this.Execute(sparql);
        }

        internal IGraph Execute(SparqlParameterizedString sparql)
        {
            try
            {
                return connector.Query(sparql.ToString()) as IGraph;
            }
            // Handle empty graphs since GraphDB returns empty response with the wrong headers.
            catch (Exception e)
            {
                var x = new Graph();
                return x;
            }
        }

        private static SparqlParameterizedString GetResource(string name)
        {
            var sparqlParameterizedString = null as SparqlParameterizedString;

            using (var sparqlResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name))
            {
                using (var reader = new StreamReader(sparqlResourceStream))
                {
                    sparqlParameterizedString = new SparqlParameterizedString(reader.ReadToEnd());
                }
            }

            return sparqlParameterizedString;
        }

        private static void SetLiterals(SparqlParameterizedString sparql, string parameter, IEnumerable<string> values)
        {
            // Need a formatter and a factory to create literal nodes
            var formatter = new SparqlFormatter();
            var factory = new NodeFactory();
            sparql.CommandText = sparql.CommandText.Replace($"@{parameter}", string.Join(" ", values.Select(value => formatter.Format(factory.CreateLiteralNode(value)))));
        }

        private static void SetUris(SparqlParameterizedString sparql, string parameter, IEnumerable<Uri> values)
        {
            // Need a formatter and a factory to enclose Uris in <>
            var formatter = new SparqlFormatter();
            var factory = new NodeFactory();
            sparql.CommandText = sparql.CommandText.Replace($"@{parameter}", string.Join(" ", values.Select(uri => formatter.Format(factory.CreateUriNode(uri)))));
        }

        private static void SetUndef(SparqlParameterizedString sparql, string parameter)
        {
            sparql.CommandText = sparql.CommandText.Replace($"@{parameter}", "undef");
        }

        void IDisposable.Dispose()
        {
            this.connector.Dispose();
        }
    }
}

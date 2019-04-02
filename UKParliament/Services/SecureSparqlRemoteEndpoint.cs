// MIT License
//
// Copyright (c) 2019 UK Parliament
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

namespace VDS.RDF.Query
{
    using Microsoft.Extensions.Configuration;
    using System;
    using System.Net;

    public class SecureSparqlRemoteEndpoint : SparqlRemoteEndpoint
    {
        private readonly string authorisationHeader;
        private readonly string key;

        public SecureSparqlRemoteEndpoint(Uri endpointUri, IConfiguration config) : base(endpointUri)
        {
            this.authorisationHeader = config.GetSection("SparqlService")["AuthorisationHeader"]; ;
            this.key = config.GetSection("SparqlService")["Key"];
        }

        protected override void ApplyCustomRequestOptions(HttpWebRequest httpRequest)
        {
            if (!string.IsNullOrEmpty(this.authorisationHeader) && !string.IsNullOrEmpty(this.key))
            {
                httpRequest.Headers[this.authorisationHeader] = this.key;
            }
        }
    }
}

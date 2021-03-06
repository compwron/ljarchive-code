/* 
XML-RPC.NET library
Copyright (c) 2001-2003, Charles Cook <ccook@cookcomputing.com>

Permission is hereby granted, free of charge, to any person 
obtaining a copy of this software and associated documentation 
files (the "Software"), to deal in the Software without restriction, 
including without limitation the rights to use, copy, modify, merge, 
publish, distribute, sublicense, and/or sell copies of the Software, 
and to permit persons to whom the Software is furnished to do so, 
subject to the following conditions:

The above copyright notice and this permission notice shall be 
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES 
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
DEALINGS IN THE SOFTWARE.
*/

using System;
using System.IO;

namespace CookComputing.XmlRpc
{
  public class XmlRpcHttpResponse : CookComputing.XmlRpc.IHttpResponse
  {
    public XmlRpcHttpResponse(System.Web.HttpResponse response)
    {
      m_resp = response;
    }

    string IHttpResponse.ContentType 
    { 
      get { return m_resp.ContentType; } 
      set { m_resp.ContentType = value; } 
    }
    TextWriter IHttpResponse.Output { get { return m_resp.Output; } }

    Stream IHttpResponse.OutputStream { get { return m_resp.OutputStream; } }

    int IHttpResponse.StatusCode 
    { 
      get { return m_resp.StatusCode; } 
      set { m_resp.StatusCode = value; } 
    }

    string IHttpResponse.StatusDescription 
    { 
      get { return m_resp.StatusDescription; } 
      set { m_resp.StatusDescription = value; } 
    }

    private System.Web.HttpResponse m_resp;
  }
}

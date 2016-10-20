/*
 * Copyright (c) 2014 Optimal Payments
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
 * associated documentation files (the "Software"), to deal in the Software without restriction,
 * including without limitation the rights to use, copy, modify, merge, publish, distribute,
 * sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies or
 * substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
 * NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
 * DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Paysafe.Common
{
    public static class JsonHelper
    {
        public static Dictionary<string, object> Deserialize(string json)
        {
            return ToObject(JToken.Parse(json)) as Dictionary<string, object>;
        }

        private static dynamic ToObject(JToken token)
        {
            if (JTokenType.Object == token.Type)
            {
                Dictionary<string, object> dict = new Dictionary<string, object>();
                foreach (JProperty prop in token)
                {
                    dict.Add(prop.Name, ToObject(prop.Value));
                }
                return dict;
            }
            else if (JTokenType.Array == token.Type)
            {
                List<object> list = new List<object>();
                foreach (JToken value in token)
                {
                    list.Add(ToObject(value));
                }
                return list;
            }
            var tokenValue = ((JValue)token).Value;
            if (tokenValue != null
                && (tokenValue is int || tokenValue is bool || tokenValue is long))
            {
                return tokenValue.ToString();
            }
            else 
            {
                return tokenValue;
            }
        }
    }
}
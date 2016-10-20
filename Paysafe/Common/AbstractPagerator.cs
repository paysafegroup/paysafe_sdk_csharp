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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Modified by Manjiri.Bankar on 02.08.2016. This is Pagerator class.
namespace Paysafe.Common
{
    public abstract class AbstractPagerator<T> : IEnumerable
    {

        /// <summary>
        /// The result set so far retrieved
        /// </summary>
        protected List<T> results = new List<T>();

        /// <summary>
        /// The key in the returned array to be added to the resutl set
        /// </summary>
        protected string arrayKey = null;

        /// <summary>
        /// The type to instantiate
        /// </summary>
        protected Type classType;

        /// <summary>
        /// The url to the next page, if we haven't yet retrieved all results
        /// </summary>
        protected String nextPage = null;

        /// <summary>
        /// The url to the self page
        /// </summary>
        protected String selfPage = null;

        /// <summary>
        /// The url to the previous page
        /// </summary>
        protected String previousPage = null;

        /// <summary>
        /// The client
        /// </summary>
        protected PaysafeApiClient client = null;


        public AbstractPagerator(PaysafeApiClient apiClient, Type pagingClassType)
        {
            this.arrayKey = pagingClassType.GetMethod("getPageableArrayKey").Invoke(null, null) as string;

            this.client = apiClient;
            this.classType = pagingClassType;
        }

        /// <summary>
        /// Get the current set of elements
        /// </summary>
        /// <returns>List<T></returns>
        public List<T> getResults()
        {
            return this.results;
        }

        /// <summary>
        /// Used by PageratorEnumerator to get result
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        protected T get(int index)
        {
            return this.results.ElementAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Implemented to extended IEnumerable
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            return new PageratorEnumerator(this.classType, this);
        }


        protected abstract void parseResponse(Dictionary<string, object> data);

        public class PageratorEnumerator : IEnumerator
        {
            AbstractPagerator<T> parent = null;

            private int position = -1;

            public PageratorEnumerator(Type classType, AbstractPagerator<T> parent)
            {
                this.parent = parent;
            }

            public bool MoveNext()
            {
                this.position++;
                if (this.parent.results.Count >= this.position && !String.IsNullOrWhiteSpace(this.parent.nextPage))
                {
                    Request request = new Request(url: this.parent.nextPage);
                    this.parent.parseResponse(this.parent.client.processRequest(request));
                }
                return this.position < this.parent.results.Count;
            }

            public void Reset()
            {
                position = -1;
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public T Current
            {
                get
                {
                    return this.parent.get(position);
                }
            }
        }
    }
}

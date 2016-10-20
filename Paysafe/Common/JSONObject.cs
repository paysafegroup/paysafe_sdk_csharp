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
using System.ComponentModel;

using Newtonsoft.Json;

namespace Paysafe.Common
{
    /// <summary>
    /// This is the base class for all objects within the sdk.
    /// It is used to allow generic assignment of fields and properties.
    /// </summary>
    public abstract class JSONObject
    {
        /// <summary>
        /// fieldTypes must be passed into the constructor in order to allow generic validation
        /// </summary>
        protected Dictionary<string, object> fieldTypes;

        /// <summary>
        /// this dictionary will store all set properties within the final object
        /// </summary>
        private Dictionary<string, object> properties = new Dictionary<string,object>();

        /// <summary>
        /// optionalFields will be used by the api client to determine which of the set fields
        /// should be sent to the api
        /// </summary>
        private List<string> optionalFields;

        /// <summary>
        /// requiredFields will be used by the api client to determine which of the fields must
        /// be set before sending a request to the api
        /// </summary>
        private List<string> requiredFields;

        protected static Type STRING_TYPE = typeof(string);
        protected static Type INT_TYPE = typeof(int);
        protected static Type BOOL_TYPE = typeof(bool);
        protected static Type URL_TYPE = typeof(Url);
        protected static Type EMAIL_TYPE = typeof(Email);
        protected static Type FLOAT_TYPE = typeof(float);

        /// <summary>
        /// The object will be json serialized using only the optional and required properties
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this.jsonSerialize());
        }

        /// <summary>
        /// This method will serialize only the required or optional properties within this
        /// and any nested JSONObjects. or if no required/optional properties are set, then
        /// all properties will be returned
        /// </summary>
        /// <returns></returns>
        private Dictionary<string, object> jsonSerialize()
        {
            this.checkRequiredFields();
            Dictionary<string, object> toJSON;
            if ((null == this.optionalFields || 0 == this.optionalFields.Count) && 
                (null == this.requiredFields || 0 == this.requiredFields.Count))
            {
                toJSON = this.properties;
            }
            else
            {
                toJSON = new Dictionary<string, object>();
                if (requiredFields != null)
                {
                    foreach (string key in requiredFields)
                    {
                        if (properties.ContainsKey(key))
                        {
                            toJSON.Add(key, properties[key]);
                        }
                    }
                }
                if (optionalFields != null)
                {
                    foreach (string key in optionalFields)
                    {
                        if (properties.ContainsKey(key))
                        {
                            toJSON.Add(key, properties[key]);
                        }
                    }
                }
            }
            return this.filterJSON(toJSON) as Dictionary<string, object>;
        }

        /// <summary>
        /// Throws an exception if any required fields have not been set
        /// </summary>
        public void checkRequiredFields()
        {
            if (requiredFields != null)
            {
                List<string> missingFields = new List<string>();
                foreach (string key in requiredFields)
                {
                    if (!properties.ContainsKey(key))
                    {
                        missingFields.Add(key);
                    }
                }
                if (missingFields.Count > 0)
                {
                    throw new PaysafeException("Missing required properties: " + string.Join(", ", missingFields));
                }
            }
        }

        /// <summary>
        /// This method is used by jsonSerialize, and will filter all non required/optional
        /// from any nested objects
        /// </summary>
        /// <param name="result">Dictioanry<string,object></param>
        /// <returns>Dictionary<string,object></returns>
        private dynamic filterJSON(dynamic result)
        {
            if (result is Dictionary<string, object>)
            {
                Dictionary<string, object> @return = new Dictionary<string, object>();
                foreach (string key in ((Dictionary<string, object>)result).Keys)
                {
                    @return[key] = this.filterJSON(result[key]);
                }
                return @return;
            }
            else if (((object)result).GetType().IsGenericType
                && ((object)result).GetType().GetGenericTypeDefinition() == typeof(List<>))
            {
                return this.filterList(result);
            }
            else if (result is JSONObject)
            {
                return ((JSONObject)result).jsonSerialize();
            }
            return result;
        }

        private List<object> filterList<T>(List<T> list)
        {
            List<object> @return = new List<object>();
            foreach (T item in list)
            {
                @return.Add(this.filterJSON(item));
            }
            return @return; ;
        }

        /// <summary>
        /// Set the optional fields to be consumed by the api client
        /// </summary>
        /// <param name="fields">List<String></param>
        public void setOptionalFields(List<string> fields)
        {
            List<string> invalidKeys = new List<string>();
            foreach (string key in fields)
            {
                if (!this.fieldTypes.ContainsKey(key))
                {
                    invalidKeys.Add(key);
                }
            }
            if (invalidKeys.Count > 0)
            {
                throw new PaysafeException("Invalid optional fields. Unknown fields: " + string.Join(", ", invalidKeys));
            }
            this.optionalFields = fields;
        }

        /// <summary>
        /// Set the required fields to be consumed by the api client
        /// </summary>
        /// <param name="fields"></param>
        public void setRequiredFields(List<string> fields)
        {
            List<string> invalidKeys = new List<string>();
            foreach (string key in fields)
            {
                if (!this.fieldTypes.ContainsKey(key))
                {
                    invalidKeys.Add(key);
                }
            }
            if (invalidKeys.Count > 0)
            {
                throw new PaysafeException("Invalid required fields. Unknown fields: " + string.Join(", ", invalidKeys));
            }
            this.requiredFields = fields;
        }

        /// <summary>
        /// Initialize the Object, setting the internetal properties from parameters based on the types
        /// </summary>
        /// <param name="types">Dictioanry<string,string></param>
        /// <param name="parameters">Dictionary<string,object></param>
        public JSONObject(Dictionary<string, object> types, Dictionary<string, object> parameters = null)
        {
            this.fieldTypes = types;
            if (!Object.ReferenceEquals(parameters, null))
            {
                foreach (string key in parameters.Keys)
                {
                    var tmp = getFieldInfo(key);
                    if (!Object.ReferenceEquals(tmp, null))
                    {
                        KeyValuePair<string, object> info = (KeyValuePair<string, object>)tmp;
                        this.setProperty(info.Key, parameters[key]);
                    }
                }
            }
        }

        /// <summary>
        /// Set the property name with value cast based on the fieldTypes dictionary
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="value">dynamic</param>
        protected void setProperty(string name, dynamic value) {
            var tmp = getFieldInfo(name);
            if (Object.ReferenceEquals(tmp, null))
            {
                throw new PaysafeException("Invalid property " + name + " for class " + this.GetType().ToString());
            }
            KeyValuePair<string, object> info = (KeyValuePair<string, object>)tmp;

            if (Object.ReferenceEquals(value, null))
            {
                this.properties.Remove(info.Key);
            }
            else
            {
                this.properties[info.Key] = this.cast(info.Key, value, info.Value);
            }
            
        }

        /// <summary>
        /// Get the pproperty name fromt he properties dictionary
        /// </summary>
        /// <param name="name">string</param>
        /// <returns></returns>
        protected dynamic getProperty(string name)
        {
            var tmp = getFieldInfo(name);
            if (Object.ReferenceEquals(tmp, null))
            {
                throw new PaysafeException("Invalid property " + name + " for class " + this.GetType().ToString());
            }
            KeyValuePair<string, object> info = (KeyValuePair<string, object>)tmp;
            if (this.properties.ContainsKey(info.Key))
            {
                return this.properties[info.Key];
            }
            return null;
        }

        /// <summary>
        /// Checks if a specfic property has been set
        /// </summary>
        /// <param name="name">string</param>
        /// <returns></returns>
        public bool hasProperty(string name)
        {
            var tmp = getFieldInfo(name);
            if (null == tmp)
            {
                return false;
            }
            KeyValuePair<string, object> info = (KeyValuePair<string, object>)tmp;
            return this.properties.ContainsKey(info.Key);
        }

        /// <summary>
        /// Get the validation rules for a given field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>KeyValuePair<string, string> or null</returns>
        private dynamic getFieldInfo(string name)
        {
            if (null == this.fieldTypes)
            {
                throw new PaysafeException("field types must be initialized");
            }
            if (this.fieldTypes.ContainsKey(name))
            {
                return new KeyValuePair<string, object>(name, this.fieldTypes[name]);
            }
            name = name.ToLower();
            foreach (string key in this.fieldTypes.Keys)
            {
                if (key.ToLower() == name)
                {
                    return new KeyValuePair<string, object>(key, this.fieldTypes[key]);
                }
            }
            return null;
        }

        /// <summary>
        /// Casts property value to type validation
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="value">dynamic</param>
        /// <param name="validation">string</param>
        /// <returns></returns>
        public dynamic cast(string name, dynamic value, dynamic validation)
        {
            string valueString = null;
            if (value is string)
            {
                valueString = (string)value;
            }
            if (validation is List<string>)
            {
                List<string> validationList = (List<string>)validation;
                if (null == valueString  || !validationList.Contains(valueString))
                {
                    throw new PaysafeException("Invalid value for property " + name + " for class " + this.GetType().ToString() + ". Expected one of: " + string.Join(", ", validationList) + ".");
                }
                return value;
            }
            else if (validation is Type)
            {
                Type validationType = validation as Type;
                if (validationType.Equals(STRING_TYPE))
                {
                    if (null == valueString)
                    {
                        throw new PaysafeException("Invalid value for property " + name + " for class " + this.GetType().ToString() + ". String expected.");
                    }
                    return value;
                }
                else if (validationType.Equals(EMAIL_TYPE))
                {
                    if (null == valueString|| valueString.IndexOf("@", StringComparison.CurrentCulture) <= 0)
                    {
                        throw new PaysafeException("Invalid value for property " + name + " for class " + this.GetType().ToString() + ". Email expected.");
                    }
                    return value;
                }
                else if (validationType.Equals(URL_TYPE))
                {
                    System.Uri uriResult;
                    if (null == valueString || (Uri.TryCreate(valueString, UriKind.Absolute, out uriResult) && null == uriResult))
                    {
                        throw new PaysafeException("Invalid value for property " + name + " for class " + this.GetType().ToString() + ". URL expected.");
                    }
                    return value;
                }
                else if (validationType.Equals(INT_TYPE))
                {
                    try
                    {
                        return Convert.ToInt32(value);
                    }
                    catch (Exception)
                    {
                        //format exception or overflow exception
                        throw new PaysafeException("Invalid value for property " + name + " for class " + this.GetType().ToString() + ". Integer expected.");
                    }
                }
                else if (validationType.Equals(FLOAT_TYPE))
                {
                    decimal decVal;
                    if (value is decimal)
                    {
                        decVal = ((decimal)value);
                    }
                    else if (valueString != null || !decimal.TryParse(((string)value), out decVal))
                    {
                        throw new PaysafeException("Invalid value for property " + name + " for class " + this.GetType().ToString() + ". Decimal expected.");
                    }
                    return decVal;
                }
                else if (validationType.Equals(BOOL_TYPE))
                {
                    bool boolVal;
                    if (value is bool)
                    {
                        boolVal = ((bool)value);
                    }
                    else if (null == valueString || !bool.TryParse(valueString, out boolVal))
                    {
                        throw new PaysafeException("Invalid value for property " + name + " for class " + this.GetType().ToString() + ". Boolean expected.");
                    }
                    return boolVal;
                }
                else if (validationType.IsGenericType && 
                    validationType.GetGenericTypeDefinition() == typeof(List<>))
                {
                    Type subType = validationType.GetGenericArguments()[0];
                    if (!(value is System.Collections.IList))
                    {
                        throw new PaysafeException("Invalid value for property " + name + " for class " + this.GetType().ToString() + ". List expected.");
                    }
                    Type T = null;
                    for (int i = 0; i < ((System.Collections.IList)value).Count; i++)
                    {
                        value[i] = this.cast(name, value[i], subType);
                        T = ((object)((System.Collections.IList)value)[i]).GetType();
                    }
                    if (T != null && value is List<object>)
                    {
                        //convert list of subtype object to a list of the required subtype
                        dynamic newList = typeof(List<>)
                            .MakeGenericType(T)
                            .GetConstructor(new Type[] { })
                            .Invoke(new object[] { });
                        for (int i = 0; i < ((List<dynamic>)value).Count; i++)
                        {
                            newList.Add(value[i]);
                        }
                        return newList;
                    }
                    return value;
                }
                else
                {
                    Type valueType = value.GetType();
                    if ((value is Dictionary<string, object>))
                    {
                        Object[] args = { value };
                        return Activator.CreateInstance(validationType, args);
                    }
                    else if (valueType == validationType)
                    {
                        return value;
                    }
                    else if (valueType.GetMethod("Build") != null && valueType.IsSubclassOf(typeof(GenericJSONBuilder)))
                    {
                        dynamic returnValue = value.Build();
                        if (returnValue.GetType() as Type == validationType)
                        {
                            return returnValue;
                        }
                    }
                    throw new PaysafeException("Invalid value for property " + name + " for class " + this.GetType().ToString());
                }
            }
            throw new PaysafeException("Invalid validation rule for property " + name + " for class " + this.GetType().ToString());
        }
    }
}

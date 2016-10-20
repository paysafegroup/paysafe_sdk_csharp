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
using Paysafe.Common;

namespace Paysafe.CustomerVault
{
    public class Profile : Paysafe.Common.JSONObject
    {
        /// <summary>
        /// Initialize the Profile object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public Profile(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {CustomerVaultConstants.id, STRING_TYPE},
            {CustomerVaultConstants.status, CustomerVaultConstants.enumStatus},
            {CustomerVaultConstants.merchantCustomerId, STRING_TYPE},
            {CustomerVaultConstants.locale,  CustomerVaultConstants.enumLocale},
            {CustomerVaultConstants.firstName, STRING_TYPE},
            {CustomerVaultConstants.middleName, STRING_TYPE},
            {CustomerVaultConstants.lastName, STRING_TYPE},
            {CustomerVaultConstants.dateOfBirth, typeof(DateOfBirth)},
            {CustomerVaultConstants.ip, STRING_TYPE},
            {CustomerVaultConstants.gender, CustomerVaultConstants.enumGender},
            {CustomerVaultConstants.nationality, STRING_TYPE},
            {CustomerVaultConstants.email, EMAIL_TYPE},
            {CustomerVaultConstants.phone, STRING_TYPE},
            {CustomerVaultConstants.cellPhone, STRING_TYPE},
            {CustomerVaultConstants.paymentToken, STRING_TYPE},
            {CustomerVaultConstants.addresses, typeof(List<Address>)},
            {CustomerVaultConstants.cards, typeof(List<Card>)},
            {CustomerVaultConstants.error, typeof(OptError)},
            {CustomerVaultConstants.links, typeof(List<Link>)},
            {CustomerVaultConstants.card, typeof(Card)},
            {CustomerVaultConstants.achBankAccounts, typeof(List<ACHBankAccounts>)},
            {CustomerVaultConstants.bacsBankAccounts, typeof(List<BACSBankAccounts>)},
            {CustomerVaultConstants.sepaBankAccounts, typeof(List<SEPABankAccounts>)},
            {CustomerVaultConstants.eftBankAccounts, typeof(List<EFTBankAccounts>)}
        };

        /// <summary>
        /// Get the id
        /// </summary>
        /// <returns>string</returns>
        public string id()
        {
            return this.getProperty(CustomerVaultConstants.id);
        }

        /// <summary>
        /// Set the id
        /// </summary>
        /// <returns>void</returns>
        public void id(string data)
        {
            this.setProperty(CustomerVaultConstants.id, data);
        }

        /// <summary>
        /// Get the status
        /// </summary>
        /// <returns>string</returns>
        public string status()
        {
            return this.getProperty(CustomerVaultConstants.status);
        }

        /// <summary>
        /// Set the status
        /// </summary>
        /// <returns>void</returns>
        public void status(string data)
        {
            this.setProperty(CustomerVaultConstants.status, data);
        }

        /// <summary>
        /// Get the merchantCustomerId
        /// </summary>
        /// <returns>string</returns>
        public string merchantCustomerId()
        {
            return this.getProperty(CustomerVaultConstants.merchantCustomerId);
        }

        /// <summary>
        /// Set the merchantCustomerId
        /// </summary>
        /// <returns>void</returns>
        public void merchantCustomerId(string data)
        {
            this.setProperty(CustomerVaultConstants.merchantCustomerId, data);
        }

        /// <summary>
        /// Get the locale
        /// </summary>
        /// <returns>string</returns>
        public string locale()
        {
            return this.getProperty(CustomerVaultConstants.locale);
        }

        /// <summary>
        /// Set the locale
        /// </summary>
        /// <returns>void</returns>
        public void locale(string data)
        {
            this.setProperty(CustomerVaultConstants.locale, data);
        }

        /// <summary>
        /// Get the firstName
        /// </summary>
        /// <returns>string</returns>
        public string firstName()
        {
            return this.getProperty(CustomerVaultConstants.firstName);
        }

        /// <summary>
        /// Set the firstName
        /// </summary>
        /// <returns>void</returns>
        public void firstName(string data)
        {
            this.setProperty(CustomerVaultConstants.firstName, data);
        }

        /// <summary>
        /// Get the lastName
        /// </summary>
        /// <returns>string</returns>
        public string lastName()
        {
            return this.getProperty(CustomerVaultConstants.lastName);
        }

        /// <summary>
        /// Set the lastName
        /// </summary>
        /// <returns>void</returns>
        public void lastName(string data)
        {
            this.setProperty(CustomerVaultConstants.lastName, data);
        }

        /// <summary>
        /// Get the dateOfBirth
        /// </summary>
        /// <returns>DateOfBirth</returns>
        public DateOfBirth dateOfBirth()
        {
            return this.getProperty(CustomerVaultConstants.dateOfBirth);
        }

        /// <summary>
        /// Set the dateOfBirth
        /// </summary>
        /// <returns>void</returns>
        public void dateOfBirth(DateOfBirth data)
        {
            this.setProperty(CustomerVaultConstants.dateOfBirth, data);
        }

        /// <summary>
        /// Get the ip
        /// </summary>
        /// <returns>string</returns>
        public string ip()
        {
            return this.getProperty(CustomerVaultConstants.ip);
        }

        /// <summary>
        /// Set the ip
        /// </summary>
        /// <returns>void</returns>
        public void ip(string data)
        {
            this.setProperty(CustomerVaultConstants.ip, data);
        }

        /// <summary>
        /// Get the gender
        /// </summary>
        /// <returns>string</returns>
        public string gender()
        {
            return this.getProperty(CustomerVaultConstants.gender);
        }

        /// <summary>
        /// Set the gender
        /// </summary>
        /// <returns>void</returns>
        public void gender(string data)
        {
            this.setProperty(CustomerVaultConstants.gender, data);
        }

        /// <summary>
        /// Get the nationality
        /// </summary>
        /// <returns>string</returns>
        public string nationality()
        {
            return this.getProperty(CustomerVaultConstants.nationality);
        }

        /// <summary>
        /// Set the nationality
        /// </summary>
        /// <returns>void</returns>
        public void nationality(string data)
        {
            this.setProperty(CustomerVaultConstants.nationality, data);
        }

        /// <summary>
        /// Get the email
        /// </summary>
        /// <returns>string</returns>
        public string email()
        {
            return this.getProperty(CustomerVaultConstants.email);
        }

        /// <summary>
        /// Set the email
        /// </summary>
        /// <returns>void</returns>
        public void email(string data)
        {
            this.setProperty(CustomerVaultConstants.email, data);
        }

        /// <summary>
        /// Get the phone
        /// </summary>
        /// <returns>string</returns>
        public string phone()
        {
            return this.getProperty(CustomerVaultConstants.phone);
        }

        /// <summary>
        /// Set the phone
        /// </summary>
        /// <returns>void</returns>
        public void phone(string data)
        {
            this.setProperty(CustomerVaultConstants.phone, data);
        }

        /// <summary>
        /// Get the cellPhone
        /// </summary>
        /// <returns>string</returns>
        public string cellPhone()
        {
            return this.getProperty(CustomerVaultConstants.cellPhone);
        }

        /// <summary>
        /// Set the cellPhone
        /// </summary>
        /// <returns>string</returns>
        public void cellPhone(string data)
        {
            this.setProperty(CustomerVaultConstants.cellPhone, data);
        }

        /// <summary>
        /// Get the paymentToken
        /// </summary>
        /// <returns>string</returns>
        public string paymentToken()
        {
            return this.getProperty(CustomerVaultConstants.paymentToken);
        }

        /// <summary>
        /// Set the paymentToken
        /// </summary>
        /// <returns>void</returns>
        public void paymentToken(string data)
        {
            this.setProperty(CustomerVaultConstants.paymentToken, data);
        }

        /// <summary>
        /// Get the addresses
        /// </summary>
        /// <returns>List<Address></returns>
        public List<Address> addresses()
        {
            return this.getProperty(CustomerVaultConstants.addresses);
        }

        /// <summary>
        /// Set the addresses
        /// </summary>
        /// <returns>void</returns>
        public void addresses(List<Address> data)
        {
            this.setProperty(CustomerVaultConstants.addresses, data);
        }

        /// <summary>
        /// Get the cards
        /// </summary>
        /// <returns>List<Card></returns>
        public List<Card> cards()
        {
            return this.getProperty(CustomerVaultConstants.cards);
        }

        /// <summary>
        /// Set the cards
        /// </summary>
        /// <returns>void</returns>
        public void cards(List<Card> data)
        {
            this.setProperty(CustomerVaultConstants.cards, data);
        }

        /// <summary>
        /// Get the error
        /// </summary>
        /// <returns>OptError</returns>
        public OptError error()
        {
            return this.getProperty(CustomerVaultConstants.error);
        }

        /// <summary>
        /// Set the error
        /// </summary>
        /// <returns>void</returns>
        public void error(OptError data)
        {
            this.setProperty(CustomerVaultConstants.error, data);
        }

        /// <summary>
        /// Get the links
        /// </summary>
        /// <returns>List<Paysafe.Common.Link></returns>
        public List<Paysafe.Common.Link> links()
        {
            return this.getProperty(CustomerVaultConstants.links);
        }

        /// <summary>
        /// Set the links
        /// </summary>
        /// <returns>void</returns>
        public void links(List<Paysafe.Common.Link> data)
        {
            this.setProperty(CustomerVaultConstants.links, data);
        }


        /// <summary>
        /// Get the card
        /// </summary>
        /// <returns>Card</returns>
        public Card card()
        {
            return this.getProperty(CustomerVaultConstants.card);
        }

        /// <summary>
        /// Set the card
        /// </summary>
        /// <returns>void</returns>
        public void card(Card data)
        {
            this.setProperty(CustomerVaultConstants.card, data);
        }


        /// <summary>
        /// Get the achBankAccounts
        /// </summary>
        /// <returns>List<Address></returns>
        public List<ACHBankAccounts> achBankAccounts()
        {
            return this.getProperty(CustomerVaultConstants.achBankAccounts);
        }

        /// <summary>
        /// Set the achBankAccounts
        /// </summary>
        /// <returns>void</returns>
        public void achBankAccounts(List<ACHBankAccounts> data)
        {
            this.setProperty(CustomerVaultConstants.achBankAccounts, data);
        }

        /// <summary>
        /// Get the bacsBankAccounts
        /// </summary>
        /// <returns>List<Address></returns>
        public List<BACSBankAccounts> bacsBankAccounts()
        {
            return this.getProperty(CustomerVaultConstants.bacsBankAccounts);
        }

        /// <summary>
        /// Set the bacsBankAccounts
        /// </summary>
        /// <returns>void</returns>
        public void bacsBankAccounts(List<BACSBankAccounts> data)
        {
            this.setProperty(CustomerVaultConstants.bacsBankAccounts, data);
        }
        /// <summary>
        /// Get the sepaBankAccounts
        /// </summary>
        /// <returns>List<Address></returns>
        public List<SEPABankAccounts> sepaBankAccounts()
        {
            return this.getProperty(CustomerVaultConstants.sepaBankAccounts);
        }

        /// <summary>
        /// Set the sepaBankAccounts
        /// </summary>
        /// <returns>void</returns>
        public void sepaBankAccounts(List<SEPABankAccounts> data)
        {
            this.setProperty(CustomerVaultConstants.sepaBankAccounts, data);
        }
        /// <summary>
        /// Get the eftBankAccounts
        /// </summary>
        /// <returns>List<Address></returns>
        public List<EFTBankAccounts> eftBankAccounts()
        {
            return this.getProperty(CustomerVaultConstants.eftBankAccounts);
        }

        /// <summary>
        /// Set the eftBankAccounts
        /// </summary>
        /// <returns>void</returns>
        public void eftBankAccounts(List<EFTBankAccounts> data)
        {
            this.setProperty(CustomerVaultConstants.eftBankAccounts, data);
        }

        public static ProfileBuilder Builder()
        {
            return new ProfileBuilder();
        }

        /// <summary>
        /// ProfileBuilder will allow an authorization to be initialized.
        /// set all properties and subpropeties, then trigger .Build() to 
        /// get the generated Profile object
        /// </summary>
        public class ProfileBuilder : BaseJSONBuilder<Profile>
        {

            /// <summary>
            /// Set the id parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ProfileBuilder</returns>
            public ProfileBuilder id(string data)
            {
                this.properties[CustomerVaultConstants.id] = data;
                return this;
            }

            /// <summary>
            /// Set the merchantCustomerId parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ProfileBuilder</returns>
            public ProfileBuilder merchantCustomerId(string data)
            {
                this.properties[CustomerVaultConstants.merchantCustomerId] = data;
                return this;
            }

            /// <summary>
            /// Set the locale parameter
            /// </summary>
            /// <param name=data>List<string></param>
            /// <returns>ProfileBuilder</returns>
            public ProfileBuilder locale(string data)
            {
                this.properties[CustomerVaultConstants.locale] = data;
                return this;
            }

            /// <summary>
            /// Set the firstName parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ProfileBuilder</returns>
            public ProfileBuilder firstName(string data)
            {
                this.properties[CustomerVaultConstants.firstName] = data;
                return this;
            }

            /// <summary>
            /// Set the middleName parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ProfileBuilder</returns>
            public ProfileBuilder middleName(string data)
            {
                this.properties[CustomerVaultConstants.middleName] = data;
                return this;
            }

            /// <summary>
            /// Set the lastName parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ProfileBuilder</returns>
            public ProfileBuilder lastName(string data)
            {
                this.properties[CustomerVaultConstants.lastName] = data;
                return this;
            }

            /// <summary>
            /// Build a dateOfBirth within this authorization.
            /// </summary>
            /// <returns>DateOfBirth.DateOfBirthBuilder<ProfileBuilder></returns>
            public DateOfBirth.DateOfBirthBuilder<ProfileBuilder> dateOfBirth()
            {
                if (!this.properties.ContainsKey(CustomerVaultConstants.dateOfBirth))
                {
                    this.properties[CustomerVaultConstants.dateOfBirth] = new DateOfBirth.DateOfBirthBuilder<ProfileBuilder>(this);
                }
                return this.properties[CustomerVaultConstants.dateOfBirth] as DateOfBirth.DateOfBirthBuilder<ProfileBuilder>;
            }

            /// <summary>
            /// Set the ip parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ProfileBuilder</returns>
            public ProfileBuilder ip(string data)
            {
                this.properties[CustomerVaultConstants.ip] = data;
                return this;
            }

            /// <summary>
            /// Set the gender parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ProfileBuilder</returns>
            public ProfileBuilder gender(string data)
            {
                this.properties[CustomerVaultConstants.gender] = data;
                return this;
            }

            /// <summary>
            /// Set the nationality parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ProfileBuilder</returns>
            public ProfileBuilder nationality(string data)
            {
                this.properties[CustomerVaultConstants.nationality] = data;
                return this;
            }

            /// <summary>
            /// Set the email parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ProfileBuilder</returns>
            public ProfileBuilder email(string data)
            {
                this.properties[CustomerVaultConstants.email] = data;
                return this;
            }

            /// <summary>
            /// Set the phone parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ProfileBuilder</returns>
            public ProfileBuilder phone(string data)
            {
                this.properties[CustomerVaultConstants.phone] = data;
                return this;
            }

            /// <summary>
            /// Set the cellPhone parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ProfileBuilder</returns>
            public ProfileBuilder cellPhone(string data)
            {
                this.properties[CustomerVaultConstants.cellPhone] = data;
                return this;
            }

            /// <summary>
            /// Build a card object within this Profile.
            /// </summary>
            /// <returns>Profile.profileBuilder<VerificationBuilder></returns>
            public Card.CardBuilderSingelUse<ProfileBuilder> card()
            {
                if (!this.properties.ContainsKey(CustomerVaultConstants.card))
                {
                    this.properties[CustomerVaultConstants.card] = new Card.CardBuilderSingelUse<ProfileBuilder>(this);
                }
                return this.properties[CustomerVaultConstants.card] as Card.CardBuilderSingelUse<ProfileBuilder>;
            }

        }
    }
}

﻿#region License

/*
 * Copyright 2002-2011 the original author or authors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#endregion

using System;

namespace Spring.Social.OAuth1
{
    /// <summary>
    /// A OAuth 1.0 request token that has been authorized by the user.
    /// </summary>
    /// <remarks>
    /// Constructed after the user grants the consumer application access to their data hosted at the service provider.
    /// This is typically achieved by the user clicking "Allow" over at the provider's site.
    /// The service provider returns a Verifier string in the authorization callback that must also be submitted in the access token request.
    /// </remarks>
    /// <author>Keith Donald</author>
    /// <author>Bruno Baia (.NET)</author>
    public class AuthorizedRequestToken 
    {
	    private OAuth1Token requestToken;
	    private string verifier;

        /// <summary>
        /// Creates an authorized request token.
        /// </summary>
        /// <param name="requestToken">The request token object.</param>
        /// <param name="verifier">The access token verifier.</param>
	    public AuthorizedRequestToken(OAuth1Token requestToken, string verifier) 
        {
		    this.requestToken = requestToken;
		    this.verifier = verifier;
	    }

        /// <summary>
        /// Gets the request token value.
        /// </summary>
	    public string Value 
        {
            get { return this.requestToken.Value; }
	    }

        /// <summary>
        /// Gets the request token secret.
        /// </summary>
	    public string Secret 
        {
            get { return this.requestToken.Secret; }
	    }

	    /// <summary>
        /// Gets the verifier string generated by the provider.
	    /// </summary>
	    public string Verifier 
        {
            get { return verifier; }
	    }
    }
}
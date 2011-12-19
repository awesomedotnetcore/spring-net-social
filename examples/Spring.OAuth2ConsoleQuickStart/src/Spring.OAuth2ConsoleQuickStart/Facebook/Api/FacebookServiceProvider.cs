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

using Spring.Social.OAuth2;
using Spring.Social.Facebook.Api.Impl;

namespace Spring.Social.Facebook.Api
{
    // Facebook ServiceProvider implementation.
    public class FacebookServiceProvider : AbstractOAuth2ServiceProvider<IFacebook>
    {
        public FacebookServiceProvider(string clientId, string clientSecret)
            : base(new FacebookOAuth2Template(clientId, clientSecret))
        {
        }

        public override IFacebook GetApi(string accessToken)
        {
            return new FacebookTemplate(accessToken);
        }
    }
}
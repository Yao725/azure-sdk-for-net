// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Scheduler.Models
{
    /// <summary> The BasicAuthentication. </summary>
    public partial class BasicAuthentication : HttpAuthentication
    {
        /// <summary> Initializes a new instance of BasicAuthentication. </summary>
        public BasicAuthentication()
        {
            Type = HttpAuthenticationType.Basic;
        }

        /// <summary> Initializes a new instance of BasicAuthentication. </summary>
        /// <param name="type"> Gets or sets the HTTP authentication type. </param>
        /// <param name="username"> Gets or sets the username. </param>
        /// <param name="password"> Gets or sets the password, return value will always be empty. </param>
        internal BasicAuthentication(HttpAuthenticationType type, string username, string password) : base(type)
        {
            Username = username;
            Password = password;
            Type = type;
        }

        /// <summary> Gets or sets the username. </summary>
        public string Username { get; set; }
        /// <summary> Gets or sets the password, return value will always be empty. </summary>
        public string Password { get; set; }
    }
}

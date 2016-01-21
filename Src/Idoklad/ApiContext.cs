﻿using System;
using IdokladSdk.Extensions;

namespace IdokladSdk
{
    public class ApiContext
    {
        /// <summary>
        /// Access token suitable for all API requests accessed through ApiExplorer
        /// </summary>
        public string AccessToken { get; private set; }

        /// <summary>
        /// Your application name (optional but recommended)
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// Your application version (optional)
        /// </summary>
        public string AppVersion { get; set; }

        /// <summary>
        /// Agenda ID
        /// At the present time, API automatically choose your default agenda
        /// </summary>
        [Obsolete]
        public int? Agenda { get; set; }

        public ApiContext(string accessToken)
        {
            if (accessToken.IsNullOrEmpty())
            {
                throw new ArgumentNullException("Access Token can not be null");
            }

            this.AccessToken = accessToken;
        }
    }
}

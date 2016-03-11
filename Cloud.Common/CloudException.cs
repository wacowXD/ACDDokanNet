﻿using System;
using System.Net;

namespace Azi.Cloud.Common
{
    public class CloudException : Exception
    {
        public CloudException(HttpStatusCode error, Exception ex)
            : base(error.ToString(), ex)
        {
            Error = error;
        }

        public HttpStatusCode Error { get; }
    }
}

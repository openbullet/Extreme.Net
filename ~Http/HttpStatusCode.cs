namespace Extreme.Net
{
    /// <summary>
    /// HTTP status-codes for every request responses.
    /// </summary>
    public enum HttpStatusCode
    {
        None = 0,

        Continue = 100,
        SwitchingProtocols = 101,

        OK = 200,
        Created = 201,
        Accepted = 202,
        NonAuthoritativeInformation = 203,
        NoContent = 204,
        ResetContent = 205,
        PartialContent = 206,

        MultipleChoices = 300,
        MovedPermanently = 301,
        Moved = 301,
        Found = 302,
        Redirect = 302,
        SeeOther = 303,
        RedirectMethod = 303,
        NotModified = 304,
        UseProxy = 305,
        Unused = 306,
        TemporaryRedirect = 307,
        RedirectKeepVerb = 307,
        TooManyRedirects = 310,

        BadRequest = 400,
        Unauthorized = 401,
        PaymentRequired = 402,
        Forbidden = 403,
        NotFound = 404,
        MethodNotAllowed = 405,
        NotAcceptable = 406,
        ProxyAuthenticationRequired = 407,
        RequestTimeout = 408,
        Conflict = 409,
        Gone = 410,
        LengthRequired = 411,
        PreconditionFailed = 412,
        RequestEntityTooLarge = 413,
        RequestUriTooLong = 414,
        UnsupportedMediaType = 415,
        RequestedRangeNotSatisfiable = 416,
        ExpectationFailed = 417,
        BadMapping = 421,
        MisdirectedRequest = 421,
        NoResponse = 444,
        RetryWith = 449,
        BlockedByWindowsParentalControls = 450,
        UnavailableForLegalReasons = 451,

        /// <summary>
        /// Nginx-specific status codes
        /// </summary>
        SSLCertificateError = 495,
        SSLCertificateRequired = 496,
        HTTPRequestSentToHTTPSPort = 497,
        TokenExpired = 498,
        TokenInvalid = 498,
        ClientClosedRequest = 499,

        InternalServerError = 500,
        NotImplemented = 501,
        BadGateway = 502,
        ServiceUnavailable = 503,
        GatewayTimeout = 504,
        HttpVersionNotSupported = 505,
        BandwidthLimitExceeded = 509,
        
        /// <summary>
        /// Cloudflare-specific status codes
        /// </summary>
        UnknownError = 520,
        WebServerIsDown = 521,
        ConnexionTimedOut = 522,
        OriginIsUnreachable = 523,
        ATimeoutOccured = 524,
        SSLHandshakeFailed = 525,
        InvalidSSLCertificates = 526,
        RailgunError = 527,
    }
}

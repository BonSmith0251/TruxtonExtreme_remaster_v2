namespace Steamworks;

[Token(Token = "0x2000013")]
public static class SteamHTTP
{

	[Address(RVA = "0x5EF5F0", Offset = "0x5EE9F0", Length = "0x8A")]
	[Token(Token = "0x600024B")]
	public static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify) { }

	[Address(RVA = "0x5EF680", Offset = "0x5EEA80", Length = "0x14F")]
	[Token(Token = "0x600023A")]
	public static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL) { }

	[Address(RVA = "0x5EF7D0", Offset = "0x5EEBD0", Length = "0x4C")]
	[Token(Token = "0x6000241")]
	public static bool DeferHTTPRequest(HTTPRequestHandle hRequest) { }

	[Address(RVA = "0x5EF820", Offset = "0x5EEC20", Length = "0x5B")]
	[Token(Token = "0x6000249")]
	public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut) { }

	[Address(RVA = "0x5EF880", Offset = "0x5EEC80", Length = "0x5B")]
	[Token(Token = "0x6000252")]
	public static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut) { }

	[Address(RVA = "0x5EF8E0", Offset = "0x5EECE0", Length = "0x72")]
	[Token(Token = "0x6000246")]
	public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, Byte[] pBodyDataBuffer, uint unBufferSize) { }

	[Address(RVA = "0x5EF960", Offset = "0x5EED60", Length = "0x5B")]
	[Token(Token = "0x6000245")]
	public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize) { }

	[Address(RVA = "0x5EF9C0", Offset = "0x5EEDC0", Length = "0x13B")]
	[Token(Token = "0x6000243")]
	public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize) { }

	[Address(RVA = "0x5EFB00", Offset = "0x5EEF00", Length = "0x142")]
	[Token(Token = "0x6000244")]
	public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, Byte[] pHeaderValueBuffer, uint unBufferSize) { }

	[Address(RVA = "0x5EFC50", Offset = "0x5EF050", Length = "0x82")]
	[Token(Token = "0x6000247")]
	public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, Byte[] pBodyDataBuffer, uint unBufferSize) { }

	[Address(RVA = "0x5EFCE0", Offset = "0x5EF0E0", Length = "0x4C")]
	[Token(Token = "0x6000242")]
	public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest) { }

	[Address(RVA = "0x5EFD30", Offset = "0x5EF130", Length = "0x4C")]
	[Token(Token = "0x600024C")]
	public static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer) { }

	[Address(RVA = "0x5EFD80", Offset = "0x5EF180", Length = "0x4C")]
	[Token(Token = "0x6000248")]
	public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest) { }

	[Address(RVA = "0x5EFE30", Offset = "0x5EF230", Length = "0x5B")]
	[Token(Token = "0x600023F")]
	public static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle) { }

	[Address(RVA = "0x5EFDD0", Offset = "0x5EF1D0", Length = "0x5B")]
	[Token(Token = "0x6000240")]
	public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle) { }

	[Address(RVA = "0x5EFE90", Offset = "0x5EF290", Length = "0x24E")]
	[Token(Token = "0x600024D")]
	public static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie) { }

	[Address(RVA = "0x5F00E0", Offset = "0x5EF4E0", Length = "0x5A")]
	[Token(Token = "0x6000251")]
	public static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds) { }

	[Address(RVA = "0x5F0140", Offset = "0x5EF540", Length = "0x5B")]
	[Token(Token = "0x600023B")]
	public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue) { }

	[Address(RVA = "0x5F01A0", Offset = "0x5EF5A0", Length = "0x5A")]
	[Token(Token = "0x600024E")]
	public static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer) { }

	[Address(RVA = "0x5F0200", Offset = "0x5EF600", Length = "0x1C4")]
	[Token(Token = "0x600023E")]
	public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue) { }

	[Address(RVA = "0x5F03D0", Offset = "0x5EF7D0", Length = "0x1C4")]
	[Token(Token = "0x600023D")]
	public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue) { }

	[Address(RVA = "0x5F05A0", Offset = "0x5EF9A0", Length = "0x5A")]
	[Token(Token = "0x600023C")]
	public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds) { }

	[Address(RVA = "0x5F0600", Offset = "0x5EFA00", Length = "0x142")]
	[Token(Token = "0x600024A")]
	public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, Byte[] pubBody, uint unBodyLen) { }

	[Address(RVA = "0x5F0750", Offset = "0x5EFB50", Length = "0x5C")]
	[Token(Token = "0x6000250")]
	public static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate) { }

	[Address(RVA = "0x5F07B0", Offset = "0x5EFBB0", Length = "0x123")]
	[Token(Token = "0x600024F")]
	public static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo) { }

}


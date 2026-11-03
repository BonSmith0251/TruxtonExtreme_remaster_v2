namespace Steamworks;

[Token(Token = "0x2000009")]
public static class SteamGameServerHTTP
{

	[Address(RVA = "0x5DFE30", Offset = "0x5DF230", Length = "0x8A")]
	[Token(Token = "0x60000F4")]
	public static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify) { }

	[Address(RVA = "0x5DFEC0", Offset = "0x5DF2C0", Length = "0x14F")]
	[Token(Token = "0x60000E3")]
	public static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL) { }

	[Address(RVA = "0x5E0010", Offset = "0x5DF410", Length = "0x4C")]
	[Token(Token = "0x60000EA")]
	public static bool DeferHTTPRequest(HTTPRequestHandle hRequest) { }

	[Address(RVA = "0x5E0060", Offset = "0x5DF460", Length = "0x5B")]
	[Token(Token = "0x60000F2")]
	public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut) { }

	[Address(RVA = "0x5E00C0", Offset = "0x5DF4C0", Length = "0x5B")]
	[Token(Token = "0x60000FB")]
	public static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut) { }

	[Address(RVA = "0x5E0120", Offset = "0x5DF520", Length = "0x72")]
	[Token(Token = "0x60000EF")]
	public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, Byte[] pBodyDataBuffer, uint unBufferSize) { }

	[Address(RVA = "0x5E01A0", Offset = "0x5DF5A0", Length = "0x5B")]
	[Token(Token = "0x60000EE")]
	public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize) { }

	[Address(RVA = "0x5E0200", Offset = "0x5DF600", Length = "0x13B")]
	[Token(Token = "0x60000EC")]
	public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize) { }

	[Address(RVA = "0x5E0340", Offset = "0x5DF740", Length = "0x142")]
	[Token(Token = "0x60000ED")]
	public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, Byte[] pHeaderValueBuffer, uint unBufferSize) { }

	[Address(RVA = "0x5E0490", Offset = "0x5DF890", Length = "0x82")]
	[Token(Token = "0x60000F0")]
	public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, Byte[] pBodyDataBuffer, uint unBufferSize) { }

	[Address(RVA = "0x5E0520", Offset = "0x5DF920", Length = "0x4C")]
	[Token(Token = "0x60000EB")]
	public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest) { }

	[Address(RVA = "0x5E0570", Offset = "0x5DF970", Length = "0x4C")]
	[Token(Token = "0x60000F5")]
	public static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer) { }

	[Address(RVA = "0x5E05C0", Offset = "0x5DF9C0", Length = "0x4C")]
	[Token(Token = "0x60000F1")]
	public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest) { }

	[Address(RVA = "0x5E0670", Offset = "0x5DFA70", Length = "0x5B")]
	[Token(Token = "0x60000E8")]
	public static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle) { }

	[Address(RVA = "0x5E0610", Offset = "0x5DFA10", Length = "0x5B")]
	[Token(Token = "0x60000E9")]
	public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle) { }

	[Address(RVA = "0x5E06D0", Offset = "0x5DFAD0", Length = "0x24E")]
	[Token(Token = "0x60000F6")]
	public static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie) { }

	[Address(RVA = "0x5E0920", Offset = "0x5DFD20", Length = "0x5A")]
	[Token(Token = "0x60000FA")]
	public static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds) { }

	[Address(RVA = "0x5E0980", Offset = "0x5DFD80", Length = "0x5B")]
	[Token(Token = "0x60000E4")]
	public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue) { }

	[Address(RVA = "0x5E09E0", Offset = "0x5DFDE0", Length = "0x5A")]
	[Token(Token = "0x60000F7")]
	public static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer) { }

	[Address(RVA = "0x5E0A40", Offset = "0x5DFE40", Length = "0x1C4")]
	[Token(Token = "0x60000E7")]
	public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue) { }

	[Address(RVA = "0x5E0C10", Offset = "0x5E0010", Length = "0x1C4")]
	[Token(Token = "0x60000E6")]
	public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue) { }

	[Address(RVA = "0x5E0DE0", Offset = "0x5E01E0", Length = "0x5A")]
	[Token(Token = "0x60000E5")]
	public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds) { }

	[Address(RVA = "0x5E0E40", Offset = "0x5E0240", Length = "0x142")]
	[Token(Token = "0x60000F3")]
	public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, Byte[] pubBody, uint unBodyLen) { }

	[Address(RVA = "0x5E0F90", Offset = "0x5E0390", Length = "0x5C")]
	[Token(Token = "0x60000F9")]
	public static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate) { }

	[Address(RVA = "0x5E0FF0", Offset = "0x5E03F0", Length = "0x123")]
	[Token(Token = "0x60000F8")]
	public static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo) { }

}


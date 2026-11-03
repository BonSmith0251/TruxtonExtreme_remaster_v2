namespace System.Net.NetworkInformation;

[Token(Token = "0x20002E4")]
internal class Win32NetworkInterface
{
	[Token(Token = "0x4000C9E")]
	private static Win32_FIXED_INFO fixedInfo; //Field offset: 0x0
	[Token(Token = "0x4000C9F")]
	private static bool initialized; //Field offset: 0x58

	[Token(Token = "0x17000438")]
	public static Win32_FIXED_INFO FixedInfo
	{
		[Address(RVA = "0x25F88F0", Offset = "0x25F7CF0", Length = "0x64F")]
		[Token(Token = "0x6001364")]
		 get { } //Length: 1615
	}

	[Address(RVA = "0x25F8800", Offset = "0x25F7C00", Length = "0xEA")]
	[CompilerGenerated]
	[Token(Token = "0x6001365")]
	internal static string <get_FixedInfo>g__GetStringFromMultiByte|5_0(Byte* bytes) { }

	[Address(RVA = "0x25F88F0", Offset = "0x25F7CF0", Length = "0x64F")]
	[Token(Token = "0x6001364")]
	public static Win32_FIXED_INFO get_FixedInfo() { }

	[Address(RVA = "0x25F86A0", Offset = "0x25F7AA0", Length = "0x90")]
	[Token(Token = "0x6001362")]
	private static int GetNetworkParams(IntPtr ptr, ref int size) { }

	[Address(RVA = "0x25F8730", Offset = "0x25F7B30", Length = "0xC2")]
	[Token(Token = "0x6001363")]
	private static int MultiByteToWideChar(uint CodePage, uint dwFlags, Byte* lpMultiByteStr, int cbMultiByte, Char* lpWideCharStr, int cchWideChar) { }

}


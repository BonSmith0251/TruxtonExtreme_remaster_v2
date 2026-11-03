namespace System.Net;

[Token(Token = "0x2000288")]
internal static class UnsafeNclNativeMethods
{
	[Token(Token = "0x2000289")]
	public static class HttpApi
	{
		[Token(Token = "0x200028A")]
		public static class HTTP_REQUEST_HEADER_ID
		{
			[Token(Token = "0x4000A66")]
			private static String[] m_Strings; //Field offset: 0x0

			[Address(RVA = "0x26C4260", Offset = "0x26C3660", Length = "0x7E6")]
			[Token(Token = "0x6001122")]
			private static HTTP_REQUEST_HEADER_ID() { }

			[Address(RVA = "0x26C41F0", Offset = "0x26C35F0", Length = "0x6E")]
			[Token(Token = "0x6001121")]
			internal static string ToString(int position) { }

		}

		[Token(Token = "0x4000A65")]
		private static String[] m_Strings; //Field offset: 0x0

		[Address(RVA = "0x26C7490", Offset = "0x26C6890", Length = "0x5D6")]
		[Token(Token = "0x6001120")]
		private static HttpApi() { }

	}

	[Token(Token = "0x200028B")]
	public static class SecureStringHelper
	{

		[Address(RVA = "0x26CD240", Offset = "0x26CC640", Length = "0x9F")]
		[Token(Token = "0x6001124")]
		internal static SecureString CreateSecureString(string plainString) { }

		[Address(RVA = "0x26CD2E0", Offset = "0x26CC6E0", Length = "0x107")]
		[Token(Token = "0x6001123")]
		internal static string CreateString(SecureString secureString) { }

	}


}


namespace Steamworks;

[Token(Token = "0x200018B")]
public class InteropHelp
{
	[Token(Token = "0x200018D")]
	internal class SteamParamStringArray
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A5C")]
		private IntPtr[] m_Strings; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A5D")]
		private IntPtr m_ptrStrings; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A5E")]
		private IntPtr m_pSteamParamStringArray; //Field offset: 0x20

		[Address(RVA = "0x63C810", Offset = "0x63BC10", Length = "0x536")]
		[Token(Token = "0x60008FC")]
		public SteamParamStringArray(IList<String> strings) { }

		[Address(RVA = "0x63C6D0", Offset = "0x63BAD0", Length = "0x131")]
		[Token(Token = "0x60008FD")]
		protected virtual void Finalize() { }

		[Address(RVA = "0x63CD50", Offset = "0x63C150", Length = "0x17")]
		[Token(Token = "0x60008FE")]
		public static IntPtr op_Implicit(SteamParamStringArray that) { }

	}

	[Token(Token = "0x200018C")]
	internal class UTF8StringHandle : SafeHandleZeroOrMinusOneIsInvalid
	{

		[Address(RVA = "0x645D80", Offset = "0x645180", Length = "0x13F")]
		[Token(Token = "0x60008FA")]
		public UTF8StringHandle(string str) { }

		[Address(RVA = "0x645D10", Offset = "0x645110", Length = "0x6A")]
		[Token(Token = "0x60008FB")]
		protected virtual bool ReleaseHandle() { }

	}


	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60008F9")]
	public InteropHelp() { }

	[Address(RVA = "0x60DCC0", Offset = "0x60D0C0", Length = "0x7D")]
	[Token(Token = "0x60008F7")]
	public static string ByteArrayToStringUTF8(Byte[] buffer) { }

	[Address(RVA = "0x60DD40", Offset = "0x60D140", Length = "0x121")]
	[Token(Token = "0x60008F6")]
	public static string PtrToStringUTF8(IntPtr nativeUtf8) { }

	[Address(RVA = "0x60DE70", Offset = "0x60D270", Length = "0xA8")]
	[Token(Token = "0x60008F8")]
	public static void StringToByteArrayUTF8(string str, Byte[] outArrayBuffer, int outArrayBufferSize) { }

	[Address(RVA = "0x60DF20", Offset = "0x60D320", Length = "0x96")]
	[Token(Token = "0x60008F4")]
	public static void TestIfAvailableClient() { }

	[Address(RVA = "0x60DFC0", Offset = "0x60D3C0", Length = "0x96")]
	[Token(Token = "0x60008F5")]
	public static void TestIfAvailableGameServer() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60008F3")]
	public static void TestIfPlatformSupported() { }

}


namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002CC")]
public struct XAsyncBlockPtr
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000787")]
	internal readonly IntPtr IntPtr; //Field offset: 0x0

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000FA6")]
	internal XAsyncBlockPtr(IntPtr intPtr) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000FA7")]
	public static IntPtr op_Implicit(XAsyncBlockPtr ptr) { }

	[Address(RVA = "0x2BA0130", Offset = "0x2B9F530", Length = "0x19")]
	[Token(Token = "0x6000FA8")]
	public static XAsyncBlockPtr op_Implicit(XAsyncBlock block) { }

}


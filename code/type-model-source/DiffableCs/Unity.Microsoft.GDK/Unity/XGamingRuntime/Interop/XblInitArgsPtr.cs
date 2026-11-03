namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000350")]
internal struct XblInitArgsPtr
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400098F")]
	internal readonly IntPtr IntPtr; //Field offset: 0x0

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x60011B7")]
	internal XblInitArgsPtr(IntPtr intPtr) { }

}


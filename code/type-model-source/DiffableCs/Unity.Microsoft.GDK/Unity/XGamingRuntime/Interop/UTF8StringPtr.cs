namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002BB")]
internal struct UTF8StringPtr
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000747")]
	private IntPtr pointer; //Field offset: 0x0

	[Address(RVA = "0x2B9FC60", Offset = "0x2B9F060", Length = "0x17F")]
	[Token(Token = "0x6000E2D")]
	internal UTF8StringPtr(string str, DisposableCollection disposableCollection) { }

	[Address(RVA = "0x2B9FAB0", Offset = "0x2B9EEB0", Length = "0x1A7")]
	[Token(Token = "0x6000E2E")]
	internal string GetString() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6000E2F")]
	internal IntPtr ToPointer() { }

}


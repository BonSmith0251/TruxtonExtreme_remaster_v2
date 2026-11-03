namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002BA")]
internal class UInt64Ref
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000746")]
	internal readonly ulong Value; //Field offset: 0x10

	[Address(RVA = "0x2B7F420", Offset = "0x2B7E820", Length = "0x26")]
	[Token(Token = "0x6000E2C")]
	internal UInt64Ref(ulong value) { }

}


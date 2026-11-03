namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200033B")]
internal struct XblPreferredColor
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000934")]
	internal readonly Byte[] primaryColor; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000935")]
	internal readonly Byte[] secondaryColor; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000936")]
	internal readonly Byte[] tertiaryColor; //Field offset: 0x10

}


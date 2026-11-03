namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200034F")]
internal struct XblInitArgs
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400098D")]
	public XTaskQueueHandle queue; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400098E")]
	public IntPtr scid; //Field offset: 0x8

}


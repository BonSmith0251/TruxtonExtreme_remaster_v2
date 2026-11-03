namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002F8")]
internal struct XblMultiplayerSessionChangeEventArgs
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000828")]
	internal XblMultiplayerSessionReference SessionReference; //Field offset: 0x0
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000829")]
	internal Byte[] Branch; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400082A")]
	internal readonly ulong ChangeNumber; //Field offset: 0xF8

	[Address(RVA = "0x2BB6370", Offset = "0x2BB5770", Length = "0x45")]
	[Token(Token = "0x600114F")]
	internal string GetBranch() { }

}


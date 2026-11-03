namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002FA")]
internal struct XblMultiplayerSessionHandleId
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400082C")]
	internal Byte[] value; //Field offset: 0x0

	[Address(RVA = "0x2BB6BB0", Offset = "0x2BB5FB0", Length = "0x41")]
	[Token(Token = "0x6001150")]
	internal string GetValue() { }

}


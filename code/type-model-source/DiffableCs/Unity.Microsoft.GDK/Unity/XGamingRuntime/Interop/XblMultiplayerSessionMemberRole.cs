namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000301")]
internal struct XblMultiplayerSessionMemberRole
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400085B")]
	internal UTF8StringPtr roleTypeName; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400085C")]
	internal UTF8StringPtr roleName; //Field offset: 0x8

	[Address(RVA = "0x2BB6D80", Offset = "0x2BB6180", Length = "0x7A")]
	[Token(Token = "0x600115E")]
	internal XblMultiplayerSessionMemberRole(XblMultiplayerSessionMemberRole publicObject, DisposableCollection disposableCollection) { }

}


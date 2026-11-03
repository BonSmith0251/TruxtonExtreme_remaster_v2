namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200033C")]
internal struct XblSocialManagerEvent
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000937")]
	internal readonly IntPtr user; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000938")]
	internal readonly XblSocialManagerEventType eventType; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000939")]
	internal readonly int hr; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400093A")]
	internal readonly XblSocialManagerUserGroupHandle loadedGroup; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400093B")]
	internal readonly IntPtr[] usersAffected; //Field offset: 0x18

	[Address(RVA = "0x2BB82A0", Offset = "0x2BB76A0", Length = "0x238")]
	[Token(Token = "0x60011AC")]
	internal XblSocialManagerUser[] GetUserArray() { }

}


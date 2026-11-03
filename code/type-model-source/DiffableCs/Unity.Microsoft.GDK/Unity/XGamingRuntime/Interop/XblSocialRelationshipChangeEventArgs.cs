namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000339")]
public struct XblSocialRelationshipChangeEventArgs
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400092F")]
	public ulong callerXboxUserId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000930")]
	public XblSocialNotificationType socialNotification; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000931")]
	public UInt64* xboxUserIds; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000932")]
	public SizeT xboxUserIdsCount; //Field offset: 0x18

}


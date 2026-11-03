namespace Unity.XGamingRuntime;

[Token(Token = "0x20001D2")]
public struct XblSocialRelationshipChangeEventArgs
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004EB")]
	public ulong callerXboxUserId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40004EC")]
	public XblSocialNotificationType socialNotification; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004ED")]
	public UInt64[] xboxUserIds; //Field offset: 0x10

}


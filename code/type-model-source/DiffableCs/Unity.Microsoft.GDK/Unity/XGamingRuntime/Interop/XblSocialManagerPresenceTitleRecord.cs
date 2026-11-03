namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200033F")]
internal struct XblSocialManagerPresenceTitleRecord
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000941")]
	internal readonly uint titleId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000942")]
	internal readonly Byte[] titleName; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000943")]
	internal readonly bool isTitleActive; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000944")]
	internal readonly Byte[] presenceText; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000945")]
	internal readonly bool isBroadcasting; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000946")]
	internal readonly XblPresenceDeviceType deviceType; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000947")]
	internal readonly bool isPrimary; //Field offset: 0x28

	[Address(RVA = "0x2BB8660", Offset = "0x2BB7A60", Length = "0x1CD")]
	[Token(Token = "0x60011B1")]
	internal XblSocialManagerPresenceTitleRecord(XblSocialManagerPresenceTitleRecord titleRecord) { }

}


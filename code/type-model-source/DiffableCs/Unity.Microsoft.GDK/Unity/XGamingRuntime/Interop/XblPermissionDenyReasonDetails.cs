namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000331")]
internal struct XblPermissionDenyReasonDetails
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000912")]
	internal readonly XblPermissionDenyReason reason; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000913")]
	internal readonly XblPrivilege restrictedPrivilege; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000914")]
	internal readonly XblPrivacySetting restrictedPrivacySetting; //Field offset: 0x8

	[Address(RVA = "0x2BB7800", Offset = "0x2BB6C00", Length = "0x24")]
	[Token(Token = "0x600119F")]
	internal XblPermissionDenyReasonDetails(XblPermissionDenyReasonDetails publicObject) { }

}


namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001C2")]
public class XblPermissionDenyReasonDetails
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000499")]
	private XblPermissionDenyReason <Reason>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400049A")]
	private XblPrivilege <RestrictedPrivilege>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400049B")]
	private XblPrivacySetting <RestrictedPrivacySetting>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700019B")]
	public private XblPermissionDenyReason Reason
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000976")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000977")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700019D")]
	public private XblPrivacySetting RestrictedPrivacySetting
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600097A")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600097B")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700019C")]
	public private XblPrivilege RestrictedPrivilege
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000978")]
		 get { } //Length: 4
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000979")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x2ACAF60", Offset = "0x2ACA360", Length = "0x33")]
	[Token(Token = "0x6000975")]
	internal XblPermissionDenyReasonDetails(XblPermissionDenyReasonDetails interopStruct) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6000976")]
	public XblPermissionDenyReason get_Reason() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600097A")]
	public XblPrivacySetting get_RestrictedPrivacySetting() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000978")]
	public XblPrivilege get_RestrictedPrivilege() { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000977")]
	private void set_Reason(XblPermissionDenyReason value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600097B")]
	private void set_RestrictedPrivacySetting(XblPrivacySetting value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000979")]
	private void set_RestrictedPrivilege(XblPrivilege value) { }

}


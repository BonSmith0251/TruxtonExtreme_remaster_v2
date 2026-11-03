namespace System.Net.Configuration;

[Token(Token = "0x20002ED")]
internal sealed class SettingsSectionInternal
{
	[Token(Token = "0x4000CBB")]
	private static readonly SettingsSectionInternal instance; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CBC")]
	internal readonly bool HttpListenerUnescapeRequestUrl; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000CBD")]
	internal readonly IPProtectionLevel IPProtectionLevel; //Field offset: 0x14

	[Token(Token = "0x1700043C")]
	internal bool Ipv6Enabled
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600136E")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x1700043B")]
	internal static SettingsSectionInternal Section
	{
		[Address(RVA = "0x25E2680", Offset = "0x25E1A80", Length = "0x4E")]
		[Token(Token = "0x600136D")]
		internal get { } //Length: 78
	}

	[Address(RVA = "0x25E25E0", Offset = "0x25E19E0", Length = "0x72")]
	[Token(Token = "0x6001370")]
	private static SettingsSectionInternal() { }

	[Address(RVA = "0x25E2660", Offset = "0x25E1A60", Length = "0x12")]
	[Token(Token = "0x600136F")]
	public SettingsSectionInternal() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600136E")]
	internal bool get_Ipv6Enabled() { }

	[Address(RVA = "0x25E2680", Offset = "0x25E1A80", Length = "0x4E")]
	[Token(Token = "0x600136D")]
	internal static SettingsSectionInternal get_Section() { }

}


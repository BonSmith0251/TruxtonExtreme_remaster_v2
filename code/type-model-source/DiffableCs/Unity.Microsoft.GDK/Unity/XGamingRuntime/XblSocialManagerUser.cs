namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001E5")]
public class XblSocialManagerUser
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000530")]
	private ulong <XboxUserId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000531")]
	private bool <IsFavorite>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x4000532")]
	private bool <IsFollowingUser>k__BackingField; //Field offset: 0x19
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1A")]
	[Token(Token = "0x4000533")]
	private bool <IsFollowedByCaller>k__BackingField; //Field offset: 0x1A
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000534")]
	private string <DisplayName>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000535")]
	private string <RealName>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000536")]
	private string <DisplayPicUrlRaw>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000537")]
	private bool <UseAvatar>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000538")]
	private string <Gamerscore>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000539")]
	private string <Gamertag>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400053A")]
	private string <ModernGamertag>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400053B")]
	private string <ModernGamertagSuffix>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400053C")]
	private string <UniqueModernGamertag>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400053D")]
	private XblSocialManagerPresenceRecord <PresenceRecord>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400053E")]
	private XblTitleHistory <TitleHistory>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400053F")]
	private XblPreferredColor <PreferredColor>k__BackingField; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000540")]
	private bool m_isFriend; //Field offset: 0x80

	[Token(Token = "0x170001C3")]
	public private string DisplayName
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A0A")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000A0B")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001C5")]
	public private string DisplayPicUrlRaw
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A0E")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000A0F")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001C7")]
	public private string Gamerscore
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A12")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000A13")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001C8")]
	public private string Gamertag
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A14")]
		 get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000A15")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001BF")]
	public private bool IsFavorite
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A02")]
		 get { } //Length: 5
		[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000A03")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170001C2")]
	public private bool IsFollowedByCaller
	{
		[Address(RVA = "0x116C050", Offset = "0x116B450", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A08")]
		 get { } //Length: 5
		[Address(RVA = "0x21BAC00", Offset = "0x21BA000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000A09")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170001C1")]
	public private bool IsFollowingUser
	{
		[Address(RVA = "0x1D88C10", Offset = "0x1D88010", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A06")]
		 get { } //Length: 5
		[Address(RVA = "0x21BAC10", Offset = "0x21BA010", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000A07")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170001C0")]
	public private bool IsFriend
	{
		[Address(RVA = "0x1C0B600", Offset = "0x1C0AA00", Length = "0x8")]
		[Token(Token = "0x6000A04")]
		 get { } //Length: 8
		[Address(RVA = "0x1C0B610", Offset = "0x1C0AA10", Length = "0x7")]
		[Token(Token = "0x6000A05")]
		private set { } //Length: 7
	}

	[Token(Token = "0x170001C9")]
	public private string ModernGamertag
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A16")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000A17")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001CA")]
	public private string ModernGamertagSuffix
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A18")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000A19")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001CE")]
	public private XblPreferredColor PreferredColor
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A20")]
		 get { } //Length: 5
		[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000A21")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001CC")]
	public private XblSocialManagerPresenceRecord PresenceRecord
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A1C")]
		 get { } //Length: 5
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000A1D")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001C4")]
	public private string RealName
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A0C")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000A0D")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001CD")]
	public private XblTitleHistory TitleHistory
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A1E")]
		 get { } //Length: 5
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000A1F")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001CB")]
	public private string UniqueModernGamertag
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A1A")]
		 get { } //Length: 5
		[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
		[CompilerGenerated]
		[Token(Token = "0x6000A1B")]
		private set { } //Length: 995
	}

	[Token(Token = "0x170001C6")]
	public private bool UseAvatar
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A10")]
		 get { } //Length: 5
		[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000A11")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170001BE")]
	public private ulong XboxUserId
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A00")]
		 get { } //Length: 5
		[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A01")]
		private set { } //Length: 5
	}

	[Address(RVA = "0x2B8B790", Offset = "0x2B8AB90", Length = "0x4D5")]
	[Token(Token = "0x60009FE")]
	internal XblSocialManagerUser(XblSocialManagerUser interopUser) { }

	[Address(RVA = "0x2B8BC70", Offset = "0x2B8B070", Length = "0x4FD")]
	[Token(Token = "0x60009FF")]
	internal XblSocialManagerUser(XblSocialManagerUser2 interopUser) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A0A")]
	public string get_DisplayName() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A0E")]
	public string get_DisplayPicUrlRaw() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A12")]
	public string get_Gamerscore() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A14")]
	public string get_Gamertag() { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A02")]
	public bool get_IsFavorite() { }

	[Address(RVA = "0x116C050", Offset = "0x116B450", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A08")]
	public bool get_IsFollowedByCaller() { }

	[Address(RVA = "0x1D88C10", Offset = "0x1D88010", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A06")]
	public bool get_IsFollowingUser() { }

	[Address(RVA = "0x1C0B600", Offset = "0x1C0AA00", Length = "0x8")]
	[Token(Token = "0x6000A04")]
	public bool get_IsFriend() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A16")]
	public string get_ModernGamertag() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A18")]
	public string get_ModernGamertagSuffix() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A20")]
	public XblPreferredColor get_PreferredColor() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A1C")]
	public XblSocialManagerPresenceRecord get_PresenceRecord() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A0C")]
	public string get_RealName() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A1E")]
	public XblTitleHistory get_TitleHistory() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A1A")]
	public string get_UniqueModernGamertag() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A10")]
	public bool get_UseAvatar() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A00")]
	public ulong get_XboxUserId() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000A0B")]
	private void set_DisplayName(string value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000A0F")]
	private void set_DisplayPicUrlRaw(string value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000A13")]
	private void set_Gamerscore(string value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000A15")]
	private void set_Gamertag(string value) { }

	[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000A03")]
	private void set_IsFavorite(bool value) { }

	[Address(RVA = "0x21BAC00", Offset = "0x21BA000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000A09")]
	private void set_IsFollowedByCaller(bool value) { }

	[Address(RVA = "0x21BAC10", Offset = "0x21BA010", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000A07")]
	private void set_IsFollowingUser(bool value) { }

	[Address(RVA = "0x1C0B610", Offset = "0x1C0AA10", Length = "0x7")]
	[Token(Token = "0x6000A05")]
	private void set_IsFriend(bool value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000A17")]
	private void set_ModernGamertag(string value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000A19")]
	private void set_ModernGamertagSuffix(string value) { }

	[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000A21")]
	private void set_PreferredColor(XblPreferredColor value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000A1D")]
	private void set_PresenceRecord(XblSocialManagerPresenceRecord value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000A0D")]
	private void set_RealName(string value) { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000A1F")]
	private void set_TitleHistory(XblTitleHistory value) { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[CompilerGenerated]
	[Token(Token = "0x6000A1B")]
	private void set_UniqueModernGamertag(string value) { }

	[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000A11")]
	private void set_UseAvatar(bool value) { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A01")]
	private void set_XboxUserId(ulong value) { }

}


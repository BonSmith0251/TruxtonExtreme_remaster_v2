namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001E4")]
public class XblSocialManagerPresenceTitleRecord
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000529")]
	private uint <TitleId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400052A")]
	private string <TitleName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400052B")]
	private bool <IsTitleActive>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400052C")]
	private string <PresenceText>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400052D")]
	private bool <IsBroadcasting>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400052E")]
	private XblPresenceDeviceType <DeviceType>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400052F")]
	private bool <IsPrimary>k__BackingField; //Field offset: 0x38

	[Token(Token = "0x170001BC")]
	public private XblPresenceDeviceType DeviceType
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60009FA")]
		 get { } //Length: 4
		[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60009FB")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170001BB")]
	public private bool IsBroadcasting
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009F8")]
		 get { } //Length: 5
		[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60009F9")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170001BD")]
	public private bool IsPrimary
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009FC")]
		 get { } //Length: 5
		[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60009FD")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170001B9")]
	public private bool IsTitleActive
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009F4")]
		 get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60009F5")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170001BA")]
	public private string PresenceText
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009F6")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60009F7")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001B7")]
	public private uint TitleId
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x60009F0")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60009F1")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170001B8")]
	public private string TitleName
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009F2")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60009F3")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x2B8B670", Offset = "0x2B8AA70", Length = "0x78")]
	[Token(Token = "0x60009EF")]
	internal XblSocialManagerPresenceTitleRecord(XblSocialManagerPresenceTitleRecord interopRecord) { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60009FA")]
	public XblPresenceDeviceType get_DeviceType() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009F8")]
	public bool get_IsBroadcasting() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009FC")]
	public bool get_IsPrimary() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009F4")]
	public bool get_IsTitleActive() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009F6")]
	public string get_PresenceText() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x60009F0")]
	public uint get_TitleId() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009F2")]
	public string get_TitleName() { }

	[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60009FB")]
	private void set_DeviceType(XblPresenceDeviceType value) { }

	[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60009F9")]
	private void set_IsBroadcasting(bool value) { }

	[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60009FD")]
	private void set_IsPrimary(bool value) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60009F5")]
	private void set_IsTitleActive(bool value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60009F7")]
	private void set_PresenceText(string value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60009F1")]
	private void set_TitleId(uint value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60009F3")]
	private void set_TitleName(string value) { }

}


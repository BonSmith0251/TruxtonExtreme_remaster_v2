namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001B7")]
public class XblPresenceRichPresenceIds
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000458")]
	private string <ServiceConfigurationId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000459")]
	private string <PresenceId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400045A")]
	private String[] <PresenceTokenIds>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700018D")]
	public private string PresenceId
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000951")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000952")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700018E")]
	public private String[] PresenceTokenIds
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000953")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000954")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700018C")]
	public private string ServiceConfigurationId
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600094F")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000950")]
		private set { } //Length: 13
	}

	[Address(RVA = "0xA96E10", Offset = "0xA96210", Length = "0x6B")]
	[Token(Token = "0x600094D")]
	private XblPresenceRichPresenceIds(string serviceConfigurationId, string presenceId, String[] presenceTokenIds) { }

	[Address(RVA = "0x2B8AD20", Offset = "0x2B8A120", Length = "0xDC")]
	[Token(Token = "0x600094E")]
	public static int Create(string serviceConfigurationId, string presenceId, String[] presenceTokenIds, out XblPresenceRichPresenceIds richPresenceIds) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000951")]
	public string get_PresenceId() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000953")]
	public String[] get_PresenceTokenIds() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600094F")]
	public string get_ServiceConfigurationId() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000952")]
	private void set_PresenceId(string value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000954")]
	private void set_PresenceTokenIds(String[] value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000950")]
	private void set_ServiceConfigurationId(string value) { }

}


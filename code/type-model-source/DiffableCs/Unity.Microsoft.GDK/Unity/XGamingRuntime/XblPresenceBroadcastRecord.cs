namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001AF")]
public class XblPresenceBroadcastRecord
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400042E")]
	private string <BroadcastId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400042F")]
	private string <Session>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000430")]
	private XblPresenceBroadcastProvider <Provider>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000431")]
	private uint <ViewerCount>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000432")]
	private DateTime <StartTime>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x1700017F")]
	public private string BroadcastId
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600092B")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600092C")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000181")]
	public private XblPresenceBroadcastProvider Provider
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600092F")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000930")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000180")]
	public private string Session
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600092D")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600092E")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000183")]
	public private DateTime StartTime
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000933")]
		 get { } //Length: 5
		[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000934")]
		private set { } //Length: 5
	}

	[Token(Token = "0x17000182")]
	public private uint ViewerCount
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000931")]
		 get { } //Length: 4
		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000932")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x2B8A8E0", Offset = "0x2B89CE0", Length = "0xF1")]
	[Token(Token = "0x600092A")]
	internal XblPresenceBroadcastRecord(XblPresenceBroadcastRecord interopRecord) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600092B")]
	public string get_BroadcastId() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600092F")]
	public XblPresenceBroadcastProvider get_Provider() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600092D")]
	public string get_Session() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000933")]
	public DateTime get_StartTime() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000931")]
	public uint get_ViewerCount() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600092C")]
	private void set_BroadcastId(string value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000930")]
	private void set_Provider(XblPresenceBroadcastProvider value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600092E")]
	private void set_Session(string value) { }

	[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000934")]
	private void set_StartTime(DateTime value) { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000932")]
	private void set_ViewerCount(uint value) { }

}


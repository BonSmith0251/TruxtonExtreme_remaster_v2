namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000163")]
public class XblLeaderboardRow
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400028B")]
	private string <Gamertag>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400028C")]
	private string <ModernGamertag>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400028D")]
	private string <ModernGamertagSuffix>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400028E")]
	private string <UniqueModernGamertag>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400028F")]
	private ulong <XboxUserId>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000290")]
	private double <Percentile>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000291")]
	private uint <Rank>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000292")]
	private uint <GlobalRank>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000293")]
	private String[] <ColumnValues>k__BackingField; //Field offset: 0x48

	[Token(Token = "0x170000BD")]
	public private String[] ColumnValues
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007FC")]
		 get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60007FD")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000B5")]
	public private string Gamertag
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007EC")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60007ED")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000BC")]
	public private uint GlobalRank
	{
		[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007FA")]
		 get { } //Length: 4
		[Address(RVA = "0x2490E80", Offset = "0x2490280", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007FB")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170000B6")]
	public private string ModernGamertag
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007EE")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60007EF")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000B7")]
	public private string ModernGamertagSuffix
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007F0")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60007F1")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000BA")]
	public private double Percentile
	{
		[Address(RVA = "0x1BB5D30", Offset = "0x1BB5130", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60007F6")]
		 get { } //Length: 6
		[Address(RVA = "0x1BB5D40", Offset = "0x1BB5140", Length = "0x9F")]
		[CompilerGenerated]
		[Token(Token = "0x60007F7")]
		private set { } //Length: 159
	}

	[Token(Token = "0x170000BB")]
	public private uint Rank
	{
		[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007F8")]
		 get { } //Length: 4
		[Address(RVA = "0x1116990", Offset = "0x1115D90", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007F9")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170000B8")]
	public private string UniqueModernGamertag
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007F2")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60007F3")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000B9")]
	public private ulong XboxUserId
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007F4")]
		 get { } //Length: 5
		[Address(RVA = "0x2162050", Offset = "0x2161450", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007F5")]
		private set { } //Length: 5
	}

	[Address(RVA = "0x2B862E0", Offset = "0x2B856E0", Length = "0xC3")]
	[Token(Token = "0x60007EB")]
	internal XblLeaderboardRow(XblLeaderboardRow interopRow) { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007FC")]
	public String[] get_ColumnValues() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007EC")]
	public string get_Gamertag() { }

	[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007FA")]
	public uint get_GlobalRank() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007EE")]
	public string get_ModernGamertag() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007F0")]
	public string get_ModernGamertagSuffix() { }

	[Address(RVA = "0x1BB5D30", Offset = "0x1BB5130", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x60007F6")]
	public double get_Percentile() { }

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007F8")]
	public uint get_Rank() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007F2")]
	public string get_UniqueModernGamertag() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007F4")]
	public ulong get_XboxUserId() { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60007FD")]
	private void set_ColumnValues(String[] value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60007ED")]
	private void set_Gamertag(string value) { }

	[Address(RVA = "0x2490E80", Offset = "0x2490280", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007FB")]
	private void set_GlobalRank(uint value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60007EF")]
	private void set_ModernGamertag(string value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60007F1")]
	private void set_ModernGamertagSuffix(string value) { }

	[Address(RVA = "0x1BB5D40", Offset = "0x1BB5140", Length = "0x9F")]
	[CompilerGenerated]
	[Token(Token = "0x60007F7")]
	private void set_Percentile(double value) { }

	[Address(RVA = "0x1116990", Offset = "0x1115D90", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007F9")]
	private void set_Rank(uint value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60007F3")]
	private void set_UniqueModernGamertag(string value) { }

	[Address(RVA = "0x2162050", Offset = "0x2161450", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007F5")]
	private void set_XboxUserId(ulong value) { }

}


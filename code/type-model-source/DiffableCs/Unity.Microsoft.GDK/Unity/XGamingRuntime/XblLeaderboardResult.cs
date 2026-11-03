namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000161")]
public class XblLeaderboardResult
{
	[CompilerGenerated]
	[Token(Token = "0x2000162")]
	private sealed class <>c
	{
		[Token(Token = "0x4000288")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000289")]
		public static Func<XblLeaderboardColumn, XblLeaderboardColumn> <>9__0_0; //Field offset: 0x8
		[Token(Token = "0x400028A")]
		public static Func<XblLeaderboardRow, XblLeaderboardRow> <>9__0_1; //Field offset: 0x10

		[Address(RVA = "0x2B80890", Offset = "0x2B7FC90", Length = "0x67")]
		[Token(Token = "0x60007E7")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60007E8")]
		public <>c() { }

		[Address(RVA = "0x2B7FAA0", Offset = "0x2B7EEA0", Length = "0x5E")]
		[Token(Token = "0x60007E9")]
		internal XblLeaderboardColumn <.ctor>b__0_0(XblLeaderboardColumn c) { }

		[Address(RVA = "0x2B800E0", Offset = "0x2B7F4E0", Length = "0x149")]
		[Token(Token = "0x60007EA")]
		internal XblLeaderboardRow <.ctor>b__0_1(XblLeaderboardRow r) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000283")]
	private uint <TotalRowCount>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000284")]
	private XblLeaderboardColumn[] <Columns>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000285")]
	private XblLeaderboardRow[] <Rows>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000286")]
	private bool <HasNext>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000287")]
	private XblLeaderboardQuery <NextQuery>k__BackingField; //Field offset: 0x30

	[Token(Token = "0x170000B1")]
	public private XblLeaderboardColumn[] Columns
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007DF")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60007E0")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000B3")]
	public private bool HasNext
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007E3")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007E4")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170000B4")]
	public private XblLeaderboardQuery NextQuery
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007E5")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60007E6")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000B2")]
	public private XblLeaderboardRow[] Rows
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007E1")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60007E2")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000B0")]
	public private uint TotalRowCount
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x60007DD")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007DE")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x2B7EE80", Offset = "0x2B7E280", Length = "0x4FA")]
	[Token(Token = "0x60007DC")]
	internal XblLeaderboardResult(XblLeaderboardResult interopResult) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007DF")]
	public XblLeaderboardColumn[] get_Columns() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007E3")]
	public bool get_HasNext() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007E5")]
	public XblLeaderboardQuery get_NextQuery() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007E1")]
	public XblLeaderboardRow[] get_Rows() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x60007DD")]
	public uint get_TotalRowCount() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60007E0")]
	private void set_Columns(XblLeaderboardColumn[] value) { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007E4")]
	private void set_HasNext(bool value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60007E6")]
	private void set_NextQuery(XblLeaderboardQuery value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60007E2")]
	private void set_Rows(XblLeaderboardRow[] value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007DE")]
	private void set_TotalRowCount(uint value) { }

}


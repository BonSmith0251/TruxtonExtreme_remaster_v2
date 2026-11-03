namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001B8")]
public class XblPresenceTitleRecord
{
	[CompilerGenerated]
	[Token(Token = "0x20001B9")]
	private sealed class <>c
	{
		[Token(Token = "0x4000462")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000463")]
		public static Func<XblPresenceBroadcastRecord, XblPresenceBroadcastRecord> <>9__0_0; //Field offset: 0x8

		[Address(RVA = "0x2B807B0", Offset = "0x2B7FBB0", Length = "0x67")]
		[Token(Token = "0x6000964")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000965")]
		public <>c() { }

		[Address(RVA = "0x2B7F810", Offset = "0x2B7EC10", Length = "0x11C")]
		[Token(Token = "0x6000966")]
		internal XblPresenceBroadcastRecord <.ctor>b__0_0(XblPresenceBroadcastRecord br) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400045B")]
	private uint <TitleId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400045C")]
	private string <TitleName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400045D")]
	private DateTime <LastModified>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400045E")]
	private bool <TitleActive>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400045F")]
	private string <RichPresenceString>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000460")]
	private XblPresenceTitleViewState <ViewState>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000461")]
	private XblPresenceBroadcastRecord <BroadcastRecord>k__BackingField; //Field offset: 0x40

	[Token(Token = "0x17000195")]
	public private XblPresenceBroadcastRecord BroadcastRecord
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000962")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000963")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000191")]
	public private DateTime LastModified
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600095A")]
		 get { } //Length: 5
		[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600095B")]
		private set { } //Length: 5
	}

	[Token(Token = "0x17000193")]
	public private string RichPresenceString
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600095E")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600095F")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000192")]
	public private bool TitleActive
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600095C")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600095D")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700018F")]
	public private uint TitleId
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000956")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000957")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000190")]
	public private string TitleName
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000958")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000959")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000194")]
	public private XblPresenceTitleViewState ViewState
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000960")]
		 get { } //Length: 4
		[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000961")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x2B8AE00", Offset = "0x2B8A200", Length = "0x218")]
	[Token(Token = "0x6000955")]
	internal XblPresenceTitleRecord(XblPresenceTitleRecord interopRecord) { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000962")]
	public XblPresenceBroadcastRecord get_BroadcastRecord() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600095A")]
	public DateTime get_LastModified() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600095E")]
	public string get_RichPresenceString() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600095C")]
	public bool get_TitleActive() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6000956")]
	public uint get_TitleId() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000958")]
	public string get_TitleName() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000960")]
	public XblPresenceTitleViewState get_ViewState() { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000963")]
	private void set_BroadcastRecord(XblPresenceBroadcastRecord value) { }

	[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600095B")]
	private void set_LastModified(DateTime value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600095F")]
	private void set_RichPresenceString(string value) { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600095D")]
	private void set_TitleActive(bool value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000957")]
	private void set_TitleId(uint value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000959")]
	private void set_TitleName(string value) { }

	[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000961")]
	private void set_ViewState(XblPresenceTitleViewState value) { }

}


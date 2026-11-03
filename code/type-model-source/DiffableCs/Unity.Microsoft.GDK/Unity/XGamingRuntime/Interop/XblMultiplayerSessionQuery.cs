namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000306")]
internal struct XblMultiplayerSessionQuery
{
	[CompilerGenerated]
	[Token(Token = "0x2000307")]
	private sealed class <>c
	{
		[Token(Token = "0x4000880")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000881")]
		public static Func<UInt64, DisposableCollection, UInt64> <>9__11_0; //Field offset: 0x8

		[Address(RVA = "0x2B9F730", Offset = "0x2B9EB30", Length = "0x67")]
		[Token(Token = "0x600116A")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600116B")]
		public <>c() { }

		[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
		[Token(Token = "0x600116C")]
		internal ulong <.ctor>b__11_0(ulong x, DisposableCollection dc) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000875")]
	internal readonly Byte[] Scid; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000876")]
	private uint MaxItems; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000877")]
	internal bool IncludePrivateSessions; //Field offset: 0xC
	[FieldOffset(Offset = "0xD")]
	[Token(Token = "0x4000878")]
	internal bool IncludeReservations; //Field offset: 0xD
	[FieldOffset(Offset = "0xE")]
	[Token(Token = "0x4000879")]
	internal bool IncludeInactiveSessions; //Field offset: 0xE
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400087A")]
	private readonly IntPtr XuidFilters; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400087B")]
	private SizeT XuidFiltersCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400087C")]
	internal UTF8StringPtr KeywordFilter; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400087D")]
	internal readonly Byte[] SessionTemplateNameFilter; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400087E")]
	private XblMultiplayerSessionVisibility VisibilityFilter; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400087F")]
	private uint ContractVersionFilter; //Field offset: 0x34

	[Address(RVA = "0x2BB7340", Offset = "0x2BB6740", Length = "0x320")]
	[Token(Token = "0x6001169")]
	internal XblMultiplayerSessionQuery(XblMultiplayerSessionQuery publicObject, DisposableCollection disposableCollection) { }

}


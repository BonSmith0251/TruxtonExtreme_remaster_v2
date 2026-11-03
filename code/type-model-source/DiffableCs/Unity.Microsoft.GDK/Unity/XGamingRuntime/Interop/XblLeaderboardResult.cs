namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002EA")]
internal struct XblLeaderboardResult
{
	[CompilerGenerated]
	[Token(Token = "0x20002EB")]
	private sealed class <>c
	{
		[Token(Token = "0x40007FA")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40007FB")]
		public static Func<XblLeaderboardColumn, DisposableCollection, XblLeaderboardColumn> <>9__9_0; //Field offset: 0x8
		[Token(Token = "0x40007FC")]
		public static Func<XblLeaderboardRow, DisposableCollection, XblLeaderboardRow> <>9__9_1; //Field offset: 0x10

		[Address(RVA = "0x2B9F6C0", Offset = "0x2B9EAC0", Length = "0x67")]
		[Token(Token = "0x6001142")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001143")]
		public <>c() { }

		[Address(RVA = "0x2B9F460", Offset = "0x2B9E860", Length = "0x5C")]
		[Token(Token = "0x6001144")]
		internal XblLeaderboardColumn <.ctor>b__9_0(XblLeaderboardColumn c, DisposableCollection dc) { }

		[Address(RVA = "0x2B9F4C0", Offset = "0x2B9E8C0", Length = "0x3E")]
		[Token(Token = "0x6001145")]
		internal XblLeaderboardRow <.ctor>b__9_1(XblLeaderboardRow r, DisposableCollection dc) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007F3")]
	internal readonly uint totalRowCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40007F4")]
	private readonly IntPtr columns; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007F5")]
	private readonly SizeT columnsCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007F6")]
	private readonly IntPtr rows; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007F7")]
	private readonly SizeT rowsCount; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007F8")]
	internal readonly NativeBool hasNext; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40007F9")]
	internal readonly XblLeaderboardQuery nextQuery; //Field offset: 0x30

	[Address(RVA = "0x2BB5B00", Offset = "0x2BB4F00", Length = "0x2F4")]
	[Token(Token = "0x6001141")]
	internal XblLeaderboardResult(XblLeaderboardResult result, DisposableCollection disposableCollection) { }

	[Address(RVA = "0x9E7010", Offset = "0x9E6410", Length = "0x4E")]
	[Token(Token = "0x600113F")]
	internal T[] GetColumns(Func<XblLeaderboardColumn, T> ctor) { }

	[Address(RVA = "0x9E7060", Offset = "0x9E6460", Length = "0x4E")]
	[Token(Token = "0x6001140")]
	internal T[] GetRows(Func<XblLeaderboardRow, T> ctor) { }

}


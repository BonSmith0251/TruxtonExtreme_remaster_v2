namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002EC")]
internal struct XblLeaderboardRow
{
	[CompilerGenerated]
	[Token(Token = "0x20002ED")]
	private sealed class <>c
	{
		[Token(Token = "0x4000807")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000808")]
		public static Func<UTF8StringPtr, String> <>9__0_0; //Field offset: 0x8
		[Token(Token = "0x4000809")]
		public static Func<String, DisposableCollection, UTF8StringPtr> <>9__11_0; //Field offset: 0x10

		[Address(RVA = "0x2B9F810", Offset = "0x2B9EC10", Length = "0x67")]
		[Token(Token = "0x6001148")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001149")]
		public <>c() { }

		[Address(RVA = "0x2B9F340", Offset = "0x2B9E740", Length = "0x24")]
		[Token(Token = "0x600114B")]
		internal UTF8StringPtr <.ctor>b__11_0(string s, DisposableCollection dc) { }

		[Address(RVA = "0x2B9F320", Offset = "0x2B9E720", Length = "0x1A")]
		[Token(Token = "0x600114A")]
		internal string <GetColumnValues>b__0_0(UTF8StringPtr s) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007FD")]
	internal readonly Byte[] gamertag; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40007FE")]
	internal readonly Byte[] modernGamertag; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007FF")]
	internal readonly Byte[] modernGamertagSuffix; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000800")]
	internal readonly Byte[] uniqueModernGamertag; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000801")]
	internal readonly ulong xboxUserId; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000802")]
	internal readonly double percentile; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000803")]
	internal readonly uint rank; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000804")]
	internal readonly uint globalRank; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000805")]
	private readonly IntPtr columnValues; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000806")]
	private readonly SizeT columnValuesCount; //Field offset: 0x40

	[Address(RVA = "0x2BB5F30", Offset = "0x2BB5330", Length = "0x431")]
	[Token(Token = "0x6001147")]
	internal XblLeaderboardRow(XblLeaderboardRow row, DisposableCollection disposableCollection) { }

	[Address(RVA = "0x2BB5E00", Offset = "0x2BB5200", Length = "0x122")]
	[Token(Token = "0x6001146")]
	public String[] GetColumnValues() { }

}


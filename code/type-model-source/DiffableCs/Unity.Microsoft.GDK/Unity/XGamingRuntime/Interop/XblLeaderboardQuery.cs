namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002E7")]
internal struct XblLeaderboardQuery
{
	[CompilerGenerated]
	[Token(Token = "0x20002E8")]
	private sealed class <>c
	{
		[Token(Token = "0x40007F0")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40007F1")]
		public static Func<UTF8StringPtr, String> <>9__0_0; //Field offset: 0x8

		[Address(RVA = "0x2B9F500", Offset = "0x2B9E900", Length = "0x67")]
		[Token(Token = "0x600113C")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600113D")]
		public <>c() { }

		[Address(RVA = "0x2B9F320", Offset = "0x2B9E720", Length = "0x1A")]
		[Token(Token = "0x600113E")]
		internal string <GetAdditionalColumnleaderboardNames>b__0_0(UTF8StringPtr s) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002E9")]
	[UnsafeValueType]
	internal struct <scid>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007F2")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007E3")]
	internal readonly ulong xboxUserId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[FixedBuffer(typeof(byte), 40)]
	[Token(Token = "0x40007E4")]
	private <scid>e__FixedBuffer scid; //Field offset: 0x8
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40007E5")]
	internal readonly UTF8StringPtr leaderboardName; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40007E6")]
	internal readonly UTF8StringPtr statName; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40007E7")]
	internal readonly XblSocialGroupType socialGroup; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40007E8")]
	private readonly IntPtr additionalColumnleaderboardNames; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40007E9")]
	private readonly SizeT additionalColumnleaderboardNamesCount; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40007EA")]
	internal readonly XblLeaderboardSortOrder order; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40007EB")]
	internal readonly uint maxItems; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40007EC")]
	internal readonly ulong skipToXboxUserId; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40007ED")]
	internal readonly uint skipResultToRank; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40007EE")]
	internal readonly UTF8StringPtr continuationToken; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40007EF")]
	internal readonly XblLeaderboardQueryType queryType; //Field offset: 0x78

	[Address(RVA = "0x2BB59F0", Offset = "0x2BB4DF0", Length = "0x102")]
	[Token(Token = "0x600113A")]
	internal XblLeaderboardQuery(XblLeaderboardQuery query, DisposableCollection disposableCollection) { }

	[Address(RVA = "0x2BB5800", Offset = "0x2BB4C00", Length = "0x122")]
	[Token(Token = "0x6001138")]
	internal String[] GetAdditionalColumnleaderboardNames() { }

	[Address(RVA = "0x2BB5930", Offset = "0x2BB4D30", Length = "0x11")]
	[Token(Token = "0x6001139")]
	internal string GetScid() { }

	[Address(RVA = "0x2BB5950", Offset = "0x2BB4D50", Length = "0x9A")]
	[Token(Token = "0x600113B")]
	internal static bool ValidateFields(string scid) { }

}


namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000304")]
internal struct XblMultiplayerSessionProperties
{
	[CompilerGenerated]
	[Token(Token = "0x2000305")]
	private sealed class <>c
	{
		[Token(Token = "0x4000872")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000873")]
		public static Func<UTF8StringPtr, String> <>9__18_0; //Field offset: 0x8
		[Token(Token = "0x4000874")]
		public static Func<UTF8StringPtr, String> <>9__20_0; //Field offset: 0x10

		[Address(RVA = "0x2B9F9D0", Offset = "0x2B9EDD0", Length = "0x67")]
		[Token(Token = "0x6001165")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001166")]
		public <>c() { }

		[Address(RVA = "0x2B9F320", Offset = "0x2B9E720", Length = "0x1A")]
		[Token(Token = "0x6001167")]
		internal string <GetKeywords>b__18_0(UTF8StringPtr s) { }

		[Address(RVA = "0x2B9F320", Offset = "0x2B9E720", Length = "0x1A")]
		[Token(Token = "0x6001168")]
		internal string <GetServerConnectionStringCandidates>b__20_0(UTF8StringPtr s) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000860")]
	internal readonly IntPtr Keywords; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000861")]
	internal readonly SizeT KeywordCount; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000862")]
	internal XblMultiplayerSessionRestriction JoinRestriction; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000863")]
	internal XblMultiplayerSessionRestriction ReadRestriction; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000864")]
	private readonly IntPtr TurnCollection; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000865")]
	private readonly SizeT TurnCollectionCount; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000866")]
	internal readonly UTF8StringPtr MatchmakingTargetSessionConstantsJson; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000867")]
	internal readonly UTF8StringPtr SessionCustomPropertiesJson; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000868")]
	internal readonly UTF8StringPtr MatchmakingServerConnectionString; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000869")]
	private readonly IntPtr ServerConnectionStringCandidates; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400086A")]
	private readonly SizeT ServerConnectionStringCandidatesCount; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400086B")]
	private readonly IntPtr SessionOwnerMemberIds; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400086C")]
	private readonly SizeT SessionOwnerMemberIdsCount; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400086D")]
	internal readonly XblDeviceToken HostDeviceToken; //Field offset: 0x60
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400086E")]
	internal bool Closed; //Field offset: 0x88
	[FieldOffset(Offset = "0x89")]
	[Token(Token = "0x400086F")]
	internal bool Locked; //Field offset: 0x89
	[FieldOffset(Offset = "0x8A")]
	[Token(Token = "0x4000870")]
	internal bool AllocateCloudCompute; //Field offset: 0x8A
	[FieldOffset(Offset = "0x8B")]
	[Token(Token = "0x4000871")]
	internal bool MatchmakingResubmit; //Field offset: 0x8B

	[Address(RVA = "0x2BB70E0", Offset = "0x2BB64E0", Length = "0x121")]
	[Token(Token = "0x6001161")]
	internal String[] GetKeywords() { }

	[Address(RVA = "0x2BB7210", Offset = "0x2BB6610", Length = "0x122")]
	[Token(Token = "0x6001163")]
	internal String[] GetServerConnectionStringCandidates() { }

	[Address(RVA = "0x9E7460", Offset = "0x9E6860", Length = "0x4E")]
	[Token(Token = "0x6001164")]
	internal T[] GetSessionOwnerMemberIds(Func<UInt32, T> ctor) { }

	[Address(RVA = "0x9E74B0", Offset = "0x9E68B0", Length = "0x4E")]
	[Token(Token = "0x6001162")]
	internal T[] GetTurnCollection(Func<UInt32, T> ctor) { }

}


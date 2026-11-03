namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002FE")]
internal struct XblMultiplayerSessionMember
{
	[CompilerGenerated]
	[Token(Token = "0x20002FF")]
	private sealed class <>c
	{
		[Token(Token = "0x4000857")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000858")]
		public static Func<UTF8StringPtr, String> <>9__35_0; //Field offset: 0x8
		[Token(Token = "0x4000859")]
		public static Func<UTF8StringPtr, String> <>9__36_0; //Field offset: 0x10

		[Address(RVA = "0x2B9F960", Offset = "0x2B9ED60", Length = "0x67")]
		[Token(Token = "0x600115A")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600115B")]
		public <>c() { }

		[Address(RVA = "0x2B9F320", Offset = "0x2B9E720", Length = "0x1A")]
		[Token(Token = "0x600115D")]
		internal string <GetEncounters>b__36_0(UTF8StringPtr s) { }

		[Address(RVA = "0x2B9F320", Offset = "0x2B9E720", Length = "0x1A")]
		[Token(Token = "0x600115C")]
		internal string <GetGroups>b__35_0(UTF8StringPtr s) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000300")]
	[UnsafeValueType]
	internal struct <Gamertag>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400085A")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000837")]
	internal uint MemberId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000838")]
	internal UTF8StringPtr TeamId; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000839")]
	internal UTF8StringPtr InitialTeam; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400083A")]
	internal XblTournamentArbitrationStatus ArbitrationStatus; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400083B")]
	internal ulong Xuid; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400083C")]
	internal UTF8StringPtr CustomConstantsJson; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400083D")]
	internal UTF8StringPtr SecureDeviceBaseAddress64; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400083E")]
	private readonly IntPtr Roles; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400083F")]
	private readonly SizeT RolesCount; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000840")]
	internal UTF8StringPtr CustomPropertiesJson; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[FixedBuffer(typeof(byte), 48)]
	[Token(Token = "0x4000841")]
	private <Gamertag>e__FixedBuffer Gamertag; //Field offset: 0x50
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000842")]
	internal XblMultiplayerSessionMemberStatus Status; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000843")]
	internal bool IsTurnAvailable; //Field offset: 0x84
	[FieldOffset(Offset = "0x85")]
	[Token(Token = "0x4000844")]
	internal bool IsCurrentUser; //Field offset: 0x85
	[FieldOffset(Offset = "0x86")]
	[Token(Token = "0x4000845")]
	internal bool InitializeRequested; //Field offset: 0x86
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000846")]
	internal UTF8StringPtr MatchmakingResultServerMeasurementsJson; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000847")]
	internal UTF8StringPtr ServerMeasurementsJson; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000848")]
	private readonly IntPtr MembersInGroupIds; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000849")]
	private readonly SizeT MembersInGroupCount; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400084A")]
	internal UTF8StringPtr QosMeasurementsJson; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400084B")]
	internal XblDeviceToken DeviceToken; //Field offset: 0xB0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x400084C")]
	internal XblNetworkAddressTranslationSetting Nat; //Field offset: 0xD8
	[FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x400084D")]
	internal uint ActiveTitleId; //Field offset: 0xDC
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400084E")]
	internal uint InitializationEpisode; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400084F")]
	internal TimeT JoinTime; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000850")]
	internal XblMultiplayerMeasurementFailure InitializationFailureCause; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000851")]
	private readonly IntPtr Groups; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000852")]
	private readonly SizeT GroupsCount; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000853")]
	private readonly IntPtr Encounters; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000854")]
	private readonly SizeT EncountersCount; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000855")]
	internal XblMultiplayerSessionReference TournamentTeamSessionReference; //Field offset: 0x118
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4000856")]
	internal readonly IntPtr Internal; //Field offset: 0x208

	[Address(RVA = "0x2BB6E00", Offset = "0x2BB6200", Length = "0x128")]
	[Token(Token = "0x6001159")]
	internal String[] GetEncounters() { }

	[Address(RVA = "0x2BB6F30", Offset = "0x2BB6330", Length = "0x11")]
	[Token(Token = "0x6001155")]
	internal string GetGamertag() { }

	[Address(RVA = "0x2BB6F50", Offset = "0x2BB6350", Length = "0x128")]
	[Token(Token = "0x6001158")]
	internal String[] GetGroups() { }

	[Address(RVA = "0x9E72F0", Offset = "0x9E66F0", Length = "0x54")]
	[Token(Token = "0x6001157")]
	internal T[] GetMembersInGroupIds(Func<UInt32, T> ctor) { }

	[Address(RVA = "0x9E73B0", Offset = "0x9E67B0", Length = "0x4E")]
	[Token(Token = "0x6001156")]
	internal T[] GetRoles(Func<XblMultiplayerSessionMemberRole, T> ctor) { }

}


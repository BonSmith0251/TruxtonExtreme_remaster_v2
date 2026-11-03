namespace System;

[Token(Token = "0x2000090")]
[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
public sealed class TimeZoneInfo : IEquatable<TimeZoneInfo>, ISerializable, IDeserializationCallback
{
	[CompilerGenerated]
	[Token(Token = "0x2000097")]
	private sealed class <>c
	{
		[Token(Token = "0x4000277")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000278")]
		public static Comparison<TimeZoneInfo> <>9__49_0; //Field offset: 0x8
		[Token(Token = "0x4000279")]
		public static Comparison<TimeZoneInfo> <>9__110_0; //Field offset: 0x10

		[Address(RVA = "0x1FA8570", Offset = "0x1FA7970", Length = "0x67")]
		[Token(Token = "0x6000399")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600039A")]
		public <>c() { }

		[Address(RVA = "0x1FA84A0", Offset = "0x1FA78A0", Length = "0xCE")]
		[Token(Token = "0x600039D")]
		internal bool <.cctor>b__157_0() { }

		[Address(RVA = "0x1FA8110", Offset = "0x1FA7510", Length = "0xBF")]
		[Token(Token = "0x600039C")]
		internal int <GetSystemTimeZones>b__110_0(TimeZoneInfo x, TimeZoneInfo y) { }

		[Address(RVA = "0x1FA81D0", Offset = "0x1FA75D0", Length = "0xBF")]
		[Token(Token = "0x600039B")]
		internal int <GetSystemTimeZonesWinRTFallback>b__49_0(TimeZoneInfo x, TimeZoneInfo y) { }

	}

	[Token(Token = "0x2000095")]
	internal sealed class AdjustmentRule : IEquatable<AdjustmentRule>, ISerializable, IDeserializationCallback
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400026A")]
		private readonly DateTime _dateStart; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400026B")]
		private readonly DateTime _dateEnd; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400026C")]
		private readonly TimeSpan _daylightDelta; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400026D")]
		private readonly TransitionTime _daylightTransitionStart; //Field offset: 0x28
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400026E")]
		private readonly TransitionTime _daylightTransitionEnd; //Field offset: 0x40
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400026F")]
		private readonly TimeSpan _baseUtcOffsetDelta; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000270")]
		private readonly bool _noDaylightTransitions; //Field offset: 0x60

		[Token(Token = "0x17000044")]
		internal TimeSpan BaseUtcOffsetDelta
		{
			[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
			[Token(Token = "0x600037A")]
			internal get { } //Length: 5
		}

		[Token(Token = "0x17000040")]
		public DateTime DateEnd
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x6000376")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700003F")]
		public DateTime DateStart
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x6000375")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000041")]
		public TimeSpan DaylightDelta
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x6000377")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000043")]
		public TransitionTime DaylightTransitionEnd
		{
			[Address(RVA = "0x1F8A780", Offset = "0x1F89B80", Length = "0x15")]
			[Token(Token = "0x6000379")]
			 get { } //Length: 21
		}

		[Token(Token = "0x17000042")]
		public TransitionTime DaylightTransitionStart
		{
			[Address(RVA = "0xB00090", Offset = "0xAFF490", Length = "0x15")]
			[Token(Token = "0x6000378")]
			 get { } //Length: 21
		}

		[Token(Token = "0x17000046")]
		internal bool HasDaylightSaving
		{
			[Address(RVA = "0x1F8A7A0", Offset = "0x1F89BA0", Length = "0x1DB")]
			[Token(Token = "0x600037C")]
			internal get { } //Length: 475
		}

		[Token(Token = "0x17000045")]
		internal bool NoDaylightTransitions
		{
			[Address(RVA = "0x1E9FB00", Offset = "0x1E9EF00", Length = "0x5")]
			[Token(Token = "0x600037B")]
			internal get { } //Length: 5
		}

		[Address(RVA = "0x1F8A750", Offset = "0x1F89B50", Length = "0x2C")]
		[Token(Token = "0x6000387")]
		internal AdjustmentRule() { }

		[Address(RVA = "0x1F8A640", Offset = "0x1F89A40", Length = "0x108")]
		[Token(Token = "0x600037F")]
		private AdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions) { }

		[Address(RVA = "0x1F8A240", Offset = "0x1F89640", Length = "0x3F2")]
		[Token(Token = "0x6000386")]
		private AdjustmentRule(SerializationInfo info, StreamingContext context) { }

		[Address(RVA = "0x1F89340", Offset = "0x1F88740", Length = "0x136")]
		[Token(Token = "0x6000380")]
		internal static AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions) { }

		[Address(RVA = "0x1F89480", Offset = "0x1F88880", Length = "0x176")]
		[Token(Token = "0x600037D")]
		public override bool Equals(AdjustmentRule other) { }

		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x600037A")]
		internal TimeSpan get_BaseUtcOffsetDelta() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000376")]
		public DateTime get_DateEnd() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000375")]
		public DateTime get_DateStart() { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000377")]
		public TimeSpan get_DaylightDelta() { }

		[Address(RVA = "0x1F8A780", Offset = "0x1F89B80", Length = "0x15")]
		[Token(Token = "0x6000379")]
		public TransitionTime get_DaylightTransitionEnd() { }

		[Address(RVA = "0xB00090", Offset = "0xAFF490", Length = "0x15")]
		[Token(Token = "0x6000378")]
		public TransitionTime get_DaylightTransitionStart() { }

		[Address(RVA = "0x1F8A7A0", Offset = "0x1F89BA0", Length = "0x1DB")]
		[Token(Token = "0x600037C")]
		internal bool get_HasDaylightSaving() { }

		[Address(RVA = "0x1E9FB00", Offset = "0x1E9EF00", Length = "0x5")]
		[Token(Token = "0x600037B")]
		internal bool get_NoDaylightTransitions() { }

		[Address(RVA = "0x1F89600", Offset = "0x1F88A00", Length = "0x4A")]
		[Token(Token = "0x600037E")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x1F89650", Offset = "0x1F88A50", Length = "0x13F")]
		[Token(Token = "0x6000382")]
		internal bool IsEndDateMarkerForEndOfYear() { }

		[Address(RVA = "0x1F89790", Offset = "0x1F88B90", Length = "0x13F")]
		[Token(Token = "0x6000381")]
		internal bool IsStartDateMarkerForBeginningOfYear() { }

		[Address(RVA = "0x1F898D0", Offset = "0x1F88CD0", Length = "0xD1")]
		[Token(Token = "0x6000384")]
		private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

		[Address(RVA = "0x1F899B0", Offset = "0x1F88DB0", Length = "0x1FD")]
		[Token(Token = "0x6000385")]
		private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

		[Address(RVA = "0x1F89BB0", Offset = "0x1F88FB0", Length = "0x68D")]
		[Token(Token = "0x6000383")]
		private static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, bool noDaylightTransitions) { }

	}

	[Token(Token = "0x2000091")]
	private sealed class CachedData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400025A")]
		private OffsetAndRule _oneYearLocalFromUtc; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400025B")]
		private TimeZoneInfo _localTimeZone; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400025C")]
		public Dictionary<String, TimeZoneInfo> _systemTimeZones; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400025D")]
		public ReadOnlyCollection<TimeZoneInfo> _readOnlySystemTimeZones; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400025E")]
		public bool _allSystemTimeZonesRead; //Field offset: 0x30

		[Token(Token = "0x1700003E")]
		public TimeZoneInfo Local
		{
			[Address(RVA = "0x1F8FF30", Offset = "0x1F8F330", Length = "0x3D")]
			[Token(Token = "0x6000371")]
			 get { } //Length: 61
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000373")]
		public CachedData() { }

		[Address(RVA = "0x1F8FA30", Offset = "0x1F8EE30", Length = "0x19F")]
		[Token(Token = "0x6000370")]
		private TimeZoneInfo CreateLocal() { }

		[Address(RVA = "0x1F8FF30", Offset = "0x1F8F330", Length = "0x3D")]
		[Token(Token = "0x6000371")]
		public TimeZoneInfo get_Local() { }

		[Address(RVA = "0x1F8FBD0", Offset = "0x1F8EFD0", Length = "0x89")]
		[Token(Token = "0x6000372")]
		public DateTimeKind GetCorrespondingKind(TimeZoneInfo timeZone) { }

		[Address(RVA = "0x1F8FC60", Offset = "0x1F8F060", Length = "0xFE")]
		[Token(Token = "0x600036E")]
		private static TimeZoneInfo GetCurrentOneYearLocal() { }

		[Address(RVA = "0x1F8FD60", Offset = "0x1F8F160", Length = "0x1CB")]
		[Token(Token = "0x600036F")]
		public OffsetAndRule GetOneYearLocalFromUtc(int year) { }

	}

	[Token(Token = "0x2000093")]
	public struct DYNAMIC_TIME_ZONE_INFORMATION
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000262")]
		internal TIME_ZONE_INFORMATION TZI; //Field offset: 0x0
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4000263")]
		internal string TimeZoneKeyName; //Field offset: 0xB0
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4000264")]
		internal byte DynamicDaylightTimeDisabled; //Field offset: 0xB8

	}

	[Token(Token = "0x2000092")]
	private sealed class OffsetAndRule
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400025F")]
		public readonly int Year; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000260")]
		public readonly TimeSpan Offset; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000261")]
		public readonly AdjustmentRule Rule; //Field offset: 0x20

		[Address(RVA = "0x1F9B300", Offset = "0x1F9A700", Length = "0x51")]
		[Token(Token = "0x6000374")]
		public OffsetAndRule(int year, TimeSpan offset, AdjustmentRule rule) { }

	}

	[Token(Token = "0x2000094")]
	private enum TimeZoneInfoResult : int
	{
		Success = 0,
		TimeZoneNotFoundException = 1,
		InvalidTimeZoneException = 2,
		SecurityException = 3,
	}

	[IsReadOnly]
	[Token(Token = "0x2000096")]
	internal struct TransitionTime : IEquatable<TransitionTime>, ISerializable, IDeserializationCallback
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000271")]
		private readonly DateTime _timeOfDay; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000272")]
		private readonly byte _month; //Field offset: 0x8
		[FieldOffset(Offset = "0x9")]
		[Token(Token = "0x4000273")]
		private readonly byte _week; //Field offset: 0x9
		[FieldOffset(Offset = "0xA")]
		[Token(Token = "0x4000274")]
		private readonly byte _day; //Field offset: 0xA
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000275")]
		private readonly DayOfWeek _dayOfWeek; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000276")]
		private readonly bool _isFixedDateRule; //Field offset: 0x10

		[Token(Token = "0x1700004A")]
		public int Day
		{
			[Address(RVA = "0x1FA80D0", Offset = "0x1FA74D0", Length = "0x5")]
			[Token(Token = "0x600038B")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700004B")]
		public DayOfWeek DayOfWeek
		{
			[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
			[Token(Token = "0x600038C")]
			 get { } //Length: 4
		}

		[Token(Token = "0x1700004C")]
		public bool IsFixedDateRule
		{
			[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
			[Token(Token = "0x600038D")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000048")]
		public int Month
		{
			[Address(RVA = "0xAEF450", Offset = "0xAEE850", Length = "0x5")]
			[Token(Token = "0x6000389")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000047")]
		public DateTime TimeOfDay
		{
			[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
			[Token(Token = "0x6000388")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000049")]
		public int Week
		{
			[Address(RVA = "0x1BB2060", Offset = "0x1BB1460", Length = "0x5")]
			[Token(Token = "0x600038A")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x1FA7D80", Offset = "0x1FA7180", Length = "0x349")]
		[Token(Token = "0x6000398")]
		private TransitionTime(SerializationInfo info, StreamingContext context) { }

		[Address(RVA = "0x1FA7CF0", Offset = "0x1FA70F0", Length = "0x81")]
		[Token(Token = "0x6000392")]
		private TransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule) { }

		[Address(RVA = "0x1FA74B0", Offset = "0x1FA68B0", Length = "0x7C")]
		[Token(Token = "0x6000393")]
		public static TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day) { }

		[Address(RVA = "0x1FA7530", Offset = "0x1FA6930", Length = "0x89")]
		[Token(Token = "0x6000394")]
		public static TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek) { }

		[Address(RVA = "0x1FA75C0", Offset = "0x1FA69C0", Length = "0x9B")]
		[Token(Token = "0x600038E")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x1FA7660", Offset = "0x1FA6A60", Length = "0xF6")]
		[Token(Token = "0x6000390")]
		public override bool Equals(TransitionTime other) { }

		[Address(RVA = "0x1FA80D0", Offset = "0x1FA74D0", Length = "0x5")]
		[Token(Token = "0x600038B")]
		public int get_Day() { }

		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[Token(Token = "0x600038C")]
		public DayOfWeek get_DayOfWeek() { }

		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x600038D")]
		public bool get_IsFixedDateRule() { }

		[Address(RVA = "0xAEF450", Offset = "0xAEE850", Length = "0x5")]
		[Token(Token = "0x6000389")]
		public int get_Month() { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6000388")]
		public DateTime get_TimeOfDay() { }

		[Address(RVA = "0x1BB2060", Offset = "0x1BB1460", Length = "0x5")]
		[Token(Token = "0x600038A")]
		public int get_Week() { }

		[Address(RVA = "0x1FA7760", Offset = "0x1FA6B60", Length = "0xE")]
		[Token(Token = "0x6000391")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x1FA80E0", Offset = "0x1FA74E0", Length = "0x2B")]
		[Token(Token = "0x600038F")]
		public static bool op_Inequality(TransitionTime t1, TransitionTime t2) { }

		[Address(RVA = "0x1FA7770", Offset = "0x1FA6B70", Length = "0x96")]
		[Token(Token = "0x6000396")]
		private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

		[Address(RVA = "0x1FA7810", Offset = "0x1FA6C10", Length = "0x16E")]
		[Token(Token = "0x6000397")]
		private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

		[Address(RVA = "0x1FA7980", Offset = "0x1FA6D80", Length = "0x369")]
		[Token(Token = "0x6000395")]
		private static void ValidateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek) { }

	}

	[Token(Token = "0x400024C")]
	private static Lazy<Boolean> lazyHaveRegistry; //Field offset: 0x0
	[Token(Token = "0x4000254")]
	private static readonly TimeZoneInfo s_utcTimeZone; //Field offset: 0x8
	[Token(Token = "0x4000255")]
	private static CachedData s_cachedData; //Field offset: 0x10
	[Token(Token = "0x4000256")]
	private static readonly DateTime s_maxDateOnly; //Field offset: 0x18
	[Token(Token = "0x4000257")]
	private static readonly DateTime s_minDateOnly; //Field offset: 0x20
	[Token(Token = "0x4000258")]
	private static readonly TimeSpan MaxOffset; //Field offset: 0x28
	[Token(Token = "0x4000259")]
	private static readonly TimeSpan MinOffset; //Field offset: 0x30
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400024D")]
	private readonly string _id; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400024E")]
	private readonly string _displayName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400024F")]
	private readonly string _standardDisplayName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000250")]
	private readonly string _daylightDisplayName; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000251")]
	private readonly TimeSpan _baseUtcOffset; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000252")]
	private readonly bool _supportsDaylightSavingTime; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000253")]
	private readonly AdjustmentRule[] _adjustmentRules; //Field offset: 0x40

	[Token(Token = "0x1700003B")]
	public TimeSpan BaseUtcOffset
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600033B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700003A")]
	public string DisplayName
	{
		[Address(RVA = "0x1FA2610", Offset = "0x1FA1A10", Length = "0x1B")]
		[Token(Token = "0x600033A")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000038")]
	private static bool HaveRegistry
	{
		[Address(RVA = "0x1FA7360", Offset = "0x1FA6760", Length = "0x6F")]
		[Token(Token = "0x600032E")]
		private get { } //Length: 111
	}

	[Token(Token = "0x17000039")]
	public string Id
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000339")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700003C")]
	public static TimeZoneInfo Local
	{
		[Address(RVA = "0x1FA73D0", Offset = "0x1FA67D0", Length = "0x84")]
		[Token(Token = "0x600034A")]
		 get { } //Length: 132
	}

	[Token(Token = "0x1700003D")]
	public static TimeZoneInfo Utc
	{
		[Address(RVA = "0x1FA7460", Offset = "0x1FA6860", Length = "0x4F")]
		[Token(Token = "0x600034C")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x1FA66C0", Offset = "0x1FA5AC0", Length = "0x29A")]
	[Token(Token = "0x600036C")]
	private static TimeZoneInfo() { }

	[Address(RVA = "0x1FA6E20", Offset = "0x1FA6220", Length = "0x2C")]
	[Token(Token = "0x600036D")]
	internal TimeZoneInfo() { }

	[Address(RVA = "0x1FA6F70", Offset = "0x1FA6370", Length = "0x3E6")]
	[Token(Token = "0x600031D")]
	private TimeZoneInfo(in TIME_ZONE_INFORMATION zone, bool dstDisabled) { }

	[Address(RVA = "0x1FA6960", Offset = "0x1FA5D60", Length = "0x4BA")]
	[Token(Token = "0x6000351")]
	private TimeZoneInfo(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1FA6E50", Offset = "0x1FA6250", Length = "0x113")]
	[Token(Token = "0x600034D")]
	private TimeZoneInfo(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) { }

	[Address(RVA = "0x1F9B360", Offset = "0x1F9A760", Length = "0x26")]
	[Token(Token = "0x600031E")]
	private static bool CheckDaylightSavingTimeNotSupported(in TIME_ZONE_INFORMATION timeZone) { }

	[Address(RVA = "0x1F9B390", Offset = "0x1F9A790", Length = "0x291")]
	[Token(Token = "0x600035E")]
	private static bool CheckIsDst(DateTime startTime, DateTime time, DateTime endTime, bool ignoreYearAdjustment, AdjustmentRule rule) { }

	[Address(RVA = "0x1F9B630", Offset = "0x1F9AA30", Length = "0x1DF")]
	[Token(Token = "0x6000354")]
	private int CompareAdjustmentRuleToDateTime(AdjustmentRule rule, AdjustmentRule previousRule, DateTime dateTime, DateTime dateOnly, bool dateTimeisUtc) { }

	[Address(RVA = "0x1F9B810", Offset = "0x1F9AC10", Length = "0x1C")]
	[Token(Token = "0x6000356")]
	private DateTime ConvertFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta) { }

	[Address(RVA = "0x1F9BAF0", Offset = "0x1F9AEF0", Length = "0x545")]
	[Token(Token = "0x6000342")]
	private static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags, CachedData cachedData) { }

	[Address(RVA = "0x1F9BA50", Offset = "0x1F9AE50", Length = "0x9A")]
	[Token(Token = "0x6000341")]
	internal static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags) { }

	[Address(RVA = "0x1F9B830", Offset = "0x1F9AC30", Length = "0x10D")]
	[Token(Token = "0x6000343")]
	public static DateTime ConvertTimeToUtc(DateTime dateTime) { }

	[Address(RVA = "0x1F9B940", Offset = "0x1F9AD40", Length = "0x10F")]
	[Token(Token = "0x6000344")]
	internal static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags) { }

	[Address(RVA = "0x1F9C040", Offset = "0x1F9B440", Length = "0x1C6")]
	[Token(Token = "0x6000357")]
	private DateTime ConvertToFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta, bool convertToUtc) { }

	[Address(RVA = "0x1F9C210", Offset = "0x1F9B610", Length = "0x1C")]
	[Token(Token = "0x6000355")]
	private DateTime ConvertToUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta) { }

	[Address(RVA = "0x1F9C230", Offset = "0x1F9B630", Length = "0x25F")]
	[Token(Token = "0x6000358")]
	private static DateTime ConvertUtcToTimeZone(long ticks, TimeZoneInfo destinationTimeZone, out bool isAmbiguousLocalDst) { }

	[Address(RVA = "0x1F9CA40", Offset = "0x1F9BE40", Length = "0x361")]
	[Token(Token = "0x600031F")]
	private static AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(in REG_TZI_FORMAT timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset) { }

	[Address(RVA = "0x1F9C490", Offset = "0x1F9B890", Length = "0x5A9")]
	[Token(Token = "0x6000333")]
	internal static AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(ref DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset) { }

	[Address(RVA = "0x1F9CDB0", Offset = "0x1F9C1B0", Length = "0x9A")]
	[Token(Token = "0x600034E")]
	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName) { }

	[Address(RVA = "0x1F9CE50", Offset = "0x1F9C250", Length = "0x160")]
	[Token(Token = "0x600032F")]
	internal static uint EnumDynamicTimeZoneInformation(uint dwIndex, out DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation) { }

	[Address(RVA = "0x1F9D010", Offset = "0x1F9C410", Length = "0x94")]
	[Token(Token = "0x6000346")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1F9CFB0", Offset = "0x1F9C3B0", Length = "0x54")]
	[Token(Token = "0x6000345")]
	public override bool Equals(TimeZoneInfo other) { }

	[Address(RVA = "0x1F9D0B0", Offset = "0x1F9C4B0", Length = "0x1BD")]
	[Token(Token = "0x6000320")]
	private static string FindIdFromTimeZoneInformation(in TIME_ZONE_INFORMATION timeZone, out bool dstDisabled) { }

	[Address(RVA = "0x1F9D270", Offset = "0x1F9C670", Length = "0x29E")]
	[Token(Token = "0x6000337")]
	internal static TimeZoneInfo FindSystemTimeZoneByIdWinRTFallback(string id) { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600033B")]
	public TimeSpan get_BaseUtcOffset() { }

	[Address(RVA = "0x1FA2610", Offset = "0x1FA1A10", Length = "0x1B")]
	[Token(Token = "0x600033A")]
	public string get_DisplayName() { }

	[Address(RVA = "0x1FA7360", Offset = "0x1FA6760", Length = "0x6F")]
	[Token(Token = "0x600032E")]
	private static bool get_HaveRegistry() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000339")]
	public string get_Id() { }

	[Address(RVA = "0x1FA73D0", Offset = "0x1FA67D0", Length = "0x84")]
	[Token(Token = "0x600034A")]
	public static TimeZoneInfo get_Local() { }

	[Address(RVA = "0x1FA7460", Offset = "0x1FA6860", Length = "0x4F")]
	[Token(Token = "0x600034C")]
	public static TimeZoneInfo get_Utc() { }

	[Address(RVA = "0x1F9D510", Offset = "0x1F9C910", Length = "0x21B")]
	[Token(Token = "0x6000353")]
	private AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, bool dateTimeisUtc, out Nullable<Int32>& ruleIndex) { }

	[Address(RVA = "0x1F9D730", Offset = "0x1F9CB30", Length = "0x1D")]
	[Token(Token = "0x6000352")]
	private AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, out Nullable<Int32>& ruleIndex) { }

	[Address(RVA = "0x1F9D750", Offset = "0x1F9CB50", Length = "0x398")]
	[Token(Token = "0x6000323")]
	internal static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out bool isAmbiguousLocalDst) { }

	[Address(RVA = "0x1F9DAF0", Offset = "0x1F9CEF0", Length = "0x80")]
	[Token(Token = "0x600035C")]
	private TimeSpan GetDaylightSavingsEndOffsetFromUtc(TimeSpan baseUtcOffset, AdjustmentRule rule) { }

	[Address(RVA = "0x1F9DB80", Offset = "0x1F9CF80", Length = "0xD7")]
	[Token(Token = "0x600035B")]
	private TimeSpan GetDaylightSavingsStartOffsetFromUtc(TimeSpan baseUtcOffset, AdjustmentRule rule, Nullable<Int32> ruleIndex) { }

	[Address(RVA = "0x1F9DC60", Offset = "0x1F9D060", Length = "0x17E")]
	[Token(Token = "0x6000359")]
	private DaylightTimeStruct GetDaylightTime(int year, AdjustmentRule rule, Nullable<Int32> ruleIndex) { }

	[Address(RVA = "0x1F9DF60", Offset = "0x1F9D360", Length = "0x153")]
	[Token(Token = "0x6000330")]
	internal static uint GetDynamicTimeZoneInformation(out DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation) { }

	[Address(RVA = "0x1F9DDE0", Offset = "0x1F9D1E0", Length = "0x17F")]
	[Token(Token = "0x6000331")]
	internal static uint GetDynamicTimeZoneInformationEffectiveYears(ref DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation, out uint FirstYear, out uint LastYear) { }

	[Address(RVA = "0x1F9E0C0", Offset = "0x1F9D4C0", Length = "0xA4")]
	[Token(Token = "0x6000347")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1F9E170", Offset = "0x1F9D570", Length = "0x372")]
	[Token(Token = "0x600035F")]
	private static bool GetIsAmbiguousTime(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime) { }

	[Address(RVA = "0x1F9EDC0", Offset = "0x1F9E1C0", Length = "0x48C")]
	[Token(Token = "0x600035A")]
	private static bool GetIsDaylightSavings(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime, TimeZoneInfoOptions flags) { }

	[Address(RVA = "0x1F9E4F0", Offset = "0x1F9D8F0", Length = "0x8C1")]
	[Token(Token = "0x600035D")]
	private static bool GetIsDaylightSavingsFromUtc(DateTime time, int year, TimeSpan utc, AdjustmentRule rule, Nullable<Int32> ruleIndex, out bool isAmbiguousLocalDst, TimeZoneInfo zone) { }

	[Address(RVA = "0x1F9F250", Offset = "0x1F9E650", Length = "0x37A")]
	[Token(Token = "0x6000360")]
	private static bool GetIsInvalidTime(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime) { }

	[Address(RVA = "0x1F9FEC0", Offset = "0x1F9F2C0", Length = "0x3BE")]
	[Token(Token = "0x600032B")]
	private static void GetLocalizedNamesByRegistryKey(RegistryKey key, out string displayName, out string standardName, out string daylightName) { }

	[Address(RVA = "0x1F9FAA0", Offset = "0x1F9EEA0", Length = "0x350")]
	[Token(Token = "0x6000321")]
	private static TimeZoneInfo GetLocalTimeZone(CachedData cachedData) { }

	[Address(RVA = "0x1F9F5D0", Offset = "0x1F9E9D0", Length = "0x11F")]
	[Token(Token = "0x6000322")]
	private static TimeZoneInfo GetLocalTimeZoneFromWin32Data(in TIME_ZONE_INFORMATION timeZoneInformation, bool dstDisabled) { }

	[Address(RVA = "0x1F9F6F0", Offset = "0x1F9EAF0", Length = "0x3A1")]
	[Token(Token = "0x6000336")]
	internal static TimeZoneInfo GetLocalTimeZoneInfoWinRTFallback() { }

	[Address(RVA = "0x1F9FE00", Offset = "0x1F9F200", Length = "0xB8")]
	[Token(Token = "0x600033E")]
	internal static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	[Address(RVA = "0x1FA0280", Offset = "0x1F9F680", Length = "0x10A")]
	[Token(Token = "0x600033C")]
	private AdjustmentRule GetPreviousAdjustmentRule(AdjustmentRule rule, Nullable<Int32> ruleIndex) { }

	[Address(RVA = "0x1FA0B10", Offset = "0x1F9FF10", Length = "0x36B")]
	[Token(Token = "0x6000348")]
	public static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones() { }

	[Address(RVA = "0x1FA0390", Offset = "0x1F9F790", Length = "0x77F")]
	[Token(Token = "0x6000338")]
	private static void GetSystemTimeZonesWinRTFallback(CachedData cachedData) { }

	[Address(RVA = "0x1FA0E80", Offset = "0x1FA0280", Length = "0x182")]
	[Token(Token = "0x6000332")]
	internal static bool GetTimeZoneInformationForYear(ushort wYear, ref DYNAMIC_TIME_ZONE_INFORMATION pdtzi, out TIME_ZONE_INFORMATION ptzi) { }

	[Address(RVA = "0x1FA1470", Offset = "0x1FA0870", Length = "0x86")]
	[Token(Token = "0x600033F")]
	internal TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	[Address(RVA = "0x1FA1BC0", Offset = "0x1FA0FC0", Length = "0x7C")]
	[Token(Token = "0x600033D")]
	public TimeSpan GetUtcOffset(DateTime dateTime) { }

	[Address(RVA = "0x1FA19B0", Offset = "0x1FA0DB0", Length = "0x203")]
	[Token(Token = "0x6000361")]
	private static TimeSpan GetUtcOffset(DateTime time, TimeZoneInfo zone, TimeZoneInfoOptions flags) { }

	[Address(RVA = "0x1FA1500", Offset = "0x1FA0900", Length = "0xCE")]
	[Token(Token = "0x600036A")]
	private static TimeSpan GetUtcOffset(TimeSpan baseUtcOffset, AdjustmentRule adjustmentRule) { }

	[Address(RVA = "0x1FA15D0", Offset = "0x1FA09D0", Length = "0x3D4")]
	[Token(Token = "0x6000340")]
	private TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags, CachedData cachedData) { }

	[Address(RVA = "0x1FA1140", Offset = "0x1FA0540", Length = "0x325")]
	[Token(Token = "0x6000364")]
	internal static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst) { }

	[Address(RVA = "0x1FA1010", Offset = "0x1FA0410", Length = "0x7A")]
	[Token(Token = "0x6000363")]
	private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings) { }

	[Address(RVA = "0x1FA1090", Offset = "0x1FA0490", Length = "0xA5")]
	[Token(Token = "0x6000362")]
	private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone) { }

	[Address(RVA = "0x1FA1C40", Offset = "0x1FA1040", Length = "0x318")]
	[Token(Token = "0x6000349")]
	public bool HasSameRules(TimeZoneInfo other) { }

	[Address(RVA = "0x1FA1F60", Offset = "0x1FA1360", Length = "0x10C")]
	[Token(Token = "0x600036B")]
	private static bool IsValidAdjustmentRuleOffest(TimeSpan baseUtcOffset, AdjustmentRule adjustmentRule) { }

	[Address(RVA = "0x1FA2220", Offset = "0x1FA1620", Length = "0x86")]
	[Token(Token = "0x600031B")]
	private static void PopulateAllSystemTimeZones(CachedData cachedData) { }

	[Address(RVA = "0x1FA2070", Offset = "0x1FA1470", Length = "0x1AB")]
	[Token(Token = "0x600031C")]
	private static void PopulateAllSystemTimeZonesFromRegistry(CachedData cachedData) { }

	[Address(RVA = "0x1FA22B0", Offset = "0x1FA16B0", Length = "0x1B8")]
	[Token(Token = "0x600034F")]
	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[Address(RVA = "0x1FA2470", Offset = "0x1FA1870", Length = "0x190")]
	[Token(Token = "0x6000350")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1FA2610", Offset = "0x1FA1A10", Length = "0x1B")]
	[Token(Token = "0x600034B")]
	public virtual string ToString() { }

	[Address(RVA = "0x1FA34D0", Offset = "0x1FA28D0", Length = "0x1E4")]
	[Token(Token = "0x6000324")]
	private static bool TransitionTimeFromTimeZoneInformation(in REG_TZI_FORMAT timeZoneInformation, out TransitionTime transitionTime, bool readStartDate) { }

	[Address(RVA = "0x1FA2630", Offset = "0x1FA1A30", Length = "0xE96")]
	[Token(Token = "0x6000334")]
	private static bool TransitionTimeFromTimeZoneInformation(DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, out TransitionTime transitionTime, bool readStartDate) { }

	[Address(RVA = "0x1FA36C0", Offset = "0x1FA2AC0", Length = "0x2CE")]
	[Token(Token = "0x6000365")]
	internal static DateTime TransitionTimeToDateTime(int year, TransitionTime transitionTime) { }

	[Address(RVA = "0x1FA3990", Offset = "0x1FA2D90", Length = "0x38")]
	[Token(Token = "0x6000327")]
	private static bool TryCompareStandardDate(in TIME_ZONE_INFORMATION timeZone, in REG_TZI_FORMAT registryTimeZoneInfo) { }

	[Address(RVA = "0x1FA39D0", Offset = "0x1FA2DD0", Length = "0x49D")]
	[Token(Token = "0x6000328")]
	private static bool TryCompareTimeZoneInformationToRegistry(in TIME_ZONE_INFORMATION timeZone, string id, out bool dstDisabled) { }

	[Address(RVA = "0x1FA3E70", Offset = "0x1FA3270", Length = "0xA23")]
	[Token(Token = "0x6000325")]
	private static bool TryCreateAdjustmentRules(string id, in REG_TZI_FORMAT defaultTimeZoneInformation, out AdjustmentRule[] rules, out Exception e, int defaultBaseUtcOffset) { }

	[Address(RVA = "0x1FA48A0", Offset = "0x1FA3CA0", Length = "0x96A")]
	[Token(Token = "0x6000335")]
	internal static TimeZoneInfo TryCreateTimeZone(DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation) { }

	[Address(RVA = "0x1FA5210", Offset = "0x1FA4610", Length = "0x278")]
	[Token(Token = "0x6000329")]
	private static string TryGetLocalizedNameByMuiNativeResource(string resource) { }

	[Address(RVA = "0x1FA5490", Offset = "0x1FA4890", Length = "0x14B")]
	[Token(Token = "0x600032A")]
	private static string TryGetLocalizedNameByNativeResource(string filePath, int resource) { }

	[Address(RVA = "0x1FA5FC0", Offset = "0x1FA53C0", Length = "0x20D")]
	[Token(Token = "0x6000366")]
	private static TimeZoneInfoResult TryGetTimeZone(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e, CachedData cachedData, bool alwaysFallbackToLocalMachine = false) { }

	[Address(RVA = "0x1FA55E0", Offset = "0x1FA49E0", Length = "0xD6")]
	[Token(Token = "0x6000326")]
	private static bool TryGetTimeZoneEntryFromRegistry(RegistryKey key, string name, out REG_TZI_FORMAT dtzi) { }

	[Address(RVA = "0x1FA5A40", Offset = "0x1FA4E40", Length = "0xD9")]
	[Token(Token = "0x600032C")]
	private static TimeZoneInfoResult TryGetTimeZoneFromLocalMachine(string id, out TimeZoneInfo value, out Exception e) { }

	[Address(RVA = "0x1FA56C0", Offset = "0x1FA4AC0", Length = "0x372")]
	[Token(Token = "0x6000367")]
	private static TimeZoneInfoResult TryGetTimeZoneFromLocalMachine(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e, CachedData cachedData) { }

	[Address(RVA = "0x1FA5B20", Offset = "0x1FA4F20", Length = "0x49C")]
	[Token(Token = "0x600032D")]
	private static TimeZoneInfoResult TryGetTimeZoneFromLocalRegistry(string id, out TimeZoneInfo value, out Exception e) { }

	[Address(RVA = "0x1FA61D0", Offset = "0x1FA55D0", Length = "0xEA")]
	[Token(Token = "0x6000369")]
	internal static bool UtcOffsetOutOfRange(TimeSpan offset) { }

	[Address(RVA = "0x1FA62C0", Offset = "0x1FA56C0", Length = "0x3F6")]
	[Token(Token = "0x6000368")]
	private static void ValidateTimeZoneInfo(string id, TimeSpan baseUtcOffset, AdjustmentRule[] adjustmentRules, out bool adjustmentRulesSupportDst) { }

}


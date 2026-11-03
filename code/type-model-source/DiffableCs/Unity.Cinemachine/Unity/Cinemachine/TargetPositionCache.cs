namespace Unity.Cinemachine;

[Token(Token = "0x20000ED")]
public class TargetPositionCache
{
	[Token(Token = "0x20000EF")]
	private class CacheCurve
	{
		[Token(Token = "0x20000F0")]
		internal struct Item
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000388")]
			public Vector3 Pos; //Field offset: 0x0
			[FieldOffset(Offset = "0xC")]
			[Token(Token = "0x4000389")]
			public Quaternion Rot; //Field offset: 0xC

			[Token(Token = "0x170000F6")]
			public static Item Empty
			{
				[Address(RVA = "0x28643D0", Offset = "0x28637D0", Length = "0x51")]
				[Token(Token = "0x6000471")]
				 get { } //Length: 81
			}

			[Address(RVA = "0x28643D0", Offset = "0x28637D0", Length = "0x51")]
			[Token(Token = "0x6000471")]
			public static Item get_Empty() { }

			[Address(RVA = "0x28642C0", Offset = "0x28636C0", Length = "0x10B")]
			[Token(Token = "0x6000470")]
			public static Item Lerp(Item a, Item b, float t) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000385")]
		public float StartTime; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000386")]
		public float StepSize; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000387")]
		private List<Item> m_Cache; //Field offset: 0x18

		[Token(Token = "0x170000F5")]
		public int Count
		{
			[Address(RVA = "0x284F0D0", Offset = "0x284E4D0", Length = "0x3C")]
			[Token(Token = "0x600046B")]
			 get { } //Length: 60
		}

		[Address(RVA = "0x284EFB0", Offset = "0x284E3B0", Length = "0x113")]
		[Token(Token = "0x600046C")]
		public CacheCurve(float startTime, float endTime, float stepSize) { }

		[Address(RVA = "0x284EC00", Offset = "0x284E000", Length = "0xDB")]
		[Token(Token = "0x600046D")]
		public void Add(Item item) { }

		[Address(RVA = "0x284E7F0", Offset = "0x284DBF0", Length = "0x402")]
		[Token(Token = "0x600046E")]
		public void AddUntil(Item item, float time, bool isCut) { }

		[Address(RVA = "0x284ECE0", Offset = "0x284E0E0", Length = "0x2C6")]
		[Token(Token = "0x600046F")]
		public Item Evaluate(float time) { }

		[Address(RVA = "0x284F0D0", Offset = "0x284E4D0", Length = "0x3C")]
		[Token(Token = "0x600046B")]
		public int get_Count() { }

	}

	[Token(Token = "0x20000F1")]
	private class CacheEntry
	{
		[Token(Token = "0x20000F2")]
		private struct RecordingItem
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400038C")]
			public float Time; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x400038D")]
			public bool IsCut; //Field offset: 0x4
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x400038E")]
			public Item Item; //Field offset: 0x8

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400038A")]
		public CacheCurve Curve; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400038B")]
		private List<RecordingItem> RawItems; //Field offset: 0x18

		[Address(RVA = "0x284F790", Offset = "0x284EB90", Length = "0x77")]
		[Token(Token = "0x6000474")]
		public CacheEntry() { }

		[Address(RVA = "0x284F110", Offset = "0x284E510", Length = "0x2FD")]
		[Token(Token = "0x6000472")]
		public void AddRawItem(float time, bool isCut, Transform target) { }

		[Address(RVA = "0x284F410", Offset = "0x284E810", Length = "0x37A")]
		[Token(Token = "0x6000473")]
		public void CreateCurves() { }

	}

	[Token(Token = "0x20000EE")]
	public enum Mode : int
	{
		Disabled = 0,
		Record = 1,
		Playback = 2,
	}

	[Token(Token = "0x20000F3")]
	public struct TimeRange
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400038F")]
		public float Start; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000390")]
		public float End; //Field offset: 0x4

		[Token(Token = "0x170000F8")]
		public static TimeRange Empty
		{
			[Address(RVA = "0x2865A10", Offset = "0x2864E10", Length = "0x19")]
			[Token(Token = "0x6000477")]
			 get { } //Length: 25
		}

		[Token(Token = "0x170000F7")]
		public bool IsEmpty
		{
			[Address(RVA = "0x2865A30", Offset = "0x2864E30", Length = "0xC")]
			[Token(Token = "0x6000475")]
			 get { } //Length: 12
		}

		[Address(RVA = "0x28659D0", Offset = "0x2864DD0", Length = "0x14")]
		[Token(Token = "0x6000476")]
		public bool Contains(float time) { }

		[Address(RVA = "0x2865A10", Offset = "0x2864E10", Length = "0x19")]
		[Token(Token = "0x6000477")]
		public static TimeRange get_Empty() { }

		[Address(RVA = "0x2865A30", Offset = "0x2864E30", Length = "0xC")]
		[Token(Token = "0x6000475")]
		public bool get_IsEmpty() { }

		[Address(RVA = "0x28659F0", Offset = "0x2864DF0", Length = "0x1D")]
		[Token(Token = "0x6000478")]
		public void Include(float time) { }

	}

	[Token(Token = "0x4000378")]
	internal static bool UseCache; //Field offset: 0x0
	[Token(Token = "0x4000379")]
	internal const float CacheStepSize = 0.016666668; //Field offset: 0x0
	[Token(Token = "0x4000380")]
	private const float kWraparoundSlush = 0.1; //Field offset: 0x0
	[Token(Token = "0x400037A")]
	private static Mode m_CacheMode; //Field offset: 0x4
	[Token(Token = "0x400037B")]
	internal static float CurrentTime; //Field offset: 0x8
	[Token(Token = "0x400037C")]
	internal static int CurrentFrame; //Field offset: 0xC
	[Token(Token = "0x400037D")]
	internal static bool IsCameraCut; //Field offset: 0x10
	[Token(Token = "0x400037E")]
	private static Dictionary<Transform, CacheEntry> m_Cache; //Field offset: 0x18
	[Token(Token = "0x400037F")]
	private static TimeRange m_CacheTimeRange; //Field offset: 0x20

	[Token(Token = "0x170000EF")]
	internal static Mode CacheMode
	{
		[Address(RVA = "0x28655D0", Offset = "0x28649D0", Length = "0x36")]
		[Token(Token = "0x600045F")]
		internal get { } //Length: 54
		[Address(RVA = "0x28657D0", Offset = "0x2864BD0", Length = "0x1F4")]
		[Token(Token = "0x6000460")]
		internal set { } //Length: 500
	}

	[Token(Token = "0x170000F3")]
	internal static TimeRange CacheTimeRange
	{
		[Address(RVA = "0x2865610", Offset = "0x2864A10", Length = "0x45")]
		[Token(Token = "0x6000464")]
		internal get { } //Length: 69
	}

	[Token(Token = "0x170000F1")]
	internal static bool CurrentPlaybackTimeValid
	{
		[Address(RVA = "0x2865660", Offset = "0x2864A60", Length = "0x85")]
		[Token(Token = "0x6000462")]
		internal get { } //Length: 133
	}

	[Token(Token = "0x170000F4")]
	internal static bool HasCurrentTime
	{
		[Address(RVA = "0x28656F0", Offset = "0x2864AF0", Length = "0x50")]
		[Token(Token = "0x6000465")]
		internal get { } //Length: 80
	}

	[Token(Token = "0x170000F2")]
	internal static bool IsEmpty
	{
		[Address(RVA = "0x2865740", Offset = "0x2864B40", Length = "0x3F")]
		[Token(Token = "0x6000463")]
		internal get { } //Length: 63
	}

	[Token(Token = "0x170000F0")]
	internal static bool IsRecording
	{
		[Address(RVA = "0x2865780", Offset = "0x2864B80", Length = "0x46")]
		[Token(Token = "0x6000461")]
		internal get { } //Length: 70
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600046A")]
	public TargetPositionCache() { }

	[Address(RVA = "0x2864CA0", Offset = "0x28640A0", Length = "0x11C")]
	[Token(Token = "0x6000466")]
	internal static void ClearCache() { }

	[Address(RVA = "0x2864DC0", Offset = "0x28641C0", Length = "0x193")]
	[Token(Token = "0x6000467")]
	private static void CreatePlaybackCurves() { }

	[Address(RVA = "0x28655D0", Offset = "0x28649D0", Length = "0x36")]
	[Token(Token = "0x600045F")]
	internal static Mode get_CacheMode() { }

	[Address(RVA = "0x2865610", Offset = "0x2864A10", Length = "0x45")]
	[Token(Token = "0x6000464")]
	internal static TimeRange get_CacheTimeRange() { }

	[Address(RVA = "0x2865660", Offset = "0x2864A60", Length = "0x85")]
	[Token(Token = "0x6000462")]
	internal static bool get_CurrentPlaybackTimeValid() { }

	[Address(RVA = "0x28656F0", Offset = "0x2864AF0", Length = "0x50")]
	[Token(Token = "0x6000465")]
	internal static bool get_HasCurrentTime() { }

	[Address(RVA = "0x2865740", Offset = "0x2864B40", Length = "0x3F")]
	[Token(Token = "0x6000463")]
	internal static bool get_IsEmpty() { }

	[Address(RVA = "0x2865780", Offset = "0x2864B80", Length = "0x46")]
	[Token(Token = "0x6000461")]
	internal static bool get_IsRecording() { }

	[Address(RVA = "0x2864F60", Offset = "0x2864360", Length = "0x318")]
	[Token(Token = "0x6000468")]
	public static Vector3 GetTargetPosition(Transform target) { }

	[Address(RVA = "0x2865280", Offset = "0x2864680", Length = "0x345")]
	[Token(Token = "0x6000469")]
	public static Quaternion GetTargetRotation(Transform target) { }

	[Address(RVA = "0x28657D0", Offset = "0x2864BD0", Length = "0x1F4")]
	[Token(Token = "0x6000460")]
	internal static void set_CacheMode(Mode value) { }

}


namespace UnityEngine.Timeline;

[Token(Token = "0x2000038")]
internal struct DiscreteTime : IComparable
{
	[Token(Token = "0x400010B")]
	private const double k_Tick = 1E-12; //Field offset: 0x0
	[Token(Token = "0x400010C")]
	public static readonly DiscreteTime kMaxTime; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400010D")]
	private readonly long m_DiscreteTime; //Field offset: 0x0

	[Token(Token = "0x1700009C")]
	public static double tickValue
	{
		[Address(RVA = "0x2F2E2F0", Offset = "0x2F2D6F0", Length = "0x9")]
		[Token(Token = "0x6000213")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2F2E0F0", Offset = "0x2F2D4F0", Length = "0x40")]
	[Token(Token = "0x600023C")]
	private static DiscreteTime() { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000214")]
	public DiscreteTime(DiscreteTime time) { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000215")]
	private DiscreteTime(long time) { }

	[Address(RVA = "0x2F2E290", Offset = "0x2F2D690", Length = "0x5A")]
	[Token(Token = "0x6000216")]
	public DiscreteTime(double time) { }

	[Address(RVA = "0x2F2E1A0", Offset = "0x2F2D5A0", Length = "0x5A")]
	[Token(Token = "0x6000217")]
	public DiscreteTime(float time) { }

	[Address(RVA = "0x2F2E200", Offset = "0x2F2D600", Length = "0x8E")]
	[Token(Token = "0x6000218")]
	public DiscreteTime(int time) { }

	[Address(RVA = "0x2F2E130", Offset = "0x2F2D530", Length = "0x6E")]
	[Token(Token = "0x6000219")]
	public DiscreteTime(int frame, double fps) { }

	[Address(RVA = "0x2F2DB90", Offset = "0x2F2CF90", Length = "0x88")]
	[Token(Token = "0x600021E")]
	public override int CompareTo(object obj) { }

	[Address(RVA = "0x2F2DC20", Offset = "0x2F2D020", Length = "0x88")]
	[Token(Token = "0x6000221")]
	private static long DoubleToDiscreteTime(double time) { }

	[Address(RVA = "0x2F2DCB0", Offset = "0x2F2D0B0", Length = "0x99")]
	[Token(Token = "0x6000220")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[Token(Token = "0x600021F")]
	public bool Equals(DiscreteTime other) { }

	[Address(RVA = "0x2F2DD50", Offset = "0x2F2D150", Length = "0x86")]
	[Token(Token = "0x6000222")]
	private static long FloatToDiscreteTime(float time) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x600021D")]
	public static DiscreteTime FromTicks(long ticks) { }

	[Address(RVA = "0x2F2E2F0", Offset = "0x2F2D6F0", Length = "0x9")]
	[Token(Token = "0x6000213")]
	public static double get_tickValue() { }

	[Address(RVA = "0x63C630", Offset = "0x63BA30", Length = "0x7")]
	[Token(Token = "0x6000236")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2F2DDE0", Offset = "0x2F2D1E0", Length = "0x50")]
	[Token(Token = "0x600023B")]
	public static long GetNearestTick(double time) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x600021C")]
	public long GetTick() { }

	[Address(RVA = "0x2F2DE30", Offset = "0x2F2D230", Length = "0x4D")]
	[Token(Token = "0x6000223")]
	private static long IntToDiscreteTime(int time) { }

	[Address(RVA = "0x2F2DE80", Offset = "0x2F2D280", Length = "0x59")]
	[Token(Token = "0x6000238")]
	public static DiscreteTime Max(DiscreteTime lhs, DiscreteTime rhs) { }

	[Address(RVA = "0x2F2DEE0", Offset = "0x2F2D2E0", Length = "0x59")]
	[Token(Token = "0x6000237")]
	public static DiscreteTime Min(DiscreteTime lhs, DiscreteTime rhs) { }

	[Address(RVA = "0x2F2DF40", Offset = "0x2F2D340", Length = "0x7")]
	[Token(Token = "0x600021B")]
	public DiscreteTime OneTickAfter() { }

	[Address(RVA = "0x2F2DF50", Offset = "0x2F2D350", Length = "0x7")]
	[Token(Token = "0x600021A")]
	public DiscreteTime OneTickBefore() { }

	[Address(RVA = "0x9D74C0", Offset = "0x9D68C0", Length = "0x5")]
	[Token(Token = "0x6000233")]
	public static DiscreteTime op_Addition(DiscreteTime lhs, DiscreteTime rhs) { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x600022D")]
	public static bool op_Equality(DiscreteTime lhs, DiscreteTime rhs) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x600022C")]
	public static DiscreteTime op_Explicit(long time) { }

	[Address(RVA = "0x2F2E300", Offset = "0x2F2D700", Length = "0x85")]
	[Token(Token = "0x6000227")]
	public static float op_Explicit(DiscreteTime b) { }

	[Address(RVA = "0x2F2E3E0", Offset = "0x2F2D7E0", Length = "0x50")]
	[Token(Token = "0x600022A")]
	public static DiscreteTime op_Explicit(float time) { }

	[Address(RVA = "0x2F2E430", Offset = "0x2F2D830", Length = "0x50")]
	[Token(Token = "0x6000229")]
	public static DiscreteTime op_Explicit(double time) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000228")]
	public static long op_Explicit(DiscreteTime b) { }

	[Address(RVA = "0x2F2E390", Offset = "0x2F2D790", Length = "0x50")]
	[Token(Token = "0x6000226")]
	public static double op_Explicit(DiscreteTime b) { }

	[Address(RVA = "0x204E850", Offset = "0x204DC50", Length = "0x7")]
	[Token(Token = "0x600022F")]
	public static bool op_GreaterThan(DiscreteTime lhs, DiscreteTime rhs) { }

	[Address(RVA = "0x204E840", Offset = "0x204DC40", Length = "0x7")]
	[Token(Token = "0x6000232")]
	public static bool op_GreaterThanOrEqual(DiscreteTime lhs, DiscreteTime rhs) { }

	[Address(RVA = "0x2F2E480", Offset = "0x2F2D880", Length = "0x7E")]
	[Token(Token = "0x600022B")]
	public static DiscreteTime op_Implicit(int time) { }

	[Address(RVA = "0x2F2E500", Offset = "0x2F2D900", Length = "0x52")]
	[Token(Token = "0x600022E")]
	public static bool op_Inequality(DiscreteTime lhs, DiscreteTime rhs) { }

	[Address(RVA = "0x204E870", Offset = "0x204DC70", Length = "0x7")]
	[Token(Token = "0x6000230")]
	public static bool op_LessThan(DiscreteTime lhs, DiscreteTime rhs) { }

	[Address(RVA = "0x204E860", Offset = "0x204DC60", Length = "0x7")]
	[Token(Token = "0x6000231")]
	public static bool op_LessThanOrEqual(DiscreteTime lhs, DiscreteTime rhs) { }

	[Address(RVA = "0x9DCE10", Offset = "0x9DC210", Length = "0x7")]
	[Token(Token = "0x6000234")]
	public static DiscreteTime op_Subtraction(DiscreteTime lhs, DiscreteTime rhs) { }

	[Address(RVA = "0x2F2E000", Offset = "0x2F2D400", Length = "0x61")]
	[Token(Token = "0x6000239")]
	public static double SnapToNearestTick(double time) { }

	[Address(RVA = "0x2F2DF60", Offset = "0x2F2D360", Length = "0x9C")]
	[Token(Token = "0x600023A")]
	public static float SnapToNearestTick(float time) { }

	[Address(RVA = "0x2F2E070", Offset = "0x2F2D470", Length = "0x11")]
	[Token(Token = "0x6000224")]
	private static double ToDouble(long time) { }

	[Address(RVA = "0x2F2E090", Offset = "0x2F2D490", Length = "0x54")]
	[Token(Token = "0x6000225")]
	private static float ToFloat(long time) { }

	[Address(RVA = "0x63C640", Offset = "0x63BA40", Length = "0x7")]
	[Token(Token = "0x6000235")]
	public virtual string ToString() { }

}


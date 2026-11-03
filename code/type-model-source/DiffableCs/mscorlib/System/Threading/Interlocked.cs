namespace System.Threading;

[Token(Token = "0x2000243")]
public static class Interlocked
{

	[Address(RVA = "0x20B1EC0", Offset = "0x20B12C0", Length = "0x5")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x600135D")]
	public static int Add(ref int location1, int value) { }

	[Address(RVA = "0x20B1ED0", Offset = "0x20B12D0", Length = "0x5")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x600135E")]
	public static long Add(ref long location1, long value) { }

	[Address(RVA = "0x20B1F10", Offset = "0x20B1310", Length = "0x5")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001348")]
	public static int CompareExchange(ref int location1, int value, int comparand) { }

	[Address(RVA = "0x20B1EF0", Offset = "0x20B12F0", Length = "0x5")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001349")]
	internal static int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded) { }

	[Address(RVA = "0x20B1EE0", Offset = "0x20B12E0", Length = "0x5")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x600134A")]
	private static void CompareExchange(ref object location1, ref object value, ref object comparand, ref object result) { }

	[Address(RVA = "0x20B1F20", Offset = "0x20B1320", Length = "0x35")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x600134B")]
	public static object CompareExchange(ref object location1, object value, object comparand) { }

	[Address(RVA = "0x20B1F60", Offset = "0x20B1360", Length = "0x5")]
	[Token(Token = "0x600134C")]
	public static float CompareExchange(ref float location1, float value, float comparand) { }

	[Address(RVA = "0x20B1F00", Offset = "0x20B1300", Length = "0x5")]
	[Token(Token = "0x6001354")]
	public static long CompareExchange(ref long location1, long value, long comparand) { }

	[Address(RVA = "0x20B1F00", Offset = "0x20B1300", Length = "0x5")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001355")]
	public static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand) { }

	[Address(RVA = "0x20B1F70", Offset = "0x20B1370", Length = "0x5")]
	[Token(Token = "0x6001356")]
	public static double CompareExchange(ref double location1, double value, double comparand) { }

	[ComVisible(False)]
	[Intrinsic]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001357")]
	public static T CompareExchange(ref T location1, T value, T comparand) { }

	[Address(RVA = "0x20B1F80", Offset = "0x20B1380", Length = "0x5")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x600134D")]
	public static int Decrement(ref int location) { }

	[ComVisible(False)]
	[Intrinsic]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x600135B")]
	public static T Exchange(ref T location1, T value) { }

	[Address(RVA = "0x20B2000", Offset = "0x20B1400", Length = "0x5")]
	[Token(Token = "0x600135A")]
	public static double Exchange(ref double location1, double value) { }

	[Address(RVA = "0x20B1FA0", Offset = "0x20B13A0", Length = "0x5")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001359")]
	public static IntPtr Exchange(ref IntPtr location1, IntPtr value) { }

	[Address(RVA = "0x20B1FA0", Offset = "0x20B13A0", Length = "0x5")]
	[Token(Token = "0x6001358")]
	public static long Exchange(ref long location1, long value) { }

	[Address(RVA = "0x20B1FF0", Offset = "0x20B13F0", Length = "0x5")]
	[Token(Token = "0x6001353")]
	public static float Exchange(ref float location1, float value) { }

	[Address(RVA = "0x20B1F90", Offset = "0x20B1390", Length = "0x5")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001351")]
	private static void Exchange(ref object location1, ref object value, ref object result) { }

	[Address(RVA = "0x20B1FB0", Offset = "0x20B13B0", Length = "0x5")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001350")]
	public static int Exchange(ref int location1, int value) { }

	[Address(RVA = "0x20B1FC0", Offset = "0x20B13C0", Length = "0x2B")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001352")]
	public static object Exchange(ref object location1, object value) { }

	[Address(RVA = "0x20B2010", Offset = "0x20B1410", Length = "0x5")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x600134F")]
	public static long Increment(ref long location) { }

	[Address(RVA = "0x20B2020", Offset = "0x20B1420", Length = "0x5")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x600134E")]
	public static int Increment(ref int location) { }

	[Address(RVA = "0x20B2030", Offset = "0x20B1430", Length = "0x5")]
	[Token(Token = "0x600135F")]
	public static void MemoryBarrier() { }

	[Address(RVA = "0x20B2040", Offset = "0x20B1440", Length = "0x5")]
	[Token(Token = "0x600135C")]
	public static long Read(ref long location) { }

}


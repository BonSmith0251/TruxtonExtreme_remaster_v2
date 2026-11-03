namespace Unity.Burst;

[Token(Token = "0x200001A")]
public static class BurstRuntime
{
	[Token(Token = "0x200001B")]
	private struct HashCode32
	{
		[Token(Token = "0x40000D0")]
		public static readonly int Value; //Field offset: 0x0

		[Address(RVA = "0x1C420E0", Offset = "0x1C414E0", Length = "0xBD")]
		[Token(Token = "0x6000090")]
		private static HashCode32`1() { }

	}

	[Token(Token = "0x200001C")]
	private struct HashCode64
	{
		[Token(Token = "0x40000D1")]
		public static readonly long Value; //Field offset: 0x0

		[Address(RVA = "0x1C421A0", Offset = "0x1C415A0", Length = "0xBF")]
		[Token(Token = "0x6000091")]
		private static HashCode64`1() { }

	}

	[Token(Token = "0x200001D")]
	public class PreserveAttribute : Attribute
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000092")]
		public PreserveAttribute() { }

	}


	[Address(RVA = "0x79B390", Offset = "0x79A790", Length = "0x73")]
	[Token(Token = "0x6000083")]
	public static int GetHashCode32() { }

	[Address(RVA = "0x27BEB90", Offset = "0x27BDF90", Length = "0x80")]
	[Token(Token = "0x6000084")]
	public static int GetHashCode32(Type type) { }

	[Address(RVA = "0x79B410", Offset = "0x79A810", Length = "0x75")]
	[Token(Token = "0x6000085")]
	public static long GetHashCode64() { }

	[Address(RVA = "0x27BEC20", Offset = "0x27BE020", Length = "0x9D")]
	[Token(Token = "0x6000086")]
	public static long GetHashCode64(Type type) { }

	[Address(RVA = "0x27BECC0", Offset = "0x27BE0C0", Length = "0x4E")]
	[Token(Token = "0x600008F")]
	public static Byte* GetUTF8LiteralPointer(string str, out int byteCount) { }

	[Address(RVA = "0x27BED10", Offset = "0x27BE110", Length = "0x68")]
	[Token(Token = "0x6000087")]
	internal static int HashStringWithFNV1A32(string text) { }

	[Address(RVA = "0x27BED80", Offset = "0x27BE180", Length = "0x81")]
	[Token(Token = "0x6000088")]
	internal static long HashStringWithFNV1A64(string text) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600008C")]
	internal static void Initialize() { }

	[Address(RVA = "0x27BEF50", Offset = "0x27BE350", Length = "0x1C6")]
	[Token(Token = "0x6000089")]
	public static bool LoadAdditionalLibrary(string pathToLibBurstGenerated) { }

	[Address(RVA = "0x27BEE10", Offset = "0x27BE210", Length = "0x13F")]
	[Token(Token = "0x600008A")]
	internal static bool LoadAdditionalLibraryInternal(string pathToLibBurstGenerated) { }

	[Address(RVA = "0x27BF120", Offset = "0x27BE520", Length = "0x24")]
	[Preserve]
	[Token(Token = "0x600008E")]
	internal static void Log(Byte* message, int logType, Byte* fileName, int lineNumber) { }

	[Address(RVA = "0x27BF150", Offset = "0x27BE550", Length = "0xCE")]
	[Preserve]
	[Token(Token = "0x600008D")]
	internal static void PreventRequiredAttributeStrip() { }

	[Address(RVA = "0x27BF220", Offset = "0x27BE620", Length = "0x24")]
	[Preserve]
	[Token(Token = "0x600008B")]
	internal static void RuntimeLog(Byte* message, int logType, Byte* fileName, int lineNumber) { }

}


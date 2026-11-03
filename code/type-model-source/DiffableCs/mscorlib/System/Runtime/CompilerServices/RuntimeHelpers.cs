namespace System.Runtime.CompilerServices;

[Token(Token = "0x20004B4")]
public static class RuntimeHelpers
{

	[Token(Token = "0x17000415")]
	public static int OffsetToStringData
	{
		[Address(RVA = "0x1F40620", Offset = "0x1F3FA20", Length = "0x5")]
		[Token(Token = "0x6002182")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1F404B0", Offset = "0x1F3F8B0", Length = "0x54")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6002188")]
	public static void EnsureSufficientExecutionStack() { }

	[Address(RVA = "0x1F40620", Offset = "0x1F3FA20", Length = "0x5")]
	[Token(Token = "0x6002182")]
	public static int get_OffsetToStringData() { }

	[Address(RVA = "0x1E9E150", Offset = "0x1E9D550", Length = "0x7")]
	[Token(Token = "0x6002183")]
	public static int GetHashCode(object o) { }

	[Address(RVA = "0x1F40510", Offset = "0x1F3F910", Length = "0x5")]
	[Token(Token = "0x6002184")]
	public static object GetObjectValue(object obj) { }

	[Address(RVA = "0x1F40580", Offset = "0x1F3F980", Length = "0x5")]
	[Token(Token = "0x6002180")]
	private static void InitializeArray(Array array, IntPtr fldHandle) { }

	[Address(RVA = "0x1F40520", Offset = "0x1F3F920", Length = "0x59")]
	[Token(Token = "0x6002181")]
	public static void InitializeArray(Array array, RuntimeFieldHandle fldHandle) { }

	[Address(RVA = "0x8EF760", Offset = "0x8EEB60", Length = "0x1F5")]
	[Token(Token = "0x600218B")]
	public static bool IsReferenceOrContainsReferences() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x600218A")]
	public static void PrepareConstrainedRegions() { }

	[Address(RVA = "0x1F40590", Offset = "0x1F3F990", Length = "0x5")]
	[Token(Token = "0x6002185")]
	private static void RunClassConstructor(IntPtr type) { }

	[Address(RVA = "0x1F405A0", Offset = "0x1F3F9A0", Length = "0x80")]
	[Token(Token = "0x6002186")]
	public static void RunClassConstructor(RuntimeTypeHandle type) { }

	[Address(RVA = "0x1F35DE0", Offset = "0x1F351E0", Length = "0x5")]
	[Token(Token = "0x6002187")]
	private static bool SufficientExecutionStack() { }

	[Address(RVA = "0x1F35DE0", Offset = "0x1F351E0", Length = "0x5")]
	[Token(Token = "0x6002189")]
	public static bool TryEnsureSufficientExecutionStack() { }

}


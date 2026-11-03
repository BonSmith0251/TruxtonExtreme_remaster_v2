namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x2000044")]
internal static class Utils
{

	[Address(RVA = "0x2F61D30", Offset = "0x2F61130", Length = "0x53")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x60000F8")]
	public static void CheckArg(bool condition, string message) { }

	[Address(RVA = "0x2F61CD0", Offset = "0x2F610D0", Length = "0x54")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x60000F7")]
	public static void CheckArgIsNotNull(object obj, string argName) { }

	[Address(RVA = "0x9E2B90", Offset = "0x9E1F90", Length = "0x43B")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x60000F9")]
	public static void CheckArgRange(T value, T minIncluded, T maxExcluded, string argName) { }

	[Address(RVA = "0x2F61D90", Offset = "0x2F61190", Length = "0x75")]
	[Token(Token = "0x60000F6")]
	public static void Destroy(object obj) { }

}


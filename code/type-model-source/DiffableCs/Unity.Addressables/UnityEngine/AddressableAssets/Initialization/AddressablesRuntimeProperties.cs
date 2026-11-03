namespace UnityEngine.AddressableAssets.Initialization;

[Token(Token = "0x200005D")]
public static class AddressablesRuntimeProperties
{
	[Token(Token = "0x400014A")]
	private static Stack<String> s_TokenStack; //Field offset: 0x0
	[Token(Token = "0x400014B")]
	private static Stack<Int32> s_TokenStartStack; //Field offset: 0x8
	[Token(Token = "0x400014C")]
	private static bool s_StaticStacksAreInUse; //Field offset: 0x10
	[Token(Token = "0x400014D")]
	private static Dictionary<String, String> s_CachedValues; //Field offset: 0x18

	[Address(RVA = "0x279FD20", Offset = "0x279F120", Length = "0x164")]
	[Token(Token = "0x600024D")]
	private static AddressablesRuntimeProperties() { }

	[Address(RVA = "0x279F050", Offset = "0x279E450", Length = "0x70")]
	[Token(Token = "0x6000248")]
	public static void ClearCachedPropertyValues() { }

	[Address(RVA = "0x279F0D0", Offset = "0x279E4D0", Length = "0x423")]
	[Token(Token = "0x6000249")]
	public static string EvaluateProperty(string name) { }

	[Address(RVA = "0x279FA10", Offset = "0x279EE10", Length = "0xFE")]
	[Token(Token = "0x600024A")]
	public static string EvaluateString(string inputString) { }

	[Address(RVA = "0x279FB10", Offset = "0x279EF10", Length = "0xCA")]
	[Token(Token = "0x600024B")]
	public static string EvaluateString(string inputString, char startDelimiter, char endDelimiter, Func<String, String> varFunc) { }

	[Address(RVA = "0x279F500", Offset = "0x279E900", Length = "0x505")]
	[Token(Token = "0x600024C")]
	private static string EvaluateStringInternal(string inputString, char startDelimiter, char endDelimiter, Func<String, String> varFunc) { }

	[Address(RVA = "0x279FBE0", Offset = "0x279EFE0", Length = "0x23")]
	[Token(Token = "0x6000245")]
	private static Assembly[] GetAssemblies() { }

	[Address(RVA = "0x279FC10", Offset = "0x279F010", Length = "0x70")]
	[Token(Token = "0x6000246")]
	internal static int GetCachedValueCount() { }

	[Address(RVA = "0x279FC90", Offset = "0x279F090", Length = "0x88")]
	[Token(Token = "0x6000247")]
	public static void SetPropertyValue(string name, string val) { }

}


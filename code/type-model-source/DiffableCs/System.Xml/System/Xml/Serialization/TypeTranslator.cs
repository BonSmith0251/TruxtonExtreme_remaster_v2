namespace System.Xml.Serialization;

[Token(Token = "0x2000103")]
internal class TypeTranslator
{
	[Token(Token = "0x4000603")]
	private static Hashtable nameCache; //Field offset: 0x0
	[Token(Token = "0x4000604")]
	private static Hashtable primitiveTypes; //Field offset: 0x8
	[Token(Token = "0x4000605")]
	private static Hashtable primitiveArrayTypes; //Field offset: 0x10
	[Token(Token = "0x4000606")]
	private static Hashtable nullableTypes; //Field offset: 0x18

	[Address(RVA = "0x25471C0", Offset = "0x25465C0", Length = "0x26B2")]
	[Token(Token = "0x6000C28")]
	private static TypeTranslator() { }

	[Address(RVA = "0x25460D0", Offset = "0x25454D0", Length = "0xC0")]
	[Token(Token = "0x6000C2D")]
	public static TypeData FindPrimitiveTypeData(string typeName) { }

	[Address(RVA = "0x25461A0", Offset = "0x25455A0", Length = "0xEB")]
	[Token(Token = "0x6000C2E")]
	public static string GetArrayName(string elemName) { }

	[Address(RVA = "0x25464D0", Offset = "0x25458D0", Length = "0x4C")]
	[Token(Token = "0x6000C2B")]
	public static TypeData GetPrimitiveTypeData(string typeName) { }

	[Address(RVA = "0x2546290", Offset = "0x2545690", Length = "0x234")]
	[Token(Token = "0x6000C2C")]
	public static TypeData GetPrimitiveTypeData(string typeName, bool nullable) { }

	[Address(RVA = "0x2546FE0", Offset = "0x25463E0", Length = "0x4F")]
	[Token(Token = "0x6000C29")]
	public static TypeData GetTypeData(Type type) { }

	[Address(RVA = "0x2546520", Offset = "0x2545920", Length = "0xABD")]
	[Token(Token = "0x6000C2A")]
	public static TypeData GetTypeData(Type runtimeType, string xmlDataType, bool underlyingEnumType = false) { }

	[Address(RVA = "0x2547030", Offset = "0x2546430", Length = "0x183")]
	[Token(Token = "0x6000C2F")]
	public static void ParseArrayType(string arrayType, out string type, out string ns, out string dimensions) { }

}


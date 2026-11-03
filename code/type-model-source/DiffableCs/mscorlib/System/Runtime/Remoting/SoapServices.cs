namespace System.Runtime.Remoting;

[ComVisible(True)]
[Token(Token = "0x200035D")]
public class SoapServices
{
	[Token(Token = "0x200035E")]
	private class TypeInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000E1C")]
		public Hashtable Attributes; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000E1D")]
		public Hashtable Elements; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001B33")]
		public TypeInfo() { }

	}

	[Token(Token = "0x4000E17")]
	private static Hashtable _xmlTypes; //Field offset: 0x0
	[Token(Token = "0x4000E18")]
	private static Hashtable _xmlElements; //Field offset: 0x8
	[Token(Token = "0x4000E19")]
	private static Hashtable _soapActions; //Field offset: 0x10
	[Token(Token = "0x4000E1A")]
	private static Hashtable _soapActionsMethods; //Field offset: 0x18
	[Token(Token = "0x4000E1B")]
	private static Hashtable _typeInfos; //Field offset: 0x20

	[Token(Token = "0x170002D8")]
	public static string XmlNsForClrTypeWithAssembly
	{
		[Address(RVA = "0x1EF0BB0", Offset = "0x1EEFFB0", Length = "0x2C")]
		[Token(Token = "0x6001B23")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170002D9")]
	public static string XmlNsForClrTypeWithNs
	{
		[Address(RVA = "0x1EF0C10", Offset = "0x1EF0010", Length = "0x2C")]
		[Token(Token = "0x6001B24")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170002DA")]
	public static string XmlNsForClrTypeWithNsAndAssembly
	{
		[Address(RVA = "0x1EF0BE0", Offset = "0x1EEFFE0", Length = "0x2C")]
		[Token(Token = "0x6001B25")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x1EF0A20", Offset = "0x1EEFE20", Length = "0x187")]
	[Token(Token = "0x6001B32")]
	private static SoapServices() { }

	[Address(RVA = "0x1EEF870", Offset = "0x1EEEC70", Length = "0x180")]
	[Token(Token = "0x6001B26")]
	public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName) { }

	[Address(RVA = "0x1EEF9F0", Offset = "0x1EEEDF0", Length = "0xC5")]
	[Token(Token = "0x6001B31")]
	private static string EncodeNs(string ns) { }

	[Address(RVA = "0x1EF0BB0", Offset = "0x1EEFFB0", Length = "0x2C")]
	[Token(Token = "0x6001B23")]
	public static string get_XmlNsForClrTypeWithAssembly() { }

	[Address(RVA = "0x1EF0C10", Offset = "0x1EF0010", Length = "0x2C")]
	[Token(Token = "0x6001B24")]
	public static string get_XmlNsForClrTypeWithNs() { }

	[Address(RVA = "0x1EF0BE0", Offset = "0x1EEFFE0", Length = "0x2C")]
	[Token(Token = "0x6001B25")]
	public static string get_XmlNsForClrTypeWithNsAndAssembly() { }

	[Address(RVA = "0x1EEFAC0", Offset = "0x1EEEEC0", Length = "0x132")]
	[Token(Token = "0x6001B28")]
	private static string GetAssemblyName(MethodBase mb) { }

	[Address(RVA = "0x1EEFC00", Offset = "0x1EEF000", Length = "0x5E")]
	[Token(Token = "0x6001B27")]
	private static string GetNameKey(string name, string namspace) { }

	[Address(RVA = "0x1EEFC60", Offset = "0x1EEF060", Length = "0x10B")]
	[Token(Token = "0x6001B29")]
	public static bool GetXmlElementForInteropType(Type type, out string xmlElement, out string xmlNamespace) { }

	[Address(RVA = "0x1EEFD70", Offset = "0x1EEF170", Length = "0xA0")]
	[Token(Token = "0x6001B2A")]
	public static string GetXmlNamespaceForMethodCall(MethodBase mb) { }

	[Address(RVA = "0x1EEFE20", Offset = "0x1EEF220", Length = "0xA0")]
	[Token(Token = "0x6001B2B")]
	public static string GetXmlNamespaceForMethodResponse(MethodBase mb) { }

	[Address(RVA = "0x1EEFED0", Offset = "0x1EEF2D0", Length = "0xEE")]
	[Token(Token = "0x6001B2C")]
	public static bool GetXmlTypeForInteropType(Type type, out string xmlType, out string xmlTypeNamespace) { }

	[Address(RVA = "0x1EF0640", Offset = "0x1EEFA40", Length = "0xB9")]
	[Token(Token = "0x6001B2D")]
	public static void PreLoad(Assembly assembly) { }

	[Address(RVA = "0x1EEFFC0", Offset = "0x1EEF3C0", Length = "0x67A")]
	[Token(Token = "0x6001B2E")]
	public static void PreLoad(Type type) { }

	[Address(RVA = "0x1EF0700", Offset = "0x1EEFB00", Length = "0x185")]
	[Token(Token = "0x6001B2F")]
	public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type) { }

	[Address(RVA = "0x1EF0890", Offset = "0x1EEFC90", Length = "0x183")]
	[Token(Token = "0x6001B30")]
	public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type) { }

}


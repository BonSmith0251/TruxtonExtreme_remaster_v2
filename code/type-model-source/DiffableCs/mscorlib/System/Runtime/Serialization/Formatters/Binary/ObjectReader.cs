namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x200042B")]
internal sealed class ObjectReader
{
	[Token(Token = "0x200042D")]
	public sealed class TopLevelAssemblyTypeResolver
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40010FE")]
		private Assembly m_topLevelAssembly; //Field offset: 0x10

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6001F8E")]
		public TopLevelAssemblyTypeResolver(Assembly topLevelAssembly) { }

		[Address(RVA = "0x1F2C5E0", Offset = "0x1F2B9E0", Length = "0x7A")]
		[Token(Token = "0x6001F8F")]
		public Type ResolveType(Assembly assembly, string simpleTypeName, bool ignoreCase) { }

	}

	[Token(Token = "0x200042C")]
	public class TypeNAssembly
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40010FC")]
		public Type type; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40010FD")]
		public string assemblyName; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001F8D")]
		public TypeNAssembly() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40010E4")]
	internal Stream m_stream; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40010E5")]
	internal ISurrogateSelector m_surrogates; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40010E6")]
	internal StreamingContext m_context; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40010E7")]
	internal ObjectManager m_objectManager; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40010E8")]
	internal InternalFE formatterEnums; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40010E9")]
	internal SerializationBinder m_binder; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40010EA")]
	internal long topId; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40010EB")]
	internal bool bSimpleAssembly; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40010EC")]
	internal object handlerObject; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40010ED")]
	internal object m_topObject; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40010EE")]
	internal Header[] headers; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40010EF")]
	internal HeaderHandler handler; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40010F0")]
	internal SerObjectInfoInit serObjectInfoInit; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40010F1")]
	internal IFormatterConverter m_formatterConverter; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40010F2")]
	internal SerStack stack; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40010F3")]
	private SerStack valueFixupStack; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40010F4")]
	internal Object[] crossAppDomainArray; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40010F5")]
	private bool bFullDeserialization; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA1")]
	[Token(Token = "0x40010F6")]
	private bool bOldFormatDetected; //Field offset: 0xA1
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40010F7")]
	private IntSizedArray valTypeObjectIdTable; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40010F8")]
	private NameCache typeCache; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40010F9")]
	private string previousAssemblyString; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40010FA")]
	private string previousName; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40010FB")]
	private Type previousType; //Field offset: 0xC8

	[Token(Token = "0x170003E3")]
	internal object TopObject
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6001F6D")]
		internal get { } //Length: 5
		[Address(RVA = "0x1F223E0", Offset = "0x1F217E0", Length = "0x43")]
		[Token(Token = "0x6001F6E")]
		internal set { } //Length: 67
	}

	[Token(Token = "0x170003E2")]
	private SerStack ValueFixupStack
	{
		[Address(RVA = "0x1F22350", Offset = "0x1F21750", Length = "0x89")]
		[Token(Token = "0x6001F6C")]
		private get { } //Length: 137
	}

	[Address(RVA = "0x1F221F0", Offset = "0x1F215F0", Length = "0x155")]
	[Token(Token = "0x6001F6F")]
	internal ObjectReader(Stream stream, ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	[Address(RVA = "0x1F1E1C0", Offset = "0x1F1D5C0", Length = "0x5C")]
	[Token(Token = "0x6001F87")]
	internal Type Bind(string assemblyString, string typeString) { }

	[Address(RVA = "0x1F1E220", Offset = "0x1F1D620", Length = "0x13E")]
	[Token(Token = "0x6001F72")]
	private void CheckSerializable(Type t) { }

	[Address(RVA = "0x1F1E360", Offset = "0x1F1D760", Length = "0xBF")]
	[Token(Token = "0x6001F8C")]
	private static void CheckTypeForwardedTo(Assembly sourceAssembly, Assembly destAssembly, Type resolvedType) { }

	[Address(RVA = "0x1F1E470", Offset = "0x1F1D870", Length = "0x180")]
	[Token(Token = "0x6001F76")]
	internal ReadObjectInfo CreateReadObjectInfo(Type objectType, String[] memberNames, Type[] memberTypes) { }

	[Address(RVA = "0x1F1E420", Offset = "0x1F1D820", Length = "0x50")]
	[Token(Token = "0x6001F75")]
	internal ReadObjectInfo CreateReadObjectInfo(Type objectType) { }

	[Address(RVA = "0x1F1E600", Offset = "0x1F1DA00", Length = "0x2E")]
	[Token(Token = "0x6001F74")]
	internal object CrossAppDomainArray(int index) { }

	[Address(RVA = "0x1F1E630", Offset = "0x1F1DA30", Length = "0x46F")]
	[Token(Token = "0x6001F70")]
	internal object Deserialize(HeaderHandler handler, __BinaryParser serParser, bool fCheck) { }

	[Address(RVA = "0x1F1EAA0", Offset = "0x1F1DEA0", Length = "0x27C")]
	[Token(Token = "0x6001F88")]
	internal Type FastBindToType(string assemblyName, string typeName) { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6001F6D")]
	internal object get_TopObject() { }

	[Address(RVA = "0x1F22350", Offset = "0x1F21750", Length = "0x89")]
	[Token(Token = "0x6001F6C")]
	private SerStack get_ValueFixupStack() { }

	[Address(RVA = "0x1F1ED20", Offset = "0x1F1E120", Length = "0xFE")]
	[Token(Token = "0x6001F86")]
	internal long GetId(long objectId) { }

	[Address(RVA = "0x1F1EE20", Offset = "0x1F1E220", Length = "0x187")]
	[Token(Token = "0x6001F8A")]
	private static void GetSimplyNamedTypeFromAssembly(Assembly assm, string typeName, ref Type type) { }

	[Address(RVA = "0x1F1EFB0", Offset = "0x1F1E3B0", Length = "0x327")]
	[Token(Token = "0x6001F8B")]
	internal Type GetType(BinaryAssemblyInfo assemblyInfo, string name) { }

	[Address(RVA = "0x1F1F2E0", Offset = "0x1F1E6E0", Length = "0xEA")]
	[Token(Token = "0x6001F71")]
	private bool HasSurrogate(Type t) { }

	[Address(RVA = "0x1F1F3D0", Offset = "0x1F1E7D0", Length = "0x131")]
	[Token(Token = "0x6001F73")]
	private void InitFullDeserialization() { }

	[Address(RVA = "0x1F1F510", Offset = "0x1F1E910", Length = "0xF8")]
	[Token(Token = "0x6001F7E")]
	private void NextRectangleMap(ParseRecord pr) { }

	[Address(RVA = "0x1F21D50", Offset = "0x1F21150", Length = "0x208")]
	[Token(Token = "0x6001F77")]
	internal void Parse(ParseRecord pr) { }

	[Address(RVA = "0x1F201E0", Offset = "0x1F1F5E0", Length = "0x8F8")]
	[Token(Token = "0x6001F7D")]
	private void ParseArray(ParseRecord pr) { }

	[Address(RVA = "0x1F1F640", Offset = "0x1F1EA40", Length = "0xB95")]
	[Token(Token = "0x6001F7F")]
	private void ParseArrayMember(ParseRecord pr) { }

	[Address(RVA = "0x1F1F610", Offset = "0x1F1EA10", Length = "0x25")]
	[Token(Token = "0x6001F80")]
	private void ParseArrayMemberEnd(ParseRecord pr) { }

	[Address(RVA = "0x1F20AE0", Offset = "0x1F1FEE0", Length = "0x258")]
	[Token(Token = "0x6001F78")]
	private void ParseError(ParseRecord processing, ParseRecord onStack) { }

	[Address(RVA = "0x1F20E00", Offset = "0x1F20200", Length = "0x70D")]
	[Token(Token = "0x6001F81")]
	private void ParseMember(ParseRecord pr) { }

	[Address(RVA = "0x1F20D40", Offset = "0x1F20140", Length = "0xB5")]
	[Token(Token = "0x6001F82")]
	private void ParseMemberEnd(ParseRecord pr) { }

	[Address(RVA = "0x1F21840", Offset = "0x1F20C40", Length = "0x3B8")]
	[Token(Token = "0x6001F7B")]
	private void ParseObject(ParseRecord pr) { }

	[Address(RVA = "0x1F21510", Offset = "0x1F20910", Length = "0x323")]
	[Token(Token = "0x6001F7C")]
	private void ParseObjectEnd(ParseRecord pr) { }

	[Address(RVA = "0x1F21C30", Offset = "0x1F21030", Length = "0x21")]
	[Token(Token = "0x6001F79")]
	private void ParseSerializedStreamHeader(ParseRecord pr) { }

	[Address(RVA = "0x1F21C00", Offset = "0x1F21000", Length = "0x20")]
	[Token(Token = "0x6001F7A")]
	private void ParseSerializedStreamHeaderEnd(ParseRecord pr) { }

	[Address(RVA = "0x1F21C60", Offset = "0x1F21060", Length = "0xEB")]
	[Token(Token = "0x6001F83")]
	private void ParseString(ParseRecord pr, ParseRecord parentPr) { }

	[Address(RVA = "0x1F220B0", Offset = "0x1F214B0", Length = "0xCE")]
	[Token(Token = "0x6001F84")]
	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr) { }

	[Address(RVA = "0x1F21F90", Offset = "0x1F21390", Length = "0x11E")]
	[Token(Token = "0x6001F85")]
	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr, bool bIsString) { }

	[Address(RVA = "0x1F22180", Offset = "0x1F21580", Length = "0x69")]
	[Token(Token = "0x6001F89")]
	private static Assembly ResolveSimpleAssemblyName(AssemblyName assemblyName) { }

	[Address(RVA = "0x1F223E0", Offset = "0x1F217E0", Length = "0x43")]
	[Token(Token = "0x6001F6E")]
	internal void set_TopObject(object value) { }

}


namespace System.Data.Common;

[Token(Token = "0x20000C0")]
internal sealed class ObjectStorage : DataStorage
{
	[Token(Token = "0x20000C1")]
	private enum Families : int
	{
		DATETIME = 0,
		NUMBER = 1,
		STRING = 2,
		BOOLEAN = 3,
		ARRAY = 4,
	}

	[Token(Token = "0x20000C2")]
	private class TempAssemblyComparer : IEqualityComparer<KeyValuePair`2<Type, XmlRootAttribute>>
	{
		[Token(Token = "0x400042C")]
		internal static readonly IEqualityComparer<KeyValuePair`2<Type, XmlRootAttribute>> s_default; //Field offset: 0x0

		[Address(RVA = "0x23C68E0", Offset = "0x23C5CE0", Length = "0x67")]
		[Token(Token = "0x6000AAF")]
		private static TempAssemblyComparer() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000AAC")]
		private TempAssemblyComparer() { }

		[Address(RVA = "0x23C66C0", Offset = "0x23C5AC0", Length = "0x172")]
		[Token(Token = "0x6000AAD")]
		public override bool Equals(KeyValuePair<Type, XmlRootAttribute> x, KeyValuePair<Type, XmlRootAttribute> y) { }

		[Address(RVA = "0x23C6840", Offset = "0x23C5C40", Length = "0x91")]
		[Token(Token = "0x6000AAE")]
		public override int GetHashCode(KeyValuePair<Type, XmlRootAttribute> obj) { }

	}

	[Token(Token = "0x4000420")]
	private static readonly object s_defaultValue; //Field offset: 0x0
	[Token(Token = "0x4000423")]
	private static readonly object s_tempAssemblyCacheLock; //Field offset: 0x8
	[Token(Token = "0x4000424")]
	private static Dictionary<KeyValuePair`2<Type, XmlRootAttribute>, XmlSerializer> s_tempAssemblyCache; //Field offset: 0x10
	[Token(Token = "0x4000425")]
	private static readonly XmlSerializerFactory s_serializerFactory; //Field offset: 0x18
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000421")]
	private Object[] _values; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000422")]
	private readonly bool _implementsIXmlSerializable; //Field offset: 0x58

	[Address(RVA = "0x238A4E0", Offset = "0x23898E0", Length = "0xF3")]
	[Token(Token = "0x6000AAB")]
	private static ObjectStorage() { }

	[Address(RVA = "0x238A5E0", Offset = "0x23899E0", Length = "0x19F")]
	[Token(Token = "0x6000A95")]
	internal ObjectStorage(DataColumn column, Type type) { }

	[Address(RVA = "0x23871D0", Offset = "0x23865D0", Length = "0x31")]
	[Token(Token = "0x6000A96")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23878D0", Offset = "0x2386CD0", Length = "0x114")]
	[Token(Token = "0x6000A97")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x2387210", Offset = "0x2386610", Length = "0x137")]
	[Token(Token = "0x6000A99")]
	private int CompareTo(object valueNo1, object valueNo2) { }

	[Address(RVA = "0x2387350", Offset = "0x2386750", Length = "0x17F")]
	[Token(Token = "0x6000A98")]
	public virtual int CompareValueTo(int recordNo1, object value) { }

	[Address(RVA = "0x23874D0", Offset = "0x23868D0", Length = "0x3F1")]
	[Token(Token = "0x6000A9A")]
	private int CompareWithFamilies(object valueNo1, object valueNo2) { }

	[Address(RVA = "0x23879F0", Offset = "0x2386DF0", Length = "0x120")]
	[Token(Token = "0x6000AA4")]
	public virtual void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	[Address(RVA = "0x2387B20", Offset = "0x2386F20", Length = "0x50E")]
	[Token(Token = "0x6000AA3")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x2388470", Offset = "0x2387870", Length = "0x62D")]
	[Token(Token = "0x6000AA2")]
	public virtual object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	[Address(RVA = "0x2388030", Offset = "0x2387430", Length = "0x436")]
	[Token(Token = "0x6000AA1")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x2388D20", Offset = "0x2388120", Length = "0x85")]
	[Token(Token = "0x6000A9B")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x2388AA0", Offset = "0x2387EA0", Length = "0x274")]
	[Token(Token = "0x6000AA6")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23895F0", Offset = "0x23889F0", Length = "0x34")]
	[Token(Token = "0x6000A9C")]
	public virtual object Get(int recordNo) { }

	[Address(RVA = "0x2388DB0", Offset = "0x23881B0", Length = "0x37")]
	[Token(Token = "0x6000AA5")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x2388DF0", Offset = "0x23881F0", Length = "0x58")]
	[Token(Token = "0x6000A9D")]
	private Families GetFamily(Type dataType) { }

	[Address(RVA = "0x2388FB0", Offset = "0x23883B0", Length = "0x63B")]
	[Token(Token = "0x6000AAA")]
	internal static XmlSerializer GetXmlSerializer(Type type, XmlRootAttribute attribute) { }

	[Address(RVA = "0x2388F30", Offset = "0x2388330", Length = "0x70")]
	[Token(Token = "0x6000AA9")]
	internal static XmlSerializer GetXmlSerializer(Type type) { }

	[Address(RVA = "0x2389630", Offset = "0x2388A30", Length = "0x2F")]
	[Token(Token = "0x6000A9E")]
	public virtual bool IsNull(int record) { }

	[Address(RVA = "0x2389990", Offset = "0x2388D90", Length = "0xA1B")]
	[Token(Token = "0x6000A9F")]
	public virtual void Set(int recordNo, object value) { }

	[Address(RVA = "0x2389660", Offset = "0x2388A60", Length = "0xCA")]
	[Token(Token = "0x6000AA0")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x2389730", Offset = "0x2388B30", Length = "0x254")]
	[Token(Token = "0x6000AA7")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

	[Address(RVA = "0x238A3B0", Offset = "0x23897B0", Length = "0x120")]
	[Token(Token = "0x6000AA8")]
	internal static void VerifyIDynamicMetaObjectProvider(Type type) { }

}


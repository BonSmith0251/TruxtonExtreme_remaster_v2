namespace System.Data.Common;

[Token(Token = "0x20000C9")]
internal abstract class DataStorage
{
	[Token(Token = "0x4000465")]
	private static readonly Type[] s_storageClassType; //Field offset: 0x0
	[Token(Token = "0x4000471")]
	private static readonly Func<Type, Tuple`4<Boolean, Boolean, Boolean, Boolean>> s_inspectTypeForInterfaces; //Field offset: 0x8
	[Token(Token = "0x4000472")]
	private static readonly ConcurrentDictionary<Type, Tuple`4<Boolean, Boolean, Boolean, Boolean>> s_typeImplementsInterface; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000466")]
	internal readonly DataColumn _column; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000467")]
	internal readonly DataTable _table; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000468")]
	internal readonly Type _dataType; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000469")]
	internal readonly StorageType _storageTypeCode; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400046A")]
	private BitArray _dbNullBits; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400046B")]
	private readonly object _defaultValue; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400046C")]
	internal readonly object _nullValue; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400046D")]
	internal readonly bool _isCloneable; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[Token(Token = "0x400046E")]
	internal readonly bool _isCustomDefinedType; //Field offset: 0x49
	[FieldOffset(Offset = "0x4A")]
	[Token(Token = "0x400046F")]
	internal readonly bool _isStringType; //Field offset: 0x4A
	[FieldOffset(Offset = "0x4B")]
	[Token(Token = "0x4000470")]
	internal readonly bool _isValueType; //Field offset: 0x4B

	[Token(Token = "0x17000186")]
	internal DataSetDateTime DateTimeMode
	{
		[Address(RVA = "0x23B0620", Offset = "0x23AFA20", Length = "0x1A")]
		[Token(Token = "0x6000AFE")]
		internal get { } //Length: 26
	}

	[Token(Token = "0x17000187")]
	internal IFormatProvider FormatProvider
	{
		[Address(RVA = "0x23B0640", Offset = "0x23AFA40", Length = "0x1D")]
		[Token(Token = "0x6000AFF")]
		internal get { } //Length: 29
	}

	[Address(RVA = "0x23AF250", Offset = "0x23AE650", Length = "0x1143")]
	[Token(Token = "0x6000B2A")]
	private static DataStorage() { }

	[Address(RVA = "0x23B03D0", Offset = "0x23AF7D0", Length = "0x168")]
	[Token(Token = "0x6000AFD")]
	protected DataStorage(DataColumn column, Type type, object defaultValue, object nullValue, bool isICloneable, StorageType storageType) { }

	[Address(RVA = "0x23B0570", Offset = "0x23AF970", Length = "0xA3")]
	[Token(Token = "0x6000AFB")]
	protected DataStorage(DataColumn column, Type type, object defaultValue, StorageType storageType) { }

	[Address(RVA = "0x23B03A0", Offset = "0x23AF7A0", Length = "0x2E")]
	[Token(Token = "0x6000AFC")]
	protected DataStorage(DataColumn column, Type type, object defaultValue, object nullValue, StorageType storageType) { }

	[Address(RVA = "0x23ACEE0", Offset = "0x23AC2E0", Length = "0xA8")]
	[Token(Token = "0x6000B00")]
	public override object Aggregate(Int32[] recordNos, AggregateType kind) { }

	[Address(RVA = "0x23ACE50", Offset = "0x23AC250", Length = "0x8C")]
	[Token(Token = "0x6000B01")]
	public object AggregateCount(Int32[] recordNos) { }

	[Token(Token = "0x6000B03")]
	public abstract int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23ACF90", Offset = "0x23AC390", Length = "0x76")]
	[Token(Token = "0x6000B02")]
	protected int CompareBits(int recordNo1, int recordNo2) { }

	[Token(Token = "0x6000B04")]
	public abstract int CompareValueTo(int recordNo1, object value) { }

	[Token(Token = "0x6000B12")]
	public abstract string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23AD010", Offset = "0x23AC410", Length = "0x45")]
	[Token(Token = "0x6000B13")]
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
	[Token(Token = "0x6000B05")]
	public override object ConvertValue(object value) { }

	[Address(RVA = "0x23AD060", Offset = "0x23AC460", Length = "0x4B")]
	[Token(Token = "0x6000B11")]
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	[Token(Token = "0x6000B10")]
	public abstract object ConvertXmlToObject(string s) { }

	[Token(Token = "0x6000B07")]
	public abstract void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23AD0B0", Offset = "0x23AC4B0", Length = "0x41")]
	[Token(Token = "0x6000B06")]
	protected void CopyBits(int srcRecordNo, int dstRecordNo) { }

	[Token(Token = "0x6000B25")]
	protected abstract void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23AD100", Offset = "0x23AC500", Length = "0x19")]
	[Token(Token = "0x6000B22")]
	internal void CopyValueInternal(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23AD120", Offset = "0x23AC520", Length = "0x2B0")]
	[Token(Token = "0x6000B14")]
	public static DataStorage CreateStorage(DataColumn column, Type dataType, StorageType typeCode) { }

	[Address(RVA = "0x23AE580", Offset = "0x23AD980", Length = "0x20")]
	[Token(Token = "0x6000B1B")]
	private static bool DetermineIfValueType(StorageType typeCode, Type dataType) { }

	[Token(Token = "0x6000B08")]
	public abstract object Get(int recordNo) { }

	[Address(RVA = "0x23B0620", Offset = "0x23AFA20", Length = "0x1A")]
	[Token(Token = "0x6000AFE")]
	internal DataSetDateTime get_DateTimeMode() { }

	[Address(RVA = "0x23B0640", Offset = "0x23AFA40", Length = "0x1D")]
	[Token(Token = "0x6000AFF")]
	internal IFormatProvider get_FormatProvider() { }

	[Address(RVA = "0x23AE610", Offset = "0x23ADA10", Length = "0x37")]
	[Token(Token = "0x6000B09")]
	protected object GetBits(int recordNo) { }

	[Token(Token = "0x6000B24")]
	protected abstract object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23AE650", Offset = "0x23ADA50", Length = "0x14")]
	[Token(Token = "0x6000B21")]
	internal object GetEmptyStorageInternal(int recordCount) { }

	[Address(RVA = "0x23AE670", Offset = "0x23ADA70", Length = "0x6A")]
	[Token(Token = "0x6000B29")]
	internal static string GetQualifiedName(Type type) { }

	[Address(RVA = "0x23AE6E0", Offset = "0x23ADAE0", Length = "0x145")]
	[Token(Token = "0x6000B15")]
	internal static StorageType GetStorageType(Type dataType) { }

	[Address(RVA = "0x23AE830", Offset = "0x23ADC30", Length = "0x6")]
	[Token(Token = "0x6000B0A")]
	public override int GetStringLength(int record) { }

	[Address(RVA = "0x23AE8B0", Offset = "0x23ADCB0", Length = "0x104")]
	[Token(Token = "0x6000B28")]
	internal static Type GetType(string value) { }

	[Address(RVA = "0x23AE840", Offset = "0x23ADC40", Length = "0x6E")]
	[Token(Token = "0x6000B16")]
	internal static Type GetTypeStorage(StorageType storageType) { }

	[Address(RVA = "0x23AE9C0", Offset = "0x23ADDC0", Length = "0x21")]
	[Token(Token = "0x6000B0B")]
	protected bool HasValue(int recordNo) { }

	[Address(RVA = "0x23AEAB0", Offset = "0x23ADEB0", Length = "0x167")]
	[Token(Token = "0x6000B1C")]
	internal static void ImplementsInterfaces(StorageType typeCode, Type dataType, out bool sqlType, out bool nullable, out bool xmlSerializable, out bool changeTracking, out bool revertibleChangeTracking) { }

	[Address(RVA = "0x23AE9F0", Offset = "0x23ADDF0", Length = "0xB7")]
	[Token(Token = "0x6000B1E")]
	internal static bool ImplementsINullableValue(StorageType typeCode, Type dataType) { }

	[Address(RVA = "0x23AEC20", Offset = "0x23AE020", Length = "0x1AE")]
	[Token(Token = "0x6000B1D")]
	private static Tuple<Boolean, Boolean, Boolean, Boolean> InspectTypeForInterfaces(Type dataType) { }

	[Address(RVA = "0x23AEDD0", Offset = "0x23AE1D0", Length = "0x1E")]
	[Token(Token = "0x6000B0C")]
	public override bool IsNull(int recordNo) { }

	[Address(RVA = "0x23AEDF0", Offset = "0x23AE1F0", Length = "0x14A")]
	[Token(Token = "0x6000B1F")]
	public static bool IsObjectNull(object value) { }

	[Address(RVA = "0x23AEF40", Offset = "0x23AE340", Length = "0xC0")]
	[Token(Token = "0x6000B20")]
	public static bool IsObjectSqlNull(object value) { }

	[Address(RVA = "0x23AF100", Offset = "0x23AE500", Length = "0x7")]
	[Token(Token = "0x6000B19")]
	internal static bool IsSqlType(StorageType storageType) { }

	[Address(RVA = "0x23AF000", Offset = "0x23AE400", Length = "0xFF")]
	[Token(Token = "0x6000B1A")]
	public static bool IsSqlType(Type dataType) { }

	[Address(RVA = "0x23AF110", Offset = "0x23AE510", Length = "0xF")]
	[Token(Token = "0x6000B18")]
	internal static bool IsTypeCustomType(StorageType typeCode) { }

	[Address(RVA = "0x23AF120", Offset = "0x23AE520", Length = "0x5D")]
	[Token(Token = "0x6000B17")]
	internal static bool IsTypeCustomType(Type type) { }

	[Token(Token = "0x6000B0D")]
	public abstract void Set(int recordNo, object value) { }

	[Address(RVA = "0x23AF180", Offset = "0x23AE580", Length = "0x8A")]
	[Token(Token = "0x6000B0F")]
	public override void SetCapacity(int capacity) { }

	[Address(RVA = "0x23AF210", Offset = "0x23AE610", Length = "0x1E")]
	[Token(Token = "0x6000B0E")]
	protected void SetNullBit(int recordNo, bool flag) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x6000B27")]
	protected void SetNullStorage(BitArray nullbits) { }

	[Token(Token = "0x6000B26")]
	protected abstract void SetStorage(object store, BitArray nullbits) { }

	[Address(RVA = "0x23AF230", Offset = "0x23AE630", Length = "0x14")]
	[Token(Token = "0x6000B23")]
	internal void SetStorageInternal(object store, BitArray nullbits) { }

}


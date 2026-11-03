namespace System.Runtime.Serialization;

[ComVisible(True)]
[Token(Token = "0x20003FA")]
public sealed class SerializationInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F77")]
	internal String[] m_members; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F78")]
	internal Object[] m_data; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F79")]
	internal Type[] m_types; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F7A")]
	private Dictionary<String, Int32> m_nameToIndex; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000F7B")]
	internal int m_currMember; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000F7C")]
	internal IFormatterConverter m_converter; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000F7D")]
	private string m_fullTypeName; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000F7E")]
	private string m_assemName; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000F7F")]
	private Type objectType; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000F80")]
	private bool isFullTypeNameSetExplicit; //Field offset: 0x58
	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x4000F81")]
	private bool isAssemblyNameSetExplicit; //Field offset: 0x59
	[FieldOffset(Offset = "0x5A")]
	[Token(Token = "0x4000F82")]
	private bool requireSameTokenInPartialTrust; //Field offset: 0x5A

	[Token(Token = "0x170003D6")]
	public string AssemblyName
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6001E65")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003D5")]
	public string FullTypeName
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6001E64")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003DA")]
	public bool IsAssemblyNameSetExplicit
	{
		[Address(RVA = "0x1CCAA30", Offset = "0x1CC9E30", Length = "0x5")]
		[Token(Token = "0x6001E6D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003D9")]
	public bool IsFullTypeNameSetExplicit
	{
		[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
		[Token(Token = "0x6001E6C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003D7")]
	public int MemberCount
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x6001E6A")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170003D8")]
	public Type ObjectType
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6001E6B")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1F2C260", Offset = "0x1F2B660", Length = "0x1A")]
	[CLSCompliant(False)]
	[Token(Token = "0x6001E62")]
	public SerializationInfo(Type type, IFormatterConverter converter) { }

	[Address(RVA = "0x1F2C280", Offset = "0x1F2B680", Length = "0x276")]
	[CLSCompliant(False)]
	[Token(Token = "0x6001E63")]
	public SerializationInfo(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust) { }

	[Address(RVA = "0x1F2A7E0", Offset = "0x1F29BE0", Length = "0x14E")]
	[Token(Token = "0x6001E79")]
	public void AddValue(string name, DateTime value) { }

	[Address(RVA = "0x1F2A450", Offset = "0x1F29850", Length = "0x125")]
	[Token(Token = "0x6001E78")]
	public void AddValue(string name, float value) { }

	[Address(RVA = "0x1F2AA60", Offset = "0x1F29E60", Length = "0x124")]
	[CLSCompliant(False)]
	[Token(Token = "0x6001E77")]
	public void AddValue(string name, ulong value) { }

	[Address(RVA = "0x1F2A150", Offset = "0x1F29550", Length = "0x124")]
	[Token(Token = "0x6001E76")]
	public void AddValue(string name, long value) { }

	[Address(RVA = "0x1F2A930", Offset = "0x1F29D30", Length = "0x124")]
	[Token(Token = "0x6001E75")]
	public void AddValue(string name, int value) { }

	[Address(RVA = "0x1F2A6B0", Offset = "0x1F29AB0", Length = "0x125")]
	[Token(Token = "0x6001E74")]
	public void AddValue(string name, short value) { }

	[Address(RVA = "0x1F2AB90", Offset = "0x1F29F90", Length = "0x124")]
	[Token(Token = "0x6001E72")]
	public void AddValue(string name, bool value) { }

	[Address(RVA = "0x1F2A280", Offset = "0x1F29680", Length = "0x1CC")]
	[Token(Token = "0x6001E71")]
	public void AddValue(string name, object value) { }

	[Address(RVA = "0x1F2A090", Offset = "0x1F29490", Length = "0xB4")]
	[Token(Token = "0x6001E70")]
	public void AddValue(string name, object value, Type type) { }

	[Address(RVA = "0x1F2A580", Offset = "0x1F29980", Length = "0x124")]
	[Token(Token = "0x6001E73")]
	public void AddValue(string name, byte value) { }

	[Address(RVA = "0x1F29D90", Offset = "0x1F29190", Length = "0x2F2")]
	[Token(Token = "0x6001E7A")]
	internal void AddValueInternal(string name, object value, Type type) { }

	[Address(RVA = "0x1F2ACC0", Offset = "0x1F2A0C0", Length = "0x75")]
	[Token(Token = "0x6001E67")]
	private static bool Compare(Byte[] a, Byte[] b) { }

	[Address(RVA = "0x1F2AD40", Offset = "0x1F2A140", Length = "0x8")]
	[Token(Token = "0x6001E68")]
	internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName) { }

	[Address(RVA = "0x1F2AD50", Offset = "0x1F2A150", Length = "0x110")]
	[Token(Token = "0x6001E6F")]
	private void ExpandArrays() { }

	[Address(RVA = "0x1F2AE60", Offset = "0x1F2A260", Length = "0xBF")]
	[Token(Token = "0x6001E7C")]
	private int FindElement(string name) { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6001E65")]
	public string get_AssemblyName() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6001E64")]
	public string get_FullTypeName() { }

	[Address(RVA = "0x1CCAA30", Offset = "0x1CC9E30", Length = "0x5")]
	[Token(Token = "0x6001E6D")]
	public bool get_IsAssemblyNameSetExplicit() { }

	[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
	[Token(Token = "0x6001E6C")]
	public bool get_IsFullTypeNameSetExplicit() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x6001E6A")]
	public int get_MemberCount() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6001E6B")]
	public Type get_ObjectType() { }

	[Address(RVA = "0x1F2AF20", Offset = "0x1F2A320", Length = "0x144")]
	[Token(Token = "0x6001E81")]
	public bool GetBoolean(string name) { }

	[Address(RVA = "0x1F2B1C0", Offset = "0x1F2A5C0", Length = "0x1C1")]
	[Token(Token = "0x6001E7D")]
	private object GetElement(string name, out Type foundType) { }

	[Address(RVA = "0x1F2B070", Offset = "0x1F2A470", Length = "0x142")]
	[ComVisible(True)]
	[Token(Token = "0x6001E7E")]
	private object GetElementNoThrow(string name, out Type foundType) { }

	[Address(RVA = "0x1F2B390", Offset = "0x1F2A790", Length = "0x93")]
	[Token(Token = "0x6001E6E")]
	public SerializationInfoEnumerator GetEnumerator() { }

	[Address(RVA = "0x1F2B430", Offset = "0x1F2A830", Length = "0x144")]
	[Token(Token = "0x6001E82")]
	public int GetInt32(string name) { }

	[Address(RVA = "0x1F2B580", Offset = "0x1F2A980", Length = "0x145")]
	[Token(Token = "0x6001E83")]
	public long GetInt64(string name) { }

	[Address(RVA = "0x1F2B6D0", Offset = "0x1F2AAD0", Length = "0x146")]
	[Token(Token = "0x6001E84")]
	public float GetSingle(string name) { }

	[Address(RVA = "0x1F2B820", Offset = "0x1F2AC20", Length = "0x14F")]
	[Token(Token = "0x6001E85")]
	public string GetString(string name) { }

	[Address(RVA = "0x1F2BB60", Offset = "0x1F2AF60", Length = "0x1D6")]
	[Token(Token = "0x6001E7F")]
	public object GetValue(string name, Type type) { }

	[Address(RVA = "0x1F2B970", Offset = "0x1F2AD70", Length = "0x1E3")]
	[ComVisible(True)]
	[Token(Token = "0x6001E80")]
	internal object GetValueNoThrow(string name, Type type) { }

	[Address(RVA = "0x1F2BD40", Offset = "0x1F2B140", Length = "0x19A")]
	[Token(Token = "0x6001E69")]
	internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName) { }

	[Address(RVA = "0x1F2BEE0", Offset = "0x1F2B2E0", Length = "0x1BA")]
	[Token(Token = "0x6001E66")]
	public void SetType(Type type) { }

	[Address(RVA = "0x1F2C0A0", Offset = "0x1F2B4A0", Length = "0x1BA")]
	[Token(Token = "0x6001E7B")]
	internal void UpdateValue(string name, object value, Type type) { }

}


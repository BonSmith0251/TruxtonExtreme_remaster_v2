namespace UnityEngine.ResourceManagement.Util;

[Token(Token = "0x200003D")]
public struct SerializedType
{
	[FieldOffset(Offset = "0x0")]
	[FormerlySerializedAs("m_assemblyName")]
	[SerializeField]
	[Token(Token = "0x400009A")]
	private string m_AssemblyName; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[FormerlySerializedAs("m_className")]
	[SerializeField]
	[Token(Token = "0x400009B")]
	private string m_ClassName; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400009C")]
	private Type m_CachedType; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400009D")]
	private bool <ValueChanged>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700002A")]
	public string AssemblyName
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x600015E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700002B")]
	public string ClassName
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[Token(Token = "0x600015F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700002C")]
	public Type Value
	{
		[Address(RVA = "0x2E4FCC0", Offset = "0x2E4F0C0", Length = "0x162")]
		[Token(Token = "0x6000161")]
		 get { } //Length: 354
		[Address(RVA = "0x2E4FE30", Offset = "0x2E4F230", Length = "0xD8")]
		[Token(Token = "0x6000162")]
		 set { } //Length: 216
	}

	[Token(Token = "0x1700002D")]
	public bool ValueChanged
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000163")]
		 get { } //Length: 5
		[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000164")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x600015E")]
	public string get_AssemblyName() { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[Token(Token = "0x600015F")]
	public string get_ClassName() { }

	[Address(RVA = "0x2E4FCC0", Offset = "0x2E4F0C0", Length = "0x162")]
	[Token(Token = "0x6000161")]
	public Type get_Value() { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000163")]
	public bool get_ValueChanged() { }

	[Address(RVA = "0x2E4FE30", Offset = "0x2E4F230", Length = "0xD8")]
	[Token(Token = "0x6000162")]
	public void set_Value(Type value) { }

	[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000164")]
	public void set_ValueChanged(bool value) { }

	[Address(RVA = "0x2E4FC10", Offset = "0x2E4F010", Length = "0xA3")]
	[Token(Token = "0x6000160")]
	public virtual string ToString() { }

}


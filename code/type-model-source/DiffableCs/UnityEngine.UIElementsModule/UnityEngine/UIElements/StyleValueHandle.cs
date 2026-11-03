namespace UnityEngine.UIElements;

[Token(Token = "0x2000490")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct StyleValueHandle : IEquatable<StyleValueHandle>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000F07")]
	private StyleValueType m_ValueType; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x4000F08")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int valueIndex; //Field offset: 0x4

	[Token(Token = "0x17000925")]
	public internal StyleValueType valueType
	{
		[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
		[Token(Token = "0x6002249")]
		 get { } //Length: 5
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x600224A")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 3
	}

	[Address(RVA = "0x32911A0", Offset = "0x32905A0", Length = "0x7")]
	[Token(Token = "0x600224B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StyleValueHandle(int valueIndex, StyleValueType valueType) { }

	[Address(RVA = "0x2FEFAC0", Offset = "0x2FEEEC0", Length = "0x12")]
	[Token(Token = "0x600224D")]
	public override bool Equals(StyleValueHandle other) { }

	[Address(RVA = "0x3291080", Offset = "0x3290480", Length = "0x8B")]
	[Token(Token = "0x600224E")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x6002249")]
	public StyleValueType get_valueType() { }

	[Address(RVA = "0x3291110", Offset = "0x3290510", Length = "0x69")]
	[Token(Token = "0x600224F")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3291180", Offset = "0x3290580", Length = "0x12")]
	[Token(Token = "0x600224C")]
	public bool IsVarFunction() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x600224A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_valueType(StyleValueType value) { }

}


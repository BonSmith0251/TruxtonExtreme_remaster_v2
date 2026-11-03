namespace UnityEngine.UIElements;

[Token(Token = "0x2000407")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct MaterialPropertyValue : IEquatable<MaterialPropertyValue>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D93")]
	public string name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000D94")]
	public MaterialPropertyValueType type; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000D95")]
	public Vector4 packedValue; //Field offset: 0xC
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D96")]
	public Texture textureValue; //Field offset: 0x20

	[Address(RVA = "0x32735F0", Offset = "0x32729F0", Length = "0xA4")]
	[Token(Token = "0x6001E8A")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x32736A0", Offset = "0x3272AA0", Length = "0x12C")]
	[Token(Token = "0x6001E8B")]
	public override bool Equals(MaterialPropertyValue other) { }

	[Address(RVA = "0x32737D0", Offset = "0x3272BD0", Length = "0x17")]
	[Token(Token = "0x6001E87")]
	public Color GetColor() { }

	[Address(RVA = "0x2FB4CA0", Offset = "0x2FB40A0", Length = "0x8")]
	[Token(Token = "0x6001E85")]
	public float GetFloat() { }

	[Address(RVA = "0x32737F0", Offset = "0x3272BF0", Length = "0x239")]
	[Token(Token = "0x6001E8C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3273A30", Offset = "0x3272E30", Length = "0xB")]
	[Token(Token = "0x6001E86")]
	public Vector4 GetVector() { }

	[Address(RVA = "0x3273BA0", Offset = "0x3272FA0", Length = "0x34")]
	[Token(Token = "0x6001E89")]
	public static bool op_Inequality(MaterialPropertyValue lhs, MaterialPropertyValue rhs) { }

	[Address(RVA = "0x3273A40", Offset = "0x3272E40", Length = "0x15D")]
	[Token(Token = "0x6001E88")]
	public virtual string ToString() { }

}


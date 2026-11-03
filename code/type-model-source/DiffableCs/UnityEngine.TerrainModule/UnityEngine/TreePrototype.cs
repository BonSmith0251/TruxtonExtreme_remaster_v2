namespace UnityEngine;

[NativeAsStruct]
[Token(Token = "0x2000006")]
[UsedByNativeCode]
public sealed class TreePrototype
{
	[FieldOffset(Offset = "0x10")]
	[NativeName("prefab")]
	[Token(Token = "0x4000003")]
	internal GameObject m_Prefab; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeName("bendFactor")]
	[Token(Token = "0x4000004")]
	internal float m_BendFactor; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[NativeName("navMeshLod")]
	[Token(Token = "0x4000005")]
	internal int m_NavMeshLod; //Field offset: 0x1C

	[Token(Token = "0x17000006")]
	public float bendFactor
	{
		[Address(RVA = "0x2F896F0", Offset = "0x2F88AF0", Length = "0x8")]
		[Token(Token = "0x6000012")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000007")]
	public int navMeshLod
	{
		[Address(RVA = "0x1C18DC0", Offset = "0x1C181C0", Length = "0x6")]
		[Token(Token = "0x6000013")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000005")]
	public GameObject prefab
	{
		[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
		[Token(Token = "0x6000011")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000014")]
	public TreePrototype() { }

	[Address(RVA = "0x316B860", Offset = "0x316AC60", Length = "0x132")]
	[Token(Token = "0x6000015")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x316B9A0", Offset = "0x316ADA0", Length = "0x108")]
	[Token(Token = "0x6000017")]
	private bool Equals(TreePrototype other) { }

	[Address(RVA = "0x2F896F0", Offset = "0x2F88AF0", Length = "0x8")]
	[Token(Token = "0x6000012")]
	public float get_bendFactor() { }

	[Address(RVA = "0x1C18DC0", Offset = "0x1C181C0", Length = "0x6")]
	[Token(Token = "0x6000013")]
	public int get_navMeshLod() { }

	[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
	[Token(Token = "0x6000011")]
	public GameObject get_prefab() { }

	[Address(RVA = "0x306AEA0", Offset = "0x306A2A0", Length = "0x9")]
	[Token(Token = "0x6000016")]
	public virtual int GetHashCode() { }

}


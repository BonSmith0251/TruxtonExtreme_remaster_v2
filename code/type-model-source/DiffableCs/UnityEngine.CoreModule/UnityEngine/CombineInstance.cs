namespace UnityEngine;

[Token(Token = "0x2000133")]
public struct CombineInstance
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003F7")]
	private int m_MeshInstanceID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40003F8")]
	private int m_SubMeshIndex; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40003F9")]
	private Matrix4x4 m_Transform; //Field offset: 0x8
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40003FA")]
	private Vector4 m_LightmapScaleOffset; //Field offset: 0x48
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40003FB")]
	private Vector4 m_RealtimeLightmapScaleOffset; //Field offset: 0x58

	[Token(Token = "0x17000208")]
	public Mesh mesh
	{
		[Address(RVA = "0x301C160", Offset = "0x301B560", Length = "0x82")]
		[Token(Token = "0x6000D5B")]
		 set { } //Length: 130
	}

	[Token(Token = "0x17000209")]
	public int subMeshIndex
	{
		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[Token(Token = "0x6000D5C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700020A")]
	public Matrix4x4 transform
	{
		[Address(RVA = "0x301C1F0", Offset = "0x301B5F0", Length = "0x20")]
		[Token(Token = "0x6000D5D")]
		 set { } //Length: 32
	}

	[Address(RVA = "0x301C160", Offset = "0x301B560", Length = "0x82")]
	[Token(Token = "0x6000D5B")]
	public void set_mesh(Mesh value) { }

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[Token(Token = "0x6000D5C")]
	public void set_subMeshIndex(int value) { }

	[Address(RVA = "0x301C1F0", Offset = "0x301B5F0", Length = "0x20")]
	[Token(Token = "0x6000D5D")]
	public void set_transform(Matrix4x4 value) { }

}


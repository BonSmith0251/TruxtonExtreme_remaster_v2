namespace UnityEngine.Rendering;

[Token(Token = "0x20003FF")]
[UsedByNativeCode]
public struct VisibleReflectionProbe : IEquatable<VisibleReflectionProbe>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D6E")]
	private Bounds m_Bounds; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D6F")]
	private Matrix4x4 m_LocalToWorldMatrix; //Field offset: 0x18
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000D70")]
	private Vector4 m_HdrData; //Field offset: 0x58
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D71")]
	private Vector3 m_Center; //Field offset: 0x68
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000D72")]
	private float m_BlendDistance; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000D73")]
	private int m_Importance; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000D74")]
	private int m_BoxProjection; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000D75")]
	private int m_InstanceId; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000D76")]
	private int m_TextureId; //Field offset: 0x84

	[Token(Token = "0x17000499")]
	public float blendDistance
	{
		[Address(RVA = "0x30D0F90", Offset = "0x30D0390", Length = "0x8")]
		[Token(Token = "0x6001EEC")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000496")]
	public Bounds bounds
	{
		[Address(RVA = "0x30D0FA0", Offset = "0x30D03A0", Length = "0x14")]
		[Token(Token = "0x6001EE9")]
		 get { } //Length: 20
	}

	[Token(Token = "0x17000498")]
	public Vector4 hdrData
	{
		[Address(RVA = "0x30D0FC0", Offset = "0x30D03C0", Length = "0xB")]
		[Token(Token = "0x6001EEB")]
		 get { } //Length: 11
	}

	[Token(Token = "0x1700049A")]
	public int importance
	{
		[Address(RVA = "0x30D0FD0", Offset = "0x30D03D0", Length = "0x6")]
		[Token(Token = "0x6001EED")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700049B")]
	public bool isBoxProjection
	{
		[Address(RVA = "0x30D0FE0", Offset = "0x30D03E0", Length = "0x4B")]
		[Token(Token = "0x6001EEE")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000497")]
	public Matrix4x4 localToWorldMatrix
	{
		[Address(RVA = "0x199AB70", Offset = "0x1999F70", Length = "0x23")]
		[Token(Token = "0x6001EEA")]
		 get { } //Length: 35
	}

	[Token(Token = "0x17000495")]
	public ReflectionProbe reflectionProbe
	{
		[Address(RVA = "0x30D1030", Offset = "0x30D0430", Length = "0x86")]
		[Token(Token = "0x6001EE8")]
		 get { } //Length: 134
	}

	[Token(Token = "0x17000494")]
	public Texture texture
	{
		[Address(RVA = "0x30D10C0", Offset = "0x30D04C0", Length = "0xA0")]
		[Token(Token = "0x6001EE7")]
		 get { } //Length: 160
	}

	[Address(RVA = "0x30D0B60", Offset = "0x30CFF60", Length = "0x28B")]
	[Token(Token = "0x6001EEF")]
	public override bool Equals(VisibleReflectionProbe other) { }

	[Address(RVA = "0x30D0A50", Offset = "0x30CFE50", Length = "0x101")]
	[Token(Token = "0x6001EF0")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x30D0F90", Offset = "0x30D0390", Length = "0x8")]
	[Token(Token = "0x6001EEC")]
	public float get_blendDistance() { }

	[Address(RVA = "0x30D0FA0", Offset = "0x30D03A0", Length = "0x14")]
	[Token(Token = "0x6001EE9")]
	public Bounds get_bounds() { }

	[Address(RVA = "0x30D0FC0", Offset = "0x30D03C0", Length = "0xB")]
	[Token(Token = "0x6001EEB")]
	public Vector4 get_hdrData() { }

	[Address(RVA = "0x30D0FD0", Offset = "0x30D03D0", Length = "0x6")]
	[Token(Token = "0x6001EED")]
	public int get_importance() { }

	[Address(RVA = "0x30D0FE0", Offset = "0x30D03E0", Length = "0x4B")]
	[Token(Token = "0x6001EEE")]
	public bool get_isBoxProjection() { }

	[Address(RVA = "0x199AB70", Offset = "0x1999F70", Length = "0x23")]
	[Token(Token = "0x6001EEA")]
	public Matrix4x4 get_localToWorldMatrix() { }

	[Address(RVA = "0x30D1030", Offset = "0x30D0430", Length = "0x86")]
	[Token(Token = "0x6001EE8")]
	public ReflectionProbe get_reflectionProbe() { }

	[Address(RVA = "0x30D10C0", Offset = "0x30D04C0", Length = "0xA0")]
	[Token(Token = "0x6001EE7")]
	public Texture get_texture() { }

	[Address(RVA = "0x30D0DF0", Offset = "0x30D01F0", Length = "0x191")]
	[Token(Token = "0x6001EF1")]
	public virtual int GetHashCode() { }

}


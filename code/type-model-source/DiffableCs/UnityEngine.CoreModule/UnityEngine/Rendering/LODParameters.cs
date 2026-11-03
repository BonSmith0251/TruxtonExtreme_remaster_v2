namespace UnityEngine.Rendering;

[Token(Token = "0x20003DC")]
public struct LODParameters : IEquatable<LODParameters>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C94")]
	private int m_IsOrthographic; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000C95")]
	private Vector3 m_CameraPosition; //Field offset: 0x4
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C96")]
	private float m_FieldOfView; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000C97")]
	private float m_OrthoSize; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C98")]
	private int m_CameraPixelHeight; //Field offset: 0x18

	[Token(Token = "0x17000435")]
	public int cameraPixelHeight
	{
		[Address(RVA = "0xE0D7C0", Offset = "0xE0CBC0", Length = "0x6")]
		[Token(Token = "0x6001DC0")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000432")]
	public Vector3 cameraPosition
	{
		[Address(RVA = "0x30C03A0", Offset = "0x30BF7A0", Length = "0x13")]
		[Token(Token = "0x6001DBD")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000433")]
	public float fieldOfView
	{
		[Address(RVA = "0x2FB4C90", Offset = "0x2FB4090", Length = "0x8")]
		[Token(Token = "0x6001DBE")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000431")]
	public bool isOrthographic
	{
		[Address(RVA = "0x30C03C0", Offset = "0x30BF7C0", Length = "0x4A")]
		[Token(Token = "0x6001DBB")]
		 get { } //Length: 74
		[Address(RVA = "0x30C0410", Offset = "0x30BF810", Length = "0x58")]
		[Token(Token = "0x6001DBC")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000434")]
	public float orthoSize
	{
		[Address(RVA = "0x199AC40", Offset = "0x199A040", Length = "0x8")]
		[Token(Token = "0x6001DBF")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x30C01A0", Offset = "0x30BF5A0", Length = "0x9F")]
	[Token(Token = "0x6001DC1")]
	public override bool Equals(LODParameters other) { }

	[Address(RVA = "0x30C0240", Offset = "0x30BF640", Length = "0xA2")]
	[Token(Token = "0x6001DC2")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xE0D7C0", Offset = "0xE0CBC0", Length = "0x6")]
	[Token(Token = "0x6001DC0")]
	public int get_cameraPixelHeight() { }

	[Address(RVA = "0x30C03A0", Offset = "0x30BF7A0", Length = "0x13")]
	[Token(Token = "0x6001DBD")]
	public Vector3 get_cameraPosition() { }

	[Address(RVA = "0x2FB4C90", Offset = "0x2FB4090", Length = "0x8")]
	[Token(Token = "0x6001DBE")]
	public float get_fieldOfView() { }

	[Address(RVA = "0x30C03C0", Offset = "0x30BF7C0", Length = "0x4A")]
	[Token(Token = "0x6001DBB")]
	public bool get_isOrthographic() { }

	[Address(RVA = "0x199AC40", Offset = "0x199A040", Length = "0x8")]
	[Token(Token = "0x6001DBF")]
	public float get_orthoSize() { }

	[Address(RVA = "0x30C02F0", Offset = "0x30BF6F0", Length = "0xA7")]
	[Token(Token = "0x6001DC3")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x30C0410", Offset = "0x30BF810", Length = "0x58")]
	[Token(Token = "0x6001DBC")]
	public void set_isOrthographic(bool value) { }

}


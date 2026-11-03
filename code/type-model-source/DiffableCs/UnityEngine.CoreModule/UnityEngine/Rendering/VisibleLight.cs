namespace UnityEngine.Rendering;

[Token(Token = "0x20003FD")]
[UsedByNativeCode]
public struct VisibleLight : IEquatable<VisibleLight>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D60")]
	private LightType m_LightType; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000D61")]
	private Color m_FinalColor; //Field offset: 0x4
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000D62")]
	private Rect m_ScreenRect; //Field offset: 0x14
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000D63")]
	private Matrix4x4 m_LocalToWorldMatrix; //Field offset: 0x24
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000D64")]
	private float m_Range; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D65")]
	private float m_SpotAngle; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000D66")]
	private float m_InnerSpotAngle; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000D67")]
	private Vector2 m_AreaSize; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000D68")]
	private int m_InstanceId; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000D69")]
	private VisibleLightFlags m_Flags; //Field offset: 0x7C

	[Token(Token = "0x17000490")]
	public Color finalColor
	{
		[Address(RVA = "0x30D0960", Offset = "0x30CFD60", Length = "0xB")]
		[Token(Token = "0x6001EE0")]
		 get { } //Length: 11
	}

	[Token(Token = "0x1700048E")]
	public Light light
	{
		[Address(RVA = "0x30D0970", Offset = "0x30CFD70", Length = "0x83")]
		[Token(Token = "0x6001EDE")]
		 get { } //Length: 131
	}

	[Token(Token = "0x1700048F")]
	public LightType lightType
	{
		[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
		[Token(Token = "0x6001EDF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000491")]
	public Matrix4x4 localToWorldMatrix
	{
		[Address(RVA = "0x30D0A00", Offset = "0x30CFE00", Length = "0x23")]
		[Token(Token = "0x6001EE1")]
		 get { } //Length: 35
	}

	[Token(Token = "0x17000492")]
	public float range
	{
		[Address(RVA = "0x30D0A30", Offset = "0x30CFE30", Length = "0x8")]
		[Token(Token = "0x6001EE2")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000493")]
	public float spotAngle
	{
		[Address(RVA = "0x30D0A40", Offset = "0x30CFE40", Length = "0x8")]
		[Token(Token = "0x6001EE3")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x30D03D0", Offset = "0x30CF7D0", Length = "0x2C1")]
	[Token(Token = "0x6001EE4")]
	public override bool Equals(VisibleLight other) { }

	[Address(RVA = "0x30D06A0", Offset = "0x30CFAA0", Length = "0xF0")]
	[Token(Token = "0x6001EE5")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x30D0960", Offset = "0x30CFD60", Length = "0xB")]
	[Token(Token = "0x6001EE0")]
	public Color get_finalColor() { }

	[Address(RVA = "0x30D0970", Offset = "0x30CFD70", Length = "0x83")]
	[Token(Token = "0x6001EDE")]
	public Light get_light() { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x6001EDF")]
	public LightType get_lightType() { }

	[Address(RVA = "0x30D0A00", Offset = "0x30CFE00", Length = "0x23")]
	[Token(Token = "0x6001EE1")]
	public Matrix4x4 get_localToWorldMatrix() { }

	[Address(RVA = "0x30D0A30", Offset = "0x30CFE30", Length = "0x8")]
	[Token(Token = "0x6001EE2")]
	public float get_range() { }

	[Address(RVA = "0x30D0A40", Offset = "0x30CFE40", Length = "0x8")]
	[Token(Token = "0x6001EE3")]
	public float get_spotAngle() { }

	[Address(RVA = "0x30D07A0", Offset = "0x30CFBA0", Length = "0x1B4")]
	[Token(Token = "0x6001EE6")]
	public virtual int GetHashCode() { }

}


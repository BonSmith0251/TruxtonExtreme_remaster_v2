namespace UnityEngine.Experimental.GlobalIllumination;

[Token(Token = "0x2000415")]
[UsedByNativeCode]
public struct LightDataGI
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000DFC")]
	public EntityId entityId; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000DFD")]
	public EntityId cookieTextureEntityId; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000DFE")]
	public float cookieScale; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000DFF")]
	public LinearColor color; //Field offset: 0xC
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000E00")]
	public LinearColor indirectColor; //Field offset: 0x1C
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000E01")]
	public Quaternion orientation; //Field offset: 0x2C
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000E02")]
	public Vector3 position; //Field offset: 0x3C
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000E03")]
	public float range; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000E04")]
	public float coneAngle; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000E05")]
	public float innerConeAngle; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000E06")]
	public float shape0; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000E07")]
	public float shape1; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000E08")]
	public LightType type; //Field offset: 0x5C
	[FieldOffset(Offset = "0x5D")]
	[Token(Token = "0x4000E09")]
	public LightMode mode; //Field offset: 0x5D
	[FieldOffset(Offset = "0x5E")]
	[Token(Token = "0x4000E0A")]
	public byte shadow; //Field offset: 0x5E
	[FieldOffset(Offset = "0x5F")]
	[Token(Token = "0x4000E0B")]
	public FalloffType falloff; //Field offset: 0x5F

	[Address(RVA = "0x30C0500", Offset = "0x30BF900", Length = "0x72")]
	[Token(Token = "0x6001F35")]
	public void Init(ref DirectionalLight light, ref Cookie cookie) { }

	[Address(RVA = "0x30C0630", Offset = "0x30BFA30", Length = "0x6D")]
	[Token(Token = "0x6001F36")]
	public void Init(ref PointLight light, ref Cookie cookie) { }

	[Address(RVA = "0x30C0480", Offset = "0x30BF880", Length = "0x7E")]
	[Token(Token = "0x6001F37")]
	public void Init(ref SpotLight light, ref Cookie cookie) { }

	[Address(RVA = "0x30C07A0", Offset = "0x30BFBA0", Length = "0x6E")]
	[Token(Token = "0x6001F38")]
	public void Init(ref RectangleLight light, ref Cookie cookie) { }

	[Address(RVA = "0x30C06A0", Offset = "0x30BFAA0", Length = "0x6D")]
	[Token(Token = "0x6001F39")]
	public void Init(ref DiscLight light, ref Cookie cookie) { }

	[Address(RVA = "0x30C0710", Offset = "0x30BFB10", Length = "0x8F")]
	[Token(Token = "0x6001F3A")]
	public void Init(ref DirectionalLight light) { }

	[Address(RVA = "0x30C0810", Offset = "0x30BFC10", Length = "0x90")]
	[Token(Token = "0x6001F3B")]
	public void Init(ref PointLight light) { }

	[Address(RVA = "0x30C0580", Offset = "0x30BF980", Length = "0xA4")]
	[Token(Token = "0x6001F3C")]
	public void Init(ref SpotLight light) { }

	[Address(RVA = "0x30C0470", Offset = "0x30BF870", Length = "0x7")]
	[Token(Token = "0x6001F3D")]
	public void InitNoBake(EntityId lightEntityId) { }

}


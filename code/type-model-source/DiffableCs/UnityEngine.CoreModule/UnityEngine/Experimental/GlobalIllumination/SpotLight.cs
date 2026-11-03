namespace UnityEngine.Experimental.GlobalIllumination;

[Token(Token = "0x2000411")]
public struct SpotLight
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000DD7")]
	public EntityId entityId; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000DD8")]
	public bool shadow; //Field offset: 0x4
	[FieldOffset(Offset = "0x5")]
	[Token(Token = "0x4000DD9")]
	public LightMode mode; //Field offset: 0x5
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000DDA")]
	public Vector3 position; //Field offset: 0x8
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000DDB")]
	public Quaternion orientation; //Field offset: 0x14
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000DDC")]
	public LinearColor color; //Field offset: 0x24
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000DDD")]
	public LinearColor indirectColor; //Field offset: 0x34
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000DDE")]
	public float range; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000DDF")]
	public float sphereRadius; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000DE0")]
	public float coneAngle; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000DE1")]
	public float innerConeAngle; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000DE2")]
	public FalloffType falloff; //Field offset: 0x54
	[FieldOffset(Offset = "0x55")]
	[Token(Token = "0x4000DE3")]
	public AngularFalloffType angularFalloff; //Field offset: 0x55

}


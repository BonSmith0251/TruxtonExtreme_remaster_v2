namespace UnityEngine.Experimental.GlobalIllumination;

[Token(Token = "0x2000410")]
public struct PointLight
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000DCD")]
	public EntityId entityId; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000DCE")]
	public bool shadow; //Field offset: 0x4
	[FieldOffset(Offset = "0x5")]
	[Token(Token = "0x4000DCF")]
	public LightMode mode; //Field offset: 0x5
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000DD0")]
	public Vector3 position; //Field offset: 0x8
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000DD1")]
	public Quaternion orientation; //Field offset: 0x14
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000DD2")]
	public LinearColor color; //Field offset: 0x24
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000DD3")]
	public LinearColor indirectColor; //Field offset: 0x34
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000DD4")]
	public float range; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000DD5")]
	public float sphereRadius; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000DD6")]
	public FalloffType falloff; //Field offset: 0x4C

}


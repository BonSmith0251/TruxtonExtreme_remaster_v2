namespace UnityEngine.Experimental.GlobalIllumination;

[Token(Token = "0x2000414")]
public struct Cookie
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000DF9")]
	public EntityId entityId; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000DFA")]
	public float scale; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000DFB")]
	public Vector2 sizes; //Field offset: 0x8

	[Address(RVA = "0x30BCAF0", Offset = "0x30BBEF0", Length = "0x43")]
	[Token(Token = "0x6001F34")]
	public static Cookie Defaults() { }

}


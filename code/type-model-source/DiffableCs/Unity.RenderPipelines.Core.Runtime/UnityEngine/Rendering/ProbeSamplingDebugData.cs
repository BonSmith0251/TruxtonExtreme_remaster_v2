namespace UnityEngine.Rendering;

[Token(Token = "0x200011F")]
internal class ProbeSamplingDebugData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000518")]
	public ProbeSamplingDebugUpdate update; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000519")]
	public Vector2 coordinates; //Field offset: 0x14
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400051A")]
	public bool forceScreenCenterCoordinates; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400051B")]
	public Camera camera; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400051C")]
	public bool shortcutPressed; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400051D")]
	public GraphicsBuffer positionNormalBuffer; //Field offset: 0x30

	[Address(RVA = "0x2C15B10", Offset = "0x2C14F10", Length = "0x15")]
	[Token(Token = "0x6000A3F")]
	public ProbeSamplingDebugData() { }

}


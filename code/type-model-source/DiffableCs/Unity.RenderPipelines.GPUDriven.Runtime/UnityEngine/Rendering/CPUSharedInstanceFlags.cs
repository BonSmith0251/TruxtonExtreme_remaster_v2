namespace UnityEngine.Rendering;

[Token(Token = "0x2000084")]
internal struct CPUSharedInstanceFlags
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400025D")]
	public TransformUpdateFlags transformUpdateFlags; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x400025E")]
	public InstanceFlags instanceFlags; //Field offset: 0x1

}


namespace UnityEngine.Rendering;

[Token(Token = "0x20003AD")]
public struct BatchRendererGroupCreateInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B7A")]
	public OnPerformCulling cullingCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000B7B")]
	public OnFinishedCulling finishedCullingCallback; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B7C")]
	public IntPtr userContext; //Field offset: 0x10

}


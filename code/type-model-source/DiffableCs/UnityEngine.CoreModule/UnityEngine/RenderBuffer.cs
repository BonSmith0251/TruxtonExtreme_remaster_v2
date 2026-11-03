namespace UnityEngine;

[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[Token(Token = "0x20000DA")]
public struct RenderBuffer
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000263")]
	internal int m_RenderTextureInstanceID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000264")]
	internal IntPtr m_BufferPtr; //Field offset: 0x8

}


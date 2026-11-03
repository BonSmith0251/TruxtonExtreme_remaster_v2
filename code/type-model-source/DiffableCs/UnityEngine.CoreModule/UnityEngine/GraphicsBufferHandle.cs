namespace UnityEngine;

[IsReadOnly]
[NativeClass("GfxBufferID")]
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[Token(Token = "0x20000F0")]
public struct GraphicsBufferHandle : IEquatable<GraphicsBufferHandle>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400028A")]
	public readonly uint value; //Field offset: 0x0

	[Address(RVA = "0x2FF3C80", Offset = "0x2FF3080", Length = "0x7F")]
	[Token(Token = "0x60009F0")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2FD0220", Offset = "0x2FCF620", Length = "0x8")]
	[Token(Token = "0x60009F1")]
	public override bool Equals(GraphicsBufferHandle other) { }

	[Address(RVA = "0x2FF3D00", Offset = "0x2FF3100", Length = "0x9")]
	[Token(Token = "0x60009EF")]
	public virtual int GetHashCode() { }

}


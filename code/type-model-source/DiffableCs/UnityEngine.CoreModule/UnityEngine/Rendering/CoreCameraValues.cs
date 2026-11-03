namespace UnityEngine.Rendering;

[Token(Token = "0x20003C8")]
[UsedByNativeCode]
internal struct CoreCameraValues : IEquatable<CoreCameraValues>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C18")]
	private int filterMode; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000C19")]
	private uint cullingMask; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000C1A")]
	private int instanceID; //Field offset: 0x8

	[Address(RVA = "0x30757F0", Offset = "0x3074BF0", Length = "0x1B")]
	[Token(Token = "0x6001D5F")]
	public override bool Equals(CoreCameraValues other) { }

	[Address(RVA = "0x30BCB40", Offset = "0x30BBF40", Length = "0xC1")]
	[Token(Token = "0x6001D60")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x30BCC10", Offset = "0x30BC010", Length = "0x15")]
	[Token(Token = "0x6001D61")]
	public virtual int GetHashCode() { }

}


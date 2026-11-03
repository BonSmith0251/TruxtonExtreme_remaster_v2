namespace UnityEngine.Rendering;

[Token(Token = "0x20003A0")]
public struct BatchPackedCullingViewID : IEquatable<BatchPackedCullingViewID>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AFA")]
	internal ulong handle; //Field offset: 0x0

	[Address(RVA = "0xFD2260", Offset = "0xFD1660", Length = "0x9")]
	[Token(Token = "0x6001CE7")]
	public override bool Equals(BatchPackedCullingViewID other) { }

	[Address(RVA = "0x30987D0", Offset = "0x3097BD0", Length = "0x81")]
	[Token(Token = "0x6001CE8")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3098860", Offset = "0x3097C60", Length = "0x9")]
	[Token(Token = "0x6001CE6")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x6001CE9")]
	public int GetInstanceID() { }

}


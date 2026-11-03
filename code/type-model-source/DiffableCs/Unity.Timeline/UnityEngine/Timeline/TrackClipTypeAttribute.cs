namespace UnityEngine.Timeline;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = True)]
[Token(Token = "0x2000062")]
public class TrackClipTypeAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000161")]
	public readonly Type inspectedType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000162")]
	public readonly bool allowAutoCreate; //Field offset: 0x18

	[Address(RVA = "0x2F4A460", Offset = "0x2F49860", Length = "0x36")]
	[Token(Token = "0x600031F")]
	public TrackClipTypeAttribute(Type clipClass) { }

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6000320")]
	public TrackClipTypeAttribute(Type clipClass, bool allowAutoCreate) { }

}


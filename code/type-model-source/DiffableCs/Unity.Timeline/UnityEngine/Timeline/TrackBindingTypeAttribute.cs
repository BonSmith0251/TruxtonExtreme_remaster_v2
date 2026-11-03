namespace UnityEngine.Timeline;

[AttributeUsage(AttributeTargets::Class (4))]
[Token(Token = "0x2000065")]
public class TrackBindingTypeAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000167")]
	public readonly Type type; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000168")]
	public readonly TrackBindingFlags flags; //Field offset: 0x18

	[Address(RVA = "0x2F4A170", Offset = "0x2F49570", Length = "0x39")]
	[Token(Token = "0x6000322")]
	public TrackBindingTypeAttribute(Type type) { }

	[Address(RVA = "0x5D2830", Offset = "0x5D1C30", Length = "0x42")]
	[Token(Token = "0x6000323")]
	public TrackBindingTypeAttribute(Type type, TrackBindingFlags flags) { }

}


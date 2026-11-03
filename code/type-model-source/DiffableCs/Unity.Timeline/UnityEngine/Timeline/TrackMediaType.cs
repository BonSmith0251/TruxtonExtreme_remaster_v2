namespace UnityEngine.Timeline;

[AttributeUsage(AttributeTargets::Class (4))]
[Obsolete("TrackMediaType has been deprecated. It is no longer required, and will be removed in a future release.", False)]
[Token(Token = "0x2000061")]
public class TrackMediaType : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000160")]
	public readonly MediaType m_MediaType; //Field offset: 0x10

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x600031E")]
	public TrackMediaType(MediaType mt) { }

}


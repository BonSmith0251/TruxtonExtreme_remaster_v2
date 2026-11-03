namespace UnityEngine.Timeline;

[NotKeyable]
[Token(Token = "0x200002C")]
internal class AudioClipProperties : PlayableBehaviour
{
	[FieldOffset(Offset = "0x10")]
	[Range(0, 1)]
	[Token(Token = "0x40000D5")]
	public float volume; //Field offset: 0x10

	[Address(RVA = "0x2F279D0", Offset = "0x2F26DD0", Length = "0xE")]
	[Token(Token = "0x60001C4")]
	public AudioClipProperties() { }

}


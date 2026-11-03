namespace UnityEngine.Timeline;

[Token(Token = "0x200002D")]
internal class AudioMixerProperties : PlayableBehaviour
{
	[FieldOffset(Offset = "0x10")]
	[Range(0, 1)]
	[Token(Token = "0x40000D6")]
	public float volume; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Range(-1, 1)]
	[Token(Token = "0x40000D7")]
	public float stereoPan; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Range(0, 1)]
	[Token(Token = "0x40000D8")]
	public float spatialBlend; //Field offset: 0x18

	[Address(RVA = "0x2F279D0", Offset = "0x2F26DD0", Length = "0xE")]
	[Token(Token = "0x60001C6")]
	public AudioMixerProperties() { }

	[Address(RVA = "0x2F279E0", Offset = "0x2F26DE0", Length = "0x32B")]
	[Token(Token = "0x60001C5")]
	public virtual void PrepareFrame(Playable playable, FrameData info) { }

}


namespace UnityEngine.Timeline;

[Token(Token = "0x2000005")]
internal class ActivationPlayableAsset : PlayableAsset, ITimelineClipAsset
{

	[Token(Token = "0x17000002")]
	public override ClipCaps clipCaps
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000009")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x1D308B0", Offset = "0x1D2FCB0", Length = "0x7")]
	[Token(Token = "0x600000B")]
	public ActivationPlayableAsset() { }

	[Address(RVA = "0x2F21970", Offset = "0x2F20D70", Length = "0x72")]
	[Token(Token = "0x600000A")]
	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000009")]
	public override ClipCaps get_clipCaps() { }

}


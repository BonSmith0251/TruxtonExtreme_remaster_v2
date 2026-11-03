//Type is in global namespace

[Token(Token = "0x2000005")]
internal class VisualEffectActivationClip : PlayableAsset, ITimelineClipAsset
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000010")]
	public VisualEffectActivationBehaviour activationBehavior; //Field offset: 0x18

	[Token(Token = "0x17000001")]
	public override ClipCaps clipCaps
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000002")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x2F79100", Offset = "0x2F78500", Length = "0x168")]
	[Token(Token = "0x6000004")]
	public VisualEffectActivationClip() { }

	[Address(RVA = "0x2F79000", Offset = "0x2F78400", Length = "0xFA")]
	[Token(Token = "0x6000003")]
	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000002")]
	public override ClipCaps get_clipCaps() { }

}


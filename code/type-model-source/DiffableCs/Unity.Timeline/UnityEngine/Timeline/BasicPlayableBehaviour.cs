namespace UnityEngine.Timeline;

[Obsolete("For best performance use PlayableAsset and PlayableBehaviour.")]
[Token(Token = "0x2000055")]
public class BasicPlayableBehaviour : ScriptableObject, IPlayableAsset, IPlayableBehaviour
{

	[Token(Token = "0x170000C8")]
	public override double duration
	{
		[Address(RVA = "0x2F28CF0", Offset = "0x2F280F0", Length = "0x50")]
		[Token(Token = "0x60002D5")]
		 get { } //Length: 80
	}

	[Token(Token = "0x170000C9")]
	public override IEnumerable<PlayableBinding> outputs
	{
		[Address(RVA = "0x2F28D40", Offset = "0x2F28140", Length = "0x4E")]
		[Token(Token = "0x60002D6")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x60002E0")]
	public BasicPlayableBehaviour() { }

	[Address(RVA = "0x2F28C20", Offset = "0x2F28020", Length = "0xC6")]
	[Token(Token = "0x60002DF")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	[Address(RVA = "0x2F28CF0", Offset = "0x2F280F0", Length = "0x50")]
	[Token(Token = "0x60002D5")]
	public override double get_duration() { }

	[Address(RVA = "0x2F28D40", Offset = "0x2F28140", Length = "0x4E")]
	[Token(Token = "0x60002D6")]
	public override IEnumerable<PlayableBinding> get_outputs() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002DC")]
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002DB")]
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002D7")]
	public override void OnGraphStart(Playable playable) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002D8")]
	public override void OnGraphStop(Playable playable) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002D9")]
	public override void OnPlayableCreate(Playable playable) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002DA")]
	public override void OnPlayableDestroy(Playable playable) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002DD")]
	public override void PrepareFrame(Playable playable, FrameData info) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002DE")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) { }

}


namespace UnityEngine.Playables;

[RequiredByNativeCode]
[Token(Token = "0x200031F")]
public abstract class PlayableBehaviour : IPlayableBehaviour, ICloneable
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600190F")]
	public PlayableBehaviour() { }

	[Address(RVA = "0x307C040", Offset = "0x307B440", Length = "0x9")]
	[Token(Token = "0x6001918")]
	public override object Clone() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001915")]
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001914")]
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001910")]
	public override void OnGraphStart(Playable playable) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001911")]
	public override void OnGraphStop(Playable playable) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001912")]
	public override void OnPlayableCreate(Playable playable) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001913")]
	public override void OnPlayableDestroy(Playable playable) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001916")]
	public override void PrepareFrame(Playable playable, FrameData info) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001917")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) { }

}


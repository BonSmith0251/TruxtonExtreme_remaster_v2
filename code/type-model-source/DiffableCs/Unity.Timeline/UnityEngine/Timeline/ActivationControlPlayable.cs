namespace UnityEngine.Timeline;

[Token(Token = "0x2000052")]
public class ActivationControlPlayable : PlayableBehaviour
{
	[Token(Token = "0x2000054")]
	private enum InitialState : int
	{
		Unset = 0,
		Active = 1,
		Inactive = 2,
	}

	[Token(Token = "0x2000053")]
	internal enum PostPlaybackState : int
	{
		Active = 0,
		Inactive = 1,
		Revert = 2,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000138")]
	public GameObject gameObject; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000139")]
	public PostPlaybackState postPlayback; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400013A")]
	private InitialState m_InitialState; //Field offset: 0x1C

	[Address(RVA = "0x2F21620", Offset = "0x2F20A20", Length = "0xE")]
	[Token(Token = "0x60002D4")]
	public ActivationControlPlayable() { }

	[Address(RVA = "0x2F211C0", Offset = "0x2F205C0", Length = "0x152")]
	[Token(Token = "0x60002CE")]
	public static ScriptPlayable<ActivationControlPlayable> Create(PlayableGraph graph, GameObject gameObject, PostPlaybackState postPlaybackState) { }

	[Address(RVA = "0x2F21320", Offset = "0x2F20720", Length = "0x91")]
	[Token(Token = "0x60002D0")]
	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	[Address(RVA = "0x2F213C0", Offset = "0x2F207C0", Length = "0x76")]
	[Token(Token = "0x60002CF")]
	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	[Address(RVA = "0x2F21440", Offset = "0x2F20840", Length = "0x84")]
	[Token(Token = "0x60002D2")]
	public virtual void OnGraphStart(Playable playable) { }

	[Address(RVA = "0x2F214D0", Offset = "0x2F208D0", Length = "0xCC")]
	[Token(Token = "0x60002D3")]
	public virtual void OnPlayableDestroy(Playable playable) { }

	[Address(RVA = "0x2F215A0", Offset = "0x2F209A0", Length = "0x76")]
	[Token(Token = "0x60002D1")]
	public virtual void ProcessFrame(Playable playable, FrameData info, object userData) { }

}


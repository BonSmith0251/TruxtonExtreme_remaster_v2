namespace UnityEngine.Timeline;

[Token(Token = "0x2000004")]
internal class ActivationMixerPlayable : PlayableBehaviour
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000006")]
	private PostPlaybackState m_PostPlaybackState; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000007")]
	private bool m_BoundGameObjectInitialStateIsActive; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000008")]
	private GameObject m_BoundGameObject; //Field offset: 0x18

	[Token(Token = "0x17000001")]
	public PostPlaybackState postPlaybackState
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000004")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x6000005")]
		 set { } //Length: 4
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000008")]
	public ActivationMixerPlayable() { }

	[Address(RVA = "0x2F21630", Offset = "0x2F20A30", Length = "0x91")]
	[Token(Token = "0x6000003")]
	public static ScriptPlayable<ActivationMixerPlayable> Create(PlayableGraph graph, int inputCount) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000004")]
	public PostPlaybackState get_postPlaybackState() { }

	[Address(RVA = "0x2F216D0", Offset = "0x2F20AD0", Length = "0xC3")]
	[Token(Token = "0x6000006")]
	public virtual void OnPlayableDestroy(Playable playable) { }

	[Address(RVA = "0x2F217A0", Offset = "0x2F20BA0", Length = "0x1C6")]
	[Token(Token = "0x6000007")]
	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x6000005")]
	public void set_postPlaybackState(PostPlaybackState value) { }

}


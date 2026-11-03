namespace UnityEngine.Timeline;

[Token(Token = "0x200005C")]
public class TimeControlPlayable : PlayableBehaviour
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000154")]
	private ITimeControl m_timeControl; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000155")]
	private bool m_started; //Field offset: 0x18

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000308")]
	public TimeControlPlayable() { }

	[Address(RVA = "0x2F42B40", Offset = "0x2F41F40", Length = "0x112")]
	[Token(Token = "0x6000303")]
	public static ScriptPlayable<TimeControlPlayable> Create(PlayableGraph graph, ITimeControl timeControl) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000304")]
	public void Initialize(ITimeControl timeControl) { }

	[Address(RVA = "0x2F42C60", Offset = "0x2F42060", Length = "0x51")]
	[Token(Token = "0x6000307")]
	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	[Address(RVA = "0x2F42CC0", Offset = "0x2F420C0", Length = "0x51")]
	[Token(Token = "0x6000306")]
	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	[Address(RVA = "0x2F42D20", Offset = "0x2F42120", Length = "0xE9")]
	[Token(Token = "0x6000305")]
	public virtual void PrepareFrame(Playable playable, FrameData info) { }

}


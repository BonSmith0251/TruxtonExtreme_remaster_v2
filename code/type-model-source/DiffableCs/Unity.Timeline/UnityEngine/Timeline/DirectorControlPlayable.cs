namespace UnityEngine.Timeline;

[Token(Token = "0x2000056")]
public class DirectorControlPlayable : PlayableBehaviour
{
	[Token(Token = "0x2000057")]
	internal enum PauseAction : int
	{
		StopDirector = 0,
		PauseDirector = 1,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000143")]
	public PlayableDirector director; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000144")]
	public PauseAction pauseAction; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000145")]
	private bool m_SyncTime; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000146")]
	private double m_AssetDuration; //Field offset: 0x20

	[Address(RVA = "0x2F2DB70", Offset = "0x2F2CF70", Length = "0x15")]
	[Token(Token = "0x60002ED")]
	public DirectorControlPlayable() { }

	[Address(RVA = "0x2F2C820", Offset = "0x2F2BC20", Length = "0x13F")]
	[Token(Token = "0x60002E1")]
	public static ScriptPlayable<DirectorControlPlayable> Create(PlayableGraph graph, PlayableDirector director) { }

	[Address(RVA = "0x2F2C960", Offset = "0x2F2BD60", Length = "0x11D")]
	[Token(Token = "0x60002EA")]
	private bool DetectDiscontinuity(Playable playable, FrameData info) { }

	[Address(RVA = "0x2F2CA80", Offset = "0x2F2BE80", Length = "0x150")]
	[Token(Token = "0x60002EB")]
	private bool DetectOutOfSync(Playable playable) { }

	[Address(RVA = "0x2F2CBE0", Offset = "0x2F2BFE0", Length = "0x100")]
	[Token(Token = "0x60002E5")]
	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	[Address(RVA = "0x2F2CCF0", Offset = "0x2F2C0F0", Length = "0xD1")]
	[Token(Token = "0x60002E4")]
	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	[Address(RVA = "0x2F2CDD0", Offset = "0x2F2C1D0", Length = "0xAC")]
	[Token(Token = "0x60002E2")]
	public virtual void OnPlayableDestroy(Playable playable) { }

	[Address(RVA = "0x2F2CE80", Offset = "0x2F2C280", Length = "0x442")]
	[Token(Token = "0x60002E3")]
	public virtual void PrepareFrame(Playable playable, FrameData info) { }

	[Address(RVA = "0x2F2D2D0", Offset = "0x2F2C6D0", Length = "0x3FA")]
	[Token(Token = "0x60002E6")]
	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	[Address(RVA = "0x2F2D6D0", Offset = "0x2F2CAD0", Length = "0x16C")]
	[Token(Token = "0x60002E7")]
	private void SyncSpeed(double speed) { }

	[Address(RVA = "0x2F2D840", Offset = "0x2F2CC40", Length = "0xBD")]
	[Token(Token = "0x60002E8")]
	private void SyncStart(PlayableGraph graph, double time) { }

	[Address(RVA = "0x2F2D900", Offset = "0x2F2CD00", Length = "0xCC")]
	[Token(Token = "0x60002E9")]
	private void SyncStop(PlayableGraph graph, double time) { }

	[Address(RVA = "0x2F2D9D0", Offset = "0x2F2CDD0", Length = "0x194")]
	[Token(Token = "0x60002EC")]
	private void UpdateTime(Playable playable) { }

}


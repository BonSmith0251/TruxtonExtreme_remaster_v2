namespace UnityEngine.Timeline;

[Token(Token = "0x200005A")]
public class ParticleControlPlayable : PlayableBehaviour
{
	[Token(Token = "0x400014E")]
	private const float kUnsetTime = 3.4028235E+38; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400014F")]
	private float m_LastPlayableTime; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000150")]
	private float m_LastParticleTime; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000151")]
	private uint m_RandomSeed; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000152")]
	private ParticleSystem <particleSystem>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x170000CA")]
	public private ParticleSystem particleSystem
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60002F2")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60002F3")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x2F42160", Offset = "0x2F41560", Length = "0x1C")]
	[Token(Token = "0x60002FA")]
	public ParticleControlPlayable() { }

	[Address(RVA = "0x2F41AC0", Offset = "0x2F40EC0", Length = "0x1A9")]
	[Token(Token = "0x60002F1")]
	public static ScriptPlayable<ParticleControlPlayable> Create(PlayableGraph graph, ParticleSystem component, uint randomSeed) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60002F2")]
	public ParticleSystem get_particleSystem() { }

	[Address(RVA = "0x2F41C70", Offset = "0x2F41070", Length = "0x89")]
	[Token(Token = "0x60002F4")]
	public void Initialize(ParticleSystem ps, uint randomSeed) { }

	[Address(RVA = "0x2F41D00", Offset = "0x2F41100", Length = "0x8")]
	[Token(Token = "0x60002F8")]
	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	[Address(RVA = "0x2F41D00", Offset = "0x2F41100", Length = "0x8")]
	[Token(Token = "0x60002F7")]
	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	[Address(RVA = "0x2F41D10", Offset = "0x2F41110", Length = "0x246")]
	[Token(Token = "0x60002F6")]
	public virtual void PrepareFrame(Playable playable, FrameData data) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60002F3")]
	private void set_particleSystem(ParticleSystem value) { }

	[Address(RVA = "0x2F41F60", Offset = "0x2F41360", Length = "0x11A")]
	[Token(Token = "0x60002F5")]
	private static void SetRandomSeed(ParticleSystem particleSystem, uint randomSeed) { }

	[Address(RVA = "0x2F42080", Offset = "0x2F41480", Length = "0xDD")]
	[Token(Token = "0x60002F9")]
	private void Simulate(float time, bool restart) { }

}


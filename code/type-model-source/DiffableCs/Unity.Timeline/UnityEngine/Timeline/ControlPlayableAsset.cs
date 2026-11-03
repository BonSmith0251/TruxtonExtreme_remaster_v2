namespace UnityEngine.Timeline;

[NotKeyable]
[Token(Token = "0x2000034")]
public class ControlPlayableAsset : PlayableAsset, IPropertyPreview, ITimelineClipAsset
{
	[CompilerGenerated]
	[Token(Token = "0x2000035")]
	private sealed class <GetControlableScripts>d__40 : IEnumerable<MonoBehaviour>, IEnumerable, IEnumerator<MonoBehaviour>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000104")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000105")]
		private MonoBehaviour <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000106")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000107")]
		private GameObject root; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000108")]
		public GameObject <>3__root; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000109")]
		private MonoBehaviour[] <>7__wrap1; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400010A")]
		private int <>7__wrap2; //Field offset: 0x40

		[Token(Token = "0x1700009A")]
		private override MonoBehaviour System.Collections.Generic.IEnumerator<UnityEngine.MonoBehaviour>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600020C")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700009B")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600020E")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000209")]
		public <GetControlableScripts>d__40(int <>1__state) { }

		[Address(RVA = "0x2F3EDA0", Offset = "0x2F3E1A0", Length = "0x144")]
		[Token(Token = "0x600020B")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2F3EEF0", Offset = "0x2F3E2F0", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x600020F")]
		private override IEnumerator<MonoBehaviour> System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600020C")]
		private override MonoBehaviour System.Collections.Generic.IEnumerator<UnityEngine.MonoBehaviour>.get_Current() { }

		[Address(RVA = "0x2F3EEF0", Offset = "0x2F3E2F0", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x6000210")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600020E")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2F3EF90", Offset = "0x2F3E390", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600020D")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600020A")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x40000EF")]
	private const int k_MaxRandInt = 10000; //Field offset: 0x0
	[Token(Token = "0x40000F0")]
	private static readonly List<PlayableDirector> k_EmptyDirectorsList; //Field offset: 0x0
	[Token(Token = "0x40000F1")]
	private static readonly List<ParticleSystem> k_EmptyParticlesList; //Field offset: 0x8
	[Token(Token = "0x40000F2")]
	private static readonly HashSet<ParticleSystem> s_SubEmitterCollector; //Field offset: 0x10
	[Token(Token = "0x4000100")]
	private static HashSet<PlayableDirector> s_ProcessedDirectors; //Field offset: 0x18
	[Token(Token = "0x4000101")]
	private static HashSet<GameObject> s_CreatedPrefabs; //Field offset: 0x20
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40000F3")]
	public ExposedReference<GameObject> sourceGameObject; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40000F4")]
	public GameObject prefabGameObject; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40000F5")]
	public bool updateParticle; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x40000F6")]
	public uint particleRandomSeed; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40000F7")]
	public bool updateDirector; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[SerializeField]
	[Token(Token = "0x40000F8")]
	public bool updateITimeControl; //Field offset: 0x39
	[FieldOffset(Offset = "0x3A")]
	[SerializeField]
	[Token(Token = "0x40000F9")]
	public bool searchHierarchy; //Field offset: 0x3A
	[FieldOffset(Offset = "0x3B")]
	[SerializeField]
	[Token(Token = "0x40000FA")]
	public bool active; //Field offset: 0x3B
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x40000FB")]
	public PostPlaybackState postPlayback; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40000FC")]
	public PauseAction directorOnClipEnd; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000FD")]
	private PlayableAsset m_ControlDirectorAsset; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000FE")]
	private double m_Duration; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000FF")]
	private bool m_SupportLoop; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x4000102")]
	private bool <controllingDirectors>k__BackingField; //Field offset: 0x59
	[CompilerGenerated]
	[FieldOffset(Offset = "0x5A")]
	[Token(Token = "0x4000103")]
	private bool <controllingParticles>k__BackingField; //Field offset: 0x5A

	[Token(Token = "0x17000099")]
	public override ClipCaps clipCaps
	{
		[Address(RVA = "0x2F2C5C0", Offset = "0x2F2B9C0", Length = "0xE")]
		[Token(Token = "0x60001F4")]
		 get { } //Length: 14
	}

	[Token(Token = "0x17000096")]
	internal bool controllingDirectors
	{
		[Address(RVA = "0x1CCAA30", Offset = "0x1CC9E30", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60001EE")]
		internal get { } //Length: 5
		[Address(RVA = "0x1CEB130", Offset = "0x1CEA530", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60001EF")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000097")]
	internal bool controllingParticles
	{
		[Address(RVA = "0x1CF2E00", Offset = "0x1CF2200", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60001F0")]
		internal get { } //Length: 5
		[Address(RVA = "0x2F2C5E0", Offset = "0x2F2B9E0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60001F1")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000098")]
	public virtual double duration
	{
		[Address(RVA = "0x2F2C5D0", Offset = "0x2F2B9D0", Length = "0x6")]
		[Token(Token = "0x60001F3")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2F2C320", Offset = "0x2F2B720", Length = "0x214")]
	[Token(Token = "0x6000208")]
	private static ControlPlayableAsset() { }

	[Address(RVA = "0x2F2C540", Offset = "0x2F2B940", Length = "0x77")]
	[Token(Token = "0x6000207")]
	public ControlPlayableAsset() { }

	[Address(RVA = "0x2F28D90", Offset = "0x2F28190", Length = "0xE9")]
	[Token(Token = "0x6000201")]
	private static void CacheSubEmitters(ParticleSystem ps, HashSet<ParticleSystem> subEmitters) { }

	[Address(RVA = "0x2F28E80", Offset = "0x2F28280", Length = "0xC0")]
	[Token(Token = "0x60001FB")]
	private static void ConnectMixerAndPlayable(PlayableGraph graph, Playable mixer, Playable playable, int portIndex) { }

	[Address(RVA = "0x2F28F40", Offset = "0x2F28340", Length = "0x204")]
	[Token(Token = "0x60001F6")]
	private static Playable ConnectPlayablesToMixer(PlayableGraph graph, List<Playable> playables) { }

	[Address(RVA = "0x2F29150", Offset = "0x2F28550", Length = "0x26B")]
	[Token(Token = "0x60001F7")]
	private void CreateActivationPlayable(GameObject root, PlayableGraph graph, List<Playable> outplayables) { }

	[Address(RVA = "0x2F293C0", Offset = "0x2F287C0", Length = "0xBB9")]
	[Token(Token = "0x60001F5")]
	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	[Address(RVA = "0x2F29F80", Offset = "0x2F29380", Length = "0x313")]
	[Token(Token = "0x6000202")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	[Address(RVA = "0x2F2C5C0", Offset = "0x2F2B9C0", Length = "0xE")]
	[Token(Token = "0x60001F4")]
	public override ClipCaps get_clipCaps() { }

	[Address(RVA = "0x1CCAA30", Offset = "0x1CC9E30", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60001EE")]
	internal bool get_controllingDirectors() { }

	[Address(RVA = "0x1CF2E00", Offset = "0x1CF2200", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60001F0")]
	internal bool get_controllingParticles() { }

	[Address(RVA = "0x2F2C5D0", Offset = "0x2F2B9D0", Length = "0x6")]
	[Token(Token = "0x60001F3")]
	public virtual double get_duration() { }

	[Address(RVA = "0x7AB710", Offset = "0x7AAB10", Length = "0xE7")]
	[Token(Token = "0x60001FC")]
	internal IList<T> GetComponent(GameObject gameObject) { }

	[Address(RVA = "0x2F2A2A0", Offset = "0x2F296A0", Length = "0x71")]
	[IteratorStateMachine(typeof(<GetControlableScripts>d__40))]
	[Token(Token = "0x60001FD")]
	internal static IEnumerable<MonoBehaviour> GetControlableScripts(GameObject root) { }

	[Address(RVA = "0x2F2A320", Offset = "0x2F29720", Length = "0x158")]
	[Token(Token = "0x60001FF")]
	private IList<ParticleSystem> GetControllableParticleSystems(GameObject go) { }

	[Address(RVA = "0x2F2A480", Offset = "0x2F29880", Length = "0x2B1")]
	[Token(Token = "0x6000200")]
	private static void GetControllableParticleSystems(Transform t, ICollection<ParticleSystem> roots, HashSet<ParticleSystem> subEmitters) { }

	[Address(RVA = "0x2F2A740", Offset = "0x2F29B40", Length = "0x2A")]
	[Token(Token = "0x60001F2")]
	public void OnEnable() { }

	[Address(RVA = "0x2F2A770", Offset = "0x2F29B70", Length = "0x26D")]
	[Token(Token = "0x6000204")]
	internal static void PreviewActivation(IPropertyCollector driver, IEnumerable<GameObject> objects) { }

	[Address(RVA = "0x2F2A9E0", Offset = "0x2F29DE0", Length = "0x29F")]
	[Token(Token = "0x6000206")]
	internal static void PreviewDirectors(IPropertyCollector driver, IEnumerable<PlayableDirector> directors) { }

	[Address(RVA = "0x2F2AC80", Offset = "0x2F2A080", Length = "0x364")]
	[Token(Token = "0x6000203")]
	internal static void PreviewParticles(IPropertyCollector driver, IEnumerable<ParticleSystem> particles) { }

	[Address(RVA = "0x2F2AFF0", Offset = "0x2F2A3F0", Length = "0x242")]
	[Token(Token = "0x6000205")]
	internal static void PreviewTimeControl(IPropertyCollector driver, PlayableDirector director, IEnumerable<MonoBehaviour> scripts) { }

	[Address(RVA = "0x2F2B240", Offset = "0x2F2A640", Length = "0x30E")]
	[Token(Token = "0x60001FA")]
	private static void SearchHierarchyAndConnectControlableScripts(IEnumerable<MonoBehaviour> controlableScripts, PlayableGraph graph, List<Playable> outplayables) { }

	[Address(RVA = "0x2F2B550", Offset = "0x2F2A950", Length = "0x3C6")]
	[Token(Token = "0x60001F9")]
	private void SearchHierarchyAndConnectDirector(IEnumerable<PlayableDirector> directors, PlayableGraph graph, List<Playable> outplayables, bool disableSelfReferences) { }

	[Address(RVA = "0x2F2B920", Offset = "0x2F2AD20", Length = "0x31A")]
	[Token(Token = "0x60001F8")]
	private void SearchHierarchyAndConnectParticleSystem(IEnumerable<ParticleSystem> particleSystems, PlayableGraph graph, List<Playable> outplayables) { }

	[Address(RVA = "0x1CEB130", Offset = "0x1CEA530", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60001EF")]
	private void set_controllingDirectors(bool value) { }

	[Address(RVA = "0x2F2C5E0", Offset = "0x2F2B9E0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60001F1")]
	private void set_controllingParticles(bool value) { }

	[Address(RVA = "0x2F2BC40", Offset = "0x2F2B040", Length = "0x6D5")]
	[Token(Token = "0x60001FE")]
	internal void UpdateDurationAndLoopFlag(IList<PlayableDirector> directors, IList<ParticleSystem> particleSystems) { }

}


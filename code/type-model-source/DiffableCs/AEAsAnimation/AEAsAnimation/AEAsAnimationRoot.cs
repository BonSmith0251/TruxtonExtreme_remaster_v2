namespace AEAsAnimation;

[Token(Token = "0x2000005")]
public class AEAsAnimationRoot : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000006")]
	private sealed class <>c__DisplayClass21_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000017")]
		public AEAsAnimationRoot <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000018")]
		public CompositionData mainComposition; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000019")]
		public Action<AEAsAnimationRoot> OnReady; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000032")]
		public <>c__DisplayClass21_0() { }

		[Address(RVA = "0x5C0F60", Offset = "0x5C0360", Length = "0xF3")]
		[Token(Token = "0x600003E")]
		internal void <ShowAsync>b__0(AEComposition rootNode) { }

		[Address(RVA = "0x5C10A0", Offset = "0x5C04A0", Length = "0x24")]
		[Token(Token = "0x6000033")]
		internal MetaData <ShowAsync>b__1() { }

		[Address(RVA = "0x5C1060", Offset = "0x5C0460", Length = "0x1B")]
		[Token(Token = "0x600003C")]
		internal AEMaterial <ShowAsync>b__10() { }

		[Address(RVA = "0x5C1080", Offset = "0x5C0480", Length = "0x1B")]
		[Token(Token = "0x600003D")]
		internal TextReflector <ShowAsync>b__11() { }

		[Address(RVA = "0x5C10D0", Offset = "0x5C04D0", Length = "0x6C")]
		[Token(Token = "0x6000034")]
		internal void <ShowAsync>b__2(AEComposition composition, GameObject root) { }

		[Address(RVA = "0x5C1140", Offset = "0x5C0540", Length = "0x6C")]
		[Token(Token = "0x6000035")]
		internal void <ShowAsync>b__3(AELayer layer, GameObject root) { }

		[Address(RVA = "0x5C11B0", Offset = "0x5C05B0", Length = "0x6C")]
		[Token(Token = "0x6000036")]
		internal void <ShowAsync>b__4(AELayer layer, AELayerReflection reflection) { }

		[Address(RVA = "0x5C1220", Offset = "0x5C0620", Length = "0x1B")]
		[Token(Token = "0x6000037")]
		internal GlobalColorData <ShowAsync>b__5() { }

		[Address(RVA = "0x5C1240", Offset = "0x5C0640", Length = "0x1B")]
		[Token(Token = "0x6000038")]
		internal IAETextureAccessor <ShowAsync>b__6() { }

		[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
		[Token(Token = "0x6000039")]
		internal IAEAudioAccessor <ShowAsync>b__7() { }

		[Address(RVA = "0x5C1280", Offset = "0x5C0680", Length = "0x1B")]
		[Token(Token = "0x600003A")]
		internal IAECompositionFilter <ShowAsync>b__8() { }

		[Address(RVA = "0x5C12A0", Offset = "0x5C06A0", Length = "0x1B")]
		[Token(Token = "0x600003B")]
		internal IAELayerFilter <ShowAsync>b__9() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000007")]
	private sealed class <>c__DisplayClass33_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400001A")]
		public Action<AELayer> callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600003F")]
		public <>c__DisplayClass33_0() { }

		[Address(RVA = "0x5C02B0", Offset = "0x5BF6B0", Length = "0x25")]
		[Token(Token = "0x6000040")]
		internal void <RegisterLayerObserver>b__0(AELayer layer) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000008")]
	private sealed class <ShowAsync>d__21 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400001B")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400001C")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400001D")]
		public AEAsAnimationRoot <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400001E")]
		public Action<AEAsAnimationRoot> OnReady; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400001F")]
		public IAETextureAccessor textures; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000020")]
		public IAEAudioAccessor audio; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000021")]
		public IAECompositionFilter compositionFilter; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000022")]
		public IAELayerFilter layerFilter; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000023")]
		public TextReflector textReflector; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000024")]
		public AEData data; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000025")]
		public Action<AEAsAnimationRoot> OnFailure; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000026")]
		private Stopwatch <stopWatch>5__2; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000027")]
		private IEnumerator <enumerator>5__3; //Field offset: 0x70

		[Token(Token = "0x17000009")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000044")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700000A")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000046")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000041")]
		public <ShowAsync>d__21(int <>1__state) { }

		[Address(RVA = "0x5BF840", Offset = "0x5BEC40", Length = "0x80A")]
		[Token(Token = "0x6000043")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000044")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000046")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x5C0050", Offset = "0x5BF450", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000045")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000042")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000007")]
	private AEData _data; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000008")]
	private IAETextureAccessor _textures; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000009")]
	private IAEAudioAccessor _audio; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400000A")]
	private IAECompositionFilter _compositionFilter; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400000B")]
	private IAELayerFilter _layerFilter; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400000C")]
	private AEMaterial _materials; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400000D")]
	private Dictionary<AEComposition, GameObject> _compositionRoots; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400000E")]
	private Dictionary<AELayer, GameObject> _layerRoots; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400000F")]
	private Dictionary<AELayer, AELayerReflection> _layerReflectionMap; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000010")]
	private AEComposition _rootNode; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000011")]
	private GlobalColorData _globalColor; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000012")]
	private TextReflector _textReflector; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000013")]
	private float _elapsedSeconds; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000014")]
	private bool _isStop; //Field offset: 0x84
	[FieldOffset(Offset = "0x85")]
	[Token(Token = "0x4000015")]
	private bool _isLoop; //Field offset: 0x85
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000016")]
	private List<MarkerData> _customMarkerList; //Field offset: 0x88

	[Token(Token = "0x17000004")]
	public List<String> allImageFiles
	{
		[Address(RVA = "0x5AD530", Offset = "0x5AC930", Length = "0x1D")]
		[Token(Token = "0x600001D")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000005")]
	public List<String> allLayerMetaData
	{
		[Address(RVA = "0x5AD550", Offset = "0x5AC950", Length = "0x1D")]
		[Token(Token = "0x600001E")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000006")]
	public List<String> allLayerNames
	{
		[Address(RVA = "0x5AD570", Offset = "0x5AC970", Length = "0x1D")]
		[Token(Token = "0x600001F")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000003")]
	public AEData animationData
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600001C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000008")]
	public List<MarkerData> customMarkerList
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[Token(Token = "0x6000021")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000002")]
	public float fps
	{
		[Address(RVA = "0x5AD5B0", Offset = "0x5AC9B0", Length = "0x25")]
		[Token(Token = "0x600001A")]
		 get { } //Length: 37
	}

	[Token(Token = "0x17000007")]
	public List<MarkerData> markerList
	{
		[Address(RVA = "0x5AD5E0", Offset = "0x5AC9E0", Length = "0x24")]
		[Token(Token = "0x6000020")]
		 get { } //Length: 36
	}

	[Token(Token = "0x17000001")]
	public float time
	{
		[Address(RVA = "0x5AD610", Offset = "0x5ACA10", Length = "0x9")]
		[Token(Token = "0x6000019")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x5AD420", Offset = "0x5AC820", Length = "0x103")]
	[Token(Token = "0x6000026")]
	public AEAsAnimationRoot() { }

	[Address(RVA = "0x5ACD70", Offset = "0x5AC170", Length = "0x1B")]
	[CompilerGenerated]
	[Token(Token = "0x6000027")]
	private MetaData <Show>b__19_0() { }

	[Address(RVA = "0x5ACDA0", Offset = "0x5AC1A0", Length = "0x63")]
	[CompilerGenerated]
	[Token(Token = "0x6000028")]
	private void <Show>b__19_1(AEComposition composition, GameObject root) { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000031")]
	private TextReflector <Show>b__19_10() { }

	[Address(RVA = "0x5ACE10", Offset = "0x5AC210", Length = "0x63")]
	[CompilerGenerated]
	[Token(Token = "0x6000029")]
	private void <Show>b__19_2(AELayer layer, GameObject root) { }

	[Address(RVA = "0x5ACE80", Offset = "0x5AC280", Length = "0x63")]
	[CompilerGenerated]
	[Token(Token = "0x600002A")]
	private void <Show>b__19_3(AELayer layer, AELayerReflection reflection) { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600002B")]
	private GlobalColorData <Show>b__19_4() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600002C")]
	private IAETextureAccessor <Show>b__19_5() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600002D")]
	private IAEAudioAccessor <Show>b__19_6() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600002E")]
	private IAECompositionFilter <Show>b__19_7() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600002F")]
	private IAELayerFilter <Show>b__19_8() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000030")]
	private AEMaterial <Show>b__19_9() { }

	[Address(RVA = "0x5AAA10", Offset = "0x5A9E10", Length = "0xAC")]
	[Token(Token = "0x6000022")]
	public void AddMarker(MarkerData marker) { }

	[Address(RVA = "0x5AAAC0", Offset = "0x5A9EC0", Length = "0x3D4")]
	[Token(Token = "0x6000003")]
	public static AEAsAnimationRoot Attach(GameObject target, string name = "AEAsAnimationRoot", bool useGlobalColor = false) { }

	[Address(RVA = "0x5AD530", Offset = "0x5AC930", Length = "0x1D")]
	[Token(Token = "0x600001D")]
	public List<String> get_allImageFiles() { }

	[Address(RVA = "0x5AD550", Offset = "0x5AC950", Length = "0x1D")]
	[Token(Token = "0x600001E")]
	public List<String> get_allLayerMetaData() { }

	[Address(RVA = "0x5AD570", Offset = "0x5AC970", Length = "0x1D")]
	[Token(Token = "0x600001F")]
	public List<String> get_allLayerNames() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600001C")]
	public AEData get_animationData() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[Token(Token = "0x6000021")]
	public List<MarkerData> get_customMarkerList() { }

	[Address(RVA = "0x5AD5B0", Offset = "0x5AC9B0", Length = "0x25")]
	[Token(Token = "0x600001A")]
	public float get_fps() { }

	[Address(RVA = "0x5AD5E0", Offset = "0x5AC9E0", Length = "0x24")]
	[Token(Token = "0x6000020")]
	public List<MarkerData> get_markerList() { }

	[Address(RVA = "0x5AD610", Offset = "0x5ACA10", Length = "0x9")]
	[Token(Token = "0x6000019")]
	public float get_time() { }

	[Address(RVA = "0x5AAEA0", Offset = "0x5AA2A0", Length = "0x254")]
	[Token(Token = "0x6000017")]
	public List<GameObject> GetAllLayerGameObjects(string name, bool activeOnly = false) { }

	[Address(RVA = "0x5AB2B0", Offset = "0x5AA6B0", Length = "0x1E")]
	[Token(Token = "0x6000023")]
	private CompositionData GetComposition(int id) { }

	[Address(RVA = "0x5AB100", Offset = "0x5AA500", Length = "0x1AD")]
	[Token(Token = "0x6000012")]
	public GameObject GetCompositionGameObjectByName(string name) { }

	[Address(RVA = "0x5AB2D0", Offset = "0x5AA6D0", Length = "0x29B")]
	[Token(Token = "0x6000016")]
	public GameObject GetImageNodeByName(string name, bool activeOnly = true, int index = 0) { }

	[Address(RVA = "0x5ABC90", Offset = "0x5AB090", Length = "0x1E")]
	[Token(Token = "0x6000024")]
	private LayerData GetLayer(string id) { }

	[Address(RVA = "0x5AB570", Offset = "0x5AA970", Length = "0x241")]
	[Token(Token = "0x6000015")]
	public AELayer GetLayerByName(string name, bool activeOnly = true, int index = 0) { }

	[Address(RVA = "0x5AB7C0", Offset = "0x5AABC0", Length = "0x208")]
	[Token(Token = "0x6000018")]
	public GameObject GetLayerGameObjectByImageFile(string imageFile) { }

	[Address(RVA = "0x5AB9D0", Offset = "0x5AADD0", Length = "0x2B9")]
	[Token(Token = "0x6000013")]
	public GameObject GetLayerGameObjectByName(string name, bool activeOnly = true, int index = 0) { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x6000025")]
	private AEComposition GetMainComposition() { }

	[Address(RVA = "0x5ABCC0", Offset = "0x5AB0C0", Length = "0x23")]
	[Token(Token = "0x600001B")]
	public int GetTotalFrame() { }

	[Address(RVA = "0x5ABCF0", Offset = "0x5AB0F0", Length = "0x20")]
	[Token(Token = "0x600000D")]
	public void GoToEnd() { }

	[Address(RVA = "0x5ABD20", Offset = "0x5AB120", Length = "0x189")]
	[Token(Token = "0x600000A")]
	public float GoToMarker(string markerTag) { }

	[Address(RVA = "0x5ABEB0", Offset = "0x5AB2B0", Length = "0x20")]
	[Token(Token = "0x600000B")]
	public float GoToMarker(MarkerData marker) { }

	[Address(RVA = "0x5ABEE0", Offset = "0x5AB2E0", Length = "0xB")]
	[Token(Token = "0x600000C")]
	public void GoToStart() { }

	[Address(RVA = "0x5ABEF0", Offset = "0x5AB2F0", Length = "0x36")]
	[Token(Token = "0x6000011")]
	public bool IsEnd() { }

	[Address(RVA = "0x5ABF30", Offset = "0x5AB330", Length = "0x7")]
	[Token(Token = "0x600000E")]
	public void Loop(bool loop) { }

	[Address(RVA = "0x5ABF40", Offset = "0x5AB340", Length = "0x8")]
	[Token(Token = "0x6000010")]
	public void PlayAnimation() { }

	[Address(RVA = "0x5ABF50", Offset = "0x5AB350", Length = "0x25D")]
	[Token(Token = "0x6000014")]
	public void RegisterLayerObserver(string name, Action<AELayer> callback, bool activeOnly = true, int index = 0) { }

	[Address(RVA = "0x5AC1B0", Offset = "0x5AB5B0", Length = "0x162")]
	[Token(Token = "0x6000004")]
	public AEAsAnimationRoot SetGlobalColor(Color overlay = null, Color multiply = null, float opacity = 1) { }

	[Address(RVA = "0x5AC5A0", Offset = "0x5AB9A0", Length = "0x72C")]
	[Token(Token = "0x6000006")]
	public AEAsAnimationRoot Show(AEData data, IAETextureAccessor textures, IAEAudioAccessor audio, IAECompositionFilter compositionFilter = null, IAELayerFilter layerFilter = null, TextReflector textReflector = null, Action<AEAsAnimationRoot> OnReady = null, Action<AEAsAnimationRoot> OnFailure = null) { }

	[Address(RVA = "0x5ACCD0", Offset = "0x5AC0D0", Length = "0x8C")]
	[Token(Token = "0x6000005")]
	public AEAsAnimationRoot Show(string json, IAETextureAccessor textures, IAEAudioAccessor audio, IAECompositionFilter compositionFilter = null, IAELayerFilter layerFilter = null, TextReflector textReflector = null, Action<AEAsAnimationRoot> OnReady = null, Action<AEAsAnimationRoot> OnFailure = null) { }

	[Address(RVA = "0x5AC480", Offset = "0x5AB880", Length = "0x11A")]
	[IteratorStateMachine(typeof(<ShowAsync>d__21))]
	[Token(Token = "0x6000008")]
	public IEnumerator ShowAsync(AEData data, IAETextureAccessor textures, IAEAudioAccessor audio, IAECompositionFilter compositionFilter = null, IAELayerFilter layerFilter = null, TextReflector textReflector = null, Action<AEAsAnimationRoot> OnReady = null, Action<AEAsAnimationRoot> OnFailure = null) { }

	[Address(RVA = "0x5AC320", Offset = "0x5AB720", Length = "0x158")]
	[Token(Token = "0x6000007")]
	public IEnumerator ShowAsync(string json, IAETextureAccessor textures, IAEAudioAccessor audio, IAECompositionFilter compositionFilter = null, IAELayerFilter layerFilter = null, TextReflector textReflector = null, Action<AEAsAnimationRoot> OnReady = null, Action<AEAsAnimationRoot> OnFailure = null) { }

	[Address(RVA = "0x5ACD60", Offset = "0x5AC160", Length = "0x8")]
	[Token(Token = "0x600000F")]
	public void StopAnimation() { }

	[Address(RVA = "0x5ACF50", Offset = "0x5AC350", Length = "0x4CF")]
	[Token(Token = "0x6000009")]
	public void UpdateTime(float deltaTime, Action<MarkerData> onMarker = null) { }

}


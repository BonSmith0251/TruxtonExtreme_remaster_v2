namespace UnityEngine.Rendering;

[Token(Token = "0x20000E5")]
public sealed class VolumeManager
{
	[CompilerGenerated]
	[Token(Token = "0x20000E6")]
	private sealed class <>c
	{
		[Token(Token = "0x40002F5")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40002F6")]
		public static Func<ValueTuple`2<String, Type>, String> <>9__16_0; //Field offset: 0x8
		[Token(Token = "0x40002F7")]
		public static Predicate<VolumeProfile> <>9__49_0; //Field offset: 0x10
		[Token(Token = "0x40002F8")]
		public static Predicate<Volume> <>9__72_0; //Field offset: 0x18

		[Address(RVA = "0x2C1E580", Offset = "0x2C1D980", Length = "0x67")]
		[Token(Token = "0x6000846")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000847")]
		public <>c() { }

		[Address(RVA = "0x2C1E3A0", Offset = "0x2C1D7A0", Length = "0xD8")]
		[Token(Token = "0x600084B")]
		internal VolumeManager <.cctor>b__75_0() { }

		[Address(RVA = "0x2BC5B40", Offset = "0x2BC4F40", Length = "0x4")]
		[Token(Token = "0x6000848")]
		internal string <BuildVolumeComponentDisplayList>b__16_0(ValueTuple<String, Type> i) { }

		[Address(RVA = "0x2C1D9C0", Offset = "0x2C1CDC0", Length = "0x4C")]
		[Token(Token = "0x600084A")]
		internal bool <GetVolumes>b__72_0(Volume v) { }

		[Address(RVA = "0x2C1E350", Offset = "0x2C1D750", Length = "0x4C")]
		[Token(Token = "0x6000849")]
		internal bool <SetCustomDefaultProfiles>b__49_0(VolumeProfile x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E7")]
	private struct <>c__DisplayClass59_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002F9")]
		public List<VolumeComponent> componentsDefaultStateList; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E8")]
	private sealed class <>c__DisplayClass59_1
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002FA")]
		public VolumeComponent profileComponent; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600084C")]
		public <>c__DisplayClass59_1() { }

		[Address(RVA = "0x2C1E4A0", Offset = "0x2C1D8A0", Length = "0x67")]
		[Token(Token = "0x600084D")]
		internal bool <EvaluateVolumeDefaultState>b__1(VolumeComponent x) { }

	}

	[Token(Token = "0x40002E5")]
	private static readonly ProfilerMarker k_ProfilerMarkerUpdate; //Field offset: 0x0
	[Token(Token = "0x40002E6")]
	private static readonly ProfilerMarker k_ProfilerMarkerReplaceData; //Field offset: 0x8
	[Token(Token = "0x40002E7")]
	private static readonly ProfilerMarker k_ProfilerMarkerEvaluateVolumeDefaultState; //Field offset: 0x10
	[Token(Token = "0x40002E8")]
	private static readonly Lazy<VolumeManager> s_Instance; //Field offset: 0x18
	[Token(Token = "0x40002EA")]
	private static readonly Dictionary<Type, List`1<ValueTuple`2<String, Type>>> s_SupportedVolumeComponentsForRenderPipeline; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002E9")]
	private VolumeStack <stack>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002EB")]
	private Type[] m_BaseComponentTypeArray; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002EC")]
	private VolumeProfile <globalDefaultProfile>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002ED")]
	private VolumeProfile <qualityDefaultProfile>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002EE")]
	private ReadOnlyCollection<VolumeProfile> <customDefaultProfiles>k__BackingField; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002EF")]
	private readonly VolumeCollection m_VolumeCollection; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002F0")]
	private VolumeComponent[] m_ComponentsDefaultState; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002F1")]
	internal VolumeParameter[] m_ParametersDefaultState; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002F2")]
	private VolumeStack m_DefaultStack; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40002F3")]
	private readonly List<VolumeStack> m_CreatedVolumeStacks; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40002F4")]
	private bool <isInitialized>k__BackingField; //Field offset: 0x60

	[Token(Token = "0x170000E0")]
	public internal Type[] baseComponentTypeArray
	{
		[Address(RVA = "0x2C22240", Offset = "0x2C21640", Length = "0x65")]
		[Token(Token = "0x6000819")]
		 get { } //Length: 101
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x600081A")]
		internal set { } //Length: 13
	}

	[Obsolete("Please use baseComponentTypeArray instead. #from(2021.2)")]
	[Token(Token = "0x170000DF")]
	public IEnumerable<Type> baseComponentTypes
	{
		[Address(RVA = "0x2C22240", Offset = "0x2C21640", Length = "0x65")]
		[Token(Token = "0x6000816")]
		 get { } //Length: 101
	}

	[Token(Token = "0x170000E3")]
	public private ReadOnlyCollection<VolumeProfile> customDefaultProfiles
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600081F")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000820")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000E1")]
	public private VolumeProfile globalDefaultProfile
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600081B")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600081C")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000DD")]
	public static VolumeManager instance
	{
		[Address(RVA = "0x2C222B0", Offset = "0x2C216B0", Length = "0x70")]
		[Token(Token = "0x6000813")]
		 get { } //Length: 112
	}

	[Token(Token = "0x170000E4")]
	public private bool isInitialized
	{
		[Address(RVA = "0x1E9FB00", Offset = "0x1E9EF00", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000823")]
		 get { } //Length: 5
		[Address(RVA = "0x28A42A0", Offset = "0x28A36A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000824")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170000E2")]
	public private VolumeProfile qualityDefaultProfile
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600081D")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600081E")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000DE")]
	public VolumeStack stack
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000814")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000815")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2C21F70", Offset = "0x2C21370", Length = "0x21A")]
	[Token(Token = "0x6000844")]
	private static VolumeManager() { }

	[Address(RVA = "0x2C22190", Offset = "0x2C21590", Length = "0xAC")]
	[Token(Token = "0x6000822")]
	internal VolumeManager() { }

	[Address(RVA = "0x2C21400", Offset = "0x2C20800", Length = "0x1F0")]
	[CompilerGenerated]
	[Token(Token = "0x6000845")]
	internal static void <EvaluateVolumeDefaultState>g__ApplyDefaultProfile|59_0(VolumeProfile profile, ref <>c__DisplayClass59_0 unnamed_param_1) { }

	[Address(RVA = "0x2C1E660", Offset = "0x2C1DA60", Length = "0x3D8")]
	[Token(Token = "0x6000818")]
	private List<ValueTuple`2<String, Type>> BuildVolumeComponentDisplayList(Type[] types) { }

	[Address(RVA = "0x2C1EA40", Offset = "0x2C1DE40", Length = "0x8B")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600083C")]
	public void CheckDefaultVolumeState() { }

	[Address(RVA = "0x2C1EAD0", Offset = "0x2C1DED0", Length = "0x25B")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600083D")]
	public void CheckStack(VolumeStack stack) { }

	[Address(RVA = "0x2C1ED30", Offset = "0x2C1E130", Length = "0x4D")]
	[Token(Token = "0x600083E")]
	private bool CheckUpdateRequired(VolumeStack stack) { }

	[Address(RVA = "0x2C1EE70", Offset = "0x2C1E270", Length = "0x67")]
	[Token(Token = "0x600082D")]
	public VolumeStack CreateStack() { }

	[Address(RVA = "0x2C1ED80", Offset = "0x2C1E180", Length = "0xEB")]
	[Token(Token = "0x600082E")]
	private VolumeStack CreateStackInternal() { }

	[Address(RVA = "0x2C1EEE0", Offset = "0x2C1E2E0", Length = "0x201")]
	[Token(Token = "0x6000827")]
	public void Deinitialize() { }

	[Address(RVA = "0x2C1F0F0", Offset = "0x2C1E4F0", Length = "0x62")]
	[Token(Token = "0x6000830")]
	public void DestroyStack(VolumeStack stack) { }

	[Address(RVA = "0x2C1F160", Offset = "0x2C1E560", Length = "0x74D")]
	[Token(Token = "0x6000834")]
	private void EvaluateVolumeDefaultState() { }

	[Address(RVA = "0x2C22240", Offset = "0x2C21640", Length = "0x65")]
	[Token(Token = "0x6000819")]
	public Type[] get_baseComponentTypeArray() { }

	[Address(RVA = "0x2C22240", Offset = "0x2C21640", Length = "0x65")]
	[Token(Token = "0x6000816")]
	public IEnumerable<Type> get_baseComponentTypes() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600081F")]
	public ReadOnlyCollection<VolumeProfile> get_customDefaultProfiles() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600081B")]
	public VolumeProfile get_globalDefaultProfile() { }

	[Address(RVA = "0x2C222B0", Offset = "0x2C216B0", Length = "0x70")]
	[Token(Token = "0x6000813")]
	public static VolumeManager get_instance() { }

	[Address(RVA = "0x1E9FB00", Offset = "0x1E9EF00", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000823")]
	public bool get_isInitialized() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600081D")]
	public VolumeProfile get_qualityDefaultProfile() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000814")]
	public VolumeStack get_stack() { }

	[Address(RVA = "0x2C1F8B0", Offset = "0x2C1ECB0", Length = "0x112")]
	[Token(Token = "0x6000821")]
	public VolumeComponent GetVolumeComponentDefaultState(Type volumeComponentType) { }

	[Address(RVA = "0x2C1F9D0", Offset = "0x2C1EDD0", Length = "0x258")]
	[Token(Token = "0x6000817")]
	internal List<ValueTuple`2<String, Type>> GetVolumeComponentsForDisplay(Type currentPipelineAssetType) { }

	[Address(RVA = "0x2C1FC30", Offset = "0x2C1F030", Length = "0x154")]
	[Token(Token = "0x6000841")]
	public Volume[] GetVolumes(LayerMask layerMask) { }

	[Address(RVA = "0x2C1FD90", Offset = "0x2C1F190", Length = "0x1E")]
	[Token(Token = "0x6000842")]
	private List<Volume> GrabVolumes(LayerMask mask) { }

	[Address(RVA = "0x2C1FFE0", Offset = "0x2C1F3E0", Length = "0x18E")]
	[Token(Token = "0x6000825")]
	public void Initialize(VolumeProfile globalDefaultVolumeProfile = null, VolumeProfile qualityDefaultVolumeProfile = null) { }

	[Address(RVA = "0x2C1FDB0", Offset = "0x2C1F1B0", Length = "0x148")]
	[Token(Token = "0x6000826")]
	internal void InitializeInternal(VolumeProfile globalDefaultVolumeProfile = null, VolumeProfile qualityDefaultVolumeProfile = null) { }

	[Address(RVA = "0x2C1FF00", Offset = "0x2C1F300", Length = "0xD8")]
	[Token(Token = "0x6000833")]
	internal void InitializeVolumeComponents() { }

	[Address(RVA = "0x9E5D20", Offset = "0x9E5120", Length = "0x51")]
	[Token(Token = "0x6000837")]
	public bool IsComponentActiveInMask(LayerMask layerMask) { }

	[Address(RVA = "0x2C20170", Offset = "0x2C1F570", Length = "0x239")]
	[Token(Token = "0x6000831")]
	private bool IsSupportedByObsoleteVolumeComponentMenuForRenderPipeline(Type t, Type pipelineAssetType) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000843")]
	private static bool IsVolumeRenderedByCamera(Volume volume, Camera camera) { }

	[Address(RVA = "0x2C203B0", Offset = "0x2C1F7B0", Length = "0x3F4")]
	[Token(Token = "0x6000832")]
	internal void LoadBaseTypes(Type pipelineAssetType) { }

	[Address(RVA = "0x2C207B0", Offset = "0x2C1FBB0", Length = "0x290")]
	[Token(Token = "0x600082C")]
	public void OnVolumeComponentChanged(VolumeComponent component) { }

	[Address(RVA = "0x2C20A50", Offset = "0x2C1FE50", Length = "0xD5")]
	[Token(Token = "0x600082B")]
	public void OnVolumeProfileChanged(VolumeProfile profile) { }

	[Address(RVA = "0x2C20B30", Offset = "0x2C1FF30", Length = "0x155")]
	[Token(Token = "0x600083A")]
	private void OverrideData(VolumeStack stack, Volume volume, float interpFactor) { }

	[Address(RVA = "0x2C20C90", Offset = "0x2C20090", Length = "0x2E6")]
	[Obsolete("Please use the Register without a given layer index. #from(6000.0)")]
	[Token(Token = "0x6000811")]
	public void Register(Volume volume, int layer) { }

	[Address(RVA = "0x2C20F80", Offset = "0x2C20380", Length = "0x54")]
	[Token(Token = "0x6000835")]
	public void Register(Volume volume) { }

	[Address(RVA = "0x2C20FE0", Offset = "0x2C203E0", Length = "0x1B8")]
	[Token(Token = "0x600083B")]
	internal void ReplaceData(VolumeStack stack) { }

	[Address(RVA = "0x2C211A0", Offset = "0x2C205A0", Length = "0x11")]
	[Token(Token = "0x600082F")]
	public void ResetMainStack() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x600081A")]
	internal void set_baseComponentTypeArray(Type[] value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000820")]
	private void set_customDefaultProfiles(ReadOnlyCollection<VolumeProfile> value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600081C")]
	private void set_globalDefaultProfile(VolumeProfile value) { }

	[Address(RVA = "0x28A42A0", Offset = "0x28A36A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000824")]
	private void set_isInitialized(bool value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600081E")]
	private void set_qualityDefaultProfile(VolumeProfile value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000815")]
	public void set_stack(VolumeStack value) { }

	[Address(RVA = "0x2C211C0", Offset = "0x2C205C0", Length = "0x1B2")]
	[Token(Token = "0x600082A")]
	public void SetCustomDefaultProfiles(List<VolumeProfile> profiles) { }

	[Address(RVA = "0x2C21380", Offset = "0x2C20780", Length = "0x25")]
	[Token(Token = "0x6000828")]
	public void SetGlobalDefaultProfile(VolumeProfile profile) { }

	[Address(RVA = "0x2C213B0", Offset = "0x2C207B0", Length = "0x1E")]
	[Token(Token = "0x6000838")]
	internal void SetLayerDirty(int layer) { }

	[Address(RVA = "0x2C213D0", Offset = "0x2C207D0", Length = "0x25")]
	[Token(Token = "0x6000829")]
	public void SetQualityDefaultProfile(VolumeProfile profile) { }

	[Address(RVA = "0x2C21600", Offset = "0x2C20A00", Length = "0x54")]
	[Token(Token = "0x6000836")]
	public void Unregister(Volume volume) { }

	[Address(RVA = "0x2C21660", Offset = "0x2C20A60", Length = "0x2E6")]
	[Obsolete("Please use the Register without a given layer index. #from(6000.0)")]
	[Token(Token = "0x6000812")]
	public void Unregister(Volume volume, int layer) { }

	[Address(RVA = "0x2C21F40", Offset = "0x2C21340", Length = "0x21")]
	[Token(Token = "0x600083F")]
	public void Update(Transform trigger, LayerMask layerMask) { }

	[Address(RVA = "0x2C21980", Offset = "0x2C20D80", Length = "0x5BD")]
	[Token(Token = "0x6000840")]
	public void Update(VolumeStack stack, Transform trigger, LayerMask layerMask) { }

	[Address(RVA = "0x2C21950", Offset = "0x2C20D50", Length = "0x24")]
	[Token(Token = "0x6000839")]
	internal void UpdateVolumeLayer(Volume volume, int prevLayer, int newLayer) { }

}


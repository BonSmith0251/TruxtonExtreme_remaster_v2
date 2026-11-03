namespace UnityEngine.Rendering;

[Token(Token = "0x200012B")]
public sealed class ProbeVolumeBakingSet : ScriptableObject, ISerializationCallbackReceiver
{
	[Token(Token = "0x200012E")]
	public struct CellCounts
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005C2")]
		public int bricksCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40005C3")]
		public int chunksCount; //Field offset: 0x4

		[Address(RVA = "0x2C0AC60", Offset = "0x2C0A060", Length = "0xA")]
		[Token(Token = "0x6000A8D")]
		public void Add(CellCounts o) { }

	}

	[Token(Token = "0x200012D")]
	public class PerScenarioDataInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40005BD")]
		public int sceneHash; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40005BE")]
		public ProbeVolumeStreamableAsset cellDataAsset; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40005BF")]
		public ProbeVolumeStreamableAsset cellOptionalDataAsset; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40005C0")]
		public ProbeVolumeStreamableAsset cellProbeOcclusionDataAsset; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40005C1")]
		private bool m_HasValidData; //Field offset: 0x30

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000A8C")]
		public PerScenarioDataInfo() { }

		[Address(RVA = "0x2C0DED0", Offset = "0x2C0D2D0", Length = "0x61")]
		[Token(Token = "0x6000A8B")]
		public bool ComputeHasValidData(ProbeVolumeSHBands shBands) { }

		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x6000A8A")]
		public bool HasValidData(ProbeVolumeSHBands shBands) { }

		[Address(RVA = "0x2C0DF40", Offset = "0x2C0D340", Length = "0x6B")]
		[Token(Token = "0x6000A88")]
		public void Initialize(ProbeVolumeSHBands shBands) { }

		[Address(RVA = "0x2C0DFB0", Offset = "0x2C0D3B0", Length = "0x15")]
		[Token(Token = "0x6000A89")]
		public bool IsValid() { }

	}

	[Token(Token = "0x2000130")]
	public struct ProbeLayerMask
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005C6")]
		public RenderingLayerMask mask; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40005C7")]
		public string name; //Field offset: 0x8

	}

	[Token(Token = "0x200012F")]
	private struct SerializedPerSceneCellList
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005C4")]
		public string sceneGUID; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40005C5")]
		public List<Int32> cellList; //Field offset: 0x8

	}

	[Token(Token = "0x200012C")]
	public enum Version : int
	{
		Initial = 0,
		RemoveProbeVolumeSceneData = 1,
		AssetsAlwaysReferenced = 2,
	}

	[Token(Token = "0x40005A6")]
	internal const int k_MaxSkyOcclusionBakingSamples = 8192; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000574")]
	internal bool singleSceneMode; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[SerializeField]
	[Token(Token = "0x4000575")]
	internal bool dialogNoProbeVolumeInSetShown; //Field offset: 0x19
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x4000576")]
	internal ProbeVolumeBakingProcessSettings settings; //Field offset: 0x1C
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000577")]
	private List<String> m_SceneGUIDs; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[FormerlySerializedAs("scenesToNotBake")]
	[Obsolete("This is now contained in the SceneBakeData structure. #from(2023.3)")]
	[SerializeField]
	[Token(Token = "0x4000578")]
	internal List<String> obsoleteScenesToNotBake; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[FormerlySerializedAs("lightingScenarios")]
	[SerializeField]
	[Token(Token = "0x4000579")]
	internal List<String> m_LightingScenarios; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x400057A")]
	internal SerializedDictionary<Int32, CellDesc> cellDescs; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400057B")]
	internal Dictionary<Int32, CellData> cellDataMap; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400057C")]
	private List<Int32> m_TotalIndexList; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x400057D")]
	private List<SerializedPerSceneCellList> m_SerializedPerSceneCellList; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400057E")]
	internal Dictionary<String, List`1<Int32>> perSceneCellLists; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	[Token(Token = "0x400057F")]
	internal ProbeVolumeStreamableAsset cellSharedDataAsset; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Token(Token = "0x4000580")]
	internal SerializedDictionary<String, PerScenarioDataInfo> scenarios; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x4000581")]
	internal ProbeVolumeStreamableAsset cellBricksDataAsset; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x4000582")]
	internal ProbeVolumeStreamableAsset cellSupportDataAsset; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[Token(Token = "0x4000583")]
	internal int chunkSizeInBricks; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB4")]
	[SerializeField]
	[Token(Token = "0x4000584")]
	internal Vector3Int maxCellPosition; //Field offset: 0xB4
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	[Token(Token = "0x4000585")]
	internal Vector3Int minCellPosition; //Field offset: 0xC0
	[FieldOffset(Offset = "0xCC")]
	[SerializeField]
	[Token(Token = "0x4000586")]
	internal Bounds globalBounds; //Field offset: 0xCC
	[FieldOffset(Offset = "0xE4")]
	[SerializeField]
	[Token(Token = "0x4000587")]
	internal int bakedSimplificationLevels; //Field offset: 0xE4
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	[Token(Token = "0x4000588")]
	internal float bakedMinDistanceBetweenProbes; //Field offset: 0xE8
	[FieldOffset(Offset = "0xEC")]
	[SerializeField]
	[Token(Token = "0x4000589")]
	internal bool bakedProbeOcclusion; //Field offset: 0xEC
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	[Token(Token = "0x400058A")]
	internal int bakedSkyOcclusionValue; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF4")]
	[SerializeField]
	[Token(Token = "0x400058B")]
	internal int bakedSkyShadingDirectionValue; //Field offset: 0xF4
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Token(Token = "0x400058C")]
	internal Vector3 bakedProbeOffset; //Field offset: 0xF8
	[FieldOffset(Offset = "0x104")]
	[SerializeField]
	[Token(Token = "0x400058D")]
	internal int bakedMaskCount; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Token(Token = "0x400058E")]
	internal uint4 bakedLayerMasks; //Field offset: 0x108
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Token(Token = "0x400058F")]
	internal int maxSHChunkCount; //Field offset: 0x118
	[FieldOffset(Offset = "0x11C")]
	[SerializeField]
	[Token(Token = "0x4000590")]
	internal int L0ChunkSize; //Field offset: 0x11C
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Token(Token = "0x4000591")]
	internal int L1ChunkSize; //Field offset: 0x120
	[FieldOffset(Offset = "0x124")]
	[SerializeField]
	[Token(Token = "0x4000592")]
	internal int L2TextureChunkSize; //Field offset: 0x124
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[Token(Token = "0x4000593")]
	internal int ProbeOcclusionChunkSize; //Field offset: 0x128
	[FieldOffset(Offset = "0x12C")]
	[SerializeField]
	[Token(Token = "0x4000594")]
	internal int sharedValidityMaskChunkSize; //Field offset: 0x12C
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	[Token(Token = "0x4000595")]
	internal int sharedSkyOcclusionL0L1ChunkSize; //Field offset: 0x130
	[FieldOffset(Offset = "0x134")]
	[SerializeField]
	[Token(Token = "0x4000596")]
	internal int sharedSkyShadingDirectionIndicesChunkSize; //Field offset: 0x134
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	[Token(Token = "0x4000597")]
	internal int sharedDataChunkSize; //Field offset: 0x138
	[FieldOffset(Offset = "0x13C")]
	[SerializeField]
	[Token(Token = "0x4000598")]
	internal int supportPositionChunkSize; //Field offset: 0x13C
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Token(Token = "0x4000599")]
	internal int supportValidityChunkSize; //Field offset: 0x140
	[FieldOffset(Offset = "0x144")]
	[SerializeField]
	[Token(Token = "0x400059A")]
	internal int supportTouchupChunkSize; //Field offset: 0x144
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	[Token(Token = "0x400059B")]
	internal int supportLayerMaskChunkSize; //Field offset: 0x148
	[FieldOffset(Offset = "0x14C")]
	[SerializeField]
	[Token(Token = "0x400059C")]
	internal int supportOffsetsChunkSize; //Field offset: 0x14C
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	[Token(Token = "0x400059D")]
	internal int supportDataChunkSize; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	[Token(Token = "0x400059E")]
	internal string lightingScenario; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x400059F")]
	private string m_OtherScenario; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x40005A0")]
	private float m_ScenarioBlendingFactor; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x40005A1")]
	private ReadCommandArray m_ReadCommandArray; //Field offset: 0x170
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x40005A2")]
	private NativeArray<ReadCommand> m_ReadCommandBuffer; //Field offset: 0x180
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x40005A3")]
	private Stack<NativeArray`1<Byte>> m_ReadOperationScratchBuffers; //Field offset: 0x190
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x40005A4")]
	private List<Int32> m_PrunedIndexList; //Field offset: 0x198
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x40005A5")]
	private List<Int32> m_PrunedScenarioIndexList; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A8")]
	[SerializeField]
	[Token(Token = "0x40005A7")]
	private Version version; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1AC")]
	[SerializeField]
	[Token(Token = "0x40005A8")]
	internal bool freezePlacement; //Field offset: 0x1AC
	[FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	[Token(Token = "0x40005A9")]
	public Vector3 probeOffset; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1BC")]
	[Range(2, 5)]
	[Token(Token = "0x40005AA")]
	public int simplificationLevels; //Field offset: 0x1BC
	[FieldOffset(Offset = "0x1C0")]
	[Min(0.1)]
	[Token(Token = "0x40005AB")]
	public float minDistanceBetweenProbes; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C4")]
	[Token(Token = "0x40005AC")]
	public LayerMask renderersLayerMask; //Field offset: 0x1C4
	[FieldOffset(Offset = "0x1C8")]
	[Min(0)]
	[Token(Token = "0x40005AD")]
	public float minRendererVolumeSize; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1CC")]
	[Token(Token = "0x40005AE")]
	public bool skyOcclusion; //Field offset: 0x1CC
	[FieldOffset(Offset = "0x1D0")]
	[Logarithmic(1, 8192)]
	[Token(Token = "0x40005AF")]
	public int skyOcclusionBakingSamples; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D4")]
	[Range(0, 5)]
	[Token(Token = "0x40005B0")]
	public int skyOcclusionBakingBounces; //Field offset: 0x1D4
	[FieldOffset(Offset = "0x1D8")]
	[Range(0, 1)]
	[Token(Token = "0x40005B1")]
	public float skyOcclusionAverageAlbedo; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1DC")]
	[Token(Token = "0x40005B2")]
	public bool skyOcclusionBackFaceCulling; //Field offset: 0x1DC
	[FieldOffset(Offset = "0x1DD")]
	[Token(Token = "0x40005B3")]
	public bool skyOcclusionShadingDirection; //Field offset: 0x1DD
	[FieldOffset(Offset = "0x1DE")]
	[SerializeField]
	[Token(Token = "0x40005B4")]
	internal bool useRenderingLayers; //Field offset: 0x1DE
	[FieldOffset(Offset = "0x1E0")]
	[SerializeField]
	[Token(Token = "0x40005B5")]
	internal ProbeLayerMask[] renderingLayerMasks; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x40005B6")]
	private bool m_HasSupportData; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1E9")]
	[Token(Token = "0x40005B7")]
	private bool m_SharedDataIsValid; //Field offset: 0x1E9
	[FieldOffset(Offset = "0x1EA")]
	[Token(Token = "0x40005B8")]
	private bool m_UseStreamingAsset; //Field offset: 0x1EA

	[Token(Token = "0x1700012D")]
	internal bool bakedSkyOcclusion
	{
		[Address(RVA = "0x2C1A820", Offset = "0x2C19C20", Length = "0xB")]
		[Token(Token = "0x6000A55")]
		internal get { } //Length: 11
		[Address(RVA = "0x2C1A920", Offset = "0x2C19D20", Length = "0x1C")]
		[Token(Token = "0x6000A56")]
		internal set { } //Length: 28
	}

	[Token(Token = "0x1700012E")]
	internal bool bakedSkyShadingDirection
	{
		[Address(RVA = "0x2C1A830", Offset = "0x2C19C30", Length = "0xB")]
		[Token(Token = "0x6000A57")]
		internal get { } //Length: 11
		[Address(RVA = "0x2C1A940", Offset = "0x2C19D40", Length = "0x1C")]
		[Token(Token = "0x6000A58")]
		internal set { } //Length: 28
	}

	[Token(Token = "0x17000131")]
	public int cellSizeInBricks
	{
		[Address(RVA = "0x2C1A840", Offset = "0x2C19C40", Length = "0x25")]
		[Token(Token = "0x6000A5B")]
		 get { } //Length: 37
	}

	[Token(Token = "0x17000134")]
	public float cellSizeInMeters
	{
		[Address(RVA = "0x2C1A870", Offset = "0x2C19C70", Length = "0x52")]
		[Token(Token = "0x6000A5E")]
		 get { } //Length: 82
	}

	[Token(Token = "0x1700012A")]
	internal bool hasDilation
	{
		[Address(RVA = "0x2C1A8D0", Offset = "0x2C19CD0", Length = "0x18")]
		[Token(Token = "0x6000A52")]
		internal get { } //Length: 24
	}

	[Token(Token = "0x1700012C")]
	public IReadOnlyList<String> lightingScenarios
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6000A54")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000132")]
	public int maxSubdivision
	{
		[Address(RVA = "0x2C1A8F0", Offset = "0x2C19CF0", Length = "0x9")]
		[Token(Token = "0x6000A5C")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000133")]
	public float minBrickSize
	{
		[Address(RVA = "0x2C1A900", Offset = "0x2C19D00", Length = "0x1F")]
		[Token(Token = "0x6000A5D")]
		 get { } //Length: 31
	}

	[Token(Token = "0x1700012F")]
	internal string otherScenario
	{
		[Address(RVA = "0x1D4E410", Offset = "0x1D4D810", Length = "0x8")]
		[Token(Token = "0x6000A59")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000130")]
	internal float scenarioBlendingFactor
	{
		[Address(RVA = "0x1CDD5B0", Offset = "0x1CDC9B0", Length = "0x9")]
		[Token(Token = "0x6000A5A")]
		internal get { } //Length: 9
	}

	[Token(Token = "0x1700012B")]
	public IReadOnlyList<String> sceneGUIDs
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6000A53")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2C1A390", Offset = "0x2C19790", Length = "0x486")]
	[Token(Token = "0x6000A87")]
	public ProbeVolumeBakingSet() { }

	[Address(RVA = "0x2C15EA0", Offset = "0x2C152A0", Length = "0x26")]
	[Token(Token = "0x6000A73")]
	private static int AlignUp16(int count) { }

	[Address(RVA = "0x2C15ED0", Offset = "0x2C152D0", Length = "0x324")]
	[Token(Token = "0x6000A71")]
	internal void BlendLightingScenario(string otherScenario, float blendingFactor) { }

	[Address(RVA = "0x2C16200", Offset = "0x2C15600", Length = "0x7B")]
	[Token(Token = "0x6000A68")]
	internal bool CheckCompatibleCellLayout() { }

	[Address(RVA = "0x2C16280", Offset = "0x2C15680", Length = "0x3A7")]
	[Token(Token = "0x6000A6F")]
	internal void Cleanup() { }

	[Address(RVA = "0x2C16630", Offset = "0x2C15A30", Length = "0x4A")]
	[Token(Token = "0x6000A69")]
	private bool ComputeHasSupportData() { }

	[Address(RVA = "0x2C16680", Offset = "0x2C15A80", Length = "0x4A")]
	[Token(Token = "0x6000A66")]
	private bool ComputeHasValidSharedData() { }

	[Address(RVA = "0x2C166D0", Offset = "0x2C15AD0", Length = "0x100")]
	[Token(Token = "0x6000A5F")]
	internal uint4 ComputeRegionMasks() { }

	[Address(RVA = "0x2C167E0", Offset = "0x2C15BE0", Length = "0x66")]
	[Token(Token = "0x6000A76")]
	private bool FileExists(string path) { }

	[Address(RVA = "0x2C1A820", Offset = "0x2C19C20", Length = "0xB")]
	[Token(Token = "0x6000A55")]
	internal bool get_bakedSkyOcclusion() { }

	[Address(RVA = "0x2C1A830", Offset = "0x2C19C30", Length = "0xB")]
	[Token(Token = "0x6000A57")]
	internal bool get_bakedSkyShadingDirection() { }

	[Address(RVA = "0x2C1A840", Offset = "0x2C19C40", Length = "0x25")]
	[Token(Token = "0x6000A5B")]
	public int get_cellSizeInBricks() { }

	[Address(RVA = "0x2C1A870", Offset = "0x2C19C70", Length = "0x52")]
	[Token(Token = "0x6000A5E")]
	public float get_cellSizeInMeters() { }

	[Address(RVA = "0x2C1A8D0", Offset = "0x2C19CD0", Length = "0x18")]
	[Token(Token = "0x6000A52")]
	internal bool get_hasDilation() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6000A54")]
	public IReadOnlyList<String> get_lightingScenarios() { }

	[Address(RVA = "0x2C1A8F0", Offset = "0x2C19CF0", Length = "0x9")]
	[Token(Token = "0x6000A5C")]
	public int get_maxSubdivision() { }

	[Address(RVA = "0x2C1A900", Offset = "0x2C19D00", Length = "0x1F")]
	[Token(Token = "0x6000A5D")]
	public float get_minBrickSize() { }

	[Address(RVA = "0x1D4E410", Offset = "0x1D4D810", Length = "0x8")]
	[Token(Token = "0x6000A59")]
	internal string get_otherScenario() { }

	[Address(RVA = "0x1CDD5B0", Offset = "0x1CDC9B0", Length = "0x9")]
	[Token(Token = "0x6000A5A")]
	internal float get_scenarioBlendingFactor() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6000A53")]
	public IReadOnlyList<String> get_sceneGUIDs() { }

	[Address(RVA = "0x2C16850", Offset = "0x2C15C50", Length = "0x1AC")]
	[Token(Token = "0x6000A72")]
	internal int GetBakingHashCode() { }

	[Address(RVA = "0x2C16A00", Offset = "0x2C15E00", Length = "0x76")]
	[Token(Token = "0x6000A84")]
	internal CellData GetCellData(int cellIndex) { }

	[Address(RVA = "0x2C16A80", Offset = "0x2C15E80", Length = "0x76")]
	[Token(Token = "0x6000A83")]
	internal CellDesc GetCellDesc(int cellIndex) { }

	[Address(RVA = "0x2C16B00", Offset = "0x2C15F00", Length = "0x21")]
	[Token(Token = "0x6000A60")]
	internal static int GetCellSizeInBricks(int simplificationLevels) { }

	[Address(RVA = "0x2C16B30", Offset = "0x2C15F30", Length = "0x35")]
	[Token(Token = "0x6000A85")]
	internal int GetChunkGPUMemory(ProbeVolumeSHBands shBands) { }

	[Address(RVA = "0x2C16B70", Offset = "0x2C15F70", Length = "0x4")]
	[Token(Token = "0x6000A61")]
	internal static int GetMaxSubdivision(int simplificationLevels) { }

	[Address(RVA = "0x2C16B80", Offset = "0x2C15F80", Length = "0x18")]
	[Token(Token = "0x6000A62")]
	internal static float GetMinBrickSize(float minDistanceBetweenProbes) { }

	[Address(RVA = "0x2C16BA0", Offset = "0x2C15FA0", Length = "0x7B")]
	[Token(Token = "0x6000A7B")]
	internal List<Int32> GetSceneCellIndexList(string sceneGUID) { }

	[Address(RVA = "0x8B46B0", Offset = "0x8B3AB0", Length = "0x10B")]
	[Token(Token = "0x6000A74")]
	private NativeArray<T> GetSubArray(NativeArray<Byte> input, int count, ref int offset) { }

	[Address(RVA = "0x2C16C20", Offset = "0x2C16020", Length = "0x16B")]
	[Token(Token = "0x6000A6B")]
	public bool HasBakedData(string scenario = null) { }

	[Address(RVA = "0x2C16D90", Offset = "0x2C16190", Length = "0x1FF")]
	[Token(Token = "0x6000A86")]
	internal bool HasSameSceneGUIDs(ProbeVolumeBakingSet other) { }

	[Address(RVA = "0x2C16F90", Offset = "0x2C16390", Length = "0x8")]
	[Token(Token = "0x6000A6A")]
	internal bool HasSupportData() { }

	[Address(RVA = "0x2C16FA0", Offset = "0x2C163A0", Length = "0x8")]
	[Token(Token = "0x6000A67")]
	internal bool HasValidSharedData() { }

	[Address(RVA = "0x2C16FB0", Offset = "0x2C163B0", Length = "0x486")]
	[Token(Token = "0x6000A6E")]
	internal void Initialize(bool useStreamingAsset) { }

	[Address(RVA = "0x8B4DE0", Offset = "0x8B41E0", Length = "0x61C")]
	[Token(Token = "0x6000A77")]
	private NativeArray<T> LoadStreambleAssetData(ProbeVolumeStreamableAsset asset, List<Int32> cellIndices) { }

	[Address(RVA = "0x2C17440", Offset = "0x2C16840", Length = "0x12A")]
	[Token(Token = "0x6000A65")]
	internal void Migrate() { }

	[Address(RVA = "0x2C17570", Offset = "0x2C16970", Length = "0x1AF")]
	[Token(Token = "0x6000A64")]
	private void OnEnable() { }

	[Address(RVA = "0x2C17720", Offset = "0x2C16B20", Length = "0x178")]
	[Token(Token = "0x6000A63")]
	private void OnValidate() { }

	[Address(RVA = "0x2C17A50", Offset = "0x2C16E50", Length = "0x181")]
	[Token(Token = "0x6000A79")]
	private void PruneCellIndexList(List<Int32> cellIndices, List<Int32> prunedIndexList) { }

	[Address(RVA = "0x2C178A0", Offset = "0x2C16CA0", Length = "0x1AA")]
	[Token(Token = "0x6000A7A")]
	private void PruneCellIndexListForScenario(List<Int32> cellIndices, PerScenarioDataInfo scenarioData, List<Int32> prunedIndexList) { }

	[Address(RVA = "0x2C17BE0", Offset = "0x2C16FE0", Length = "0x86")]
	[Token(Token = "0x6000A82")]
	internal void ReleaseCell(int cellIndex) { }

	[Address(RVA = "0x8B5AC0", Offset = "0x8B4EC0", Length = "0x9E")]
	[Token(Token = "0x6000A78")]
	private void ReleaseStreamableAssetData(NativeArray<T> buffer) { }

	[Address(RVA = "0x2C17C70", Offset = "0x2C17070", Length = "0x13E")]
	[Token(Token = "0x6000A75")]
	private NativeArray<Byte> RequestScratchBuffer(int size) { }

	[Address(RVA = "0x2C17DB0", Offset = "0x2C171B0", Length = "0x33")]
	[Token(Token = "0x6000A7C")]
	private bool ResolveAllCellData() { }

	[Address(RVA = "0x2C17DF0", Offset = "0x2C171F0", Length = "0x447")]
	[Token(Token = "0x6000A7D")]
	internal bool ResolveCellData(List<Int32> cellIndices) { }

	[Address(RVA = "0x2C18240", Offset = "0x2C17640", Length = "0x5D0")]
	[Token(Token = "0x6000A80")]
	internal bool ResolvePerScenarioCellData(List<Int32> cellIndices) { }

	[Address(RVA = "0x2C18820", Offset = "0x2C17C20", Length = "0x6CB")]
	[Token(Token = "0x6000A81")]
	internal bool ResolvePerScenarioCellData(NativeArray<Byte> cellData, NativeArray<Byte> cellOptionalData, NativeArray<Byte> cellProbeOcclusionData, string scenario, List<Int32> cellIndices) { }

	[Address(RVA = "0x2C19160", Offset = "0x2C18560", Length = "0x856")]
	[Token(Token = "0x6000A7E")]
	private void ResolveSharedCellData(List<Int32> cellIndices, NativeArray<Brick> bricksData, NativeArray<Byte> cellSharedData, NativeArray<Byte> cellSupportData) { }

	[Address(RVA = "0x2C18EF0", Offset = "0x2C182F0", Length = "0x266")]
	[Token(Token = "0x6000A7F")]
	internal bool ResolveSharedCellData(List<Int32> cellIndices) { }

	[Address(RVA = "0x2C1A920", Offset = "0x2C19D20", Length = "0x1C")]
	[Token(Token = "0x6000A56")]
	internal void set_bakedSkyOcclusion(bool value) { }

	[Address(RVA = "0x2C1A940", Offset = "0x2C19D40", Length = "0x1C")]
	[Token(Token = "0x6000A58")]
	internal void set_bakedSkyShadingDirection(bool value) { }

	[Address(RVA = "0x2C199C0", Offset = "0x2C18DC0", Length = "0x26E")]
	[Token(Token = "0x6000A70")]
	internal void SetActiveScenario(string scenario, bool verbose = true) { }

	[Address(RVA = "0x2C19C30", Offset = "0x2C19030", Length = "0x4BD")]
	[Token(Token = "0x6000A6C")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	[Address(RVA = "0x2C1A0F0", Offset = "0x2C194F0", Length = "0x290")]
	[Token(Token = "0x6000A6D")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}


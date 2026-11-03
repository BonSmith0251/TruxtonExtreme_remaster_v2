namespace UnityEngine;

[NativeHeader("Modules/ParticleSystem/ParticleSystemRenderer.h")]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemRendererScriptBindings.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x200003B")]
public sealed class ParticleSystemRenderer : Renderer
{
	[Token(Token = "0x200003C")]
	public struct BakeTextureOutput
	{
		[FieldOffset(Offset = "0x0")]
		[NativeName("first")]
		[Token(Token = "0x4000100")]
		internal Texture2D vertices; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[NativeName("second")]
		[Token(Token = "0x4000101")]
		internal Texture2D indices; //Field offset: 0x8

	}


	[Token(Token = "0x17000075")]
	public int activeTrailVertexStreamsCount
	{
		[Address(RVA = "0x31190F0", Offset = "0x31184F0", Length = "0x76")]
		[Token(Token = "0x6000173")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000074")]
	public int activeVertexStreamsCount
	{
		[Address(RVA = "0x31191B0", Offset = "0x31185B0", Length = "0x76")]
		[Token(Token = "0x6000170")]
		 get { } //Length: 118
	}

	[NativeName("RenderAlignment")]
	[Token(Token = "0x1700005C")]
	public ParticleSystemRenderSpace alignment
	{
		[Address(RVA = "0x3119270", Offset = "0x3118670", Length = "0x76")]
		[Token(Token = "0x600012F")]
		 get { } //Length: 118
		[Address(RVA = "0x311A450", Offset = "0x3119850", Length = "0x83")]
		[Token(Token = "0x6000130")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700006E")]
	public bool allowRoll
	{
		[Address(RVA = "0x3119330", Offset = "0x3118730", Length = "0x76")]
		[Token(Token = "0x6000152")]
		 get { } //Length: 118
		[Address(RVA = "0x311A530", Offset = "0x3119930", Length = "0x86")]
		[Token(Token = "0x6000153")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000071")]
	public bool applyActiveColorSpace
	{
		[Address(RVA = "0x31193F0", Offset = "0x31187F0", Length = "0x76")]
		[Token(Token = "0x6000158")]
		 get { } //Length: 118
		[Address(RVA = "0x311A610", Offset = "0x3119A10", Length = "0x86")]
		[Token(Token = "0x6000159")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000062")]
	public float cameraVelocityScale
	{
		[Address(RVA = "0x31194B0", Offset = "0x31188B0", Length = "0x76")]
		[Token(Token = "0x600013B")]
		 get { } //Length: 118
		[Address(RVA = "0x311A6F0", Offset = "0x3119AF0", Length = "0x86")]
		[Token(Token = "0x600013C")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700006D")]
	public bool enableGPUInstancing
	{
		[Address(RVA = "0x3119570", Offset = "0x3118970", Length = "0x76")]
		[Token(Token = "0x6000150")]
		 get { } //Length: 118
		[Address(RVA = "0x311A7D0", Offset = "0x3119BD0", Length = "0x86")]
		[Token(Token = "0x6000151")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000069")]
	public Vector3 flip
	{
		[Address(RVA = "0x3119640", Offset = "0x3118A40", Length = "0x90")]
		[Token(Token = "0x6000149")]
		 get { } //Length: 144
		[Address(RVA = "0x311A8B0", Offset = "0x3119CB0", Length = "0x85")]
		[Token(Token = "0x600014A")]
		 set { } //Length: 133
	}

	[Token(Token = "0x1700006F")]
	public bool freeformStretching
	{
		[Address(RVA = "0x3119720", Offset = "0x3118B20", Length = "0x76")]
		[Token(Token = "0x6000154")]
		 get { } //Length: 118
		[Address(RVA = "0x311A990", Offset = "0x3119D90", Length = "0x86")]
		[Token(Token = "0x6000155")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000060")]
	public float lengthScale
	{
		[Address(RVA = "0x31197E0", Offset = "0x3118BE0", Length = "0x76")]
		[Token(Token = "0x6000137")]
		 get { } //Length: 118
		[Address(RVA = "0x311AA70", Offset = "0x3119E70", Length = "0x86")]
		[Token(Token = "0x6000138")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700006A")]
	public SpriteMaskInteraction maskInteraction
	{
		[Address(RVA = "0x31198A0", Offset = "0x3118CA0", Length = "0x76")]
		[Token(Token = "0x600014B")]
		 get { } //Length: 118
		[Address(RVA = "0x311AB40", Offset = "0x3119F40", Length = "0x83")]
		[Token(Token = "0x600014C")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000067")]
	public float maxParticleSize
	{
		[Address(RVA = "0x3119960", Offset = "0x3118D60", Length = "0x76")]
		[Token(Token = "0x6000145")]
		 get { } //Length: 118
		[Address(RVA = "0x311AC20", Offset = "0x311A020", Length = "0x86")]
		[Token(Token = "0x6000146")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000072")]
	public Mesh mesh
	{
		[Address(RVA = "0x3119BA0", Offset = "0x3118FA0", Length = "0x90")]
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMesh", HasExplicitThis = True)]
		[Token(Token = "0x600015A")]
		 get { } //Length: 144
		[Address(RVA = "0x311ADD0", Offset = "0x311A1D0", Length = "0xBA")]
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMesh", HasExplicitThis = True)]
		[Token(Token = "0x600015B")]
		 set { } //Length: 186
	}

	[Token(Token = "0x17000073")]
	public int meshCount
	{
		[Address(RVA = "0x3119A20", Offset = "0x3118E20", Length = "0x76")]
		[Token(Token = "0x6000162")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700005E")]
	public ParticleSystemMeshDistribution meshDistribution
	{
		[Address(RVA = "0x3119AE0", Offset = "0x3118EE0", Length = "0x76")]
		[Token(Token = "0x6000133")]
		 get { } //Length: 118
		[Address(RVA = "0x311ACF0", Offset = "0x311A0F0", Length = "0x83")]
		[Token(Token = "0x6000134")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000066")]
	public float minParticleSize
	{
		[Address(RVA = "0x3119C80", Offset = "0x3119080", Length = "0x76")]
		[Token(Token = "0x6000143")]
		 get { } //Length: 118
		[Address(RVA = "0x311AEE0", Offset = "0x311A2E0", Length = "0x86")]
		[Token(Token = "0x6000144")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000063")]
	public float normalDirection
	{
		[Address(RVA = "0x3119D40", Offset = "0x3119140", Length = "0x76")]
		[Token(Token = "0x600013D")]
		 get { } //Length: 118
		[Address(RVA = "0x311AFC0", Offset = "0x311A3C0", Length = "0x86")]
		[Token(Token = "0x600013E")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700006C")]
	internal Material oldTrailMaterial
	{
		[Address(RVA = "0x311B0A0", Offset = "0x311A4A0", Length = "0xBA")]
		[Token(Token = "0x600014F")]
		internal set { } //Length: 186
	}

	[Token(Token = "0x17000068")]
	public Vector3 pivot
	{
		[Address(RVA = "0x3119E10", Offset = "0x3119210", Length = "0x90")]
		[Token(Token = "0x6000147")]
		 get { } //Length: 144
		[Address(RVA = "0x311B1B0", Offset = "0x311A5B0", Length = "0x85")]
		[Token(Token = "0x6000148")]
		 set { } //Length: 133
	}

	[Token(Token = "0x1700005D")]
	public ParticleSystemRenderMode renderMode
	{
		[Address(RVA = "0x3119EF0", Offset = "0x31192F0", Length = "0x76")]
		[Token(Token = "0x6000131")]
		 get { } //Length: 118
		[Address(RVA = "0x311B280", Offset = "0x311A680", Length = "0x83")]
		[Token(Token = "0x6000132")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000070")]
	public bool rotateWithStretchDirection
	{
		[Address(RVA = "0x3119FB0", Offset = "0x31193B0", Length = "0x76")]
		[Token(Token = "0x6000156")]
		 get { } //Length: 118
		[Address(RVA = "0x311B360", Offset = "0x311A760", Length = "0x86")]
		[Token(Token = "0x6000157")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000064")]
	public float shadowBias
	{
		[Address(RVA = "0x311A070", Offset = "0x3119470", Length = "0x76")]
		[Token(Token = "0x600013F")]
		 get { } //Length: 118
		[Address(RVA = "0x311B440", Offset = "0x311A840", Length = "0x86")]
		[Token(Token = "0x6000140")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000065")]
	public float sortingFudge
	{
		[Address(RVA = "0x311A1F0", Offset = "0x31195F0", Length = "0x76")]
		[Token(Token = "0x6000141")]
		 get { } //Length: 118
		[Address(RVA = "0x311B5F0", Offset = "0x311A9F0", Length = "0x86")]
		[Token(Token = "0x6000142")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700005F")]
	public ParticleSystemSortMode sortMode
	{
		[Address(RVA = "0x311A130", Offset = "0x3119530", Length = "0x76")]
		[Token(Token = "0x6000135")]
		 get { } //Length: 118
		[Address(RVA = "0x311B510", Offset = "0x311A910", Length = "0x83")]
		[Token(Token = "0x6000136")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700006B")]
	public Material trailMaterial
	{
		[Address(RVA = "0x311A2B0", Offset = "0x31196B0", Length = "0x90")]
		[Token(Token = "0x600014D")]
		 get { } //Length: 144
		[Address(RVA = "0x311B6D0", Offset = "0x311AAD0", Length = "0xBA")]
		[Token(Token = "0x600014E")]
		 set { } //Length: 186
	}

	[Token(Token = "0x17000061")]
	public float velocityScale
	{
		[Address(RVA = "0x311A390", Offset = "0x3119790", Length = "0x76")]
		[Token(Token = "0x6000139")]
		 get { } //Length: 118
		[Address(RVA = "0x311B7E0", Offset = "0x311ABE0", Length = "0x86")]
		[Token(Token = "0x600013A")]
		 set { } //Length: 134
	}

	[Address(RVA = "0xE31DA0", Offset = "0xE311A0", Length = "0x7")]
	[Token(Token = "0x6000176")]
	public ParticleSystemRenderer() { }

	[Address(RVA = "0x3115B00", Offset = "0x3114F00", Length = "0x1B")]
	[Obsolete("AreVertexStreamsEnabled is deprecated. Use GetActiveVertexStreams instead.", False)]
	[Token(Token = "0x6000127")]
	public bool AreVertexStreamsEnabled(ParticleSystemVertexStreams streams) { }

	[Address(RVA = "0x3115CF0", Offset = "0x31150F0", Length = "0x14B")]
	[Token(Token = "0x6000164")]
	public void BakeMesh(Mesh mesh, Camera camera, ParticleSystemBakeMeshOptions options) { }

	[Address(RVA = "0x3115E40", Offset = "0x3115240", Length = "0x14C")]
	[Obsolete("BakeMesh with useTransform is deprecated. Use BakeMesh with ParticleSystemBakeMeshOptions instead.", False)]
	[Token(Token = "0x600012C")]
	public void BakeMesh(Mesh mesh, Camera camera, bool useTransform = false) { }

	[Address(RVA = "0x3115F90", Offset = "0x3115390", Length = "0x14F")]
	[Obsolete("BakeMesh with useTransform is deprecated. Use BakeMesh with ParticleSystemBakeMeshOptions instead.", False)]
	[Token(Token = "0x600012B")]
	public void BakeMesh(Mesh mesh, bool useTransform = false) { }

	[Address(RVA = "0x3115B90", Offset = "0x3114F90", Length = "0x152")]
	[Token(Token = "0x6000163")]
	public void BakeMesh(Mesh mesh, ParticleSystemBakeMeshOptions options) { }

	[Address(RVA = "0x3115B20", Offset = "0x3114F20", Length = "0x62")]
	[Token(Token = "0x60001A9")]
	private static void BakeMesh_Injected(IntPtr _unity_self, IntPtr mesh, IntPtr camera, ParticleSystemBakeMeshOptions options) { }

	[Address(RVA = "0x3116870", Offset = "0x3115C70", Length = "0x49")]
	[Token(Token = "0x6000167")]
	public int BakeTexture(ref Texture2D verticesTexture, ParticleSystemBakeTextureOptions options) { }

	[Address(RVA = "0x3116660", Offset = "0x3115A60", Length = "0x208")]
	[Token(Token = "0x6000168")]
	public int BakeTexture(ref Texture2D verticesTexture, Camera camera, ParticleSystemBakeTextureOptions options) { }

	[Address(RVA = "0x31168C0", Offset = "0x3115CC0", Length = "0x1BC")]
	[Token(Token = "0x600016A")]
	public int BakeTexture(ref Texture2D verticesTexture, ref Texture2D indicesTexture, ParticleSystemBakeTextureOptions options) { }

	[Address(RVA = "0x31164A0", Offset = "0x31158A0", Length = "0x1BF")]
	[Token(Token = "0x600016B")]
	public int BakeTexture(ref Texture2D verticesTexture, ref Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options) { }

	[Address(RVA = "0x3116150", Offset = "0x3115550", Length = "0x180")]
	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::BakeTexture", HasExplicitThis = True)]
	[Token(Token = "0x600016C")]
	private BakeTextureOutput BakeTextureInternal(Texture2D verticesTexture, Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options, out int indexCount) { }

	[Address(RVA = "0x31160E0", Offset = "0x31154E0", Length = "0x62")]
	[Token(Token = "0x60001AC")]
	private static void BakeTextureInternal_Injected(IntPtr _unity_self, IntPtr verticesTexture, IntPtr indicesTexture, IntPtr camera, ParticleSystemBakeTextureOptions options, out int indexCount, out BakeTextureOutput ret) { }

	[Address(RVA = "0x3116350", Offset = "0x3115750", Length = "0x145")]
	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::BakeTextureNoIndices", HasExplicitThis = True)]
	[Token(Token = "0x6000169")]
	private Texture2D BakeTextureNoIndicesInternal(Texture2D verticesTexture, Camera camera, ParticleSystemBakeTextureOptions options, out int indexCount) { }

	[Address(RVA = "0x31162E0", Offset = "0x31156E0", Length = "0x62")]
	[Token(Token = "0x60001AB")]
	private static IntPtr BakeTextureNoIndicesInternal_Injected(IntPtr _unity_self, IntPtr verticesTexture, IntPtr camera, ParticleSystemBakeTextureOptions options, out int indexCount) { }

	[Address(RVA = "0x3116EF0", Offset = "0x31162F0", Length = "0x14C")]
	[Obsolete("BakeTrailsMesh with useTransform is deprecated. Use BakeTrailsMesh with ParticleSystemBakeMeshOptions instead.", False)]
	[Token(Token = "0x600012E")]
	public void BakeTrailsMesh(Mesh mesh, Camera camera, bool useTransform = false) { }

	[Address(RVA = "0x3116DA0", Offset = "0x31161A0", Length = "0x14F")]
	[Obsolete("BakeTrailsMesh with useTransform is deprecated. Use BakeTrailsMesh with ParticleSystemBakeMeshOptions instead.", False)]
	[Token(Token = "0x600012D")]
	public void BakeTrailsMesh(Mesh mesh, bool useTransform = false) { }

	[Address(RVA = "0x3116C50", Offset = "0x3116050", Length = "0x14B")]
	[Token(Token = "0x6000166")]
	public void BakeTrailsMesh(Mesh mesh, Camera camera, ParticleSystemBakeMeshOptions options) { }

	[Address(RVA = "0x3116AF0", Offset = "0x3115EF0", Length = "0x152")]
	[Token(Token = "0x6000165")]
	public void BakeTrailsMesh(Mesh mesh, ParticleSystemBakeMeshOptions options) { }

	[Address(RVA = "0x3116A80", Offset = "0x3115E80", Length = "0x62")]
	[Token(Token = "0x60001AA")]
	private static void BakeTrailsMesh_Injected(IntPtr _unity_self, IntPtr mesh, IntPtr camera, ParticleSystemBakeMeshOptions options) { }

	[Address(RVA = "0x3117400", Offset = "0x3116800", Length = "0x1BF")]
	[Token(Token = "0x600016E")]
	public int BakeTrailsTexture(ref Texture2D verticesTexture, ref Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options) { }

	[Address(RVA = "0x3117240", Offset = "0x3116640", Length = "0x1BC")]
	[Token(Token = "0x600016D")]
	public int BakeTrailsTexture(ref Texture2D verticesTexture, ref Texture2D indicesTexture, ParticleSystemBakeTextureOptions options) { }

	[Address(RVA = "0x31170B0", Offset = "0x31164B0", Length = "0x180")]
	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::BakeTrailsTexture", HasExplicitThis = True)]
	[Token(Token = "0x600016F")]
	private BakeTextureOutput BakeTrailsTextureInternal(Texture2D verticesTexture, Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options, out int indexCount) { }

	[Address(RVA = "0x3117040", Offset = "0x3116440", Length = "0x62")]
	[Token(Token = "0x60001AD")]
	private static void BakeTrailsTextureInternal_Injected(IntPtr _unity_self, IntPtr verticesTexture, IntPtr indicesTexture, IntPtr camera, ParticleSystemBakeTextureOptions options, out int indexCount, out BakeTextureOutput ret) { }

	[Address(RVA = "0x31175C0", Offset = "0x31169C0", Length = "0xB")]
	[Obsolete("DisableVertexStreams is deprecated. Use SetActiveVertexStreams instead.", False)]
	[Token(Token = "0x6000126")]
	public void DisableVertexStreams(ParticleSystemVertexStreams streams) { }

	[Address(RVA = "0x31175D0", Offset = "0x31169D0", Length = "0xB")]
	[Obsolete("EnableVertexStreams is deprecated. Use SetActiveVertexStreams instead.", False)]
	[Token(Token = "0x6000125")]
	public void EnableVertexStreams(ParticleSystemVertexStreams streams) { }

	[Address(RVA = "0x31190F0", Offset = "0x31184F0", Length = "0x76")]
	[Token(Token = "0x6000173")]
	public int get_activeTrailVertexStreamsCount() { }

	[Address(RVA = "0x31190B0", Offset = "0x31184B0", Length = "0x33")]
	[Token(Token = "0x60001B1")]
	private static int get_activeTrailVertexStreamsCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31191B0", Offset = "0x31185B0", Length = "0x76")]
	[Token(Token = "0x6000170")]
	public int get_activeVertexStreamsCount() { }

	[Address(RVA = "0x3119170", Offset = "0x3118570", Length = "0x33")]
	[Token(Token = "0x60001AE")]
	private static int get_activeVertexStreamsCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3119270", Offset = "0x3118670", Length = "0x76")]
	[Token(Token = "0x600012F")]
	public ParticleSystemRenderSpace get_alignment() { }

	[Address(RVA = "0x3119230", Offset = "0x3118630", Length = "0x33")]
	[Token(Token = "0x6000177")]
	private static ParticleSystemRenderSpace get_alignment_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3119330", Offset = "0x3118730", Length = "0x76")]
	[Token(Token = "0x6000152")]
	public bool get_allowRoll() { }

	[Address(RVA = "0x31192F0", Offset = "0x31186F0", Length = "0x33")]
	[Token(Token = "0x600019A")]
	private static bool get_allowRoll_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31193F0", Offset = "0x31187F0", Length = "0x76")]
	[Token(Token = "0x6000158")]
	public bool get_applyActiveColorSpace() { }

	[Address(RVA = "0x31193B0", Offset = "0x31187B0", Length = "0x33")]
	[Token(Token = "0x60001A0")]
	private static bool get_applyActiveColorSpace_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31194B0", Offset = "0x31188B0", Length = "0x76")]
	[Token(Token = "0x600013B")]
	public float get_cameraVelocityScale() { }

	[Address(RVA = "0x3119470", Offset = "0x3118870", Length = "0x33")]
	[Token(Token = "0x6000183")]
	private static float get_cameraVelocityScale_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3119570", Offset = "0x3118970", Length = "0x76")]
	[Token(Token = "0x6000150")]
	public bool get_enableGPUInstancing() { }

	[Address(RVA = "0x3119530", Offset = "0x3118930", Length = "0x33")]
	[Token(Token = "0x6000198")]
	private static bool get_enableGPUInstancing_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3119640", Offset = "0x3118A40", Length = "0x90")]
	[Token(Token = "0x6000149")]
	public Vector3 get_flip() { }

	[Address(RVA = "0x31195F0", Offset = "0x31189F0", Length = "0x42")]
	[Token(Token = "0x6000191")]
	private static void get_flip_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x3119720", Offset = "0x3118B20", Length = "0x76")]
	[Token(Token = "0x6000154")]
	public bool get_freeformStretching() { }

	[Address(RVA = "0x31196E0", Offset = "0x3118AE0", Length = "0x33")]
	[Token(Token = "0x600019C")]
	private static bool get_freeformStretching_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31197E0", Offset = "0x3118BE0", Length = "0x76")]
	[Token(Token = "0x6000137")]
	public float get_lengthScale() { }

	[Address(RVA = "0x31197A0", Offset = "0x3118BA0", Length = "0x33")]
	[Token(Token = "0x600017F")]
	private static float get_lengthScale_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31198A0", Offset = "0x3118CA0", Length = "0x76")]
	[Token(Token = "0x600014B")]
	public SpriteMaskInteraction get_maskInteraction() { }

	[Address(RVA = "0x3119860", Offset = "0x3118C60", Length = "0x33")]
	[Token(Token = "0x6000193")]
	private static SpriteMaskInteraction get_maskInteraction_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3119960", Offset = "0x3118D60", Length = "0x76")]
	[Token(Token = "0x6000145")]
	public float get_maxParticleSize() { }

	[Address(RVA = "0x3119920", Offset = "0x3118D20", Length = "0x33")]
	[Token(Token = "0x600018D")]
	private static float get_maxParticleSize_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3119BA0", Offset = "0x3118FA0", Length = "0x90")]
	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMesh", HasExplicitThis = True)]
	[Token(Token = "0x600015A")]
	public Mesh get_mesh() { }

	[Address(RVA = "0x3119B60", Offset = "0x3118F60", Length = "0x33")]
	[Token(Token = "0x60001A2")]
	private static IntPtr get_mesh_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3119A20", Offset = "0x3118E20", Length = "0x76")]
	[Token(Token = "0x6000162")]
	public int get_meshCount() { }

	[Address(RVA = "0x31199E0", Offset = "0x3118DE0", Length = "0x33")]
	[Token(Token = "0x60001A8")]
	private static int get_meshCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3119AE0", Offset = "0x3118EE0", Length = "0x76")]
	[Token(Token = "0x6000133")]
	public ParticleSystemMeshDistribution get_meshDistribution() { }

	[Address(RVA = "0x3119AA0", Offset = "0x3118EA0", Length = "0x33")]
	[Token(Token = "0x600017B")]
	private static ParticleSystemMeshDistribution get_meshDistribution_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3119C80", Offset = "0x3119080", Length = "0x76")]
	[Token(Token = "0x6000143")]
	public float get_minParticleSize() { }

	[Address(RVA = "0x3119C40", Offset = "0x3119040", Length = "0x33")]
	[Token(Token = "0x600018B")]
	private static float get_minParticleSize_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3119D40", Offset = "0x3119140", Length = "0x76")]
	[Token(Token = "0x600013D")]
	public float get_normalDirection() { }

	[Address(RVA = "0x3119D00", Offset = "0x3119100", Length = "0x33")]
	[Token(Token = "0x6000185")]
	private static float get_normalDirection_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3119E10", Offset = "0x3119210", Length = "0x90")]
	[Token(Token = "0x6000147")]
	public Vector3 get_pivot() { }

	[Address(RVA = "0x3119DC0", Offset = "0x31191C0", Length = "0x42")]
	[Token(Token = "0x600018F")]
	private static void get_pivot_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x3119EF0", Offset = "0x31192F0", Length = "0x76")]
	[Token(Token = "0x6000131")]
	public ParticleSystemRenderMode get_renderMode() { }

	[Address(RVA = "0x3119EB0", Offset = "0x31192B0", Length = "0x33")]
	[Token(Token = "0x6000179")]
	private static ParticleSystemRenderMode get_renderMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3119FB0", Offset = "0x31193B0", Length = "0x76")]
	[Token(Token = "0x6000156")]
	public bool get_rotateWithStretchDirection() { }

	[Address(RVA = "0x3119F70", Offset = "0x3119370", Length = "0x33")]
	[Token(Token = "0x600019E")]
	private static bool get_rotateWithStretchDirection_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x311A070", Offset = "0x3119470", Length = "0x76")]
	[Token(Token = "0x600013F")]
	public float get_shadowBias() { }

	[Address(RVA = "0x311A030", Offset = "0x3119430", Length = "0x33")]
	[Token(Token = "0x6000187")]
	private static float get_shadowBias_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x311A1F0", Offset = "0x31195F0", Length = "0x76")]
	[Token(Token = "0x6000141")]
	public float get_sortingFudge() { }

	[Address(RVA = "0x311A1B0", Offset = "0x31195B0", Length = "0x33")]
	[Token(Token = "0x6000189")]
	private static float get_sortingFudge_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x311A130", Offset = "0x3119530", Length = "0x76")]
	[Token(Token = "0x6000135")]
	public ParticleSystemSortMode get_sortMode() { }

	[Address(RVA = "0x311A0F0", Offset = "0x31194F0", Length = "0x33")]
	[Token(Token = "0x600017D")]
	private static ParticleSystemSortMode get_sortMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x311A2B0", Offset = "0x31196B0", Length = "0x90")]
	[Token(Token = "0x600014D")]
	public Material get_trailMaterial() { }

	[Address(RVA = "0x311A270", Offset = "0x3119670", Length = "0x33")]
	[Token(Token = "0x6000195")]
	private static IntPtr get_trailMaterial_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x311A390", Offset = "0x3119790", Length = "0x76")]
	[Token(Token = "0x6000139")]
	public float get_velocityScale() { }

	[Address(RVA = "0x311A350", Offset = "0x3119750", Length = "0x33")]
	[Token(Token = "0x6000181")]
	private static float get_velocityScale_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3117630", Offset = "0x3116A30", Length = "0x20A")]
	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetActiveTrailVertexStreams", HasExplicitThis = True)]
	[Token(Token = "0x6000175")]
	public void GetActiveTrailVertexStreams(List<ParticleSystemVertexStream> streams) { }

	[Address(RVA = "0x31175E0", Offset = "0x31169E0", Length = "0x42")]
	[Token(Token = "0x60001B3")]
	private static void GetActiveTrailVertexStreams_Injected(IntPtr _unity_self, ref BlittableListWrapper streams) { }

	[Address(RVA = "0x3117890", Offset = "0x3116C90", Length = "0x20A")]
	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetActiveVertexStreams", HasExplicitThis = True)]
	[Token(Token = "0x6000172")]
	public void GetActiveVertexStreams(List<ParticleSystemVertexStream> streams) { }

	[Address(RVA = "0x3117840", Offset = "0x3116C40", Length = "0x42")]
	[Token(Token = "0x60001B0")]
	private static void GetActiveVertexStreams_Injected(IntPtr _unity_self, ref BlittableListWrapper streams) { }

	[Address(RVA = "0x3117AA0", Offset = "0x3116EA0", Length = "0xA")]
	[Obsolete("GetEnabledVertexStreams is deprecated. Use GetActiveVertexStreams instead.", False)]
	[Token(Token = "0x6000128")]
	public ParticleSystemVertexStreams GetEnabledVertexStreams(ParticleSystemVertexStreams streams) { }

	[Address(RVA = "0x3117CB0", Offset = "0x31170B0", Length = "0xA7")]
	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshes", HasExplicitThis = True)]
	[RequiredByNativeCode]
	[Token(Token = "0x600015C")]
	public int GetMeshes(out Mesh[] meshes) { }

	[Address(RVA = "0x3117C60", Offset = "0x3117060", Length = "0x42")]
	[Token(Token = "0x60001A4")]
	private static int GetMeshes_Injected(IntPtr _unity_self, out Mesh[] meshes) { }

	[Address(RVA = "0x3117B00", Offset = "0x3116F00", Length = "0x155")]
	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshWeightings", HasExplicitThis = True)]
	[Token(Token = "0x600015F")]
	public int GetMeshWeightings(out Single[] weightings) { }

	[Address(RVA = "0x3117AB0", Offset = "0x3116EB0", Length = "0x42")]
	[Token(Token = "0x60001A6")]
	private static int GetMeshWeightings_Injected(IntPtr _unity_self, out BlittableArrayWrapper weightings) { }

	[Address(RVA = "0x3117D60", Offset = "0x3117160", Length = "0x2A1")]
	[Obsolete("Internal_GetVertexStreams is deprecated. Use GetActiveVertexStreams instead.", False)]
	[Token(Token = "0x600012A")]
	internal ParticleSystemVertexStreams Internal_GetEnabledVertexStreams(ParticleSystemVertexStreams streams) { }

	[Address(RVA = "0x3118010", Offset = "0x3117410", Length = "0x736")]
	[Obsolete("Internal_SetVertexStreams is deprecated. Use SetActiveVertexStreams instead.", False)]
	[Token(Token = "0x6000129")]
	internal void Internal_SetVertexStreams(ParticleSystemVertexStreams streams, bool enabled) { }

	[Address(RVA = "0x311A450", Offset = "0x3119850", Length = "0x83")]
	[Token(Token = "0x6000130")]
	public void set_alignment(ParticleSystemRenderSpace value) { }

	[Address(RVA = "0x311A410", Offset = "0x3119810", Length = "0x40")]
	[Token(Token = "0x6000178")]
	private static void set_alignment_Injected(IntPtr _unity_self, ParticleSystemRenderSpace value) { }

	[Address(RVA = "0x311A530", Offset = "0x3119930", Length = "0x86")]
	[Token(Token = "0x6000153")]
	public void set_allowRoll(bool value) { }

	[Address(RVA = "0x311A4E0", Offset = "0x31198E0", Length = "0x42")]
	[Token(Token = "0x600019B")]
	private static void set_allowRoll_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x311A610", Offset = "0x3119A10", Length = "0x86")]
	[Token(Token = "0x6000159")]
	public void set_applyActiveColorSpace(bool value) { }

	[Address(RVA = "0x311A5C0", Offset = "0x31199C0", Length = "0x42")]
	[Token(Token = "0x60001A1")]
	private static void set_applyActiveColorSpace_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x311A6F0", Offset = "0x3119AF0", Length = "0x86")]
	[Token(Token = "0x600013C")]
	public void set_cameraVelocityScale(float value) { }

	[Address(RVA = "0x311A6A0", Offset = "0x3119AA0", Length = "0x43")]
	[Token(Token = "0x6000184")]
	private static void set_cameraVelocityScale_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x311A7D0", Offset = "0x3119BD0", Length = "0x86")]
	[Token(Token = "0x6000151")]
	public void set_enableGPUInstancing(bool value) { }

	[Address(RVA = "0x311A780", Offset = "0x3119B80", Length = "0x42")]
	[Token(Token = "0x6000199")]
	private static void set_enableGPUInstancing_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x311A8B0", Offset = "0x3119CB0", Length = "0x85")]
	[Token(Token = "0x600014A")]
	public void set_flip(Vector3 value) { }

	[Address(RVA = "0x311A860", Offset = "0x3119C60", Length = "0x42")]
	[Token(Token = "0x6000192")]
	private static void set_flip_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x311A990", Offset = "0x3119D90", Length = "0x86")]
	[Token(Token = "0x6000155")]
	public void set_freeformStretching(bool value) { }

	[Address(RVA = "0x311A940", Offset = "0x3119D40", Length = "0x42")]
	[Token(Token = "0x600019D")]
	private static void set_freeformStretching_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x311AA70", Offset = "0x3119E70", Length = "0x86")]
	[Token(Token = "0x6000138")]
	public void set_lengthScale(float value) { }

	[Address(RVA = "0x311AA20", Offset = "0x3119E20", Length = "0x43")]
	[Token(Token = "0x6000180")]
	private static void set_lengthScale_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x311AB40", Offset = "0x3119F40", Length = "0x83")]
	[Token(Token = "0x600014C")]
	public void set_maskInteraction(SpriteMaskInteraction value) { }

	[Address(RVA = "0x311AB00", Offset = "0x3119F00", Length = "0x40")]
	[Token(Token = "0x6000194")]
	private static void set_maskInteraction_Injected(IntPtr _unity_self, SpriteMaskInteraction value) { }

	[Address(RVA = "0x311AC20", Offset = "0x311A020", Length = "0x86")]
	[Token(Token = "0x6000146")]
	public void set_maxParticleSize(float value) { }

	[Address(RVA = "0x311ABD0", Offset = "0x3119FD0", Length = "0x43")]
	[Token(Token = "0x600018E")]
	private static void set_maxParticleSize_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x311ADD0", Offset = "0x311A1D0", Length = "0xBA")]
	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMesh", HasExplicitThis = True)]
	[Token(Token = "0x600015B")]
	public void set_mesh(Mesh value) { }

	[Address(RVA = "0x311AD80", Offset = "0x311A180", Length = "0x42")]
	[Token(Token = "0x60001A3")]
	private static void set_mesh_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x311ACF0", Offset = "0x311A0F0", Length = "0x83")]
	[Token(Token = "0x6000134")]
	public void set_meshDistribution(ParticleSystemMeshDistribution value) { }

	[Address(RVA = "0x311ACB0", Offset = "0x311A0B0", Length = "0x40")]
	[Token(Token = "0x600017C")]
	private static void set_meshDistribution_Injected(IntPtr _unity_self, ParticleSystemMeshDistribution value) { }

	[Address(RVA = "0x311AEE0", Offset = "0x311A2E0", Length = "0x86")]
	[Token(Token = "0x6000144")]
	public void set_minParticleSize(float value) { }

	[Address(RVA = "0x311AE90", Offset = "0x311A290", Length = "0x43")]
	[Token(Token = "0x600018C")]
	private static void set_minParticleSize_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x311AFC0", Offset = "0x311A3C0", Length = "0x86")]
	[Token(Token = "0x600013E")]
	public void set_normalDirection(float value) { }

	[Address(RVA = "0x311AF70", Offset = "0x311A370", Length = "0x43")]
	[Token(Token = "0x6000186")]
	private static void set_normalDirection_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x311B0A0", Offset = "0x311A4A0", Length = "0xBA")]
	[Token(Token = "0x600014F")]
	internal void set_oldTrailMaterial(Material value) { }

	[Address(RVA = "0x311B050", Offset = "0x311A450", Length = "0x42")]
	[Token(Token = "0x6000197")]
	private static void set_oldTrailMaterial_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x311B1B0", Offset = "0x311A5B0", Length = "0x85")]
	[Token(Token = "0x6000148")]
	public void set_pivot(Vector3 value) { }

	[Address(RVA = "0x311B160", Offset = "0x311A560", Length = "0x42")]
	[Token(Token = "0x6000190")]
	private static void set_pivot_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x311B280", Offset = "0x311A680", Length = "0x83")]
	[Token(Token = "0x6000132")]
	public void set_renderMode(ParticleSystemRenderMode value) { }

	[Address(RVA = "0x311B240", Offset = "0x311A640", Length = "0x40")]
	[Token(Token = "0x600017A")]
	private static void set_renderMode_Injected(IntPtr _unity_self, ParticleSystemRenderMode value) { }

	[Address(RVA = "0x311B360", Offset = "0x311A760", Length = "0x86")]
	[Token(Token = "0x6000157")]
	public void set_rotateWithStretchDirection(bool value) { }

	[Address(RVA = "0x311B310", Offset = "0x311A710", Length = "0x42")]
	[Token(Token = "0x600019F")]
	private static void set_rotateWithStretchDirection_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x311B440", Offset = "0x311A840", Length = "0x86")]
	[Token(Token = "0x6000140")]
	public void set_shadowBias(float value) { }

	[Address(RVA = "0x311B3F0", Offset = "0x311A7F0", Length = "0x43")]
	[Token(Token = "0x6000188")]
	private static void set_shadowBias_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x311B5F0", Offset = "0x311A9F0", Length = "0x86")]
	[Token(Token = "0x6000142")]
	public void set_sortingFudge(float value) { }

	[Address(RVA = "0x311B5A0", Offset = "0x311A9A0", Length = "0x43")]
	[Token(Token = "0x600018A")]
	private static void set_sortingFudge_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x311B510", Offset = "0x311A910", Length = "0x83")]
	[Token(Token = "0x6000136")]
	public void set_sortMode(ParticleSystemSortMode value) { }

	[Address(RVA = "0x311B4D0", Offset = "0x311A8D0", Length = "0x40")]
	[Token(Token = "0x600017E")]
	private static void set_sortMode_Injected(IntPtr _unity_self, ParticleSystemSortMode value) { }

	[Address(RVA = "0x311B6D0", Offset = "0x311AAD0", Length = "0xBA")]
	[Token(Token = "0x600014E")]
	public void set_trailMaterial(Material value) { }

	[Address(RVA = "0x311B680", Offset = "0x311AA80", Length = "0x42")]
	[Token(Token = "0x6000196")]
	private static void set_trailMaterial_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x311B7E0", Offset = "0x311ABE0", Length = "0x86")]
	[Token(Token = "0x600013A")]
	public void set_velocityScale(float value) { }

	[Address(RVA = "0x311B790", Offset = "0x311AB90", Length = "0x43")]
	[Token(Token = "0x6000182")]
	private static void set_velocityScale_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x31187A0", Offset = "0x3117BA0", Length = "0x20A")]
	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetActiveTrailVertexStreams", HasExplicitThis = True)]
	[Token(Token = "0x6000174")]
	public void SetActiveTrailVertexStreams(List<ParticleSystemVertexStream> streams) { }

	[Address(RVA = "0x3118750", Offset = "0x3117B50", Length = "0x42")]
	[Token(Token = "0x60001B2")]
	private static void SetActiveTrailVertexStreams_Injected(IntPtr _unity_self, ref BlittableListWrapper streams) { }

	[Address(RVA = "0x3118A00", Offset = "0x3117E00", Length = "0x20A")]
	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetActiveVertexStreams", HasExplicitThis = True)]
	[Token(Token = "0x6000171")]
	public void SetActiveVertexStreams(List<ParticleSystemVertexStream> streams) { }

	[Address(RVA = "0x31189B0", Offset = "0x3117DB0", Length = "0x42")]
	[Token(Token = "0x60001AF")]
	private static void SetActiveVertexStreams_Injected(IntPtr _unity_self, ref BlittableListWrapper streams) { }

	[Address(RVA = "0x3119000", Offset = "0x3118400", Length = "0xAA")]
	[Token(Token = "0x600015E")]
	public void SetMeshes(Mesh[] meshes) { }

	[Address(RVA = "0x3118F40", Offset = "0x3118340", Length = "0xB7")]
	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMeshes", HasExplicitThis = True)]
	[Token(Token = "0x600015D")]
	public void SetMeshes(Mesh[] meshes, int size) { }

	[Address(RVA = "0x3118EE0", Offset = "0x31182E0", Length = "0x52")]
	[Token(Token = "0x60001A5")]
	private static void SetMeshes_Injected(IntPtr _unity_self, Mesh[] meshes, int size) { }

	[Address(RVA = "0x3118C70", Offset = "0x3118070", Length = "0x136")]
	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMeshWeightings", HasExplicitThis = True)]
	[Token(Token = "0x6000160")]
	public void SetMeshWeightings(Single[] weightings, int size) { }

	[Address(RVA = "0x3118DB0", Offset = "0x31181B0", Length = "0x120")]
	[Token(Token = "0x6000161")]
	public void SetMeshWeightings(Single[] weightings) { }

	[Address(RVA = "0x3118C10", Offset = "0x3118010", Length = "0x52")]
	[Token(Token = "0x60001A7")]
	private static void SetMeshWeightings_Injected(IntPtr _unity_self, ref ManagedSpanWrapper weightings, int size) { }

}


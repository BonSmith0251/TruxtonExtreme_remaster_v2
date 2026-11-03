namespace UnityEngine.VFX;

[NativeHeader("Modules/VFX/Public/ScriptBindings/VisualEffectBindings.h")]
[NativeHeader("Modules/VFX/Public/VisualEffect.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x2000014")]
public class VisualEffect : Behaviour
{
	[Token(Token = "0x2000015")]
	public enum VFXCPUEffectMarkers : int
	{
		FullUpdate = 0,
		ProcessUpdate = 1,
		EvaluateExpressions = 2,
	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400002D")]
	private VFXEventAttribute m_cachedEventAttribute; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400002E")]
	public Action<VFXOutputEventArgs> outputEventReceived; //Field offset: 0x20

	[Token(Token = "0x17000016")]
	public int aliveParticleCount
	{
		[Address(RVA = "0x348A9F0", Offset = "0x3489DF0", Length = "0x76")]
		[Token(Token = "0x6000119")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000014")]
	public bool culled
	{
		[Address(RVA = "0x348AAB0", Offset = "0x3489EB0", Length = "0x76")]
		[Token(Token = "0x6000093")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000012")]
	public int initialEventID
	{
		[Address(RVA = "0x348AB70", Offset = "0x3489F70", Length = "0x76")]
		[FreeFunction(Name = "VisualEffectBindings::GetInitialEventID", HasExplicitThis = True)]
		[Token(Token = "0x600008F")]
		 get { } //Length: 118
		[Address(RVA = "0x348B230", Offset = "0x348A630", Length = "0x83")]
		[FreeFunction(Name = "VisualEffectBindings::SetInitialEventID", HasExplicitThis = True)]
		[Token(Token = "0x6000090")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000013")]
	public string initialEventName
	{
		[Address(RVA = "0x348AC40", Offset = "0x348A040", Length = "0x106")]
		[FreeFunction(Name = "VisualEffectBindings::GetInitialEventName", HasExplicitThis = True)]
		[Token(Token = "0x6000091")]
		 get { } //Length: 262
		[Address(RVA = "0x348B310", Offset = "0x348A710", Length = "0x1C7")]
		[FreeFunction(Name = "VisualEffectBindings::SetInitialEventName", HasExplicitThis = True)]
		[Token(Token = "0x6000092")]
		 set { } //Length: 455
	}

	[Token(Token = "0x1700000E")]
	public bool pause
	{
		[Address(RVA = "0x348AD90", Offset = "0x348A190", Length = "0x76")]
		[Token(Token = "0x6000087")]
		 get { } //Length: 118
		[Address(RVA = "0x348B530", Offset = "0x348A930", Length = "0x86")]
		[Token(Token = "0x6000088")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700000F")]
	public float playRate
	{
		[Address(RVA = "0x348AE50", Offset = "0x348A250", Length = "0x76")]
		[Token(Token = "0x6000089")]
		 get { } //Length: 118
		[Address(RVA = "0x348B610", Offset = "0x348AA10", Length = "0x86")]
		[Token(Token = "0x600008A")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000011")]
	public bool resetSeedOnPlay
	{
		[Address(RVA = "0x348AF10", Offset = "0x348A310", Length = "0x76")]
		[Token(Token = "0x600008D")]
		 get { } //Length: 118
		[Address(RVA = "0x348B6F0", Offset = "0x348AAF0", Length = "0x86")]
		[Token(Token = "0x600008E")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000010")]
	public uint startSeed
	{
		[Address(RVA = "0x348AFD0", Offset = "0x348A3D0", Length = "0x76")]
		[Token(Token = "0x600008B")]
		 get { } //Length: 118
		[Address(RVA = "0x348B7C0", Offset = "0x348ABC0", Length = "0x83")]
		[Token(Token = "0x600008C")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000017")]
	internal float time
	{
		[Address(RVA = "0x348B090", Offset = "0x348A490", Length = "0x76")]
		[Token(Token = "0x600011A")]
		internal get { } //Length: 118
	}

	[Token(Token = "0x17000015")]
	public VisualEffectAsset visualEffectAsset
	{
		[Address(RVA = "0x348B150", Offset = "0x348A550", Length = "0x90")]
		[Token(Token = "0x6000094")]
		 get { } //Length: 144
		[Address(RVA = "0x348B8A0", Offset = "0x348ACA0", Length = "0xBA")]
		[Token(Token = "0x6000095")]
		 set { } //Length: 186
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x600011E")]
	public VisualEffect() { }

	[Address(RVA = "0x34833D0", Offset = "0x34827D0", Length = "0x76")]
	[Token(Token = "0x60000A3")]
	public void AdvanceOneFrame() { }

	[Address(RVA = "0x3483390", Offset = "0x3482790", Length = "0x33")]
	[Token(Token = "0x6000130")]
	private static void AdvanceOneFrame_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3483450", Offset = "0x3482850", Length = "0x13D")]
	[Token(Token = "0x6000097")]
	private void CheckValidVFXEventAttribute(VFXEventAttribute eventAttribute) { }

	[Address(RVA = "0x3483590", Offset = "0x3482990", Length = "0x264")]
	[Token(Token = "0x6000096")]
	public VFXEventAttribute CreateVFXEventAttribute() { }

	[Address(RVA = "0x348A9F0", Offset = "0x3489DF0", Length = "0x76")]
	[Token(Token = "0x6000119")]
	public int get_aliveParticleCount() { }

	[Address(RVA = "0x348A9B0", Offset = "0x3489DB0", Length = "0x33")]
	[Token(Token = "0x6000169")]
	private static int get_aliveParticleCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348AAB0", Offset = "0x3489EB0", Length = "0x76")]
	[Token(Token = "0x6000093")]
	public bool get_culled() { }

	[Address(RVA = "0x348AA70", Offset = "0x3489E70", Length = "0x33")]
	[Token(Token = "0x600012B")]
	private static bool get_culled_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348AB70", Offset = "0x3489F70", Length = "0x76")]
	[FreeFunction(Name = "VisualEffectBindings::GetInitialEventID", HasExplicitThis = True)]
	[Token(Token = "0x600008F")]
	public int get_initialEventID() { }

	[Address(RVA = "0x348AB30", Offset = "0x3489F30", Length = "0x33")]
	[Token(Token = "0x6000127")]
	private static int get_initialEventID_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348AC40", Offset = "0x348A040", Length = "0x106")]
	[FreeFunction(Name = "VisualEffectBindings::GetInitialEventName", HasExplicitThis = True)]
	[Token(Token = "0x6000091")]
	public string get_initialEventName() { }

	[Address(RVA = "0x348ABF0", Offset = "0x3489FF0", Length = "0x42")]
	[Token(Token = "0x6000129")]
	private static void get_initialEventName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x348AD90", Offset = "0x348A190", Length = "0x76")]
	[Token(Token = "0x6000087")]
	public bool get_pause() { }

	[Address(RVA = "0x348AD50", Offset = "0x348A150", Length = "0x33")]
	[Token(Token = "0x600011F")]
	private static bool get_pause_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348AE50", Offset = "0x348A250", Length = "0x76")]
	[Token(Token = "0x6000089")]
	public float get_playRate() { }

	[Address(RVA = "0x348AE10", Offset = "0x348A210", Length = "0x33")]
	[Token(Token = "0x6000121")]
	private static float get_playRate_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348AF10", Offset = "0x348A310", Length = "0x76")]
	[Token(Token = "0x600008D")]
	public bool get_resetSeedOnPlay() { }

	[Address(RVA = "0x348AED0", Offset = "0x348A2D0", Length = "0x33")]
	[Token(Token = "0x6000125")]
	private static bool get_resetSeedOnPlay_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348AFD0", Offset = "0x348A3D0", Length = "0x76")]
	[Token(Token = "0x600008B")]
	public uint get_startSeed() { }

	[Address(RVA = "0x348AF90", Offset = "0x348A390", Length = "0x33")]
	[Token(Token = "0x6000123")]
	private static uint get_startSeed_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348B090", Offset = "0x348A490", Length = "0x76")]
	[Token(Token = "0x600011A")]
	internal float get_time() { }

	[Address(RVA = "0x348B050", Offset = "0x348A450", Length = "0x33")]
	[Token(Token = "0x600016A")]
	private static float get_time_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348B150", Offset = "0x348A550", Length = "0x90")]
	[Token(Token = "0x6000094")]
	public VisualEffectAsset get_visualEffectAsset() { }

	[Address(RVA = "0x348B110", Offset = "0x348A510", Length = "0x33")]
	[Token(Token = "0x600012C")]
	private static IntPtr get_visualEffectAsset_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x34838F0", Offset = "0x3482CF0", Length = "0xF0")]
	[Token(Token = "0x600010F")]
	public AnimationCurve GetAnimationCurve(string name) { }

	[Address(RVA = "0x3483800", Offset = "0x3482C00", Length = "0xE3")]
	[Token(Token = "0x60000D7")]
	public AnimationCurve GetAnimationCurve(int nameID) { }

	[Address(RVA = "0x3483A30", Offset = "0x3482E30", Length = "0x90")]
	[Token(Token = "0x600010E")]
	public bool GetBool(string name) { }

	[Address(RVA = "0x3483AD0", Offset = "0x3482ED0", Length = "0x83")]
	[FreeFunction(Name = "VisualEffectBindings::GetValueFromScript<bool>", HasExplicitThis = True)]
	[Token(Token = "0x60000C9")]
	public bool GetBool(int nameID) { }

	[Address(RVA = "0x34839F0", Offset = "0x3482DF0", Length = "0x40")]
	[Token(Token = "0x6000156")]
	private static bool GetBool_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3483ED0", Offset = "0x34832D0", Length = "0xA3")]
	[FreeFunction(Name = "VisualEffectBindings::GetComputedBounds", HasExplicitThis = True)]
	[Token(Token = "0x60000DC")]
	internal Bounds GetComputedBounds(int nameID) { }

	[Address(RVA = "0x3483F80", Offset = "0x3483380", Length = "0xD0")]
	[Token(Token = "0x6000117")]
	internal Bounds GetComputedBounds(string name) { }

	[Address(RVA = "0x3483E80", Offset = "0x3483280", Length = "0x50")]
	[Token(Token = "0x6000167")]
	private static void GetComputedBounds_Injected(IntPtr _unity_self, int nameID, out Bounds ret) { }

	[Address(RVA = "0x3483BC0", Offset = "0x3482FC0", Length = "0x113")]
	[FreeFunction(Name = "VisualEffectBindings::GetCPUEffectMarkerName", HasExplicitThis = True, ThrowsException = True)]
	[NativeConditional("ENABLE_PROFILER")]
	[Token(Token = "0x60000A6")]
	internal string GetCPUEffectMarkerName(int markerIndex) { }

	[Address(RVA = "0x3483BB0", Offset = "0x3482FB0", Length = "0xA")]
	[Token(Token = "0x6000115")]
	internal string GetCPUEffectMarkerName(VFXCPUEffectMarkers markerId) { }

	[Address(RVA = "0x3483B60", Offset = "0x3482F60", Length = "0x50")]
	[Token(Token = "0x6000133")]
	private static void GetCPUEffectMarkerName_Injected(IntPtr _unity_self, int markerIndex, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x3483D60", Offset = "0x3483160", Length = "0x113")]
	[FreeFunction(Name = "VisualEffectBindings::GetCPUSystemMarkerName", HasExplicitThis = True, ThrowsException = True)]
	[NativeConditional("ENABLE_PROFILER")]
	[Token(Token = "0x60000A7")]
	private string GetCPUSystemMarkerName(int nameID) { }

	[Address(RVA = "0x3483D30", Offset = "0x3483130", Length = "0x28")]
	[Token(Token = "0x6000114")]
	internal string GetCPUSystemMarkerName(string systemName) { }

	[Address(RVA = "0x3483CE0", Offset = "0x34830E0", Length = "0x50")]
	[Token(Token = "0x6000134")]
	private static void GetCPUSystemMarkerName_Injected(IntPtr _unity_self, int nameID, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x34840B0", Offset = "0x34834B0", Length = "0xC6")]
	[Token(Token = "0x6000118")]
	internal Vector3 GetCurrentBoundsPadding(string name) { }

	[Address(RVA = "0x3484180", Offset = "0x3483580", Length = "0x9F")]
	[FreeFunction(Name = "VisualEffectBindings::GetCurrentBoundsPadding", HasExplicitThis = True)]
	[Token(Token = "0x60000DD")]
	internal Vector3 GetCurrentBoundsPadding(int nameID) { }

	[Address(RVA = "0x3484060", Offset = "0x3483460", Length = "0x50")]
	[Token(Token = "0x6000168")]
	private static void GetCurrentBoundsPadding_Injected(IntPtr _unity_self, int nameID, out Vector3 ret) { }

	[Address(RVA = "0x34842F0", Offset = "0x34836F0", Length = "0x90")]
	[Token(Token = "0x6000105")]
	public float GetFloat(string name) { }

	[Address(RVA = "0x3484260", Offset = "0x3483660", Length = "0x83")]
	[FreeFunction(Name = "VisualEffectBindings::GetValueFromScript<float>", HasExplicitThis = True)]
	[Token(Token = "0x60000CC")]
	public float GetFloat(int nameID) { }

	[Address(RVA = "0x3484220", Offset = "0x3483620", Length = "0x40")]
	[Token(Token = "0x6000159")]
	private static float GetFloat_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x34843F0", Offset = "0x34837F0", Length = "0x37")]
	[Token(Token = "0x6000113")]
	internal string GetGPUTaskMarkerName(string systemName, int taskIndex) { }

	[Address(RVA = "0x3484430", Offset = "0x3483830", Length = "0x126")]
	[FreeFunction(Name = "VisualEffectBindings::GetGPUTaskMarkerName", HasExplicitThis = True, ThrowsException = True)]
	[NativeConditional("ENABLE_PROFILER")]
	[Token(Token = "0x60000A5")]
	private string GetGPUTaskMarkerName(int nameID, int taskIndex) { }

	[Address(RVA = "0x3484390", Offset = "0x3483790", Length = "0x60")]
	[Token(Token = "0x6000132")]
	private static void GetGPUTaskMarkerName_Injected(IntPtr _unity_self, int nameID, int taskIndex, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x3484560", Offset = "0x3483960", Length = "0xF0")]
	[Token(Token = "0x6000110")]
	public Gradient GetGradient(string name) { }

	[Address(RVA = "0x3484660", Offset = "0x3483A60", Length = "0xE3")]
	[Token(Token = "0x60000D5")]
	public Gradient GetGradient(int nameID) { }

	[Address(RVA = "0x3484840", Offset = "0x3483C40", Length = "0xB3")]
	[Token(Token = "0x600010D")]
	internal GraphicsBuffer GetGraphicsBuffer(string name) { }

	[Address(RVA = "0x3484790", Offset = "0x3483B90", Length = "0xA6")]
	[FreeFunction(Name = "VisualEffectBindings::GetValueFromScript<GraphicsBuffer*>", HasExplicitThis = True)]
	[Token(Token = "0x60000D4")]
	internal GraphicsBuffer GetGraphicsBuffer(int nameID) { }

	[Address(RVA = "0x3484750", Offset = "0x3483B50", Length = "0x40")]
	[Token(Token = "0x6000161")]
	private static IntPtr GetGraphicsBuffer_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3484940", Offset = "0x3483D40", Length = "0x90")]
	[Token(Token = "0x6000103")]
	public int GetInt(string name) { }

	[Address(RVA = "0x34849E0", Offset = "0x3483DE0", Length = "0x83")]
	[FreeFunction(Name = "VisualEffectBindings::GetValueFromScript<int>", HasExplicitThis = True)]
	[Token(Token = "0x60000CA")]
	public int GetInt(int nameID) { }

	[Address(RVA = "0x3484900", Offset = "0x3483D00", Length = "0x40")]
	[Token(Token = "0x6000157")]
	private static int GetInt_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3484AC0", Offset = "0x3483EC0", Length = "0xA9")]
	[FreeFunction(Name = "VisualEffectBindings::GetValueFromScript<Matrix4x4f>", HasExplicitThis = True)]
	[Token(Token = "0x60000D0")]
	public Matrix4x4 GetMatrix4x4(int nameID) { }

	[Address(RVA = "0x3484B70", Offset = "0x3483F70", Length = "0xF5")]
	[Token(Token = "0x6000109")]
	public Matrix4x4 GetMatrix4x4(string name) { }

	[Address(RVA = "0x3484A70", Offset = "0x3483E70", Length = "0x50")]
	[Token(Token = "0x600015D")]
	private static void GetMatrix4x4_Injected(IntPtr _unity_self, int nameID, out Matrix4x4 ret) { }

	[Address(RVA = "0x3484CB0", Offset = "0x34840B0", Length = "0xAA")]
	[Token(Token = "0x600010B")]
	public Mesh GetMesh(string name) { }

	[Address(RVA = "0x3484D60", Offset = "0x3484160", Length = "0x9D")]
	[FreeFunction(Name = "VisualEffectBindings::GetValueFromScript<Mesh*>", HasExplicitThis = True)]
	[Token(Token = "0x60000D2")]
	public Mesh GetMesh(int nameID) { }

	[Address(RVA = "0x3484C70", Offset = "0x3484070", Length = "0x40")]
	[Token(Token = "0x600015F")]
	private static IntPtr GetMesh_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3484E00", Offset = "0x3484200", Length = "0x1FE")]
	[Token(Token = "0x60000E3")]
	public void GetOutputEventNames(List<String> names) { }

	[Address(RVA = "0x3485050", Offset = "0x3484450", Length = "0xDC")]
	[Token(Token = "0x6000112")]
	public VFXParticleSystemInfo GetParticleSystemInfo(string name) { }

	[Address(RVA = "0x3485130", Offset = "0x3484530", Length = "0xA6")]
	[FreeFunction(Name = "VisualEffectBindings::GetParticleSystemInfo", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x60000D9")]
	public VFXParticleSystemInfo GetParticleSystemInfo(int nameID) { }

	[Address(RVA = "0x3485000", Offset = "0x3484400", Length = "0x50")]
	[Token(Token = "0x6000164")]
	private static void GetParticleSystemInfo_Injected(IntPtr _unity_self, int nameID, out VFXParticleSystemInfo ret) { }

	[Address(RVA = "0x34851E0", Offset = "0x34845E0", Length = "0x1FE")]
	[Token(Token = "0x60000E2")]
	public void GetParticleSystemNames(List<String> names) { }

	[Address(RVA = "0x3485420", Offset = "0x3484820", Length = "0xAA")]
	[Token(Token = "0x600010C")]
	public SkinnedMeshRenderer GetSkinnedMeshRenderer(string name) { }

	[Address(RVA = "0x34854D0", Offset = "0x34848D0", Length = "0x9D")]
	[FreeFunction(Name = "VisualEffectBindings::GetValueFromScript<SkinnedMeshRenderer*>", HasExplicitThis = True)]
	[Token(Token = "0x60000D3")]
	public SkinnedMeshRenderer GetSkinnedMeshRenderer(int nameID) { }

	[Address(RVA = "0x34853E0", Offset = "0x34847E0", Length = "0x40")]
	[Token(Token = "0x6000160")]
	private static IntPtr GetSkinnedMeshRenderer_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x34859D0", Offset = "0x3484DD0", Length = "0x93")]
	[FreeFunction(Name = "VisualEffectBindings::GetSpawnSystemInfo", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x60000DA")]
	private void GetSpawnSystemInfo(int nameID, IntPtr spawnerState) { }

	[Address(RVA = "0x34855C0", Offset = "0x34849C0", Length = "0x158")]
	[Token(Token = "0x60000DF")]
	public VFXSpawnerState GetSpawnSystemInfo(int nameID) { }

	[Address(RVA = "0x3485890", Offset = "0x3484C90", Length = "0x13C")]
	[Token(Token = "0x60000DE")]
	public void GetSpawnSystemInfo(int nameID, VFXSpawnerState spawnState) { }

	[Address(RVA = "0x3485720", Offset = "0x3484B20", Length = "0x165")]
	[Token(Token = "0x6000116")]
	public VFXSpawnerState GetSpawnSystemInfo(string name) { }

	[Address(RVA = "0x3485570", Offset = "0x3484970", Length = "0x50")]
	[Token(Token = "0x6000165")]
	private static void GetSpawnSystemInfo_Injected(IntPtr _unity_self, int nameID, IntPtr spawnerState) { }

	[Address(RVA = "0x3485A70", Offset = "0x3484E70", Length = "0x1FE")]
	[Token(Token = "0x60000E4")]
	public void GetSpawnSystemNames(List<String> names) { }

	[Address(RVA = "0x3485C70", Offset = "0x3485070", Length = "0x1FE")]
	[Token(Token = "0x60000E1")]
	public void GetSystemNames(List<String> names) { }

	[Address(RVA = "0x3486020", Offset = "0x3485420", Length = "0x9D")]
	[FreeFunction(Name = "VisualEffectBindings::GetValueFromScript<Texture*>", HasExplicitThis = True)]
	[Token(Token = "0x60000D1")]
	public Texture GetTexture(int nameID) { }

	[Address(RVA = "0x34860C0", Offset = "0x34854C0", Length = "0xAA")]
	[Token(Token = "0x600010A")]
	public Texture GetTexture(string name) { }

	[Address(RVA = "0x3485FE0", Offset = "0x34853E0", Length = "0x40")]
	[Token(Token = "0x600015E")]
	private static IntPtr GetTexture_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3485F50", Offset = "0x3485350", Length = "0x83")]
	[FreeFunction(Name = "VisualEffectBindings::GetTextureDimensionFromScript", HasExplicitThis = True)]
	[Token(Token = "0x60000AC")]
	public TextureDimension GetTextureDimension(int nameID) { }

	[Address(RVA = "0x3485EB0", Offset = "0x34852B0", Length = "0x90")]
	[Token(Token = "0x60000EE")]
	public TextureDimension GetTextureDimension(string name) { }

	[Address(RVA = "0x3485E70", Offset = "0x3485270", Length = "0x40")]
	[Token(Token = "0x6000139")]
	private static TextureDimension GetTextureDimension_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3486240", Offset = "0x3485640", Length = "0x90")]
	[Token(Token = "0x6000104")]
	public uint GetUInt(string name) { }

	[Address(RVA = "0x34861B0", Offset = "0x34855B0", Length = "0x83")]
	[FreeFunction(Name = "VisualEffectBindings::GetValueFromScript<UInt32>", HasExplicitThis = True)]
	[Token(Token = "0x60000CB")]
	public uint GetUInt(int nameID) { }

	[Address(RVA = "0x3486170", Offset = "0x3485570", Length = "0x40")]
	[Token(Token = "0x6000158")]
	private static uint GetUInt_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3486330", Offset = "0x3485730", Length = "0xA1")]
	[Token(Token = "0x6000106")]
	public Vector2 GetVector2(string name) { }

	[Address(RVA = "0x34863E0", Offset = "0x34857E0", Length = "0x94")]
	[FreeFunction(Name = "VisualEffectBindings::GetValueFromScript<Vector2f>", HasExplicitThis = True)]
	[Token(Token = "0x60000CD")]
	public Vector2 GetVector2(int nameID) { }

	[Address(RVA = "0x34862E0", Offset = "0x34856E0", Length = "0x50")]
	[Token(Token = "0x600015A")]
	private static void GetVector2_Injected(IntPtr _unity_self, int nameID, out Vector2 ret) { }

	[Address(RVA = "0x34865A0", Offset = "0x34859A0", Length = "0x9F")]
	[FreeFunction(Name = "VisualEffectBindings::GetValueFromScript<Vector3f>", HasExplicitThis = True)]
	[Token(Token = "0x60000CE")]
	public Vector3 GetVector3(int nameID) { }

	[Address(RVA = "0x34864D0", Offset = "0x34858D0", Length = "0xC6")]
	[Token(Token = "0x6000107")]
	public Vector3 GetVector3(string name) { }

	[Address(RVA = "0x3486480", Offset = "0x3485880", Length = "0x50")]
	[Token(Token = "0x600015B")]
	private static void GetVector3_Injected(IntPtr _unity_self, int nameID, out Vector3 ret) { }

	[Address(RVA = "0x3486690", Offset = "0x3485A90", Length = "0xB8")]
	[Token(Token = "0x6000108")]
	public Vector4 GetVector4(string name) { }

	[Address(RVA = "0x3486750", Offset = "0x3485B50", Length = "0x9D")]
	[FreeFunction(Name = "VisualEffectBindings::GetValueFromScript<Vector4f>", HasExplicitThis = True)]
	[Token(Token = "0x60000CF")]
	public Vector4 GetVector4(int nameID) { }

	[Address(RVA = "0x3486640", Offset = "0x3485A40", Length = "0x50")]
	[Token(Token = "0x600015C")]
	private static void GetVector4_Injected(IntPtr _unity_self, int nameID, out Vector4 ret) { }

	[Address(RVA = "0x34868C0", Offset = "0x3485CC0", Length = "0x90")]
	[Token(Token = "0x60000EF")]
	public bool HasAnimationCurve(string name) { }

	[Address(RVA = "0x3486830", Offset = "0x3485C30", Length = "0x83")]
	[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<AnimationCurve*>", HasExplicitThis = True)]
	[Token(Token = "0x60000B6")]
	public bool HasAnimationCurve(int nameID) { }

	[Address(RVA = "0x34867F0", Offset = "0x3485BF0", Length = "0x40")]
	[Token(Token = "0x6000143")]
	private static bool HasAnimationCurve_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x34869A0", Offset = "0x3485DA0", Length = "0x76")]
	[Token(Token = "0x60000DB")]
	public bool HasAnySystemAwake() { }

	[Address(RVA = "0x3486960", Offset = "0x3485D60", Length = "0x33")]
	[Token(Token = "0x6000166")]
	private static bool HasAnySystemAwake_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3486A60", Offset = "0x3485E60", Length = "0x83")]
	[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<bool>", HasExplicitThis = True)]
	[Token(Token = "0x60000AD")]
	public bool HasBool(int nameID) { }

	[Address(RVA = "0x3486AF0", Offset = "0x3485EF0", Length = "0x90")]
	[Token(Token = "0x60000F4")]
	public bool HasBool(string name) { }

	[Address(RVA = "0x3486A20", Offset = "0x3485E20", Length = "0x40")]
	[Token(Token = "0x600013A")]
	private static bool HasBool_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3486BD0", Offset = "0x3485FD0", Length = "0x90")]
	[Token(Token = "0x60000E8")]
	public bool HasFloat(string name) { }

	[Address(RVA = "0x3486C70", Offset = "0x3486070", Length = "0x83")]
	[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<float>", HasExplicitThis = True)]
	[Token(Token = "0x60000B0")]
	public bool HasFloat(int nameID) { }

	[Address(RVA = "0x3486B90", Offset = "0x3485F90", Length = "0x40")]
	[Token(Token = "0x600013D")]
	private static bool HasFloat_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3486D40", Offset = "0x3486140", Length = "0x83")]
	[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<Gradient*>", HasExplicitThis = True)]
	[Token(Token = "0x60000B7")]
	public bool HasGradient(int nameID) { }

	[Address(RVA = "0x3486DD0", Offset = "0x34861D0", Length = "0x90")]
	[Token(Token = "0x60000F0")]
	public bool HasGradient(string name) { }

	[Address(RVA = "0x3486D00", Offset = "0x3486100", Length = "0x40")]
	[Token(Token = "0x6000144")]
	private static bool HasGradient_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3486F40", Offset = "0x3486340", Length = "0x90")]
	[Token(Token = "0x60000F3")]
	public bool HasGraphicsBuffer(string name) { }

	[Address(RVA = "0x3486EB0", Offset = "0x34862B0", Length = "0x83")]
	[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<GraphicsBuffer*>", HasExplicitThis = True)]
	[Token(Token = "0x60000BA")]
	public bool HasGraphicsBuffer(int nameID) { }

	[Address(RVA = "0x3486E70", Offset = "0x3486270", Length = "0x40")]
	[Token(Token = "0x6000147")]
	private static bool HasGraphicsBuffer_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3487020", Offset = "0x3486420", Length = "0x83")]
	[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<int>", HasExplicitThis = True)]
	[Token(Token = "0x60000AE")]
	public bool HasInt(int nameID) { }

	[Address(RVA = "0x34870B0", Offset = "0x34864B0", Length = "0x90")]
	[Token(Token = "0x60000E6")]
	public bool HasInt(string name) { }

	[Address(RVA = "0x3486FE0", Offset = "0x34863E0", Length = "0x40")]
	[Token(Token = "0x600013B")]
	private static bool HasInt_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3487190", Offset = "0x3486590", Length = "0x83")]
	[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<Matrix4x4f>", HasExplicitThis = True)]
	[Token(Token = "0x60000B4")]
	public bool HasMatrix4x4(int nameID) { }

	[Address(RVA = "0x3487220", Offset = "0x3486620", Length = "0x90")]
	[Token(Token = "0x60000EC")]
	public bool HasMatrix4x4(string name) { }

	[Address(RVA = "0x3487150", Offset = "0x3486550", Length = "0x40")]
	[Token(Token = "0x6000141")]
	private static bool HasMatrix4x4_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3487300", Offset = "0x3486700", Length = "0x90")]
	[Token(Token = "0x60000F1")]
	public bool HasMesh(string name) { }

	[Address(RVA = "0x34873A0", Offset = "0x34867A0", Length = "0x83")]
	[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<Mesh*>", HasExplicitThis = True)]
	[Token(Token = "0x60000B8")]
	public bool HasMesh(int nameID) { }

	[Address(RVA = "0x34872C0", Offset = "0x34866C0", Length = "0x40")]
	[Token(Token = "0x6000145")]
	private static bool HasMesh_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3487510", Offset = "0x3486910", Length = "0x83")]
	[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<SkinnedMeshRenderer*>", HasExplicitThis = True)]
	[Token(Token = "0x60000B9")]
	public bool HasSkinnedMeshRenderer(int nameID) { }

	[Address(RVA = "0x3487470", Offset = "0x3486870", Length = "0x90")]
	[Token(Token = "0x60000F2")]
	public bool HasSkinnedMeshRenderer(string name) { }

	[Address(RVA = "0x3487430", Offset = "0x3486830", Length = "0x40")]
	[Token(Token = "0x6000146")]
	private static bool HasSkinnedMeshRenderer_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x34875A0", Offset = "0x34869A0", Length = "0x18B")]
	[Token(Token = "0x6000111")]
	public bool HasSystem(string name) { }

	[Address(RVA = "0x3487730", Offset = "0x3486B30", Length = "0x17E")]
	[Token(Token = "0x60000E0")]
	public bool HasSystem(int nameID) { }

	[Address(RVA = "0x34878F0", Offset = "0x3486CF0", Length = "0x83")]
	[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<Texture*>", HasExplicitThis = True)]
	[Token(Token = "0x60000B5")]
	public bool HasTexture(int nameID) { }

	[Address(RVA = "0x3487980", Offset = "0x3486D80", Length = "0x90")]
	[Token(Token = "0x60000ED")]
	public bool HasTexture(string name) { }

	[Address(RVA = "0x34878B0", Offset = "0x3486CB0", Length = "0x40")]
	[Token(Token = "0x6000142")]
	private static bool HasTexture_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3487A60", Offset = "0x3486E60", Length = "0x83")]
	[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<UInt32>", HasExplicitThis = True)]
	[Token(Token = "0x60000AF")]
	public bool HasUInt(int nameID) { }

	[Address(RVA = "0x3487AF0", Offset = "0x3486EF0", Length = "0x90")]
	[Token(Token = "0x60000E7")]
	public bool HasUInt(string name) { }

	[Address(RVA = "0x3487A20", Offset = "0x3486E20", Length = "0x40")]
	[Token(Token = "0x600013C")]
	private static bool HasUInt_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3487C60", Offset = "0x3487060", Length = "0x90")]
	[Token(Token = "0x60000E9")]
	public bool HasVector2(string name) { }

	[Address(RVA = "0x3487BD0", Offset = "0x3486FD0", Length = "0x83")]
	[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<Vector2f>", HasExplicitThis = True)]
	[Token(Token = "0x60000B1")]
	public bool HasVector2(int nameID) { }

	[Address(RVA = "0x3487B90", Offset = "0x3486F90", Length = "0x40")]
	[Token(Token = "0x600013E")]
	private static bool HasVector2_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3487DE0", Offset = "0x34871E0", Length = "0x83")]
	[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<Vector3f>", HasExplicitThis = True)]
	[Token(Token = "0x60000B2")]
	public bool HasVector3(int nameID) { }

	[Address(RVA = "0x3487D40", Offset = "0x3487140", Length = "0x90")]
	[Token(Token = "0x60000EA")]
	public bool HasVector3(string name) { }

	[Address(RVA = "0x3487D00", Offset = "0x3487100", Length = "0x40")]
	[Token(Token = "0x600013F")]
	private static bool HasVector3_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3487F40", Offset = "0x3487340", Length = "0x90")]
	[Token(Token = "0x60000EB")]
	public bool HasVector4(string name) { }

	[Address(RVA = "0x3487EB0", Offset = "0x34872B0", Length = "0x83")]
	[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<Vector4f>", HasExplicitThis = True)]
	[Token(Token = "0x60000B3")]
	public bool HasVector4(int nameID) { }

	[Address(RVA = "0x3487E70", Offset = "0x3487270", Length = "0x40")]
	[Token(Token = "0x6000140")]
	private static bool HasVector4_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3488030", Offset = "0x3487430", Length = "0xAE")]
	[FreeFunction(Name = "VisualEffectBindings::Internal_GetAnimationCurveFromScript", HasExplicitThis = True)]
	[Token(Token = "0x60000D8")]
	private void Internal_GetAnimationCurve(int nameID, AnimationCurve curve) { }

	[Address(RVA = "0x3487FE0", Offset = "0x34873E0", Length = "0x50")]
	[Token(Token = "0x6000163")]
	private static void Internal_GetAnimationCurve_Injected(IntPtr _unity_self, int nameID, IntPtr curve) { }

	[Address(RVA = "0x3488130", Offset = "0x3487530", Length = "0xAE")]
	[FreeFunction(Name = "VisualEffectBindings::Internal_GetGradientFromScript", HasExplicitThis = True)]
	[Token(Token = "0x60000D6")]
	private void Internal_GetGradient(int nameID, Gradient gradient) { }

	[Address(RVA = "0x34880E0", Offset = "0x34874E0", Length = "0x50")]
	[Token(Token = "0x6000162")]
	private static void Internal_GetGradient_Injected(IntPtr _unity_self, int nameID, IntPtr gradient) { }

	[Address(RVA = "0x34881E0", Offset = "0x34875E0", Length = "0x4A")]
	[RequiredByNativeCode]
	[Token(Token = "0x600011C")]
	private static VFXEventAttribute InvokeGetCachedEventAttributeForOutputEvent_Internal(VisualEffect source) { }

	[Address(RVA = "0x3488230", Offset = "0x3487630", Length = "0x5F")]
	[RequiredByNativeCode]
	[Token(Token = "0x600011D")]
	private static void InvokeOutputEventReceived_Internal(VisualEffect source, int eventNameId) { }

	[Address(RVA = "0x34882D0", Offset = "0x34876D0", Length = "0x76")]
	[FreeFunction(Name = "VisualEffectBindings::IsRegisteredForProfiling", HasExplicitThis = True, ThrowsException = False)]
	[NativeConditional("ENABLE_PROFILER")]
	[Token(Token = "0x60000AA")]
	internal bool IsRegisteredForProfiling() { }

	[Address(RVA = "0x3488290", Offset = "0x3487690", Length = "0x33")]
	[Token(Token = "0x6000137")]
	private static bool IsRegisteredForProfiling_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x34883C0", Offset = "0x34877C0", Length = "0xC8")]
	[Token(Token = "0x600009E")]
	public void Play() { }

	[Address(RVA = "0x3488350", Offset = "0x3487750", Length = "0x6C")]
	[Token(Token = "0x600009D")]
	public void Play(VFXEventAttribute eventAttribute) { }

	[Address(RVA = "0x34884D0", Offset = "0x34878D0", Length = "0x76")]
	[Token(Token = "0x60000A4")]
	internal void RecreateData() { }

	[Address(RVA = "0x3488490", Offset = "0x3487890", Length = "0x33")]
	[Token(Token = "0x6000131")]
	private static void RecreateData_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3488590", Offset = "0x3487990", Length = "0x76")]
	[FreeFunction(Name = "VisualEffectBindings::RegisterForProfiling", HasExplicitThis = True, ThrowsException = False)]
	[NativeConditional("ENABLE_PROFILER")]
	[Token(Token = "0x60000A8")]
	internal void RegisterForProfiling() { }

	[Address(RVA = "0x3488550", Offset = "0x3487950", Length = "0x33")]
	[Token(Token = "0x6000135")]
	private static void RegisterForProfiling_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x34886E0", Offset = "0x3487AE0", Length = "0x86")]
	[Token(Token = "0x60000A2")]
	internal void Reinit(bool sendInitialEventAndPrewarm = true) { }

	[Address(RVA = "0x3488660", Offset = "0x3487A60", Length = "0x78")]
	[Token(Token = "0x60000A1")]
	public void Reinit() { }

	[Address(RVA = "0x3488610", Offset = "0x3487A10", Length = "0x42")]
	[Token(Token = "0x600012F")]
	private static void Reinit_Injected(IntPtr _unity_self, bool sendInitialEventAndPrewarm) { }

	[Address(RVA = "0x3488850", Offset = "0x3487C50", Length = "0x83")]
	[FreeFunction(Name = "VisualEffectBindings::ResetOverrideFromScript", HasExplicitThis = True)]
	[Token(Token = "0x60000AB")]
	public void ResetOverride(int nameID) { }

	[Address(RVA = "0x34887B0", Offset = "0x3487BB0", Length = "0x90")]
	[Token(Token = "0x60000E5")]
	public void ResetOverride(string name) { }

	[Address(RVA = "0x3488770", Offset = "0x3487B70", Length = "0x40")]
	[Token(Token = "0x6000138")]
	private static void ResetOverride_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3488C40", Offset = "0x3488040", Length = "0xAF")]
	[Token(Token = "0x600009C")]
	public void SendEvent(string eventName) { }

	[Address(RVA = "0x3488CF0", Offset = "0x34880F0", Length = "0x37")]
	[Token(Token = "0x600009A")]
	public void SendEvent(string eventName, VFXEventAttribute eventAttribute) { }

	[Address(RVA = "0x34889E0", Offset = "0x3487DE0", Length = "0x86")]
	[Token(Token = "0x600009B")]
	public void SendEvent(int eventNameID) { }

	[Address(RVA = "0x3488A70", Offset = "0x3487E70", Length = "0x1C2")]
	[Token(Token = "0x6000099")]
	public void SendEvent(int eventNameID, VFXEventAttribute eventAttribute) { }

	[Address(RVA = "0x3488930", Offset = "0x3487D30", Length = "0xAE")]
	[FreeFunction(Name = "VisualEffectBindings::SendEventFromScript", HasExplicitThis = True)]
	[Token(Token = "0x6000098")]
	private void SendEventFromScript(int eventNameID, VFXEventAttribute eventAttribute) { }

	[Address(RVA = "0x34888E0", Offset = "0x3487CE0", Length = "0x50")]
	[Token(Token = "0x600012E")]
	private static void SendEventFromScript_Injected(IntPtr _unity_self, int eventNameID, IntPtr eventAttribute) { }

	[Address(RVA = "0x348B230", Offset = "0x348A630", Length = "0x83")]
	[FreeFunction(Name = "VisualEffectBindings::SetInitialEventID", HasExplicitThis = True)]
	[Token(Token = "0x6000090")]
	public void set_initialEventID(int value) { }

	[Address(RVA = "0x348B1F0", Offset = "0x348A5F0", Length = "0x40")]
	[Token(Token = "0x6000128")]
	private static void set_initialEventID_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x348B310", Offset = "0x348A710", Length = "0x1C7")]
	[FreeFunction(Name = "VisualEffectBindings::SetInitialEventName", HasExplicitThis = True)]
	[Token(Token = "0x6000092")]
	public void set_initialEventName(string value) { }

	[Address(RVA = "0x348B2C0", Offset = "0x348A6C0", Length = "0x42")]
	[Token(Token = "0x600012A")]
	private static void set_initialEventName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	[Address(RVA = "0x348B530", Offset = "0x348A930", Length = "0x86")]
	[Token(Token = "0x6000088")]
	public void set_pause(bool value) { }

	[Address(RVA = "0x348B4E0", Offset = "0x348A8E0", Length = "0x42")]
	[Token(Token = "0x6000120")]
	private static void set_pause_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x348B610", Offset = "0x348AA10", Length = "0x86")]
	[Token(Token = "0x600008A")]
	public void set_playRate(float value) { }

	[Address(RVA = "0x348B5C0", Offset = "0x348A9C0", Length = "0x43")]
	[Token(Token = "0x6000122")]
	private static void set_playRate_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x348B6F0", Offset = "0x348AAF0", Length = "0x86")]
	[Token(Token = "0x600008E")]
	public void set_resetSeedOnPlay(bool value) { }

	[Address(RVA = "0x348B6A0", Offset = "0x348AAA0", Length = "0x42")]
	[Token(Token = "0x6000126")]
	private static void set_resetSeedOnPlay_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x348B7C0", Offset = "0x348ABC0", Length = "0x83")]
	[Token(Token = "0x600008C")]
	public void set_startSeed(uint value) { }

	[Address(RVA = "0x348B780", Offset = "0x348AB80", Length = "0x40")]
	[Token(Token = "0x6000124")]
	private static void set_startSeed_Injected(IntPtr _unity_self, uint value) { }

	[Address(RVA = "0x348B8A0", Offset = "0x348ACA0", Length = "0xBA")]
	[Token(Token = "0x6000095")]
	public void set_visualEffectAsset(VisualEffectAsset value) { }

	[Address(RVA = "0x348B850", Offset = "0x348AC50", Length = "0x42")]
	[Token(Token = "0x600012D")]
	private static void set_visualEffectAsset_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x3488D80", Offset = "0x3488180", Length = "0xE2")]
	[Token(Token = "0x60000FD")]
	public void SetAnimationCurve(string name, AnimationCurve c) { }

	[Address(RVA = "0x3488E70", Offset = "0x3488270", Length = "0xD5")]
	[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<AnimationCurve*>", HasExplicitThis = True)]
	[Token(Token = "0x60000C4")]
	public void SetAnimationCurve(int nameID, AnimationCurve c) { }

	[Address(RVA = "0x3488D30", Offset = "0x3488130", Length = "0x50")]
	[Token(Token = "0x6000151")]
	private static void SetAnimationCurve_Injected(IntPtr _unity_self, int nameID, IntPtr c) { }

	[Address(RVA = "0x3489060", Offset = "0x3488460", Length = "0x95")]
	[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<bool>", HasExplicitThis = True)]
	[Token(Token = "0x60000BB")]
	public void SetBool(int nameID, bool b) { }

	[Address(RVA = "0x3488FB0", Offset = "0x34883B0", Length = "0xA2")]
	[Token(Token = "0x6000102")]
	public void SetBool(string name, bool b) { }

	[Address(RVA = "0x3488F50", Offset = "0x3488350", Length = "0x52")]
	[Token(Token = "0x6000148")]
	private static void SetBool_Injected(IntPtr _unity_self, int nameID, bool b) { }

	[Address(RVA = "0x3489150", Offset = "0x3488550", Length = "0x93")]
	[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<float>", HasExplicitThis = True)]
	[Token(Token = "0x60000BE")]
	public void SetFloat(int nameID, float f) { }

	[Address(RVA = "0x34891F0", Offset = "0x34885F0", Length = "0xA0")]
	[Token(Token = "0x60000F7")]
	public void SetFloat(string name, float f) { }

	[Address(RVA = "0x3489100", Offset = "0x3488500", Length = "0x50")]
	[Token(Token = "0x600014B")]
	private static void SetFloat_Injected(IntPtr _unity_self, int nameID, float f) { }

	[Address(RVA = "0x34893E0", Offset = "0x34887E0", Length = "0xD5")]
	[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<Gradient*>", HasExplicitThis = True)]
	[Token(Token = "0x60000C5")]
	public void SetGradient(int nameID, Gradient g) { }

	[Address(RVA = "0x34892F0", Offset = "0x34886F0", Length = "0xE2")]
	[Token(Token = "0x60000FE")]
	public void SetGradient(string name, Gradient g) { }

	[Address(RVA = "0x34892A0", Offset = "0x34886A0", Length = "0x50")]
	[Token(Token = "0x6000152")]
	private static void SetGradient_Injected(IntPtr _unity_self, int nameID, IntPtr g) { }

	[Address(RVA = "0x34895D0", Offset = "0x34889D0", Length = "0xAE")]
	[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<GraphicsBuffer*>", HasExplicitThis = True)]
	[Token(Token = "0x60000C8")]
	public void SetGraphicsBuffer(int nameID, GraphicsBuffer g) { }

	[Address(RVA = "0x3489510", Offset = "0x3488910", Length = "0xBB")]
	[Token(Token = "0x6000101")]
	public void SetGraphicsBuffer(string name, GraphicsBuffer g) { }

	[Address(RVA = "0x34894C0", Offset = "0x34888C0", Length = "0x50")]
	[Token(Token = "0x6000155")]
	private static void SetGraphicsBuffer_Injected(IntPtr _unity_self, int nameID, IntPtr g) { }

	[Address(RVA = "0x3489770", Offset = "0x3488B70", Length = "0xA0")]
	[Token(Token = "0x60000F5")]
	public void SetInt(string name, int i) { }

	[Address(RVA = "0x34896D0", Offset = "0x3488AD0", Length = "0x93")]
	[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<int>", HasExplicitThis = True)]
	[Token(Token = "0x60000BC")]
	public void SetInt(int nameID, int i) { }

	[Address(RVA = "0x3489680", Offset = "0x3488A80", Length = "0x50")]
	[Token(Token = "0x6000149")]
	private static void SetInt_Injected(IntPtr _unity_self, int nameID, int i) { }

	[Address(RVA = "0x3489870", Offset = "0x3488C70", Length = "0x93")]
	[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<Matrix4x4f>", HasExplicitThis = True)]
	[Token(Token = "0x60000C2")]
	public void SetMatrix4x4(int nameID, Matrix4x4 v) { }

	[Address(RVA = "0x3489910", Offset = "0x3488D10", Length = "0xBB")]
	[Token(Token = "0x60000FB")]
	public void SetMatrix4x4(string name, Matrix4x4 v) { }

	[Address(RVA = "0x3489820", Offset = "0x3488C20", Length = "0x50")]
	[Token(Token = "0x600014F")]
	private static void SetMatrix4x4_Injected(IntPtr _unity_self, int nameID, in Matrix4x4 v) { }

	[Address(RVA = "0x3489B10", Offset = "0x3488F10", Length = "0xEE")]
	[Token(Token = "0x60000FF")]
	public void SetMesh(string name, Mesh m) { }

	[Address(RVA = "0x3489A20", Offset = "0x3488E20", Length = "0xE1")]
	[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<Mesh*>", HasExplicitThis = True)]
	[Token(Token = "0x60000C6")]
	public void SetMesh(int nameID, Mesh m) { }

	[Address(RVA = "0x34899D0", Offset = "0x3488DD0", Length = "0x50")]
	[Token(Token = "0x6000153")]
	private static void SetMesh_Injected(IntPtr _unity_self, int nameID, IntPtr m) { }

	[Address(RVA = "0x3489C50", Offset = "0x3489050", Length = "0xDD")]
	[Token(Token = "0x6000100")]
	public void SetSkinnedMeshRenderer(string name, SkinnedMeshRenderer m) { }

	[Address(RVA = "0x3489D30", Offset = "0x3489130", Length = "0xD0")]
	[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<SkinnedMeshRenderer*>", HasExplicitThis = True)]
	[Token(Token = "0x60000C7")]
	public void SetSkinnedMeshRenderer(int nameID, SkinnedMeshRenderer m) { }

	[Address(RVA = "0x3489C00", Offset = "0x3489000", Length = "0x50")]
	[Token(Token = "0x6000154")]
	private static void SetSkinnedMeshRenderer_Injected(IntPtr _unity_self, int nameID, IntPtr m) { }

	[Address(RVA = "0x3489E60", Offset = "0x3489260", Length = "0xEE")]
	[Token(Token = "0x60000FC")]
	public void SetTexture(string name, Texture t) { }

	[Address(RVA = "0x3489F50", Offset = "0x3489350", Length = "0xE1")]
	[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<Texture*>", HasExplicitThis = True)]
	[Token(Token = "0x60000C3")]
	public void SetTexture(int nameID, Texture t) { }

	[Address(RVA = "0x3489E10", Offset = "0x3489210", Length = "0x50")]
	[Token(Token = "0x6000150")]
	private static void SetTexture_Injected(IntPtr _unity_self, int nameID, IntPtr t) { }

	[Address(RVA = "0x348A130", Offset = "0x3489530", Length = "0xA0")]
	[Token(Token = "0x60000F6")]
	public void SetUInt(string name, uint i) { }

	[Address(RVA = "0x348A090", Offset = "0x3489490", Length = "0x93")]
	[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<UInt32>", HasExplicitThis = True)]
	[Token(Token = "0x60000BD")]
	public void SetUInt(int nameID, uint i) { }

	[Address(RVA = "0x348A040", Offset = "0x3489440", Length = "0x50")]
	[Token(Token = "0x600014A")]
	private static void SetUInt_Injected(IntPtr _unity_self, int nameID, uint i) { }

	[Address(RVA = "0x348A230", Offset = "0x3489630", Length = "0x8D")]
	[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<Vector2f>", HasExplicitThis = True)]
	[Token(Token = "0x60000BF")]
	public void SetVector2(int nameID, Vector2 v) { }

	[Address(RVA = "0x348A2C0", Offset = "0x34896C0", Length = "0xAA")]
	[Token(Token = "0x60000F8")]
	public void SetVector2(string name, Vector2 v) { }

	[Address(RVA = "0x348A1E0", Offset = "0x34895E0", Length = "0x50")]
	[Token(Token = "0x600014C")]
	private static void SetVector2_Injected(IntPtr _unity_self, int nameID, in Vector2 v) { }

	[Address(RVA = "0x348A460", Offset = "0x3489860", Length = "0xA9")]
	[Token(Token = "0x60000F9")]
	public void SetVector3(string name, Vector3 v) { }

	[Address(RVA = "0x348A3C0", Offset = "0x34897C0", Length = "0x93")]
	[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<Vector3f>", HasExplicitThis = True)]
	[Token(Token = "0x60000C0")]
	public void SetVector3(int nameID, Vector3 v) { }

	[Address(RVA = "0x348A370", Offset = "0x3489770", Length = "0x50")]
	[Token(Token = "0x600014D")]
	private static void SetVector3_Injected(IntPtr _unity_self, int nameID, in Vector3 v) { }

	[Address(RVA = "0x348A560", Offset = "0x3489960", Length = "0xA0")]
	[Token(Token = "0x60000FA")]
	public void SetVector4(string name, Vector4 v) { }

	[Address(RVA = "0x348A610", Offset = "0x3489A10", Length = "0x93")]
	[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<Vector4f>", HasExplicitThis = True)]
	[Token(Token = "0x60000C1")]
	public void SetVector4(int nameID, Vector4 v) { }

	[Address(RVA = "0x348A510", Offset = "0x3489910", Length = "0x50")]
	[Token(Token = "0x600014E")]
	private static void SetVector4_Injected(IntPtr _unity_self, int nameID, in Vector4 v) { }

	[Address(RVA = "0x348A710", Offset = "0x3489B10", Length = "0x95")]
	[Token(Token = "0x600011B")]
	public void Simulate(float stepDeltaTime, uint stepCount = 1) { }

	[Address(RVA = "0x348A6B0", Offset = "0x3489AB0", Length = "0x52")]
	[Token(Token = "0x600016B")]
	private static void Simulate_Injected(IntPtr _unity_self, float stepDeltaTime, uint stepCount) { }

	[Address(RVA = "0x348A7B0", Offset = "0x3489BB0", Length = "0xC9")]
	[Token(Token = "0x60000A0")]
	public void Stop() { }

	[Address(RVA = "0x348A880", Offset = "0x3489C80", Length = "0x6D")]
	[Token(Token = "0x600009F")]
	public void Stop(VFXEventAttribute eventAttribute) { }

	[Address(RVA = "0x348A930", Offset = "0x3489D30", Length = "0x76")]
	[FreeFunction(Name = "VisualEffectBindings::UnregisterForProfiling", HasExplicitThis = True, ThrowsException = False)]
	[NativeConditional("ENABLE_PROFILER")]
	[Token(Token = "0x60000A9")]
	internal void UnregisterForProfiling() { }

	[Address(RVA = "0x348A8F0", Offset = "0x3489CF0", Length = "0x33")]
	[Token(Token = "0x6000136")]
	private static void UnregisterForProfiling_Injected(IntPtr _unity_self) { }

}


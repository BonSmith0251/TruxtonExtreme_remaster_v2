namespace UnityEngine.Playables;

[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[NativeHeader("Modules/Director/PlayableDirector.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000004")]
public class PlayableDirector : Behaviour, IExposedPropertyTable
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000002")]
	private Action<PlayableDirector> played; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000003")]
	private Action<PlayableDirector> paused; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000004")]
	private Action<PlayableDirector> stopped; //Field offset: 0x28

	[Token(Token = "0x14000002")]
	public event Action<PlayableDirector> paused
	{
		[Address(RVA = "0x30D32F0", Offset = "0x30D26F0", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6000035")]
		 add { } //Length: 172
		[Address(RVA = "0x30D39C0", Offset = "0x30D2DC0", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6000036")]
		 remove { } //Length: 172
	}

	[Token(Token = "0x14000001")]
	public event Action<PlayableDirector> played
	{
		[Address(RVA = "0x30D33A0", Offset = "0x30D27A0", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6000033")]
		 add { } //Length: 172
		[Address(RVA = "0x30D3A70", Offset = "0x30D2E70", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6000034")]
		 remove { } //Length: 172
	}

	[Token(Token = "0x14000003")]
	public event Action<PlayableDirector> stopped
	{
		[Address(RVA = "0x30D3450", Offset = "0x30D2850", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6000037")]
		 add { } //Length: 172
		[Address(RVA = "0x30D3B20", Offset = "0x30D2F20", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6000038")]
		 remove { } //Length: 172
	}

	[Token(Token = "0x17000009")]
	public double duration
	{
		[Address(RVA = "0x30D3540", Offset = "0x30D2940", Length = "0x76")]
		[Token(Token = "0x6000019")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000002")]
	public DirectorWrapMode extrapolationMode
	{
		[Address(RVA = "0x30D20F0", Offset = "0x30D14F0", Length = "0x76")]
		[Token(Token = "0x6000008")]
		 get { } //Length: 118
		[Address(RVA = "0x30D31A0", Offset = "0x30D25A0", Length = "0x83")]
		[Token(Token = "0x6000007")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000008")]
	public double initialTime
	{
		[Address(RVA = "0x30D3600", Offset = "0x30D2A00", Length = "0x76")]
		[Token(Token = "0x6000018")]
		 get { } //Length: 118
		[Address(RVA = "0x30D3C20", Offset = "0x30D3020", Length = "0x86")]
		[Token(Token = "0x6000017")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000003")]
	public PlayableAsset playableAsset
	{
		[Address(RVA = "0x30D3680", Offset = "0x30D2A80", Length = "0x102")]
		[Token(Token = "0x6000009")]
		 get { } //Length: 258
		[Address(RVA = "0x30D2F70", Offset = "0x30D2370", Length = "0xBA")]
		[Token(Token = "0x600000A")]
		 set { } //Length: 186
	}

	[Token(Token = "0x17000004")]
	public PlayableGraph playableGraph
	{
		[Address(RVA = "0x30D3790", Offset = "0x30D2B90", Length = "0xA0")]
		[Token(Token = "0x600000B")]
		 get { } //Length: 160
	}

	[Token(Token = "0x17000005")]
	public bool playOnAwake
	{
		[Address(RVA = "0x30D1E60", Offset = "0x30D1260", Length = "0x76")]
		[Token(Token = "0x600000C")]
		 get { } //Length: 118
		[Address(RVA = "0x30D2E90", Offset = "0x30D2290", Length = "0x86")]
		[Token(Token = "0x600000D")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000001")]
	public PlayState state
	{
		[Address(RVA = "0x30D1F20", Offset = "0x30D1320", Length = "0x76")]
		[Token(Token = "0x6000006")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000007")]
	public double time
	{
		[Address(RVA = "0x30D3940", Offset = "0x30D2D40", Length = "0x76")]
		[Token(Token = "0x6000016")]
		 get { } //Length: 118
		[Address(RVA = "0x30D3DD0", Offset = "0x30D31D0", Length = "0x86")]
		[Token(Token = "0x6000015")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000006")]
	public DirectorUpdateMode timeUpdateMode
	{
		[Address(RVA = "0x30D3880", Offset = "0x30D2C80", Length = "0x76")]
		[Token(Token = "0x6000014")]
		 get { } //Length: 118
		[Address(RVA = "0x30D3CF0", Offset = "0x30D30F0", Length = "0x83")]
		[Token(Token = "0x6000013")]
		 set { } //Length: 131
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x600003D")]
	public PlayableDirector() { }

	[Address(RVA = "0x30D32F0", Offset = "0x30D26F0", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6000035")]
	public void add_paused(Action<PlayableDirector> value) { }

	[Address(RVA = "0x30D33A0", Offset = "0x30D27A0", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6000033")]
	public void add_played(Action<PlayableDirector> value) { }

	[Address(RVA = "0x30D3450", Offset = "0x30D2850", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6000037")]
	public void add_stopped(Action<PlayableDirector> value) { }

	[Address(RVA = "0x30D1900", Offset = "0x30D0D00", Length = "0xBA")]
	[NativeMethod("ClearBindingFor")]
	[Token(Token = "0x6000025")]
	public void ClearGenericBinding(object key) { }

	[Address(RVA = "0x30D18B0", Offset = "0x30D0CB0", Length = "0x42")]
	[Token(Token = "0x6000050")]
	private static void ClearGenericBinding_Injected(IntPtr _unity_self, IntPtr key) { }

	[Address(RVA = "0x30D1A10", Offset = "0x30D0E10", Length = "0x7E")]
	[Token(Token = "0x6000021")]
	public override void ClearReferenceValue(PropertyName id) { }

	[Address(RVA = "0x30D19C0", Offset = "0x30D0DC0", Length = "0x42")]
	[Token(Token = "0x600004C")]
	private static void ClearReferenceValue_Injected(IntPtr _unity_self, in PropertyName id) { }

	[Address(RVA = "0x30D1A90", Offset = "0x30D0E90", Length = "0x76")]
	[Token(Token = "0x600000E")]
	public void DeferredEvaluate() { }

	[Address(RVA = "0x30D1B90", Offset = "0x30D0F90", Length = "0x76")]
	[NativeThrows]
	[Token(Token = "0x600001A")]
	public void Evaluate() { }

	[Address(RVA = "0x30D1B50", Offset = "0x30D0F50", Length = "0x33")]
	[Token(Token = "0x6000045")]
	private static void Evaluate_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30D1A90", Offset = "0x30D0E90", Length = "0x76")]
	[NativeThrows]
	[Token(Token = "0x600002C")]
	private void EvaluateNextFrame() { }

	[Address(RVA = "0x30D1B10", Offset = "0x30D0F10", Length = "0x33")]
	[Token(Token = "0x6000057")]
	private static void EvaluateNextFrame_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30D3540", Offset = "0x30D2940", Length = "0x76")]
	[Token(Token = "0x6000019")]
	public double get_duration() { }

	[Address(RVA = "0x30D3500", Offset = "0x30D2900", Length = "0x33")]
	[Token(Token = "0x6000044")]
	private static double get_duration_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30D20F0", Offset = "0x30D14F0", Length = "0x76")]
	[Token(Token = "0x6000008")]
	public DirectorWrapMode get_extrapolationMode() { }

	[Address(RVA = "0x30D3600", Offset = "0x30D2A00", Length = "0x76")]
	[Token(Token = "0x6000018")]
	public double get_initialTime() { }

	[Address(RVA = "0x30D35C0", Offset = "0x30D29C0", Length = "0x33")]
	[Token(Token = "0x6000043")]
	private static double get_initialTime_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30D3680", Offset = "0x30D2A80", Length = "0x102")]
	[Token(Token = "0x6000009")]
	public PlayableAsset get_playableAsset() { }

	[Address(RVA = "0x30D3790", Offset = "0x30D2B90", Length = "0xA0")]
	[Token(Token = "0x600000B")]
	public PlayableGraph get_playableGraph() { }

	[Address(RVA = "0x30D1E60", Offset = "0x30D1260", Length = "0x76")]
	[Token(Token = "0x600000C")]
	public bool get_playOnAwake() { }

	[Address(RVA = "0x30D1F20", Offset = "0x30D1320", Length = "0x76")]
	[Token(Token = "0x6000006")]
	public PlayState get_state() { }

	[Address(RVA = "0x30D3940", Offset = "0x30D2D40", Length = "0x76")]
	[Token(Token = "0x6000016")]
	public double get_time() { }

	[Address(RVA = "0x30D3900", Offset = "0x30D2D00", Length = "0x33")]
	[Token(Token = "0x6000041")]
	private static double get_time_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30D3880", Offset = "0x30D2C80", Length = "0x76")]
	[Token(Token = "0x6000014")]
	public DirectorUpdateMode get_timeUpdateMode() { }

	[Address(RVA = "0x30D3840", Offset = "0x30D2C40", Length = "0x33")]
	[Token(Token = "0x600003F")]
	private static DirectorUpdateMode get_timeUpdateMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30D1C60", Offset = "0x30D1060", Length = "0xD8")]
	[NativeMethod("GetBindingFor")]
	[Token(Token = "0x6000024")]
	public object GetGenericBinding(object key) { }

	[Address(RVA = "0x30D1C10", Offset = "0x30D1010", Length = "0x42")]
	[Token(Token = "0x600004F")]
	private static IntPtr GetGenericBinding_Injected(IntPtr _unity_self, IntPtr key) { }

	[Address(RVA = "0x30D1D90", Offset = "0x30D1190", Length = "0x8E")]
	[Token(Token = "0x600002D")]
	private PlayableGraph GetGraphHandle() { }

	[Address(RVA = "0x30D1D40", Offset = "0x30D1140", Length = "0x42")]
	[Token(Token = "0x6000058")]
	private static void GetGraphHandle_Injected(IntPtr _unity_self, out PlayableGraph ret) { }

	[Address(RVA = "0x30D1E60", Offset = "0x30D1260", Length = "0x76")]
	[Token(Token = "0x600002F")]
	private bool GetPlayOnAwake() { }

	[Address(RVA = "0x30D1E20", Offset = "0x30D1220", Length = "0x33")]
	[Token(Token = "0x600005A")]
	private static bool GetPlayOnAwake_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30D1F20", Offset = "0x30D1320", Length = "0x76")]
	[Token(Token = "0x6000029")]
	private PlayState GetPlayState() { }

	[Address(RVA = "0x30D1EE0", Offset = "0x30D12E0", Length = "0x33")]
	[Token(Token = "0x6000054")]
	private static PlayState GetPlayState_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30D2000", Offset = "0x30D1400", Length = "0xA9")]
	[Token(Token = "0x6000023")]
	public override object GetReferenceValue(PropertyName id, out bool idValid) { }

	[Address(RVA = "0x30D1FA0", Offset = "0x30D13A0", Length = "0x52")]
	[Token(Token = "0x600004E")]
	private static IntPtr GetReferenceValue_Injected(IntPtr _unity_self, in PropertyName id, out bool idValid) { }

	[Address(RVA = "0x30D20F0", Offset = "0x30D14F0", Length = "0x76")]
	[Token(Token = "0x600002B")]
	private DirectorWrapMode GetWrapMode() { }

	[Address(RVA = "0x30D20B0", Offset = "0x30D14B0", Length = "0x33")]
	[Token(Token = "0x6000056")]
	private static DirectorWrapMode GetWrapMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30D21C0", Offset = "0x30D15C0", Length = "0xBA")]
	[NativeMethod("HasBinding")]
	[Token(Token = "0x6000028")]
	internal bool HasGenericBinding(object key) { }

	[Address(RVA = "0x30D2170", Offset = "0x30D1570", Length = "0x42")]
	[Token(Token = "0x6000053")]
	private static bool HasGenericBinding_Injected(IntPtr _unity_self, IntPtr key) { }

	[Address(RVA = "0x30D22C0", Offset = "0x30D16C0", Length = "0x90")]
	[Token(Token = "0x6000032")]
	private ScriptableObject Internal_GetPlayableAsset() { }

	[Address(RVA = "0x30D2280", Offset = "0x30D1680", Length = "0x33")]
	[Token(Token = "0x600005D")]
	private static IntPtr Internal_GetPlayableAsset_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30D23C0", Offset = "0x30D17C0", Length = "0xEF")]
	[NativeThrows]
	[Token(Token = "0x6000030")]
	private void Internal_SetGenericBinding(object key, object value) { }

	[Address(RVA = "0x30D2360", Offset = "0x30D1760", Length = "0x52")]
	[Token(Token = "0x600005B")]
	private static void Internal_SetGenericBinding_Injected(IntPtr _unity_self, IntPtr key, IntPtr value) { }

	[Address(RVA = "0x30D24F0", Offset = "0x30D18F0", Length = "0x76")]
	[Token(Token = "0x600001E")]
	public void Pause() { }

	[Address(RVA = "0x30D24B0", Offset = "0x30D18B0", Length = "0x33")]
	[Token(Token = "0x6000049")]
	private static void Pause_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30D2880", Offset = "0x30D1C80", Length = "0x7F")]
	[Token(Token = "0x600000F")]
	internal void Play(FrameRate frameRate) { }

	[Address(RVA = "0x30D2900", Offset = "0x30D1D00", Length = "0x124")]
	[Token(Token = "0x6000010")]
	public void Play(PlayableAsset asset) { }

	[Address(RVA = "0x30D2680", Offset = "0x30D1A80", Length = "0x1F4")]
	[Token(Token = "0x6000011")]
	public void Play(PlayableAsset asset, DirectorWrapMode mode) { }

	[Address(RVA = "0x30D2A30", Offset = "0x30D1E30", Length = "0x76")]
	[NativeThrows]
	[Token(Token = "0x600001C")]
	public void Play() { }

	[Address(RVA = "0x30D2640", Offset = "0x30D1A40", Length = "0x33")]
	[Token(Token = "0x6000047")]
	private static void Play_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30D25C0", Offset = "0x30D19C0", Length = "0x7E")]
	[NativeThrows]
	[Token(Token = "0x600001B")]
	private void PlayOnFrame(FrameRate frameRate) { }

	[Address(RVA = "0x30D2570", Offset = "0x30D1970", Length = "0x42")]
	[Token(Token = "0x6000046")]
	private static void PlayOnFrame_Injected(IntPtr _unity_self, in FrameRate frameRate) { }

	[Address(RVA = "0x30D2AF0", Offset = "0x30D1EF0", Length = "0x76")]
	[Token(Token = "0x6000027")]
	internal void ProcessPendingGraphChanges() { }

	[Address(RVA = "0x30D2AB0", Offset = "0x30D1EB0", Length = "0x33")]
	[Token(Token = "0x6000052")]
	private static void ProcessPendingGraphChanges_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30D2BB0", Offset = "0x30D1FB0", Length = "0x76")]
	[NativeThrows]
	[Token(Token = "0x6000026")]
	public void RebindPlayableGraphOutputs() { }

	[Address(RVA = "0x30D2B70", Offset = "0x30D1F70", Length = "0x33")]
	[Token(Token = "0x6000051")]
	private static void RebindPlayableGraphOutputs_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30D2C70", Offset = "0x30D2070", Length = "0x76")]
	[NativeThrows]
	[Token(Token = "0x6000020")]
	public void RebuildGraph() { }

	[Address(RVA = "0x30D2C30", Offset = "0x30D2030", Length = "0x33")]
	[Token(Token = "0x600004B")]
	private static void RebuildGraph_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30D39C0", Offset = "0x30D2DC0", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6000036")]
	public void remove_paused(Action<PlayableDirector> value) { }

	[Address(RVA = "0x30D3A70", Offset = "0x30D2E70", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6000034")]
	public void remove_played(Action<PlayableDirector> value) { }

	[Address(RVA = "0x30D3B20", Offset = "0x30D2F20", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6000038")]
	public void remove_stopped(Action<PlayableDirector> value) { }

	[Address(RVA = "0x30D2CF0", Offset = "0x30D20F0", Length = "0x2A")]
	[NativeHeader("Runtime/Director/Core/DirectorManager.h")]
	[StaticAccessor("GetDirectorManager()", StaticAccessorType::Dot (0))]
	[Token(Token = "0x6000039")]
	internal static void ResetFrameTiming() { }

	[Address(RVA = "0x30D2D60", Offset = "0x30D2160", Length = "0x76")]
	[Token(Token = "0x600001F")]
	public void Resume() { }

	[Address(RVA = "0x30D2D20", Offset = "0x30D2120", Length = "0x33")]
	[Token(Token = "0x600004A")]
	private static void Resume_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30D2DE0", Offset = "0x30D21E0", Length = "0x1E")]
	[RequiredByNativeCode]
	[Token(Token = "0x600003B")]
	private void SendOnPlayableDirectorPause() { }

	[Address(RVA = "0x30D2E00", Offset = "0x30D2200", Length = "0x1E")]
	[RequiredByNativeCode]
	[Token(Token = "0x600003A")]
	private void SendOnPlayableDirectorPlay() { }

	[Address(RVA = "0x30D2E20", Offset = "0x30D2220", Length = "0x1E")]
	[RequiredByNativeCode]
	[Token(Token = "0x600003C")]
	private void SendOnPlayableDirectorStop() { }

	[Address(RVA = "0x30D31A0", Offset = "0x30D25A0", Length = "0x83")]
	[Token(Token = "0x6000007")]
	public void set_extrapolationMode(DirectorWrapMode value) { }

	[Address(RVA = "0x30D3C20", Offset = "0x30D3020", Length = "0x86")]
	[Token(Token = "0x6000017")]
	public void set_initialTime(double value) { }

	[Address(RVA = "0x30D3BD0", Offset = "0x30D2FD0", Length = "0x43")]
	[Token(Token = "0x6000042")]
	private static void set_initialTime_Injected(IntPtr _unity_self, double value) { }

	[Address(RVA = "0x30D2F70", Offset = "0x30D2370", Length = "0xBA")]
	[Token(Token = "0x600000A")]
	public void set_playableAsset(PlayableAsset value) { }

	[Address(RVA = "0x30D2E90", Offset = "0x30D2290", Length = "0x86")]
	[Token(Token = "0x600000D")]
	public void set_playOnAwake(bool value) { }

	[Address(RVA = "0x30D3DD0", Offset = "0x30D31D0", Length = "0x86")]
	[Token(Token = "0x6000015")]
	public void set_time(double value) { }

	[Address(RVA = "0x30D3D80", Offset = "0x30D3180", Length = "0x43")]
	[Token(Token = "0x6000040")]
	private static void set_time_Injected(IntPtr _unity_self, double value) { }

	[Address(RVA = "0x30D3CF0", Offset = "0x30D30F0", Length = "0x83")]
	[Token(Token = "0x6000013")]
	public void set_timeUpdateMode(DirectorUpdateMode value) { }

	[Address(RVA = "0x30D3CB0", Offset = "0x30D30B0", Length = "0x40")]
	[Token(Token = "0x600003E")]
	private static void set_timeUpdateMode_Injected(IntPtr _unity_self, DirectorUpdateMode value) { }

	[Address(RVA = "0x30D23C0", Offset = "0x30D17C0", Length = "0xEF")]
	[Token(Token = "0x6000012")]
	public void SetGenericBinding(object key, object value) { }

	[Address(RVA = "0x30D2F70", Offset = "0x30D2370", Length = "0xBA")]
	[Token(Token = "0x6000031")]
	private void SetPlayableAsset(ScriptableObject asset) { }

	[Address(RVA = "0x30D2F20", Offset = "0x30D2320", Length = "0x42")]
	[Token(Token = "0x600005C")]
	private static void SetPlayableAsset_Injected(IntPtr _unity_self, IntPtr asset) { }

	[Address(RVA = "0x30D2E90", Offset = "0x30D2290", Length = "0x86")]
	[Token(Token = "0x600002E")]
	private void SetPlayOnAwake(bool on) { }

	[Address(RVA = "0x30D2E40", Offset = "0x30D2240", Length = "0x42")]
	[Token(Token = "0x6000059")]
	private static void SetPlayOnAwake_Injected(IntPtr _unity_self, bool on) { }

	[Address(RVA = "0x30D3090", Offset = "0x30D2490", Length = "0xC3")]
	[Token(Token = "0x6000022")]
	public override void SetReferenceValue(PropertyName id, object value) { }

	[Address(RVA = "0x30D3030", Offset = "0x30D2430", Length = "0x52")]
	[Token(Token = "0x600004D")]
	private static void SetReferenceValue_Injected(IntPtr _unity_self, in PropertyName id, IntPtr value) { }

	[Address(RVA = "0x30D31A0", Offset = "0x30D25A0", Length = "0x83")]
	[Token(Token = "0x600002A")]
	private void SetWrapMode(DirectorWrapMode mode) { }

	[Address(RVA = "0x30D3160", Offset = "0x30D2560", Length = "0x40")]
	[Token(Token = "0x6000055")]
	private static void SetWrapMode_Injected(IntPtr _unity_self, DirectorWrapMode mode) { }

	[Address(RVA = "0x30D3270", Offset = "0x30D2670", Length = "0x76")]
	[Token(Token = "0x600001D")]
	public void Stop() { }

	[Address(RVA = "0x30D3230", Offset = "0x30D2630", Length = "0x33")]
	[Token(Token = "0x6000048")]
	private static void Stop_Injected(IntPtr _unity_self) { }

}


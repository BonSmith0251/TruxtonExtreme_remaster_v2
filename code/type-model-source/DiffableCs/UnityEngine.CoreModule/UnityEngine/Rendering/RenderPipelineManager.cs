namespace UnityEngine.Rendering;

[Token(Token = "0x20003E9")]
public static class RenderPipelineManager
{
	[Token(Token = "0x4000CCE")]
	private static bool s_CleanUpPipeline; //Field offset: 0x0
	[Token(Token = "0x4000CCF")]
	private static RenderPipelineAsset s_CurrentPipelineAsset; //Field offset: 0x8
	[Token(Token = "0x4000CD0")]
	private static RenderPipeline s_CurrentPipeline; //Field offset: 0x10
	[Token(Token = "0x4000CD1")]
	private static bool s_PendingRPAssignationToRaise; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000CD2")]
	private static Action<ScriptableRenderContext, List`1<Camera>> beginContextRendering; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000CD3")]
	private static Action<ScriptableRenderContext, List`1<Camera>> endContextRendering; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000CD4")]
	private static Action<ScriptableRenderContext, Camera> beginCameraRendering; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000CD5")]
	private static Action<ScriptableRenderContext, Camera> endCameraRendering; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000CD6")]
	private static Action activeRenderPipelineTypeChanged; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000CD7")]
	private static Action<RenderPipelineAsset, RenderPipelineAsset> activeRenderPipelineAssetChanged; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000CD8")]
	private static Action activeRenderPipelineCreated; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000CD9")]
	private static Action activeRenderPipelineDisposed; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000CDA")]
	private static Action<ScriptableRenderContext, Camera[]> beginFrameRendering; //Field offset: 0x60
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000CDB")]
	private static Action<ScriptableRenderContext, Camera[]> endFrameRendering; //Field offset: 0x68

	[Token(Token = "0x14000011")]
	public static event Action<ScriptableRenderContext, Camera> beginCameraRendering
	{
		[Address(RVA = "0x30C4B60", Offset = "0x30C3F60", Length = "0xDF")]
		[CompilerGenerated]
		[Token(Token = "0x6001E1A")]
		 add { } //Length: 223
		[Address(RVA = "0x30C4F70", Offset = "0x30C4370", Length = "0xDF")]
		[CompilerGenerated]
		[Token(Token = "0x6001E1B")]
		 remove { } //Length: 223
	}

	[Token(Token = "0x1400000F")]
	public static event Action<ScriptableRenderContext, List`1<Camera>> beginContextRendering
	{
		[Address(RVA = "0x30C4C40", Offset = "0x30C4040", Length = "0xDF")]
		[CompilerGenerated]
		[Token(Token = "0x6001E16")]
		 add { } //Length: 223
		[Address(RVA = "0x30C5050", Offset = "0x30C4450", Length = "0xDF")]
		[CompilerGenerated]
		[Token(Token = "0x6001E17")]
		 remove { } //Length: 223
	}

	[Token(Token = "0x14000012")]
	public static event Action<ScriptableRenderContext, Camera> endCameraRendering
	{
		[Address(RVA = "0x30C4D20", Offset = "0x30C4120", Length = "0xDF")]
		[CompilerGenerated]
		[Token(Token = "0x6001E1C")]
		 add { } //Length: 223
		[Address(RVA = "0x30C5130", Offset = "0x30C4530", Length = "0xDF")]
		[CompilerGenerated]
		[Token(Token = "0x6001E1D")]
		 remove { } //Length: 223
	}

	[Token(Token = "0x14000010")]
	public static event Action<ScriptableRenderContext, List`1<Camera>> endContextRendering
	{
		[Address(RVA = "0x30C4E00", Offset = "0x30C4200", Length = "0xDF")]
		[CompilerGenerated]
		[Token(Token = "0x6001E18")]
		 add { } //Length: 223
		[Address(RVA = "0x30C5210", Offset = "0x30C4610", Length = "0xDF")]
		[CompilerGenerated]
		[Token(Token = "0x6001E19")]
		 remove { } //Length: 223
	}

	[Token(Token = "0x1700045C")]
	public private static RenderPipeline currentPipeline
	{
		[Address(RVA = "0x30C4EE0", Offset = "0x30C42E0", Length = "0x37")]
		[Token(Token = "0x6001E14")]
		 get { } //Length: 55
		[Address(RVA = "0x30C52F0", Offset = "0x30C46F0", Length = "0x94")]
		[Token(Token = "0x6001E15")]
		private set { } //Length: 148
	}

	[Token(Token = "0x1700045D")]
	internal static bool isCurrentPipelineValid
	{
		[Address(RVA = "0x30C4F20", Offset = "0x30C4320", Length = "0x44")]
		[Token(Token = "0x6001E28")]
		internal get { } //Length: 68
	}

	[Address(RVA = "0x30C4B60", Offset = "0x30C3F60", Length = "0xDF")]
	[CompilerGenerated]
	[Token(Token = "0x6001E1A")]
	public static void add_beginCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	[Address(RVA = "0x30C4C40", Offset = "0x30C4040", Length = "0xDF")]
	[CompilerGenerated]
	[Token(Token = "0x6001E16")]
	public static void add_beginContextRendering(Action<ScriptableRenderContext, List`1<Camera>> value) { }

	[Address(RVA = "0x30C4D20", Offset = "0x30C4120", Length = "0xDF")]
	[CompilerGenerated]
	[Token(Token = "0x6001E1C")]
	public static void add_endCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	[Address(RVA = "0x30C4E00", Offset = "0x30C4200", Length = "0xDF")]
	[CompilerGenerated]
	[Token(Token = "0x6001E18")]
	public static void add_endContextRendering(Action<ScriptableRenderContext, List`1<Camera>> value) { }

	[Address(RVA = "0x30C3DB0", Offset = "0x30C31B0", Length = "0x62")]
	[Token(Token = "0x6001E1F")]
	internal static void BeginCameraRendering(ScriptableRenderContext context, Camera camera) { }

	[Address(RVA = "0x30C3E20", Offset = "0x30C3220", Length = "0xBD")]
	[Token(Token = "0x6001E1E")]
	internal static void BeginContextRendering(ScriptableRenderContext context, List<Camera> cameras) { }

	[Address(RVA = "0x30C3EE0", Offset = "0x30C32E0", Length = "0x262")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001E25")]
	internal static void CleanupRenderPipeline() { }

	[Address(RVA = "0x30C4150", Offset = "0x30C3550", Length = "0x2DF")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001E26")]
	private static void DoRenderLoop_Internal(RenderPipelineAsset pipelineAsset, IntPtr loopPtr, object renderRequest) { }

	[Address(RVA = "0x30C4430", Offset = "0x30C3830", Length = "0x62")]
	[Token(Token = "0x6001E21")]
	internal static void EndCameraRendering(ScriptableRenderContext context, Camera camera) { }

	[Address(RVA = "0x30C44A0", Offset = "0x30C38A0", Length = "0xBD")]
	[Token(Token = "0x6001E20")]
	internal static void EndContextRendering(ScriptableRenderContext context, List<Camera> cameras) { }

	[Address(RVA = "0x30C4EE0", Offset = "0x30C42E0", Length = "0x37")]
	[Token(Token = "0x6001E14")]
	public static RenderPipeline get_currentPipeline() { }

	[Address(RVA = "0x30C4F20", Offset = "0x30C4320", Length = "0x44")]
	[Token(Token = "0x6001E28")]
	internal static bool get_isCurrentPipelineValid() { }

	[Address(RVA = "0x30C4560", Offset = "0x30C3960", Length = "0x7C")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001E23")]
	internal static void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset) { }

	[Address(RVA = "0x30C45E0", Offset = "0x30C39E0", Length = "0xF9")]
	[Token(Token = "0x6001E29")]
	private static bool IsPipelineRequireCreation() { }

	[Address(RVA = "0x30C46E0", Offset = "0x30C3AE0", Length = "0x20C")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001E22")]
	private static void OnActiveRenderPipelineAssetChanged(ScriptableObject from, ScriptableObject to, bool raiseTypeChanged) { }

	[Address(RVA = "0x30C35E0", Offset = "0x30C29E0", Length = "0x8A")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001E24")]
	internal static void RecreateCurrentPipeline(RenderPipelineAsset pipelineAsset) { }

	[Address(RVA = "0x30C4F70", Offset = "0x30C4370", Length = "0xDF")]
	[CompilerGenerated]
	[Token(Token = "0x6001E1B")]
	public static void remove_beginCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	[Address(RVA = "0x30C5050", Offset = "0x30C4450", Length = "0xDF")]
	[CompilerGenerated]
	[Token(Token = "0x6001E17")]
	public static void remove_beginContextRendering(Action<ScriptableRenderContext, List`1<Camera>> value) { }

	[Address(RVA = "0x30C5130", Offset = "0x30C4530", Length = "0xDF")]
	[CompilerGenerated]
	[Token(Token = "0x6001E1D")]
	public static void remove_endCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	[Address(RVA = "0x30C5210", Offset = "0x30C4610", Length = "0xDF")]
	[CompilerGenerated]
	[Token(Token = "0x6001E19")]
	public static void remove_endContextRendering(Action<ScriptableRenderContext, List`1<Camera>> value) { }

	[Address(RVA = "0x30C52F0", Offset = "0x30C46F0", Length = "0x94")]
	[Token(Token = "0x6001E15")]
	private static void set_currentPipeline(RenderPipeline value) { }

	[Address(RVA = "0x30C48F0", Offset = "0x30C3CF0", Length = "0x263")]
	[Token(Token = "0x6001E27")]
	internal static bool TryPrepareRenderPipeline(RenderPipelineAsset pipelineAsset) { }

}


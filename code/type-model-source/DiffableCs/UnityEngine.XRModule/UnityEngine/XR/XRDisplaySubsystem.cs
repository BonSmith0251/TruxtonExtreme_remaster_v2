namespace UnityEngine.XR;

[NativeConditional("ENABLE_XR")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystem.h")]
[Token(Token = "0x2000011")]
[UsedByNativeCode]
public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor>
{
	[Token(Token = "0x2000017")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6000052")]
		public static IntPtr ConvertToNative(XRDisplaySubsystem xrDisplaySubsystem) { }

	}

	[Flags]
	[Token(Token = "0x2000012")]
	internal enum TextureLayout : int
	{
		Texture2DArray = 1,
		SingleTexture2D = 2,
		SeparateTexture2Ds = 4,
	}

	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	[Token(Token = "0x2000015")]
	internal struct XRBlitParams
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000074")]
		public RenderTexture srcTex; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000075")]
		public int srcTexArraySlice; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000076")]
		public Rect srcRect; //Field offset: 0xC
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000077")]
		public Rect destRect; //Field offset: 0x1C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000078")]
		public IntPtr foveatedRenderingInfo; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000079")]
		public bool srcHdrEncoded; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x400007A")]
		public ColorGamut srcHdrColorGamut; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400007B")]
		public int srcHdrMaxLuminance; //Field offset: 0x40

	}

	[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	[Token(Token = "0x2000016")]
	internal struct XRMirrorViewBlitDesc
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400007C")]
		private IntPtr displaySubsystemInstance; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400007D")]
		public bool nativeBlitAvailable; //Field offset: 0x8
		[FieldOffset(Offset = "0x9")]
		[Token(Token = "0x400007E")]
		public bool nativeBlitInvalidStates; //Field offset: 0x9
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400007F")]
		public int blitParamsCount; //Field offset: 0xC

		[Address(RVA = "0x3493F60", Offset = "0x3493360", Length = "0x50")]
		[NativeConditional("ENABLE_XR")]
		[NativeMethod(Name = "XRMirrorViewBlitDescScriptApi::GetBlitParameter", IsFreeFunction = True, HasExplicitThis = True)]
		[Token(Token = "0x6000051")]
		public void GetBlitParameter(int blitParameterIndex, out XRBlitParams blitParameter) { }

	}

	[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	[Token(Token = "0x2000013")]
	internal struct XRRenderParameter
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005F")]
		public Matrix4x4 view; //Field offset: 0x0
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000060")]
		public Matrix4x4 projection; //Field offset: 0x40
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000061")]
		public Rect viewport; //Field offset: 0x80
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000062")]
		public Mesh occlusionMesh; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000063")]
		public Mesh visibleMesh; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000064")]
		public int textureArraySlice; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA4")]
		[Token(Token = "0x4000065")]
		public Matrix4x4 previousView; //Field offset: 0xA4
		[FieldOffset(Offset = "0xE4")]
		[Token(Token = "0x4000066")]
		public bool isPreviousViewValid; //Field offset: 0xE4

	}

	[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
	[NativeHeader("Runtime/Graphics/RenderTextureDesc.h")]
	[Token(Token = "0x2000014")]
	internal struct XRRenderPass
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000067")]
		private IntPtr displaySubsystemInstance; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000068")]
		public int renderPassIndex; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000069")]
		public RenderTargetIdentifier renderTarget; //Field offset: 0x10
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400006A")]
		public RenderTextureDescriptor renderTargetDesc; //Field offset: 0x38
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x400006B")]
		public int renderTargetScaledWidth; //Field offset: 0x6C
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400006C")]
		public int renderTargetScaledHeight; //Field offset: 0x70
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x400006D")]
		public bool hasMotionVectorPass; //Field offset: 0x74
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x400006E")]
		public RenderTargetIdentifier motionVectorRenderTarget; //Field offset: 0x78
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400006F")]
		public RenderTextureDescriptor motionVectorRenderTargetDesc; //Field offset: 0xA0
		[FieldOffset(Offset = "0xD4")]
		[Token(Token = "0x4000070")]
		public bool shouldFillOutDepth; //Field offset: 0xD4
		[FieldOffset(Offset = "0xD5")]
		[Token(Token = "0x4000071")]
		public bool spaceWarpRightHandedNDC; //Field offset: 0xD5
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x4000072")]
		public int cullingPassIndex; //Field offset: 0xD8
		[FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x4000073")]
		public IntPtr foveatedRenderingInfo; //Field offset: 0xE0

		[Address(RVA = "0x3494070", Offset = "0x3493470", Length = "0x9A")]
		[NativeConditional("ENABLE_XR")]
		[NativeMethod(Name = "XRRenderPassScriptApi::GetRenderParameter", IsFreeFunction = True, HasExplicitThis = True, ThrowsException = True)]
		[Token(Token = "0x600004E")]
		public void GetRenderParameter(Camera camera, int renderParameterIndex, out XRRenderParameter renderParameter) { }

		[Address(RVA = "0x3494000", Offset = "0x3493400", Length = "0x62")]
		[Token(Token = "0x6000050")]
		private static void GetRenderParameter_Injected(ref XRRenderPass _unity_self, IntPtr camera, int renderParameterIndex, out XRRenderParameter renderParameter) { }

		[Address(RVA = "0x3493FC0", Offset = "0x34933C0", Length = "0x33")]
		[NativeConditional("ENABLE_XR")]
		[NativeMethod(Name = "XRRenderPassScriptApi::GetRenderParameterCount", IsFreeFunction = True, HasExplicitThis = True)]
		[Token(Token = "0x600004F")]
		public int GetRenderParameterCount() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000059")]
	private Action<Boolean> displayFocusChanged; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400005A")]
	private HDROutputSettings m_HDROutputSettings; //Field offset: 0x28

	[Token(Token = "0x1700000D")]
	public float appliedViewportScale
	{
		[Address(RVA = "0x34936E0", Offset = "0x3492AE0", Length = "0x51")]
		[Token(Token = "0x6000020")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000014")]
	public bool disableLegacyRenderer
	{
		[Address(RVA = "0x34938A0", Offset = "0x3492CA0", Length = "0x5B")]
		[Token(Token = "0x600002A")]
		 set { } //Length: 91
	}

	[Token(Token = "0x1700000F")]
	public float globalDynamicScale
	{
		[Address(RVA = "0x3493780", Offset = "0x3492B80", Length = "0x51")]
		[Token(Token = "0x6000022")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000015")]
	public HDROutputSettings hdrOutputSettings
	{
		[Address(RVA = "0x34937E0", Offset = "0x3492BE0", Length = "0x6F")]
		[Token(Token = "0x6000038")]
		 get { } //Length: 111
	}

	[Token(Token = "0x1700000E")]
	public float scaleOfAllRenderTargets
	{
		[Address(RVA = "0x3493A00", Offset = "0x3492E00", Length = "0x61")]
		[Token(Token = "0x6000021")]
		 set { } //Length: 97
	}

	[Token(Token = "0x17000012")]
	public bool sRGB
	{
		[Address(RVA = "0x3493950", Offset = "0x3492D50", Length = "0x5B")]
		[Token(Token = "0x6000025")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000013")]
	public TextureLayout textureLayout
	{
		[Address(RVA = "0x3493AB0", Offset = "0x3492EB0", Length = "0x58")]
		[Token(Token = "0x6000026")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000011")]
	public float zFar
	{
		[Address(RVA = "0x3493B60", Offset = "0x3492F60", Length = "0x61")]
		[Token(Token = "0x6000024")]
		 set { } //Length: 97
	}

	[Token(Token = "0x17000010")]
	public float zNear
	{
		[Address(RVA = "0x3493C20", Offset = "0x3493020", Length = "0x61")]
		[Token(Token = "0x6000023")]
		 set { } //Length: 97
	}

	[Address(RVA = "0x3493660", Offset = "0x3492A60", Length = "0x39")]
	[Token(Token = "0x6000039")]
	public XRDisplaySubsystem() { }

	[Address(RVA = "0x3492710", Offset = "0x3491B10", Length = "0x94")]
	[NativeConditional("ENABLE_XR")]
	[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
	[NativeMethod(Name = "AddGraphicsThreadMirrorViewBlit", IsThreadSafe = False)]
	[Token(Token = "0x6000037")]
	public bool AddGraphicsThreadMirrorViewBlit(CommandBuffer cmd, bool allowGraphicsStateInvalidate, int mode) { }

	[Address(RVA = "0x34926A0", Offset = "0x3491AA0", Length = "0x64")]
	[Token(Token = "0x600004D")]
	private static bool AddGraphicsThreadMirrorViewBlit_Injected(IntPtr _unity_self, IntPtr cmd, bool allowGraphicsStateInvalidate, int mode) { }

	[Address(RVA = "0x34927B0", Offset = "0x3491BB0", Length = "0x141")]
	[Token(Token = "0x6000030")]
	public void BeginRecordingIfLateLatched(Camera camera) { }

	[Address(RVA = "0x3492900", Offset = "0x3491D00", Length = "0x141")]
	[Token(Token = "0x600002E")]
	public void EndRecordingIfLateLatched(Camera camera) { }

	[Address(RVA = "0x34936E0", Offset = "0x3492AE0", Length = "0x51")]
	[Token(Token = "0x6000020")]
	public float get_appliedViewportScale() { }

	[Address(RVA = "0x34936A0", Offset = "0x3492AA0", Length = "0x33")]
	[Token(Token = "0x600003A")]
	private static float get_appliedViewportScale_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3493780", Offset = "0x3492B80", Length = "0x51")]
	[Token(Token = "0x6000022")]
	public float get_globalDynamicScale() { }

	[Address(RVA = "0x3493740", Offset = "0x3492B40", Length = "0x33")]
	[Token(Token = "0x600003C")]
	private static float get_globalDynamicScale_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x34937E0", Offset = "0x3492BE0", Length = "0x6F")]
	[Token(Token = "0x6000038")]
	public HDROutputSettings get_hdrOutputSettings() { }

	[Address(RVA = "0x3492A50", Offset = "0x3491E50", Length = "0x18C")]
	[Token(Token = "0x6000032")]
	public void GetCullingParameters(Camera camera, int cullingPassIndex, out ScriptableCullingParameters scriptableCullingParameters) { }

	[Address(RVA = "0x3492C50", Offset = "0x3492050", Length = "0xC6")]
	[NativeConditional("ENABLE_XR")]
	[NativeMethod(Name = "QueryMirrorViewBlitDesc", IsThreadSafe = False)]
	[Token(Token = "0x6000036")]
	public bool GetMirrorViewBlitDesc(RenderTexture mirrorRt, out XRMirrorViewBlitDesc outDesc, int mode) { }

	[Address(RVA = "0x3492BE0", Offset = "0x3491FE0", Length = "0x62")]
	[Token(Token = "0x600004C")]
	private static bool GetMirrorViewBlitDesc_Injected(IntPtr _unity_self, IntPtr mirrorRt, out XRMirrorViewBlitDesc outDesc, int mode) { }

	[Address(RVA = "0x3492D60", Offset = "0x3492160", Length = "0x51")]
	[NativeConditional("ENABLE_XR")]
	[NativeMethod(Name = "GetPreferredMirrorViewBlitMode", IsThreadSafe = False)]
	[Token(Token = "0x6000034")]
	public int GetPreferredMirrorBlitMode() { }

	[Address(RVA = "0x3492D20", Offset = "0x3492120", Length = "0x33")]
	[Token(Token = "0x600004A")]
	private static int GetPreferredMirrorBlitMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3492E60", Offset = "0x3492260", Length = "0xB8")]
	[Token(Token = "0x600002C")]
	public void GetRenderPass(int renderPassIndex, out XRRenderPass renderPass) { }

	[Address(RVA = "0x3492E00", Offset = "0x3492200", Length = "0x51")]
	[Token(Token = "0x600002B")]
	public int GetRenderPassCount() { }

	[Address(RVA = "0x3492DC0", Offset = "0x34921C0", Length = "0x33")]
	[Token(Token = "0x6000045")]
	private static int GetRenderPassCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3492F70", Offset = "0x3492370", Length = "0xAE")]
	[NativeMethod("TryBeginRecordingIfLateLatched")]
	[Token(Token = "0x6000031")]
	private bool Internal_TryBeginRecordingIfLateLatched(Camera camera) { }

	[Address(RVA = "0x3492F20", Offset = "0x3492320", Length = "0x42")]
	[Token(Token = "0x6000048")]
	private static bool Internal_TryBeginRecordingIfLateLatched_Injected(IntPtr _unity_self, IntPtr camera) { }

	[Address(RVA = "0x3493070", Offset = "0x3492470", Length = "0xAE")]
	[NativeMethod("TryEndRecordingIfLateLatched")]
	[Token(Token = "0x600002F")]
	private bool Internal_TryEndRecordingIfLateLatched(Camera camera) { }

	[Address(RVA = "0x3493020", Offset = "0x3492420", Length = "0x42")]
	[Token(Token = "0x6000047")]
	private static bool Internal_TryEndRecordingIfLateLatched_Injected(IntPtr _unity_self, IntPtr camera) { }

	[Address(RVA = "0x3493190", Offset = "0x3492590", Length = "0xC6")]
	[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableCulling.h")]
	[NativeMethod("TryGetCullingParams")]
	[Token(Token = "0x6000033")]
	private bool Internal_TryGetCullingParams(Camera camera, int cullingPassIndex, out ScriptableCullingParameters scriptableCullingParameters) { }

	[Address(RVA = "0x3493120", Offset = "0x3492520", Length = "0x62")]
	[Token(Token = "0x6000049")]
	private static bool Internal_TryGetCullingParams_Injected(IntPtr _unity_self, IntPtr camera, int cullingPassIndex, out ScriptableCullingParameters scriptableCullingParameters) { }

	[Address(RVA = "0x34932B0", Offset = "0x34926B0", Length = "0x67")]
	[NativeMethod("TryGetRenderPass")]
	[Token(Token = "0x600002D")]
	private bool Internal_TryGetRenderPass(int renderPassIndex, out XRRenderPass renderPass) { }

	[Address(RVA = "0x3493260", Offset = "0x3492660", Length = "0x50")]
	[Token(Token = "0x6000046")]
	private static bool Internal_TryGetRenderPass_Injected(IntPtr _unity_self, int renderPassIndex, out XRRenderPass renderPass) { }

	[Address(RVA = "0x2FC58D0", Offset = "0x2FC4CD0", Length = "0x1B")]
	[RequiredByNativeCode]
	[Token(Token = "0x600001F")]
	private void InvokeDisplayFocusChanged(bool focus) { }

	[Address(RVA = "0x3493370", Offset = "0x3492770", Length = "0xAE")]
	[Token(Token = "0x6000028")]
	public int ScaledTextureHeight(RenderTexture renderTexture) { }

	[Address(RVA = "0x3493320", Offset = "0x3492720", Length = "0x42")]
	[Token(Token = "0x6000042")]
	private static int ScaledTextureHeight_Injected(IntPtr _unity_self, IntPtr renderTexture) { }

	[Address(RVA = "0x3493470", Offset = "0x3492870", Length = "0xAE")]
	[Token(Token = "0x6000027")]
	public int ScaledTextureWidth(RenderTexture renderTexture) { }

	[Address(RVA = "0x3493420", Offset = "0x3492820", Length = "0x42")]
	[Token(Token = "0x6000041")]
	private static int ScaledTextureWidth_Injected(IntPtr _unity_self, IntPtr renderTexture) { }

	[Address(RVA = "0x34938A0", Offset = "0x3492CA0", Length = "0x5B")]
	[Token(Token = "0x600002A")]
	public void set_disableLegacyRenderer(bool value) { }

	[Address(RVA = "0x3493850", Offset = "0x3492C50", Length = "0x42")]
	[Token(Token = "0x6000044")]
	private static void set_disableLegacyRenderer_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x3493A00", Offset = "0x3492E00", Length = "0x61")]
	[Token(Token = "0x6000021")]
	public void set_scaleOfAllRenderTargets(float value) { }

	[Address(RVA = "0x34939B0", Offset = "0x3492DB0", Length = "0x43")]
	[Token(Token = "0x600003B")]
	private static void set_scaleOfAllRenderTargets_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x3493950", Offset = "0x3492D50", Length = "0x5B")]
	[Token(Token = "0x6000025")]
	public void set_sRGB(bool value) { }

	[Address(RVA = "0x3493900", Offset = "0x3492D00", Length = "0x42")]
	[Token(Token = "0x600003F")]
	private static void set_sRGB_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x3493AB0", Offset = "0x3492EB0", Length = "0x58")]
	[Token(Token = "0x6000026")]
	public void set_textureLayout(TextureLayout value) { }

	[Address(RVA = "0x3493A70", Offset = "0x3492E70", Length = "0x40")]
	[Token(Token = "0x6000040")]
	private static void set_textureLayout_Injected(IntPtr _unity_self, TextureLayout value) { }

	[Address(RVA = "0x3493B60", Offset = "0x3492F60", Length = "0x61")]
	[Token(Token = "0x6000024")]
	public void set_zFar(float value) { }

	[Address(RVA = "0x3493B10", Offset = "0x3492F10", Length = "0x43")]
	[Token(Token = "0x600003E")]
	private static void set_zFar_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x3493C20", Offset = "0x3493020", Length = "0x61")]
	[Token(Token = "0x6000023")]
	public void set_zNear(float value) { }

	[Address(RVA = "0x3493BD0", Offset = "0x3492FD0", Length = "0x43")]
	[Token(Token = "0x600003D")]
	private static void set_zNear_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x3493560", Offset = "0x3492960", Length = "0x58")]
	[Token(Token = "0x6000029")]
	public void SetMSAALevel(int level) { }

	[Address(RVA = "0x3493520", Offset = "0x3492920", Length = "0x40")]
	[Token(Token = "0x6000043")]
	private static void SetMSAALevel_Injected(IntPtr _unity_self, int level) { }

	[Address(RVA = "0x3493600", Offset = "0x3492A00", Length = "0x58")]
	[NativeConditional("ENABLE_XR")]
	[NativeMethod(Name = "SetPreferredMirrorViewBlitMode", IsThreadSafe = False)]
	[Token(Token = "0x6000035")]
	public void SetPreferredMirrorBlitMode(int blitMode) { }

	[Address(RVA = "0x34935C0", Offset = "0x34929C0", Length = "0x40")]
	[Token(Token = "0x600004B")]
	private static void SetPreferredMirrorBlitMode_Injected(IntPtr _unity_self, int blitMode) { }

}


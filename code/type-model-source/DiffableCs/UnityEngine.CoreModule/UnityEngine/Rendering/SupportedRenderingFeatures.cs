namespace UnityEngine.Rendering;

[Token(Token = "0x20003F9")]
public class SupportedRenderingFeatures
{
	[Flags]
	[Token(Token = "0x20003FB")]
	internal enum LightmapMixedBakeModes : int
	{
		None = 0,
		IndirectOnly = 1,
		Subtractive = 2,
		Shadowmask = 4,
	}

	[Flags]
	[Token(Token = "0x20003FA")]
	internal enum ReflectionProbeModes : int
	{
		None = 0,
		Rotation = 1,
	}

	[Token(Token = "0x4000D33")]
	private static SupportedRenderingFeatures s_Active; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D34")]
	private ReflectionProbeModes <reflectionProbeModes>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000D35")]
	private LightmapMixedBakeModes <defaultMixedLightingModes>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D36")]
	private LightmapMixedBakeModes <mixedLightingModes>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000D37")]
	private LightmapBakeType <lightmapBakeTypes>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D38")]
	private LightmapsMode <lightmapsModes>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000D39")]
	private bool <enlightenLightmapper>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x25")]
	[Token(Token = "0x4000D3A")]
	private bool <enlighten>k__BackingField; //Field offset: 0x25
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x26")]
	[Token(Token = "0x4000D3B")]
	private bool <skyOcclusion>k__BackingField; //Field offset: 0x26
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x27")]
	[Token(Token = "0x4000D3C")]
	private bool <lightProbeProxyVolumes>k__BackingField; //Field offset: 0x27
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D3D")]
	private bool <motionVectors>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4000D3E")]
	private bool <receiveShadows>k__BackingField; //Field offset: 0x29
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x4000D3F")]
	private bool <reflectionProbes>k__BackingField; //Field offset: 0x2A
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2B")]
	[Token(Token = "0x4000D40")]
	private bool <reflectionProbesBlendDistance>k__BackingField; //Field offset: 0x2B
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000D41")]
	private bool <rendererPriority>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2D")]
	[Token(Token = "0x4000D42")]
	private bool <rendersUIOverlay>k__BackingField; //Field offset: 0x2D
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2E")]
	[Token(Token = "0x4000D43")]
	private bool <overridesEnvironmentLighting>k__BackingField; //Field offset: 0x2E
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2F")]
	[Token(Token = "0x4000D44")]
	private bool <overridesFog>k__BackingField; //Field offset: 0x2F
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D45")]
	private bool <overridesRealtimeReflectionProbes>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4000D46")]
	private bool <overridesOtherLightingSettings>k__BackingField; //Field offset: 0x31
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x4000D47")]
	private bool <editableMaterialRenderQueue>k__BackingField; //Field offset: 0x32
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x33")]
	[Token(Token = "0x4000D48")]
	private bool <overridesLODBias>k__BackingField; //Field offset: 0x33
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000D49")]
	private bool <overridesMaximumLODLevel>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x35")]
	[Token(Token = "0x4000D4A")]
	private bool <overridesEnableLODCrossFade>k__BackingField; //Field offset: 0x35
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x36")]
	[Token(Token = "0x4000D4B")]
	private bool <rendererProbes>k__BackingField; //Field offset: 0x36
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x37")]
	[Token(Token = "0x4000D4C")]
	private bool <particleSystemInstancing>k__BackingField; //Field offset: 0x37
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000D4D")]
	private bool <ambientProbeBaking>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4000D4E")]
	private bool <defaultReflectionProbeBaking>k__BackingField; //Field offset: 0x39
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3A")]
	[Token(Token = "0x4000D4F")]
	private bool <overridesShadowmask>k__BackingField; //Field offset: 0x3A
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3B")]
	[Token(Token = "0x4000D50")]
	private bool <overridesLightProbeSystem>k__BackingField; //Field offset: 0x3B
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000D51")]
	private bool <supportsHDR>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3D")]
	[Token(Token = "0x4000D52")]
	private bool <supportsClouds>k__BackingField; //Field offset: 0x3D
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000D53")]
	private string <overridesLightProbeSystemWarningMessage>k__BackingField; //Field offset: 0x40

	[Token(Token = "0x17000481")]
	public static SupportedRenderingFeatures active
	{
		[Address(RVA = "0x30CFBE0", Offset = "0x30CEFE0", Length = "0xDB")]
		[Token(Token = "0x6001EBF")]
		 get { } //Length: 219
		[Address(RVA = "0x30CFCD0", Offset = "0x30CF0D0", Length = "0x69")]
		[Token(Token = "0x6001EC0")]
		 set { } //Length: 105
	}

	[Token(Token = "0x1700048A")]
	public bool ambientProbeBaking
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001ECA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000483")]
	public LightmapMixedBakeModes defaultMixedLightingModes
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001EC2")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700048B")]
	public bool defaultReflectionProbeBaking
	{
		[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001ECB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000487")]
	public bool enlighten
	{
		[Address(RVA = "0x213CD00", Offset = "0x213C100", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001EC6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000485")]
	public LightmapBakeType lightmapBakeTypes
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001EC4")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000486")]
	public LightmapsMode lightmapsModes
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001EC5")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000484")]
	public LightmapMixedBakeModes mixedLightingModes
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001EC3")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700048C")]
	public bool overridesLightProbeSystem
	{
		[Address(RVA = "0x30CFCC0", Offset = "0x30CF0C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001ECC")]
		 get { } //Length: 5
		[Address(RVA = "0x1D42E70", Offset = "0x1D42270", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001ECD")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000482")]
	public ReflectionProbeModes reflectionProbeModes
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6001EC1")]
		 get { } //Length: 85
	}

	[Token(Token = "0x17000489")]
	public bool rendersUIOverlay
	{
		[Address(RVA = "0x25D7F70", Offset = "0x25D7370", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001EC8")]
		 get { } //Length: 5
		[Address(RVA = "0x25D7F80", Offset = "0x25D7380", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001EC9")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000488")]
	public bool skyOcclusion
	{
		[Address(RVA = "0x213CD70", Offset = "0x213C170", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001EC7")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700048D")]
	public bool supportsHDR
	{
		[Address(RVA = "0x101DB80", Offset = "0x101CF80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001ECE")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x30CFAD0", Offset = "0x30CEED0", Length = "0x67")]
	[Token(Token = "0x6001EDD")]
	private static SupportedRenderingFeatures() { }

	[Address(RVA = "0x30CFB40", Offset = "0x30CEF40", Length = "0x92")]
	[Token(Token = "0x6001EDC")]
	public SupportedRenderingFeatures() { }

	[Address(RVA = "0x30CF090", Offset = "0x30CE490", Length = "0x16")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001EDA")]
	internal static void FallbackLightmapperByRef(IntPtr lightmapperPtr) { }

	[Address(RVA = "0x30CF0B0", Offset = "0x30CE4B0", Length = "0x24A")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001ECF")]
	internal static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr) { }

	[Address(RVA = "0x30CFBE0", Offset = "0x30CEFE0", Length = "0xDB")]
	[Token(Token = "0x6001EBF")]
	public static SupportedRenderingFeatures get_active() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001ECA")]
	public bool get_ambientProbeBaking() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001EC2")]
	public LightmapMixedBakeModes get_defaultMixedLightingModes() { }

	[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001ECB")]
	public bool get_defaultReflectionProbeBaking() { }

	[Address(RVA = "0x213CD00", Offset = "0x213C100", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001EC6")]
	public bool get_enlighten() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001EC4")]
	public LightmapBakeType get_lightmapBakeTypes() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001EC5")]
	public LightmapsMode get_lightmapsModes() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001EC3")]
	public LightmapMixedBakeModes get_mixedLightingModes() { }

	[Address(RVA = "0x30CFCC0", Offset = "0x30CF0C0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001ECC")]
	public bool get_overridesLightProbeSystem() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6001EC1")]
	public ReflectionProbeModes get_reflectionProbeModes() { }

	[Address(RVA = "0x25D7F70", Offset = "0x25D7370", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001EC8")]
	public bool get_rendersUIOverlay() { }

	[Address(RVA = "0x30CF300", Offset = "0x30CE700", Length = "0x64")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001ED7")]
	internal static void IsAmbientProbeBakingSupported(IntPtr isSupportedPtr) { }

	[Address(RVA = "0x30CF370", Offset = "0x30CE770", Length = "0x64")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001ED8")]
	internal static void IsDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr) { }

	[Address(RVA = "0x30CF4E0", Offset = "0x30CE8E0", Length = "0x133")]
	[Token(Token = "0x6001ED2")]
	internal static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType) { }

	[Address(RVA = "0x30CF3E0", Offset = "0x30CE7E0", Length = "0xF9")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001ED3")]
	internal static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr) { }

	[Address(RVA = "0x30CF620", Offset = "0x30CEA20", Length = "0x22")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001ED5")]
	internal static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr) { }

	[Address(RVA = "0x30CF650", Offset = "0x30CEA50", Length = "0x75")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001ED4")]
	internal static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr) { }

	[Address(RVA = "0x30CF830", Offset = "0x30CEC30", Length = "0x14E")]
	[Token(Token = "0x6001ED0")]
	internal static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode) { }

	[Address(RVA = "0x30CF6D0", Offset = "0x30CEAD0", Length = "0x15B")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001ED1")]
	internal static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr) { }

	[Address(RVA = "0x30CF980", Offset = "0x30CED80", Length = "0x67")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001EDB")]
	internal static void IsRotatingReflectionProbesSupported(IntPtr isSupportedPtr) { }

	[Address(RVA = "0x30CF9F0", Offset = "0x30CEDF0", Length = "0x64")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001ED6")]
	internal static void IsUIOverlayRenderedBySRP(IntPtr isSupportedPtr) { }

	[Address(RVA = "0x30CFA60", Offset = "0x30CEE60", Length = "0x64")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001ED9")]
	internal static void OverridesLightProbeSystem(IntPtr overridesPtr) { }

	[Address(RVA = "0x30CFCD0", Offset = "0x30CF0D0", Length = "0x69")]
	[Token(Token = "0x6001EC0")]
	public static void set_active(SupportedRenderingFeatures value) { }

	[Address(RVA = "0x1D42E70", Offset = "0x1D42270", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001ECD")]
	public void set_overridesLightProbeSystem(bool value) { }

	[Address(RVA = "0x25D7F80", Offset = "0x25D7380", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001EC9")]
	public void set_rendersUIOverlay(bool value) { }

	[Address(RVA = "0x213CD70", Offset = "0x213C170", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001EC7")]
	public void set_skyOcclusion(bool value) { }

	[Address(RVA = "0x101DB80", Offset = "0x101CF80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001ECE")]
	public void set_supportsHDR(bool value) { }

}


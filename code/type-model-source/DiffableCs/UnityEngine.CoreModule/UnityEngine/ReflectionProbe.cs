namespace UnityEngine;

[NativeHeader("Runtime/Camera/ReflectionProbes.h")]
[Token(Token = "0x20000B4")]
public sealed class ReflectionProbe : Behaviour
{
	[CompilerGenerated]
	[Token(Token = "0x20000B6")]
	private sealed class <>c__DisplayClass95_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000213")]
		public Action<Cubemap> value; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600050D")]
		public <>c__DisplayClass95_0() { }

		[Address(RVA = "0x2FF01F0", Offset = "0x2FEF5F0", Length = "0x6D")]
		[Token(Token = "0x600050F")]
		internal void <add_defaultReflectionSet>b__0(Texture b) { }

		[Address(RVA = "0x2FF0260", Offset = "0x2FEF660", Length = "0x4F")]
		[Token(Token = "0x600050E")]
		internal bool <add_defaultReflectionSet>b__1(Action<Texture> h) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000B7")]
	private sealed class <>c__DisplayClass98_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000214")]
		public Action<Texture> value; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000510")]
		public <>c__DisplayClass98_0() { }

		[Address(RVA = "0x2FF0260", Offset = "0x2FEF660", Length = "0x4F")]
		[Token(Token = "0x6000511")]
		internal bool <add_defaultReflectionTexture>b__0(Action<Texture> h) { }

	}

	[Token(Token = "0x20000B5")]
	internal enum ReflectionProbeEvent : int
	{
		ReflectionProbeAdded = 0,
		ReflectionProbeRemoved = 1,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400020D")]
	private static Action<ReflectionProbe, ReflectionProbeEvent> reflectionProbeChanged; //Field offset: 0x0
	[Token(Token = "0x400020E")]
	private static Dictionary<Int32, Action`1<Texture>> registeredDefaultReflectionSetActions; //Field offset: 0x8
	[Token(Token = "0x400020F")]
	private static List<Action`1<Texture>> registeredDefaultReflectionTextureActions; //Field offset: 0x10

	[Obsolete("ReflectionProbe.defaultReflectionSet has been deprecated. Use ReflectionProbe.defaultReflectionTexture. (UnityUpgradable) -> UnityEngine.ReflectionProbe.defaultReflectionTexture", False)]
	[Token(Token = "0x14000005")]
	public static event Action<Cubemap> defaultReflectionSet
	{
		[Address(RVA = "0x2FE66F0", Offset = "0x2FE5AF0", Length = "0x1CB")]
		[Token(Token = "0x60004D1")]
		 add { } //Length: 459
		[Address(RVA = "0x2FE8500", Offset = "0x2FE7900", Length = "0x1A9")]
		[Token(Token = "0x60004D2")]
		 remove { } //Length: 425
	}

	[Token(Token = "0x14000006")]
	public static event Action<Texture> defaultReflectionTexture
	{
		[Address(RVA = "0x2FE68C0", Offset = "0x2FE5CC0", Length = "0x234")]
		[Token(Token = "0x60004D3")]
		 add { } //Length: 564
		[Address(RVA = "0x2FE86B0", Offset = "0x2FE7AB0", Length = "0x79")]
		[Token(Token = "0x60004D4")]
		 remove { } //Length: 121
	}

	[Token(Token = "0x14000004")]
	public static event Action<ReflectionProbe, ReflectionProbeEvent> reflectionProbeChanged
	{
		[Address(RVA = "0x2FE6B00", Offset = "0x2FE5F00", Length = "0x101")]
		[CompilerGenerated]
		[Token(Token = "0x60004CE")]
		 add { } //Length: 257
		[Address(RVA = "0x2FE8730", Offset = "0x2FE7B30", Length = "0x101")]
		[CompilerGenerated]
		[Token(Token = "0x60004CF")]
		 remove { } //Length: 257
	}

	[Token(Token = "0x170000D2")]
	public Color backgroundColor
	{
		[Address(RVA = "0x2FE6C60", Offset = "0x2FE6060", Length = "0xAF")]
		[Token(Token = "0x60004AD")]
		 get { } //Length: 175
		[Address(RVA = "0x2FE8890", Offset = "0x2FE7C90", Length = "0xA6")]
		[Token(Token = "0x60004AE")]
		 set { } //Length: 166
	}

	[Token(Token = "0x170000D9")]
	public Texture bakedTexture
	{
		[Address(RVA = "0x2FE6D50", Offset = "0x2FE6150", Length = "0xB1")]
		[Token(Token = "0x60004BB")]
		 get { } //Length: 177
		[Address(RVA = "0x2FE8990", Offset = "0x2FE7D90", Length = "0xDF")]
		[Token(Token = "0x60004BC")]
		 set { } //Length: 223
	}

	[Token(Token = "0x170000D3")]
	public float blendDistance
	{
		[Address(RVA = "0x2FE6E50", Offset = "0x2FE6250", Length = "0x97")]
		[Token(Token = "0x60004AF")]
		 get { } //Length: 151
		[Address(RVA = "0x2FE8AC0", Offset = "0x2FE7EC0", Length = "0xA7")]
		[Token(Token = "0x60004B0")]
		 set { } //Length: 167
	}

	[NativeName("GlobalAABB")]
	[Token(Token = "0x170000CB")]
	public Bounds bounds
	{
		[Address(RVA = "0x2FE6F40", Offset = "0x2FE6340", Length = "0xB5")]
		[Token(Token = "0x60004A0")]
		 get { } //Length: 181
	}

	[Token(Token = "0x170000D4")]
	public bool boxProjection
	{
		[Address(RVA = "0x2FE7040", Offset = "0x2FE6440", Length = "0x97")]
		[Token(Token = "0x60004B1")]
		 get { } //Length: 151
		[Address(RVA = "0x2FE8BC0", Offset = "0x2FE7FC0", Length = "0xA7")]
		[Token(Token = "0x60004B2")]
		 set { } //Length: 167
	}

	[NativeName("BoxOffset")]
	[Token(Token = "0x170000C7")]
	public Vector3 center
	{
		[Address(RVA = "0x2FE7130", Offset = "0x2FE6530", Length = "0xB1")]
		[Token(Token = "0x6000498")]
		 get { } //Length: 177
		[Address(RVA = "0x2FE8CC0", Offset = "0x2FE80C0", Length = "0xA6")]
		[Token(Token = "0x6000499")]
		 set { } //Length: 166
	}

	[Token(Token = "0x170000D1")]
	public ReflectionProbeClearFlags clearFlags
	{
		[Address(RVA = "0x2FE7230", Offset = "0x2FE6630", Length = "0x97")]
		[Token(Token = "0x60004AB")]
		 get { } //Length: 151
		[Address(RVA = "0x2FE8DB0", Offset = "0x2FE81B0", Length = "0xA4")]
		[Token(Token = "0x60004AC")]
		 set { } //Length: 164
	}

	[Token(Token = "0x170000D0")]
	public int cullingMask
	{
		[Address(RVA = "0x2FE7310", Offset = "0x2FE6710", Length = "0x97")]
		[Token(Token = "0x60004A9")]
		 get { } //Length: 151
		[Address(RVA = "0x2FE8EA0", Offset = "0x2FE82A0", Length = "0xA4")]
		[Token(Token = "0x60004AA")]
		 set { } //Length: 164
	}

	[Token(Token = "0x170000DA")]
	public Texture customBakedTexture
	{
		[Address(RVA = "0x2FE73F0", Offset = "0x2FE67F0", Length = "0xB1")]
		[Token(Token = "0x60004BD")]
		 get { } //Length: 177
		[Address(RVA = "0x2FE8FA0", Offset = "0x2FE83A0", Length = "0xDF")]
		[Token(Token = "0x60004BE")]
		 set { } //Length: 223
	}

	[StaticAccessor("GetReflectionProbes()")]
	[Token(Token = "0x170000E1")]
	public static Texture defaultTexture
	{
		[Address(RVA = "0x2FE7590", Offset = "0x2FE6990", Length = "0x75")]
		[Token(Token = "0x60004CD")]
		 get { } //Length: 117
	}

	[StaticAccessor("GetReflectionProbes()")]
	[Token(Token = "0x170000E0")]
	public static Vector4 defaultTextureHDRDecodeValues
	{
		[Address(RVA = "0x2FE74F0", Offset = "0x2FE68F0", Length = "0x6D")]
		[Token(Token = "0x60004CC")]
		 get { } //Length: 109
	}

	[NativeName("Far")]
	[Token(Token = "0x170000C9")]
	public float farClipPlane
	{
		[Address(RVA = "0x2FE7650", Offset = "0x2FE6A50", Length = "0x97")]
		[Token(Token = "0x600049C")]
		 get { } //Length: 151
		[Address(RVA = "0x2FE90D0", Offset = "0x2FE84D0", Length = "0xA7")]
		[Token(Token = "0x600049D")]
		 set { } //Length: 167
	}

	[NativeName("HDR")]
	[Token(Token = "0x170000CC")]
	public bool hdr
	{
		[Address(RVA = "0x2FE7730", Offset = "0x2FE6B30", Length = "0x97")]
		[Token(Token = "0x60004A1")]
		 get { } //Length: 151
		[Address(RVA = "0x2FE91D0", Offset = "0x2FE85D0", Length = "0xA7")]
		[Token(Token = "0x60004A2")]
		 set { } //Length: 167
	}

	[Token(Token = "0x170000D6")]
	public int importance
	{
		[Address(RVA = "0x2FE7810", Offset = "0x2FE6C10", Length = "0x97")]
		[Token(Token = "0x60004B5")]
		 get { } //Length: 151
		[Address(RVA = "0x2FE92C0", Offset = "0x2FE86C0", Length = "0xA4")]
		[Token(Token = "0x60004B6")]
		 set { } //Length: 164
	}

	[NativeName("IntensityMultiplier")]
	[Token(Token = "0x170000CA")]
	public float intensity
	{
		[Address(RVA = "0x2FE78F0", Offset = "0x2FE6CF0", Length = "0x97")]
		[Token(Token = "0x600049E")]
		 get { } //Length: 151
		[Address(RVA = "0x2FE93C0", Offset = "0x2FE87C0", Length = "0xA7")]
		[Token(Token = "0x600049F")]
		 set { } //Length: 167
	}

	[StaticAccessor("GetReflectionProbes()")]
	[Token(Token = "0x170000DF")]
	public static int maxBakedCubemapResolution
	{
		[Address(RVA = "0x2FE7990", Offset = "0x2FE6D90", Length = "0x2A")]
		[Token(Token = "0x60004CB")]
		 get { } //Length: 42
	}

	[StaticAccessor("GetReflectionProbes()")]
	[Token(Token = "0x170000DE")]
	public static int minBakedCubemapResolution
	{
		[Address(RVA = "0x2FE79C0", Offset = "0x2FE6DC0", Length = "0x2A")]
		[Token(Token = "0x60004CA")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170000D5")]
	public ReflectionProbeMode mode
	{
		[Address(RVA = "0x2FE7A30", Offset = "0x2FE6E30", Length = "0x97")]
		[Token(Token = "0x60004B3")]
		 get { } //Length: 151
		[Address(RVA = "0x2FE94B0", Offset = "0x2FE88B0", Length = "0xA4")]
		[Token(Token = "0x60004B4")]
		 set { } //Length: 164
	}

	[NativeName("Near")]
	[Token(Token = "0x170000C8")]
	public float nearClipPlane
	{
		[Address(RVA = "0x2FE7B10", Offset = "0x2FE6F10", Length = "0x97")]
		[Token(Token = "0x600049A")]
		 get { } //Length: 151
		[Address(RVA = "0x2FE95B0", Offset = "0x2FE89B0", Length = "0xA7")]
		[Token(Token = "0x600049B")]
		 set { } //Length: 167
	}

	[Token(Token = "0x170000DB")]
	public RenderTexture realtimeTexture
	{
		[Address(RVA = "0x2FE7BF0", Offset = "0x2FE6FF0", Length = "0xB1")]
		[Token(Token = "0x60004BF")]
		 get { } //Length: 177
		[Address(RVA = "0x2FE96B0", Offset = "0x2FE8AB0", Length = "0xDF")]
		[Token(Token = "0x60004C0")]
		 set { } //Length: 223
	}

	[Token(Token = "0x170000D7")]
	public ReflectionProbeRefreshMode refreshMode
	{
		[Address(RVA = "0x2FE7CF0", Offset = "0x2FE70F0", Length = "0x97")]
		[Token(Token = "0x60004B7")]
		 get { } //Length: 151
		[Address(RVA = "0x2FE97D0", Offset = "0x2FE8BD0", Length = "0xA4")]
		[Token(Token = "0x60004B8")]
		 set { } //Length: 164
	}

	[NativeName("RenderDynamicObjects")]
	[Token(Token = "0x170000CD")]
	public bool renderDynamicObjects
	{
		[Address(RVA = "0x2FE7DD0", Offset = "0x2FE71D0", Length = "0x97")]
		[Token(Token = "0x60004A3")]
		 get { } //Length: 151
		[Address(RVA = "0x2FE98D0", Offset = "0x2FE8CD0", Length = "0xA7")]
		[Token(Token = "0x60004A4")]
		 set { } //Length: 167
	}

	[Token(Token = "0x170000CF")]
	public int resolution
	{
		[Address(RVA = "0x2FE7EB0", Offset = "0x2FE72B0", Length = "0x97")]
		[Token(Token = "0x60004A7")]
		 get { } //Length: 151
		[Address(RVA = "0x2FE99C0", Offset = "0x2FE8DC0", Length = "0xA4")]
		[Token(Token = "0x60004A8")]
		 set { } //Length: 164
	}

	[Token(Token = "0x170000CE")]
	public float shadowDistance
	{
		[Address(RVA = "0x2FE7F90", Offset = "0x2FE7390", Length = "0x97")]
		[Token(Token = "0x60004A5")]
		 get { } //Length: 151
		[Address(RVA = "0x2FE9AC0", Offset = "0x2FE8EC0", Length = "0xA7")]
		[Token(Token = "0x60004A6")]
		 set { } //Length: 167
	}

	[NativeName("BoxSize")]
	[Token(Token = "0x170000C6")]
	public Vector3 size
	{
		[Address(RVA = "0x2FE8080", Offset = "0x2FE7480", Length = "0xB1")]
		[Token(Token = "0x6000496")]
		 get { } //Length: 177
		[Address(RVA = "0x2FE9BC0", Offset = "0x2FE8FC0", Length = "0xA6")]
		[Token(Token = "0x6000497")]
		 set { } //Length: 166
	}

	[Token(Token = "0x170000DC")]
	public Texture texture
	{
		[Address(RVA = "0x2FE8280", Offset = "0x2FE7680", Length = "0xB1")]
		[Token(Token = "0x60004C1")]
		 get { } //Length: 177
	}

	[Token(Token = "0x170000DD")]
	public Vector4 textureHDRDecodeValues
	{
		[Address(RVA = "0x2FE8190", Offset = "0x2FE7590", Length = "0xAF")]
		[NativeName("CalculateHDRDecodeValues")]
		[Token(Token = "0x60004C2")]
		 get { } //Length: 175
	}

	[Token(Token = "0x170000D8")]
	public ReflectionProbeTimeSlicingMode timeSlicingMode
	{
		[Address(RVA = "0x2FE8380", Offset = "0x2FE7780", Length = "0x97")]
		[Token(Token = "0x60004B9")]
		 get { } //Length: 151
		[Address(RVA = "0x2FE9CB0", Offset = "0x2FE90B0", Length = "0xA4")]
		[Token(Token = "0x60004BA")]
		 set { } //Length: 164
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[NativeName("ProbeType")]
	[Obsolete("type property has been deprecated. Starting with Unity 5.4, the only supported reflection probe type is Cube.", True)]
	[Token(Token = "0x170000C5")]
	public ReflectionProbeType type
	{
		[Address(RVA = "0x2FE8460", Offset = "0x2FE7860", Length = "0x97")]
		[Token(Token = "0x6000494")]
		 get { } //Length: 151
		[Address(RVA = "0x2FE9DA0", Offset = "0x2FE91A0", Length = "0xA4")]
		[Token(Token = "0x6000495")]
		 set { } //Length: 164
	}

	[Address(RVA = "0x2FE6600", Offset = "0x2FE5A00", Length = "0xEB")]
	[Token(Token = "0x60004D7")]
	private static ReflectionProbe() { }

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60004D6")]
	public ReflectionProbe() { }

	[Address(RVA = "0x2FE66F0", Offset = "0x2FE5AF0", Length = "0x1CB")]
	[Token(Token = "0x60004D1")]
	public static void add_defaultReflectionSet(Action<Cubemap> value) { }

	[Address(RVA = "0x2FE68C0", Offset = "0x2FE5CC0", Length = "0x234")]
	[Token(Token = "0x60004D3")]
	public static void add_defaultReflectionTexture(Action<Texture> value) { }

	[Address(RVA = "0x2FE6B00", Offset = "0x2FE5F00", Length = "0x101")]
	[CompilerGenerated]
	[Token(Token = "0x60004CE")]
	public static void add_reflectionProbeChanged(Action<ReflectionProbe, ReflectionProbeEvent> value) { }

	[Address(RVA = "0x2FE5D00", Offset = "0x2FE5100", Length = "0x11F")]
	[FreeFunction("CubemapGPUBlend")]
	[NativeHeader("Runtime/Camera/CubemapGPUUtility.h")]
	[Token(Token = "0x60004C8")]
	public static bool BlendCubemap(Texture src, Texture dst, float blend, RenderTexture target) { }

	[Address(RVA = "0x2FE5C90", Offset = "0x2FE5090", Length = "0x62")]
	[Token(Token = "0x600050A")]
	private static bool BlendCubemap_Injected(IntPtr src, IntPtr dst, float blend, IntPtr target) { }

	[Address(RVA = "0x2FE5E20", Offset = "0x2FE5220", Length = "0x78")]
	[RequiredByNativeCode]
	[Token(Token = "0x60004D0")]
	private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbeEvent probeEvent) { }

	[Address(RVA = "0x2FE5EA0", Offset = "0x2FE52A0", Length = "0x15A")]
	[RequiredByNativeCode]
	[Token(Token = "0x60004D5")]
	private static void CallSetDefaultReflection(Texture defaultReflectionCubemap) { }

	[Address(RVA = "0x2FE6C60", Offset = "0x2FE6060", Length = "0xAF")]
	[Token(Token = "0x60004AD")]
	public Color get_backgroundColor() { }

	[Address(RVA = "0x2FE6C10", Offset = "0x2FE6010", Length = "0x42")]
	[Token(Token = "0x60004F1")]
	private static void get_backgroundColor_Injected(IntPtr _unity_self, out Color ret) { }

	[Address(RVA = "0x2FE6D50", Offset = "0x2FE6150", Length = "0xB1")]
	[Token(Token = "0x60004BB")]
	public Texture get_bakedTexture() { }

	[Address(RVA = "0x2FE6D10", Offset = "0x2FE6110", Length = "0x33")]
	[Token(Token = "0x60004FF")]
	private static IntPtr get_bakedTexture_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FE6E50", Offset = "0x2FE6250", Length = "0x97")]
	[Token(Token = "0x60004AF")]
	public float get_blendDistance() { }

	[Address(RVA = "0x2FE6E10", Offset = "0x2FE6210", Length = "0x33")]
	[Token(Token = "0x60004F3")]
	private static float get_blendDistance_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FE6F40", Offset = "0x2FE6340", Length = "0xB5")]
	[Token(Token = "0x60004A0")]
	public Bounds get_bounds() { }

	[Address(RVA = "0x2FE6EF0", Offset = "0x2FE62F0", Length = "0x42")]
	[Token(Token = "0x60004E4")]
	private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	[Address(RVA = "0x2FE7040", Offset = "0x2FE6440", Length = "0x97")]
	[Token(Token = "0x60004B1")]
	public bool get_boxProjection() { }

	[Address(RVA = "0x2FE7000", Offset = "0x2FE6400", Length = "0x33")]
	[Token(Token = "0x60004F5")]
	private static bool get_boxProjection_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FE7130", Offset = "0x2FE6530", Length = "0xB1")]
	[Token(Token = "0x6000498")]
	public Vector3 get_center() { }

	[Address(RVA = "0x2FE70E0", Offset = "0x2FE64E0", Length = "0x42")]
	[Token(Token = "0x60004DC")]
	private static void get_center_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x2FE7230", Offset = "0x2FE6630", Length = "0x97")]
	[Token(Token = "0x60004AB")]
	public ReflectionProbeClearFlags get_clearFlags() { }

	[Address(RVA = "0x2FE71F0", Offset = "0x2FE65F0", Length = "0x33")]
	[Token(Token = "0x60004EF")]
	private static ReflectionProbeClearFlags get_clearFlags_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FE7310", Offset = "0x2FE6710", Length = "0x97")]
	[Token(Token = "0x60004A9")]
	public int get_cullingMask() { }

	[Address(RVA = "0x2FE72D0", Offset = "0x2FE66D0", Length = "0x33")]
	[Token(Token = "0x60004ED")]
	private static int get_cullingMask_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FE73F0", Offset = "0x2FE67F0", Length = "0xB1")]
	[Token(Token = "0x60004BD")]
	public Texture get_customBakedTexture() { }

	[Address(RVA = "0x2FE73B0", Offset = "0x2FE67B0", Length = "0x33")]
	[Token(Token = "0x6000501")]
	private static IntPtr get_customBakedTexture_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FE7590", Offset = "0x2FE6990", Length = "0x75")]
	[Token(Token = "0x60004CD")]
	public static Texture get_defaultTexture() { }

	[Address(RVA = "0x2FE7560", Offset = "0x2FE6960", Length = "0x2A")]
	[Token(Token = "0x600050C")]
	private static IntPtr get_defaultTexture_Injected() { }

	[Address(RVA = "0x2FE74F0", Offset = "0x2FE68F0", Length = "0x6D")]
	[Token(Token = "0x60004CC")]
	public static Vector4 get_defaultTextureHDRDecodeValues() { }

	[Address(RVA = "0x2FE74B0", Offset = "0x2FE68B0", Length = "0x33")]
	[Token(Token = "0x600050B")]
	private static void get_defaultTextureHDRDecodeValues_Injected(out Vector4 ret) { }

	[Address(RVA = "0x2FE7650", Offset = "0x2FE6A50", Length = "0x97")]
	[Token(Token = "0x600049C")]
	public float get_farClipPlane() { }

	[Address(RVA = "0x2FE7610", Offset = "0x2FE6A10", Length = "0x33")]
	[Token(Token = "0x60004E0")]
	private static float get_farClipPlane_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FE7730", Offset = "0x2FE6B30", Length = "0x97")]
	[Token(Token = "0x60004A1")]
	public bool get_hdr() { }

	[Address(RVA = "0x2FE76F0", Offset = "0x2FE6AF0", Length = "0x33")]
	[Token(Token = "0x60004E5")]
	private static bool get_hdr_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FE7810", Offset = "0x2FE6C10", Length = "0x97")]
	[Token(Token = "0x60004B5")]
	public int get_importance() { }

	[Address(RVA = "0x2FE77D0", Offset = "0x2FE6BD0", Length = "0x33")]
	[Token(Token = "0x60004F9")]
	private static int get_importance_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FE78F0", Offset = "0x2FE6CF0", Length = "0x97")]
	[Token(Token = "0x600049E")]
	public float get_intensity() { }

	[Address(RVA = "0x2FE78B0", Offset = "0x2FE6CB0", Length = "0x33")]
	[Token(Token = "0x60004E2")]
	private static float get_intensity_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FE7990", Offset = "0x2FE6D90", Length = "0x2A")]
	[Token(Token = "0x60004CB")]
	public static int get_maxBakedCubemapResolution() { }

	[Address(RVA = "0x2FE79C0", Offset = "0x2FE6DC0", Length = "0x2A")]
	[Token(Token = "0x60004CA")]
	public static int get_minBakedCubemapResolution() { }

	[Address(RVA = "0x2FE7A30", Offset = "0x2FE6E30", Length = "0x97")]
	[Token(Token = "0x60004B3")]
	public ReflectionProbeMode get_mode() { }

	[Address(RVA = "0x2FE79F0", Offset = "0x2FE6DF0", Length = "0x33")]
	[Token(Token = "0x60004F7")]
	private static ReflectionProbeMode get_mode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FE7B10", Offset = "0x2FE6F10", Length = "0x97")]
	[Token(Token = "0x600049A")]
	public float get_nearClipPlane() { }

	[Address(RVA = "0x2FE7AD0", Offset = "0x2FE6ED0", Length = "0x33")]
	[Token(Token = "0x60004DE")]
	private static float get_nearClipPlane_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FE7BF0", Offset = "0x2FE6FF0", Length = "0xB1")]
	[Token(Token = "0x60004BF")]
	public RenderTexture get_realtimeTexture() { }

	[Address(RVA = "0x2FE7BB0", Offset = "0x2FE6FB0", Length = "0x33")]
	[Token(Token = "0x6000503")]
	private static IntPtr get_realtimeTexture_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FE7CF0", Offset = "0x2FE70F0", Length = "0x97")]
	[Token(Token = "0x60004B7")]
	public ReflectionProbeRefreshMode get_refreshMode() { }

	[Address(RVA = "0x2FE7CB0", Offset = "0x2FE70B0", Length = "0x33")]
	[Token(Token = "0x60004FB")]
	private static ReflectionProbeRefreshMode get_refreshMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FE7DD0", Offset = "0x2FE71D0", Length = "0x97")]
	[Token(Token = "0x60004A3")]
	public bool get_renderDynamicObjects() { }

	[Address(RVA = "0x2FE7D90", Offset = "0x2FE7190", Length = "0x33")]
	[Token(Token = "0x60004E7")]
	private static bool get_renderDynamicObjects_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FE7EB0", Offset = "0x2FE72B0", Length = "0x97")]
	[Token(Token = "0x60004A7")]
	public int get_resolution() { }

	[Address(RVA = "0x2FE7E70", Offset = "0x2FE7270", Length = "0x33")]
	[Token(Token = "0x60004EB")]
	private static int get_resolution_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FE7F90", Offset = "0x2FE7390", Length = "0x97")]
	[Token(Token = "0x60004A5")]
	public float get_shadowDistance() { }

	[Address(RVA = "0x2FE7F50", Offset = "0x2FE7350", Length = "0x33")]
	[Token(Token = "0x60004E9")]
	private static float get_shadowDistance_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FE8080", Offset = "0x2FE7480", Length = "0xB1")]
	[Token(Token = "0x6000496")]
	public Vector3 get_size() { }

	[Address(RVA = "0x2FE8030", Offset = "0x2FE7430", Length = "0x42")]
	[Token(Token = "0x60004DA")]
	private static void get_size_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x2FE8280", Offset = "0x2FE7680", Length = "0xB1")]
	[Token(Token = "0x60004C1")]
	public Texture get_texture() { }

	[Address(RVA = "0x2FE8240", Offset = "0x2FE7640", Length = "0x33")]
	[Token(Token = "0x6000505")]
	private static IntPtr get_texture_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FE8190", Offset = "0x2FE7590", Length = "0xAF")]
	[NativeName("CalculateHDRDecodeValues")]
	[Token(Token = "0x60004C2")]
	public Vector4 get_textureHDRDecodeValues() { }

	[Address(RVA = "0x2FE8140", Offset = "0x2FE7540", Length = "0x42")]
	[Token(Token = "0x6000506")]
	private static void get_textureHDRDecodeValues_Injected(IntPtr _unity_self, out Vector4 ret) { }

	[Address(RVA = "0x2FE8380", Offset = "0x2FE7780", Length = "0x97")]
	[Token(Token = "0x60004B9")]
	public ReflectionProbeTimeSlicingMode get_timeSlicingMode() { }

	[Address(RVA = "0x2FE8340", Offset = "0x2FE7740", Length = "0x33")]
	[Token(Token = "0x60004FD")]
	private static ReflectionProbeTimeSlicingMode get_timeSlicingMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FE8460", Offset = "0x2FE7860", Length = "0x97")]
	[Token(Token = "0x6000494")]
	public ReflectionProbeType get_type() { }

	[Address(RVA = "0x2FE8420", Offset = "0x2FE7820", Length = "0x33")]
	[Token(Token = "0x60004D8")]
	private static ReflectionProbeType get_type_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FE6040", Offset = "0x2FE5440", Length = "0xA4")]
	[Token(Token = "0x60004C6")]
	public bool IsFinishedRendering(int renderId) { }

	[Address(RVA = "0x2FE6000", Offset = "0x2FE5400", Length = "0x40")]
	[Token(Token = "0x6000508")]
	private static bool IsFinishedRendering_Injected(IntPtr _unity_self, int renderId) { }

	[Address(RVA = "0x2FE8500", Offset = "0x2FE7900", Length = "0x1A9")]
	[Token(Token = "0x60004D2")]
	public static void remove_defaultReflectionSet(Action<Cubemap> value) { }

	[Address(RVA = "0x2FE86B0", Offset = "0x2FE7AB0", Length = "0x79")]
	[Token(Token = "0x60004D4")]
	public static void remove_defaultReflectionTexture(Action<Texture> value) { }

	[Address(RVA = "0x2FE8730", Offset = "0x2FE7B30", Length = "0x101")]
	[CompilerGenerated]
	[Token(Token = "0x60004CF")]
	public static void remove_reflectionProbeChanged(Action<ReflectionProbe, ReflectionProbeEvent> value) { }

	[Address(RVA = "0x2FE60F0", Offset = "0x2FE54F0", Length = "0x13F")]
	[Token(Token = "0x60004C4")]
	public int RenderProbe() { }

	[Address(RVA = "0x2FE6230", Offset = "0x2FE5630", Length = "0x165")]
	[Token(Token = "0x60004C5")]
	public int RenderProbe(RenderTexture targetTexture) { }

	[Address(RVA = "0x2FE63E0", Offset = "0x2FE57E0", Length = "0x97")]
	[Token(Token = "0x60004C3")]
	public void Reset() { }

	[Address(RVA = "0x2FE63A0", Offset = "0x2FE57A0", Length = "0x33")]
	[Token(Token = "0x6000507")]
	private static void Reset_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FE64D0", Offset = "0x2FE58D0", Length = "0xF1")]
	[Token(Token = "0x60004C7")]
	private int ScheduleRender(ReflectionProbeTimeSlicingMode timeSlicingMode, RenderTexture targetTexture) { }

	[Address(RVA = "0x2FE6480", Offset = "0x2FE5880", Length = "0x50")]
	[Token(Token = "0x6000509")]
	private static int ScheduleRender_Injected(IntPtr _unity_self, ReflectionProbeTimeSlicingMode timeSlicingMode, IntPtr targetTexture) { }

	[Address(RVA = "0x2FE8890", Offset = "0x2FE7C90", Length = "0xA6")]
	[Token(Token = "0x60004AE")]
	public void set_backgroundColor(Color value) { }

	[Address(RVA = "0x2FE8840", Offset = "0x2FE7C40", Length = "0x42")]
	[Token(Token = "0x60004F2")]
	private static void set_backgroundColor_Injected(IntPtr _unity_self, in Color value) { }

	[Address(RVA = "0x2FE8990", Offset = "0x2FE7D90", Length = "0xDF")]
	[Token(Token = "0x60004BC")]
	public void set_bakedTexture(Texture value) { }

	[Address(RVA = "0x2FE8940", Offset = "0x2FE7D40", Length = "0x42")]
	[Token(Token = "0x6000500")]
	private static void set_bakedTexture_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x2FE8AC0", Offset = "0x2FE7EC0", Length = "0xA7")]
	[Token(Token = "0x60004B0")]
	public void set_blendDistance(float value) { }

	[Address(RVA = "0x2FE8A70", Offset = "0x2FE7E70", Length = "0x43")]
	[Token(Token = "0x60004F4")]
	private static void set_blendDistance_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FE8BC0", Offset = "0x2FE7FC0", Length = "0xA7")]
	[Token(Token = "0x60004B2")]
	public void set_boxProjection(bool value) { }

	[Address(RVA = "0x2FE8B70", Offset = "0x2FE7F70", Length = "0x42")]
	[Token(Token = "0x60004F6")]
	private static void set_boxProjection_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FE8CC0", Offset = "0x2FE80C0", Length = "0xA6")]
	[Token(Token = "0x6000499")]
	public void set_center(Vector3 value) { }

	[Address(RVA = "0x2FE8C70", Offset = "0x2FE8070", Length = "0x42")]
	[Token(Token = "0x60004DD")]
	private static void set_center_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x2FE8DB0", Offset = "0x2FE81B0", Length = "0xA4")]
	[Token(Token = "0x60004AC")]
	public void set_clearFlags(ReflectionProbeClearFlags value) { }

	[Address(RVA = "0x2FE8D70", Offset = "0x2FE8170", Length = "0x40")]
	[Token(Token = "0x60004F0")]
	private static void set_clearFlags_Injected(IntPtr _unity_self, ReflectionProbeClearFlags value) { }

	[Address(RVA = "0x2FE8EA0", Offset = "0x2FE82A0", Length = "0xA4")]
	[Token(Token = "0x60004AA")]
	public void set_cullingMask(int value) { }

	[Address(RVA = "0x2FE8E60", Offset = "0x2FE8260", Length = "0x40")]
	[Token(Token = "0x60004EE")]
	private static void set_cullingMask_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x2FE8FA0", Offset = "0x2FE83A0", Length = "0xDF")]
	[Token(Token = "0x60004BE")]
	public void set_customBakedTexture(Texture value) { }

	[Address(RVA = "0x2FE8F50", Offset = "0x2FE8350", Length = "0x42")]
	[Token(Token = "0x6000502")]
	private static void set_customBakedTexture_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x2FE90D0", Offset = "0x2FE84D0", Length = "0xA7")]
	[Token(Token = "0x600049D")]
	public void set_farClipPlane(float value) { }

	[Address(RVA = "0x2FE9080", Offset = "0x2FE8480", Length = "0x43")]
	[Token(Token = "0x60004E1")]
	private static void set_farClipPlane_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FE91D0", Offset = "0x2FE85D0", Length = "0xA7")]
	[Token(Token = "0x60004A2")]
	public void set_hdr(bool value) { }

	[Address(RVA = "0x2FE9180", Offset = "0x2FE8580", Length = "0x42")]
	[Token(Token = "0x60004E6")]
	private static void set_hdr_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FE92C0", Offset = "0x2FE86C0", Length = "0xA4")]
	[Token(Token = "0x60004B6")]
	public void set_importance(int value) { }

	[Address(RVA = "0x2FE9280", Offset = "0x2FE8680", Length = "0x40")]
	[Token(Token = "0x60004FA")]
	private static void set_importance_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x2FE93C0", Offset = "0x2FE87C0", Length = "0xA7")]
	[Token(Token = "0x600049F")]
	public void set_intensity(float value) { }

	[Address(RVA = "0x2FE9370", Offset = "0x2FE8770", Length = "0x43")]
	[Token(Token = "0x60004E3")]
	private static void set_intensity_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FE94B0", Offset = "0x2FE88B0", Length = "0xA4")]
	[Token(Token = "0x60004B4")]
	public void set_mode(ReflectionProbeMode value) { }

	[Address(RVA = "0x2FE9470", Offset = "0x2FE8870", Length = "0x40")]
	[Token(Token = "0x60004F8")]
	private static void set_mode_Injected(IntPtr _unity_self, ReflectionProbeMode value) { }

	[Address(RVA = "0x2FE95B0", Offset = "0x2FE89B0", Length = "0xA7")]
	[Token(Token = "0x600049B")]
	public void set_nearClipPlane(float value) { }

	[Address(RVA = "0x2FE9560", Offset = "0x2FE8960", Length = "0x43")]
	[Token(Token = "0x60004DF")]
	private static void set_nearClipPlane_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FE96B0", Offset = "0x2FE8AB0", Length = "0xDF")]
	[Token(Token = "0x60004C0")]
	public void set_realtimeTexture(RenderTexture value) { }

	[Address(RVA = "0x2FE9660", Offset = "0x2FE8A60", Length = "0x42")]
	[Token(Token = "0x6000504")]
	private static void set_realtimeTexture_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x2FE97D0", Offset = "0x2FE8BD0", Length = "0xA4")]
	[Token(Token = "0x60004B8")]
	public void set_refreshMode(ReflectionProbeRefreshMode value) { }

	[Address(RVA = "0x2FE9790", Offset = "0x2FE8B90", Length = "0x40")]
	[Token(Token = "0x60004FC")]
	private static void set_refreshMode_Injected(IntPtr _unity_self, ReflectionProbeRefreshMode value) { }

	[Address(RVA = "0x2FE98D0", Offset = "0x2FE8CD0", Length = "0xA7")]
	[Token(Token = "0x60004A4")]
	public void set_renderDynamicObjects(bool value) { }

	[Address(RVA = "0x2FE9880", Offset = "0x2FE8C80", Length = "0x42")]
	[Token(Token = "0x60004E8")]
	private static void set_renderDynamicObjects_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FE99C0", Offset = "0x2FE8DC0", Length = "0xA4")]
	[Token(Token = "0x60004A8")]
	public void set_resolution(int value) { }

	[Address(RVA = "0x2FE9980", Offset = "0x2FE8D80", Length = "0x40")]
	[Token(Token = "0x60004EC")]
	private static void set_resolution_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x2FE9AC0", Offset = "0x2FE8EC0", Length = "0xA7")]
	[Token(Token = "0x60004A6")]
	public void set_shadowDistance(float value) { }

	[Address(RVA = "0x2FE9A70", Offset = "0x2FE8E70", Length = "0x43")]
	[Token(Token = "0x60004EA")]
	private static void set_shadowDistance_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FE9BC0", Offset = "0x2FE8FC0", Length = "0xA6")]
	[Token(Token = "0x6000497")]
	public void set_size(Vector3 value) { }

	[Address(RVA = "0x2FE9B70", Offset = "0x2FE8F70", Length = "0x42")]
	[Token(Token = "0x60004DB")]
	private static void set_size_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x2FE9CB0", Offset = "0x2FE90B0", Length = "0xA4")]
	[Token(Token = "0x60004BA")]
	public void set_timeSlicingMode(ReflectionProbeTimeSlicingMode value) { }

	[Address(RVA = "0x2FE9C70", Offset = "0x2FE9070", Length = "0x40")]
	[Token(Token = "0x60004FE")]
	private static void set_timeSlicingMode_Injected(IntPtr _unity_self, ReflectionProbeTimeSlicingMode value) { }

	[Address(RVA = "0x2FE9DA0", Offset = "0x2FE91A0", Length = "0xA4")]
	[Token(Token = "0x6000495")]
	public void set_type(ReflectionProbeType value) { }

	[Address(RVA = "0x2FE9D60", Offset = "0x2FE9160", Length = "0x40")]
	[Token(Token = "0x60004D9")]
	private static void set_type_Injected(IntPtr _unity_self, ReflectionProbeType value) { }

	[Address(RVA = "0x2FE65D0", Offset = "0x2FE59D0", Length = "0x2A")]
	[NativeMethod("UpdateSampleData")]
	[StaticAccessor("GetReflectionProbes()")]
	[Token(Token = "0x60004C9")]
	public static void UpdateCachedState() { }

}


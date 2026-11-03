namespace UnityEngine;

[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Runtime/Camera/RenderManager.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
[NativeHeader("Runtime/Misc/GameObjectUtility.h")]
[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x20000A6")]
[UsedByNativeCode]
public sealed class Camera : Behaviour
{
	[Token(Token = "0x20000AD")]
	internal sealed class CameraCallback : MulticastDelegate
	{

		[Address(RVA = "0x1FCA570", Offset = "0x1FC9970", Length = "0xB4")]
		[Token(Token = "0x6000477")]
		public CameraCallback(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6000478")]
		public override void Invoke(Camera cam) { }

	}

	[Token(Token = "0x20000A8")]
	internal enum GateFitMode : int
	{
		Vertical = 1,
		Horizontal = 2,
		Fill = 3,
		Overscan = 4,
		None = 0,
	}

	[Token(Token = "0x20000A9")]
	internal struct GateFitParameters
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001F6")]
		private GateFitMode <mode>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40001F7")]
		private float <aspect>k__BackingField; //Field offset: 0x4

		[Token(Token = "0x170000C3")]
		public float aspect
		{
			[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000476")]
			 get { } //Length: 388
		}

		[Token(Token = "0x170000C2")]
		public GateFitMode mode
		{
			[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000475")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000476")]
		public float get_aspect() { }

		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000475")]
		public GateFitMode get_mode() { }

	}

	[Token(Token = "0x20000AB")]
	internal enum MonoOrStereoscopicEye : int
	{
		Left = 0,
		Right = 1,
		Mono = 2,
	}

	[Token(Token = "0x20000A7")]
	public enum ProjectionMatrixMode : int
	{
		Explicit = 0,
		Implicit = 1,
		PhysicalPropertiesBased = 2,
	}

	[Token(Token = "0x20000AC")]
	internal enum SceneViewFilterMode : int
	{
		Off = 0,
		ShowFiltered = 1,
	}

	[Token(Token = "0x20000AA")]
	internal enum StereoscopicEye : int
	{
		Left = 0,
		Right = 1,
	}

	[Token(Token = "0x40001E4")]
	public const float kMinAperture = 0.7; //Field offset: 0x0
	[Token(Token = "0x40001E5")]
	public const float kMaxAperture = 32; //Field offset: 0x0
	[Token(Token = "0x40001E6")]
	public const int kMinBladeCount = 3; //Field offset: 0x0
	[Token(Token = "0x40001E7")]
	public const int kMaxBladeCount = 11; //Field offset: 0x0
	[Token(Token = "0x40001E9")]
	public static CameraCallback onPreCull; //Field offset: 0x0
	[Token(Token = "0x40001EA")]
	public static CameraCallback onPreRender; //Field offset: 0x8
	[Token(Token = "0x40001EB")]
	public static CameraCallback onPostRender; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001E8")]
	internal uint m_NonSerializedVersion; //Field offset: 0x18

	[Token(Token = "0x170000A9")]
	public RenderTexture activeTexture
	{
		[Address(RVA = "0x2FD6780", Offset = "0x2FD5B80", Length = "0x90")]
		[NativeName("GetCurrentTargetTexture")]
		[Token(Token = "0x600034D")]
		 get { } //Length: 144
	}

	[Token(Token = "0x17000076")]
	public RenderingPath actualRenderingPath
	{
		[Address(RVA = "0x2FD6860", Offset = "0x2FD5C60", Length = "0x76")]
		[NativeName("CalculateRenderingPath")]
		[Token(Token = "0x60002E6")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170000BD")]
	public static Camera[] allCameras
	{
		[Address(RVA = "0x2FD68E0", Offset = "0x2FD5CE0", Length = "0xB3")]
		[Token(Token = "0x6000396")]
		 get { } //Length: 179
	}

	[Token(Token = "0x170000BC")]
	public static int allCamerasCount
	{
		[Address(RVA = "0x2FD2520", Offset = "0x2FD1920", Length = "0x2A")]
		[Token(Token = "0x6000395")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000079")]
	public bool allowDynamicResolution
	{
		[Address(RVA = "0x2FD69E0", Offset = "0x2FD5DE0", Length = "0x76")]
		[Token(Token = "0x60002EC")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDA0C0", Offset = "0x2FD94C0", Length = "0x86")]
		[Token(Token = "0x60002ED")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000077")]
	public bool allowHDR
	{
		[Address(RVA = "0x2FD6AA0", Offset = "0x2FD5EA0", Length = "0x76")]
		[Token(Token = "0x60002E8")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDA1A0", Offset = "0x2FD95A0", Length = "0x86")]
		[Token(Token = "0x60002E9")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000078")]
	public bool allowMSAA
	{
		[Address(RVA = "0x2FD6B60", Offset = "0x2FD5F60", Length = "0x76")]
		[Token(Token = "0x60002EA")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDA280", Offset = "0x2FD9680", Length = "0x86")]
		[Token(Token = "0x60002EB")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700009E")]
	public float anamorphism
	{
		[Address(RVA = "0x2FD6C20", Offset = "0x2FD6020", Length = "0x76")]
		[Token(Token = "0x6000338")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDA360", Offset = "0x2FD9760", Length = "0x86")]
		[Token(Token = "0x6000339")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000098")]
	public float aperture
	{
		[Address(RVA = "0x2FD6CE0", Offset = "0x2FD60E0", Length = "0x76")]
		[Token(Token = "0x600032C")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDA440", Offset = "0x2FD9840", Length = "0x86")]
		[Token(Token = "0x600032D")]
		 set { } //Length: 134
	}

	[Token(Token = "0x170000B8")]
	public bool areVRStereoViewMatricesWithinSingleCullTolerance
	{
		[Address(RVA = "0x2FD6DA0", Offset = "0x2FD61A0", Length = "0x76")]
		[NativeName("AreVRStereoViewMatricesWithinSingleCullTolerance")]
		[Token(Token = "0x6000385")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000081")]
	public float aspect
	{
		[Address(RVA = "0x2FD6E60", Offset = "0x2FD6260", Length = "0x76")]
		[Token(Token = "0x60002FD")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDA520", Offset = "0x2FD9920", Length = "0x86")]
		[Token(Token = "0x60002FE")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000090")]
	public Color backgroundColor
	{
		[Address(RVA = "0x2FD6F30", Offset = "0x2FD6330", Length = "0x8E")]
		[Token(Token = "0x600031B")]
		 get { } //Length: 142
		[Address(RVA = "0x2FDA600", Offset = "0x2FD9A00", Length = "0x85")]
		[Token(Token = "0x600031C")]
		 set { } //Length: 133
	}

	[Token(Token = "0x1700009D")]
	public float barrelClipping
	{
		[Address(RVA = "0x2FD7000", Offset = "0x2FD6400", Length = "0x76")]
		[Token(Token = "0x6000336")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDA6E0", Offset = "0x2FD9AE0", Length = "0x86")]
		[Token(Token = "0x6000337")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700009B")]
	public int bladeCount
	{
		[Address(RVA = "0x2FD70C0", Offset = "0x2FD64C0", Length = "0x76")]
		[Token(Token = "0x6000332")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDA7B0", Offset = "0x2FD9BB0", Length = "0x83")]
		[Token(Token = "0x6000333")]
		 set { } //Length: 131
	}

	[Token(Token = "0x170000AB")]
	public Matrix4x4 cameraToWorldMatrix
	{
		[Address(RVA = "0x2FD7190", Offset = "0x2FD6590", Length = "0x9A")]
		[Token(Token = "0x6000355")]
		 get { } //Length: 154
	}

	[Token(Token = "0x17000087")]
	public CameraType cameraType
	{
		[Address(RVA = "0x2FD7270", Offset = "0x2FD6670", Length = "0x76")]
		[Token(Token = "0x6000309")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDA880", Offset = "0x2FD9C80", Length = "0x83")]
		[Token(Token = "0x600030A")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000091")]
	public CameraClearFlags clearFlags
	{
		[Address(RVA = "0x2FD7330", Offset = "0x2FD6730", Length = "0x76")]
		[Token(Token = "0x600031D")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDA950", Offset = "0x2FD9D50", Length = "0x83")]
		[Token(Token = "0x600031E")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000093")]
	public bool clearStencilAfterLightingPass
	{
		[Address(RVA = "0x2FD73F0", Offset = "0x2FD67F0", Length = "0x76")]
		[Token(Token = "0x6000321")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDAA30", Offset = "0x2FD9E30", Length = "0x86")]
		[Token(Token = "0x6000322")]
		 set { } //Length: 134
	}

	[Token(Token = "0x170000C1")]
	public int commandBufferCount
	{
		[Address(RVA = "0x2FD74B0", Offset = "0x2FD68B0", Length = "0x76")]
		[Token(Token = "0x60003AC")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000083")]
	public int cullingMask
	{
		[Address(RVA = "0x2FD7570", Offset = "0x2FD6970", Length = "0x76")]
		[Token(Token = "0x6000301")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDAB00", Offset = "0x2FD9F00", Length = "0x83")]
		[Token(Token = "0x6000302")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700008F")]
	public Matrix4x4 cullingMatrix
	{
		[Address(RVA = "0x2FD7640", Offset = "0x2FD6A40", Length = "0x9A")]
		[Token(Token = "0x6000318")]
		 get { } //Length: 154
		[Address(RVA = "0x2FDABE0", Offset = "0x2FD9FE0", Length = "0x85")]
		[Token(Token = "0x6000319")]
		 set { } //Length: 133
	}

	[Token(Token = "0x170000B2")]
	public static Camera current
	{
		[Address(RVA = "0x2FD7710", Offset = "0x2FD6B10", Length = "0x54")]
		[Token(Token = "0x600037C")]
		 get { } //Length: 84
	}

	[Token(Token = "0x170000B3")]
	private static Camera currentInternal
	{
		[Address(RVA = "0x2FD7710", Offset = "0x2FD6B10", Length = "0x54")]
		[FreeFunction("GetCurrentCameraPPtr")]
		[Token(Token = "0x600037D")]
		private get { } //Length: 84
	}

	[Token(Token = "0x1700009C")]
	public Vector2 curvature
	{
		[Address(RVA = "0x2FD77C0", Offset = "0x2FD6BC0", Length = "0x87")]
		[Token(Token = "0x6000334")]
		 get { } //Length: 135
		[Address(RVA = "0x2FDACC0", Offset = "0x2FDA0C0", Length = "0x80")]
		[Token(Token = "0x6000335")]
		 set { } //Length: 128
	}

	[Token(Token = "0x17000080")]
	public float depth
	{
		[Address(RVA = "0x2FD7950", Offset = "0x2FD6D50", Length = "0x76")]
		[Token(Token = "0x60002FB")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDAE70", Offset = "0x2FDA270", Length = "0x86")]
		[Token(Token = "0x60002FC")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000092")]
	public DepthTextureMode depthTextureMode
	{
		[Address(RVA = "0x2FD7890", Offset = "0x2FD6C90", Length = "0x76")]
		[Token(Token = "0x600031F")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDAD90", Offset = "0x2FDA190", Length = "0x83")]
		[Token(Token = "0x6000320")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000084")]
	public int eventMask
	{
		[Address(RVA = "0x2FD7A10", Offset = "0x2FD6E10", Length = "0x76")]
		[Token(Token = "0x6000303")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDAF40", Offset = "0x2FDA340", Length = "0x83")]
		[Token(Token = "0x6000304")]
		 set { } //Length: 131
	}

	[NativeProperty("Far")]
	[Token(Token = "0x17000073")]
	public float farClipPlane
	{
		[Address(RVA = "0x2FD7AD0", Offset = "0x2FD6ED0", Length = "0x76")]
		[Token(Token = "0x60002E0")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDB020", Offset = "0x2FDA420", Length = "0x86")]
		[Token(Token = "0x60002E1")]
		 set { } //Length: 134
	}

	[NativeProperty("VerticalFieldOfView")]
	[Token(Token = "0x17000074")]
	public float fieldOfView
	{
		[Address(RVA = "0x2FD7B90", Offset = "0x2FD6F90", Length = "0x76")]
		[Token(Token = "0x60002E2")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDB100", Offset = "0x2FDA500", Length = "0x86")]
		[Token(Token = "0x60002E3")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700009A")]
	public float focalLength
	{
		[Address(RVA = "0x2FD7C50", Offset = "0x2FD7050", Length = "0x76")]
		[Token(Token = "0x6000330")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDB1E0", Offset = "0x2FDA5E0", Length = "0x86")]
		[Token(Token = "0x6000331")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000099")]
	public float focusDistance
	{
		[Address(RVA = "0x2FD7D10", Offset = "0x2FD7110", Length = "0x76")]
		[Token(Token = "0x600032E")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDB2C0", Offset = "0x2FDA6C0", Length = "0x86")]
		[Token(Token = "0x600032F")]
		 set { } //Length: 134
	}

	[NativeProperty("ForceIntoRT")]
	[Token(Token = "0x1700007A")]
	public bool forceIntoRenderTexture
	{
		[Address(RVA = "0x2FD7DD0", Offset = "0x2FD71D0", Length = "0x76")]
		[Token(Token = "0x60002EE")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDB3A0", Offset = "0x2FDA7A0", Length = "0x86")]
		[Token(Token = "0x60002EF")]
		 set { } //Length: 134
	}

	[Token(Token = "0x170000A1")]
	public GateFitMode gateFit
	{
		[Address(RVA = "0x2FD7E90", Offset = "0x2FD7290", Length = "0x76")]
		[Token(Token = "0x600033E")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDB470", Offset = "0x2FDA870", Length = "0x83")]
		[Token(Token = "0x600033F")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000096")]
	public int iso
	{
		[Address(RVA = "0x2FD8010", Offset = "0x2FD7410", Length = "0x76")]
		[Token(Token = "0x6000328")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDB540", Offset = "0x2FDA940", Length = "0x83")]
		[Token(Token = "0x6000329")]
		 set { } //Length: 131
	}

	[Token(Token = "0x170000C0")]
	public bool isProcessingRenderRequest
	{
		[Address(RVA = "0x2FD7F50", Offset = "0x2FD7350", Length = "0x76")]
		[NativeMethod("IsProcessingRenderRequest")]
		[Token(Token = "0x60003A9")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700008C")]
	public Single[] layerCullDistances
	{
		[Address(RVA = "0x2FD8090", Offset = "0x2FD7490", Length = "0x9")]
		[Token(Token = "0x6000313")]
		 get { } //Length: 9
		[Address(RVA = "0x2FDB5D0", Offset = "0x2FDA9D0", Length = "0x163")]
		[Token(Token = "0x6000314")]
		 set { } //Length: 355
	}

	[Token(Token = "0x17000085")]
	public bool layerCullSpherical
	{
		[Address(RVA = "0x2FD80E0", Offset = "0x2FD74E0", Length = "0x76")]
		[Token(Token = "0x6000305")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDB820", Offset = "0x2FDAC20", Length = "0x12E")]
		[Token(Token = "0x6000306")]
		 set { } //Length: 302
	}

	[NativeProperty("LayerCullSpherical")]
	[Token(Token = "0x17000086")]
	internal bool layerCullSphericalInternal
	{
		[Address(RVA = "0x2FD80E0", Offset = "0x2FD74E0", Length = "0x76")]
		[Token(Token = "0x6000307")]
		internal get { } //Length: 118
		[Address(RVA = "0x2FDB790", Offset = "0x2FDAB90", Length = "0x86")]
		[Token(Token = "0x6000308")]
		internal set { } //Length: 134
	}

	[Token(Token = "0x170000A0")]
	public Vector2 lensShift
	{
		[Address(RVA = "0x2FD81B0", Offset = "0x2FD75B0", Length = "0x87")]
		[Token(Token = "0x600033C")]
		 get { } //Length: 135
		[Address(RVA = "0x2FDB9A0", Offset = "0x2FDADA0", Length = "0x80")]
		[Token(Token = "0x600033D")]
		 set { } //Length: 128
	}

	[Token(Token = "0x170000B1")]
	public static Camera main
	{
		[Address(RVA = "0x2FD8270", Offset = "0x2FD7670", Length = "0x54")]
		[FreeFunction("FindMainCamera")]
		[Token(Token = "0x600037B")]
		 get { } //Length: 84
	}

	[NativeProperty("Near")]
	[Token(Token = "0x17000072")]
	public float nearClipPlane
	{
		[Address(RVA = "0x2FD8310", Offset = "0x2FD7710", Length = "0x76")]
		[Token(Token = "0x60002DE")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDBA80", Offset = "0x2FDAE80", Length = "0x86")]
		[Token(Token = "0x60002DF")]
		 set { } //Length: 134
	}

	[Token(Token = "0x170000AE")]
	public Matrix4x4 nonJitteredProjectionMatrix
	{
		[Address(RVA = "0x2FD83E0", Offset = "0x2FD77E0", Length = "0x9A")]
		[Token(Token = "0x600035A")]
		 get { } //Length: 154
		[Address(RVA = "0x2FDBB60", Offset = "0x2FDAF60", Length = "0x85")]
		[Token(Token = "0x600035B")]
		 set { } //Length: 133
	}

	[Token(Token = "0x1700007D")]
	public OpaqueSortMode opaqueSortMode
	{
		[Address(RVA = "0x2FD84C0", Offset = "0x2FD78C0", Length = "0x76")]
		[Token(Token = "0x60002F4")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDBC30", Offset = "0x2FDB030", Length = "0x83")]
		[Token(Token = "0x60002F5")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700007C")]
	public bool orthographic
	{
		[Address(RVA = "0x2FD8640", Offset = "0x2FD7A40", Length = "0x76")]
		[Token(Token = "0x60002F2")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDBDF0", Offset = "0x2FDB1F0", Length = "0x86")]
		[Token(Token = "0x60002F3")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700007B")]
	public float orthographicSize
	{
		[Address(RVA = "0x2FD8580", Offset = "0x2FD7980", Length = "0x76")]
		[Token(Token = "0x60002F0")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDBD10", Offset = "0x2FDB110", Length = "0x86")]
		[Token(Token = "0x60002F1")]
		 set { } //Length: 134
	}

	[NativeConditional("UNITY_EDITOR")]
	[Token(Token = "0x17000089")]
	public ulong overrideSceneCullingMask
	{
		[Address(RVA = "0x2FD8700", Offset = "0x2FD7B00", Length = "0x76")]
		[Token(Token = "0x600030C")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDBED0", Offset = "0x2FDB2D0", Length = "0x85")]
		[Token(Token = "0x600030D")]
		 set { } //Length: 133
	}

	[Token(Token = "0x170000A5")]
	public int pixelHeight
	{
		[Address(RVA = "0x2FD87C0", Offset = "0x2FD7BC0", Length = "0x76")]
		[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = True)]
		[Token(Token = "0x6000348")]
		 get { } //Length: 118
	}

	[NativeProperty("ScreenViewportRect")]
	[Token(Token = "0x170000A3")]
	public Rect pixelRect
	{
		[Address(RVA = "0x2FD8890", Offset = "0x2FD7C90", Length = "0x8E")]
		[Token(Token = "0x6000345")]
		 get { } //Length: 142
		[Address(RVA = "0x2FDBFB0", Offset = "0x2FDB3B0", Length = "0x85")]
		[Token(Token = "0x6000346")]
		 set { } //Length: 133
	}

	[Token(Token = "0x170000A4")]
	public int pixelWidth
	{
		[Address(RVA = "0x2FD8960", Offset = "0x2FD7D60", Length = "0x76")]
		[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = True)]
		[Token(Token = "0x6000347")]
		 get { } //Length: 118
	}

	[Obsolete("PreviewCullingLayer is obsolete. Use scene culling masks instead.", False)]
	[Token(Token = "0x1700008D")]
	internal static int PreviewCullingLayer
	{
		[Address(RVA = "0x2FD6730", Offset = "0x2FD5B30", Length = "0x8")]
		[Token(Token = "0x6000315")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170000B0")]
	public Matrix4x4 previousViewProjectionMatrix
	{
		[Address(RVA = "0x2FD8A30", Offset = "0x2FD7E30", Length = "0x9A")]
		[Token(Token = "0x600035E")]
		 get { } //Length: 154
	}

	[Token(Token = "0x170000AD")]
	public Matrix4x4 projectionMatrix
	{
		[Address(RVA = "0x2FD8BE0", Offset = "0x2FD7FE0", Length = "0x9A")]
		[Token(Token = "0x6000358")]
		 get { } //Length: 154
		[Address(RVA = "0x2FDC090", Offset = "0x2FDB490", Length = "0x85")]
		[Token(Token = "0x6000359")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000094")]
	internal ProjectionMatrixMode projectionMatrixMode
	{
		[Address(RVA = "0x2FD8B10", Offset = "0x2FD7F10", Length = "0x76")]
		[Token(Token = "0x6000325")]
		internal get { } //Length: 118
	}

	[NativeProperty("NormalizedViewportRect")]
	[Token(Token = "0x170000A2")]
	public Rect rect
	{
		[Address(RVA = "0x2FD8CD0", Offset = "0x2FD80D0", Length = "0x8E")]
		[Token(Token = "0x6000343")]
		 get { } //Length: 142
		[Address(RVA = "0x2FDC170", Offset = "0x2FDB570", Length = "0x85")]
		[Token(Token = "0x6000344")]
		 set { } //Length: 133
	}

	[NativeConditional("UNITY_EDITOR")]
	[Token(Token = "0x170000BF")]
	public bool renderCloudsInSceneView
	{
		[Address(RVA = "0x2FD8DA0", Offset = "0x2FD81A0", Length = "0x76")]
		[Token(Token = "0x600039F")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDC250", Offset = "0x2FDB650", Length = "0x86")]
		[Token(Token = "0x60003A0")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000075")]
	public RenderingPath renderingPath
	{
		[Address(RVA = "0x2FD8E60", Offset = "0x2FD8260", Length = "0x76")]
		[Token(Token = "0x60002E4")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDC320", Offset = "0x2FDB720", Length = "0x83")]
		[Token(Token = "0x60002E5")]
		 set { } //Length: 131
	}

	[Token(Token = "0x170000A7")]
	public int scaledPixelHeight
	{
		[Address(RVA = "0x2FD8F20", Offset = "0x2FD8320", Length = "0x76")]
		[FreeFunction("CameraScripting::GetScaledPixelHeight", HasExplicitThis = True)]
		[Token(Token = "0x600034A")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170000A6")]
	public int scaledPixelWidth
	{
		[Address(RVA = "0x2FD8FE0", Offset = "0x2FD83E0", Length = "0x76")]
		[FreeFunction("CameraScripting::GetScaledPixelWidth", HasExplicitThis = True)]
		[Token(Token = "0x6000349")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170000B4")]
	public Scene scene
	{
		[Address(RVA = "0x2FD9170", Offset = "0x2FD8570", Length = "0x87")]
		[FreeFunction("CameraScripting::GetScene", HasExplicitThis = True)]
		[Token(Token = "0x600037E")]
		 get { } //Length: 135
		[Address(RVA = "0x2FDC400", Offset = "0x2FDB800", Length = "0x7E")]
		[FreeFunction("CameraScripting::SetScene", HasExplicitThis = True)]
		[Token(Token = "0x600037F")]
		 set { } //Length: 126
	}

	[NativeConditional("UNITY_EDITOR")]
	[Token(Token = "0x1700008A")]
	internal ulong sceneCullingMask
	{
		[Address(RVA = "0x2FD90A0", Offset = "0x2FD84A0", Length = "0x76")]
		[Token(Token = "0x600030E")]
		internal get { } //Length: 118
	}

	[NativeConditional("UNITY_EDITOR")]
	[Token(Token = "0x170000BE")]
	public SceneViewFilterMode sceneViewFilterMode
	{
		[Address(RVA = "0x2FD2AE0", Offset = "0x2FD1EE0", Length = "0x76")]
		[Token(Token = "0x600039E")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700009F")]
	public Vector2 sensorSize
	{
		[Address(RVA = "0x2FD9250", Offset = "0x2FD8650", Length = "0x87")]
		[Token(Token = "0x600033A")]
		 get { } //Length: 135
		[Address(RVA = "0x2FDC4D0", Offset = "0x2FDB8D0", Length = "0x80")]
		[Token(Token = "0x600033B")]
		 set { } //Length: 128
	}

	[Token(Token = "0x17000097")]
	public float shutterSpeed
	{
		[Address(RVA = "0x2FD9320", Offset = "0x2FD8720", Length = "0x76")]
		[Token(Token = "0x600032A")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDC5B0", Offset = "0x2FDB9B0", Length = "0x86")]
		[Token(Token = "0x600032B")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000088")]
	internal Material skyboxMaterial
	{
		[Address(RVA = "0x2FD93E0", Offset = "0x2FD87E0", Length = "0x90")]
		[Token(Token = "0x600030B")]
		internal get { } //Length: 144
	}

	[Token(Token = "0x170000BB")]
	public MonoOrStereoscopicEye stereoActiveEye
	{
		[Address(RVA = "0x2FD94C0", Offset = "0x2FD88C0", Length = "0x76")]
		[FreeFunction("CameraScripting::GetStereoActiveEye", HasExplicitThis = True)]
		[Token(Token = "0x600038A")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170000B7")]
	public float stereoConvergence
	{
		[Address(RVA = "0x2FD9580", Offset = "0x2FD8980", Length = "0x76")]
		[Token(Token = "0x6000383")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDC690", Offset = "0x2FDBA90", Length = "0x86")]
		[Token(Token = "0x6000384")]
		 set { } //Length: 134
	}

	[Token(Token = "0x170000B5")]
	public bool stereoEnabled
	{
		[Address(RVA = "0x2FD9640", Offset = "0x2FD8A40", Length = "0x76")]
		[NativeMethod("GetStereoEnabledForBuiltInOrSRP")]
		[Token(Token = "0x6000380")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170000B6")]
	public float stereoSeparation
	{
		[Address(RVA = "0x2FD9700", Offset = "0x2FD8B00", Length = "0x76")]
		[Token(Token = "0x6000381")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDC770", Offset = "0x2FDBB70", Length = "0x86")]
		[Token(Token = "0x6000382")]
		 set { } //Length: 134
	}

	[Token(Token = "0x170000B9")]
	public StereoTargetEyeMask stereoTargetEye
	{
		[Address(RVA = "0x2FD97C0", Offset = "0x2FD8BC0", Length = "0x76")]
		[Token(Token = "0x6000386")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDC8D0", Offset = "0x2FDBCD0", Length = "0x12B")]
		[Token(Token = "0x6000387")]
		 set { } //Length: 299
	}

	[NativeProperty("StereoTargetEye")]
	[Token(Token = "0x170000BA")]
	internal StereoTargetEyeMask stereoTargetEyeInternal
	{
		[Address(RVA = "0x2FD97C0", Offset = "0x2FD8BC0", Length = "0x76")]
		[Token(Token = "0x6000388")]
		internal get { } //Length: 118
		[Address(RVA = "0x2FDC840", Offset = "0x2FDBC40", Length = "0x83")]
		[Token(Token = "0x6000389")]
		internal set { } //Length: 131
	}

	[Token(Token = "0x170000AA")]
	public int targetDisplay
	{
		[Address(RVA = "0x2FD9880", Offset = "0x2FD8C80", Length = "0x76")]
		[Token(Token = "0x600034E")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDCA40", Offset = "0x2FDBE40", Length = "0x83")]
		[Token(Token = "0x600034F")]
		 set { } //Length: 131
	}

	[Token(Token = "0x170000A8")]
	public RenderTexture targetTexture
	{
		[Address(RVA = "0x2FD9940", Offset = "0x2FD8D40", Length = "0x90")]
		[Token(Token = "0x600034B")]
		 get { } //Length: 144
		[Address(RVA = "0x2FDCB20", Offset = "0x2FDBF20", Length = "0xBA")]
		[Token(Token = "0x600034C")]
		 set { } //Length: 186
	}

	[Token(Token = "0x1700007F")]
	public Vector3 transparencySortAxis
	{
		[Address(RVA = "0x2FD9A30", Offset = "0x2FD8E30", Length = "0x90")]
		[Token(Token = "0x60002F8")]
		 get { } //Length: 144
		[Address(RVA = "0x2FDCC30", Offset = "0x2FDC030", Length = "0x85")]
		[Token(Token = "0x60002F9")]
		 set { } //Length: 133
	}

	[Token(Token = "0x1700007E")]
	public TransparencySortMode transparencySortMode
	{
		[Address(RVA = "0x2FD9B10", Offset = "0x2FD8F10", Length = "0x76")]
		[Token(Token = "0x60002F6")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDCD00", Offset = "0x2FDC100", Length = "0x83")]
		[Token(Token = "0x60002F7")]
		 set { } //Length: 131
	}

	[NativeConditional("UNITY_EDITOR")]
	[Token(Token = "0x1700008B")]
	internal bool useInteractiveLightBakingData
	{
		[Address(RVA = "0x2FD9BD0", Offset = "0x2FD8FD0", Length = "0x76")]
		[Token(Token = "0x600030F")]
		internal get { } //Length: 118
		[Address(RVA = "0x2FDCDE0", Offset = "0x2FDC1E0", Length = "0x86")]
		[Token(Token = "0x6000310")]
		internal set { } //Length: 134
	}

	[NativeProperty("UseJitteredProjectionMatrixForTransparent")]
	[Token(Token = "0x170000AF")]
	public bool useJitteredProjectionMatrixForTransparentRendering
	{
		[Address(RVA = "0x2FD9C90", Offset = "0x2FD9090", Length = "0x76")]
		[Token(Token = "0x600035C")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDCEC0", Offset = "0x2FDC2C0", Length = "0x86")]
		[Token(Token = "0x600035D")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700008E")]
	public bool useOcclusionCulling
	{
		[Address(RVA = "0x2FD9D50", Offset = "0x2FD9150", Length = "0x76")]
		[Token(Token = "0x6000316")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDCFA0", Offset = "0x2FDC3A0", Length = "0x86")]
		[Token(Token = "0x6000317")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000095")]
	public bool usePhysicalProperties
	{
		[Address(RVA = "0x2FD9E10", Offset = "0x2FD9210", Length = "0x76")]
		[Token(Token = "0x6000326")]
		 get { } //Length: 118
		[Address(RVA = "0x2FDD080", Offset = "0x2FDC480", Length = "0x86")]
		[Token(Token = "0x6000327")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000082")]
	public Vector3 velocity
	{
		[Address(RVA = "0x2FD9EE0", Offset = "0x2FD92E0", Length = "0x90")]
		[Token(Token = "0x6000300")]
		 get { } //Length: 144
	}

	[Token(Token = "0x170000AC")]
	public Matrix4x4 worldToCameraMatrix
	{
		[Address(RVA = "0x2FD9FD0", Offset = "0x2FD93D0", Length = "0x9A")]
		[Token(Token = "0x6000356")]
		 get { } //Length: 154
		[Address(RVA = "0x2FDD160", Offset = "0x2FDC560", Length = "0x85")]
		[Token(Token = "0x6000357")]
		 set { } //Length: 133
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60002DD")]
	public Camera() { }

	[Address(RVA = "0x2FD19C0", Offset = "0x2FD0DC0", Length = "0x22E")]
	[Token(Token = "0x60003B4")]
	public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	[Address(RVA = "0x2FD1640", Offset = "0x2FD0A40", Length = "0x245")]
	[Token(Token = "0x60003B5")]
	public void AddCommandBufferAsync(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	[Address(RVA = "0x2FD1550", Offset = "0x2FD0950", Length = "0xE9")]
	[NativeName("AddCommandBufferAsync")]
	[Token(Token = "0x60003B2")]
	private void AddCommandBufferAsyncImpl(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	[Address(RVA = "0x2FD14F0", Offset = "0x2FD08F0", Length = "0x60")]
	[Token(Token = "0x6000471")]
	private static void AddCommandBufferAsyncImpl_Injected(IntPtr _unity_self, CameraEvent evt, IntPtr buffer, ComputeQueueType queueType) { }

	[Address(RVA = "0x2FD18E0", Offset = "0x2FD0CE0", Length = "0xD5")]
	[NativeName("AddCommandBuffer")]
	[Token(Token = "0x60003B1")]
	private void AddCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	[Address(RVA = "0x2FD1890", Offset = "0x2FD0C90", Length = "0x50")]
	[Token(Token = "0x6000470")]
	private static void AddCommandBufferImpl_Injected(IntPtr _unity_self, CameraEvent evt, IntPtr buffer) { }

	[Address(RVA = "0x2FD1BF0", Offset = "0x2FD0FF0", Length = "0x16")]
	[RequiredByNativeCode]
	[Token(Token = "0x60003BC")]
	private static void BumpNonSerializedVersion(Camera cam) { }

	[Address(RVA = "0x2FD1DF0", Offset = "0x2FD11F0", Length = "0xE9")]
	[Token(Token = "0x6000374")]
	public void CalculateFrustumCorners(Rect viewport, float z, MonoOrStereoscopicEye eye, Vector3[] outCorners) { }

	[Address(RVA = "0x2FD1C80", Offset = "0x2FD1080", Length = "0x160")]
	[FreeFunction("CameraScripting::CalculateViewportRayVectors", HasExplicitThis = True)]
	[Token(Token = "0x6000373")]
	private void CalculateFrustumCornersInternal(Rect viewport, float z, MonoOrStereoscopicEye eye, out Vector3[] outCorners) { }

	[Address(RVA = "0x2FD1C10", Offset = "0x2FD1010", Length = "0x62")]
	[Token(Token = "0x6000448")]
	private static void CalculateFrustumCornersInternal_Injected(IntPtr _unity_self, in Rect viewport, float z, MonoOrStereoscopicEye eye, out BlittableArrayWrapper outCorners) { }

	[Address(RVA = "0x2FD1F40", Offset = "0x2FD1340", Length = "0xAA")]
	[FreeFunction("CameraScripting::CalculateObliqueMatrix", HasExplicitThis = True)]
	[Token(Token = "0x6000361")]
	public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane) { }

	[Address(RVA = "0x2FD1EE0", Offset = "0x2FD12E0", Length = "0x52")]
	[Token(Token = "0x600043E")]
	private static void CalculateObliqueMatrix_Injected(IntPtr _unity_self, in Vector4 clipPlane, out Matrix4x4 ret) { }

	[Address(RVA = "0x2FD20F0", Offset = "0x2FD14F0", Length = "0x8F")]
	[Token(Token = "0x6000376")]
	public static void CalculateProjectionMatrixFromPhysicalProperties(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, GateFitParameters gateFitParameters = null) { }

	[Address(RVA = "0x2FD2060", Offset = "0x2FD1460", Length = "0x8F")]
	[NativeName("CalculateProjectionMatrixFromPhysicalProperties")]
	[Token(Token = "0x6000375")]
	private static void CalculateProjectionMatrixFromPhysicalPropertiesInternal(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, float gateAspect, GateFitMode gateFitMode) { }

	[Address(RVA = "0x2FD1FF0", Offset = "0x2FD13F0", Length = "0x62")]
	[Token(Token = "0x6000449")]
	private static void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(out Matrix4x4 output, float focalLength, in Vector2 sensorSize, in Vector2 lensShift, float nearClip, float farClip, float gateAspect, GateFitMode gateFitMode) { }

	[Address(RVA = "0x2FD21D0", Offset = "0x2FD15D0", Length = "0xBA")]
	[FreeFunction("CameraScripting::CopyFrom", HasExplicitThis = True)]
	[Token(Token = "0x60003AB")]
	public void CopyFrom(Camera other) { }

	[Address(RVA = "0x2FD2180", Offset = "0x2FD1580", Length = "0x42")]
	[Token(Token = "0x600046C")]
	private static void CopyFrom_Injected(IntPtr _unity_self, IntPtr other) { }

	[Address(RVA = "0x2FD22D0", Offset = "0x2FD16D0", Length = "0x83")]
	[Token(Token = "0x600038D")]
	public void CopyStereoDeviceProjectionMatrixToNonJittered(StereoscopicEye eye) { }

	[Address(RVA = "0x2FD2290", Offset = "0x2FD1690", Length = "0x40")]
	[Token(Token = "0x6000459")]
	private static void CopyStereoDeviceProjectionMatrixToNonJittered_Injected(IntPtr _unity_self, StereoscopicEye eye) { }

	[Address(RVA = "0x2FD2360", Offset = "0x2FD1760", Length = "0x4A")]
	[NativeName("FieldOfViewToFocalLength_Safe")]
	[Token(Token = "0x6000378")]
	public static float FieldOfViewToFocalLength(float fieldOfView, float sensorSize) { }

	[Address(RVA = "0x2FD23B0", Offset = "0x2FD17B0", Length = "0x5B")]
	[RequiredByNativeCode]
	[Token(Token = "0x60003BB")]
	private static void FireOnPostRender(Camera cam) { }

	[Address(RVA = "0x2FD2410", Offset = "0x2FD1810", Length = "0x59")]
	[RequiredByNativeCode]
	[Token(Token = "0x60003B9")]
	private static void FireOnPreCull(Camera cam) { }

	[Address(RVA = "0x2FD2470", Offset = "0x2FD1870", Length = "0x5B")]
	[RequiredByNativeCode]
	[Token(Token = "0x60003BA")]
	private static void FireOnPreRender(Camera cam) { }

	[Address(RVA = "0x2FD24D0", Offset = "0x2FD18D0", Length = "0x4A")]
	[NativeName("FocalLengthToFieldOfView_Safe")]
	[Token(Token = "0x6000377")]
	public static float FocalLengthToFieldOfView(float focalLength, float sensorSize) { }

	[Address(RVA = "0x2FD6780", Offset = "0x2FD5B80", Length = "0x90")]
	[NativeName("GetCurrentTargetTexture")]
	[Token(Token = "0x600034D")]
	public RenderTexture get_activeTexture() { }

	[Address(RVA = "0x2FD6740", Offset = "0x2FD5B40", Length = "0x33")]
	[Token(Token = "0x600042C")]
	private static IntPtr get_activeTexture_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD6860", Offset = "0x2FD5C60", Length = "0x76")]
	[NativeName("CalculateRenderingPath")]
	[Token(Token = "0x60002E6")]
	public RenderingPath get_actualRenderingPath() { }

	[Address(RVA = "0x2FD6820", Offset = "0x2FD5C20", Length = "0x33")]
	[Token(Token = "0x60003CA")]
	private static RenderingPath get_actualRenderingPath_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD68E0", Offset = "0x2FD5CE0", Length = "0xB3")]
	[Token(Token = "0x6000396")]
	public static Camera[] get_allCameras() { }

	[Address(RVA = "0x2FD2520", Offset = "0x2FD1920", Length = "0x2A")]
	[Token(Token = "0x6000395")]
	public static int get_allCamerasCount() { }

	[Address(RVA = "0x2FD69E0", Offset = "0x2FD5DE0", Length = "0x76")]
	[Token(Token = "0x60002EC")]
	public bool get_allowDynamicResolution() { }

	[Address(RVA = "0x2FD69A0", Offset = "0x2FD5DA0", Length = "0x33")]
	[Token(Token = "0x60003D0")]
	private static bool get_allowDynamicResolution_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD6AA0", Offset = "0x2FD5EA0", Length = "0x76")]
	[Token(Token = "0x60002E8")]
	public bool get_allowHDR() { }

	[Address(RVA = "0x2FD6A60", Offset = "0x2FD5E60", Length = "0x33")]
	[Token(Token = "0x60003CC")]
	private static bool get_allowHDR_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD6B60", Offset = "0x2FD5F60", Length = "0x76")]
	[Token(Token = "0x60002EA")]
	public bool get_allowMSAA() { }

	[Address(RVA = "0x2FD6B20", Offset = "0x2FD5F20", Length = "0x33")]
	[Token(Token = "0x60003CE")]
	private static bool get_allowMSAA_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD6C20", Offset = "0x2FD6020", Length = "0x76")]
	[Token(Token = "0x6000338")]
	public float get_anamorphism() { }

	[Address(RVA = "0x2FD6BE0", Offset = "0x2FD5FE0", Length = "0x33")]
	[Token(Token = "0x6000417")]
	private static float get_anamorphism_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD6CE0", Offset = "0x2FD60E0", Length = "0x76")]
	[Token(Token = "0x600032C")]
	public float get_aperture() { }

	[Address(RVA = "0x2FD6CA0", Offset = "0x2FD60A0", Length = "0x33")]
	[Token(Token = "0x600040B")]
	private static float get_aperture_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD6DA0", Offset = "0x2FD61A0", Length = "0x76")]
	[NativeName("AreVRStereoViewMatricesWithinSingleCullTolerance")]
	[Token(Token = "0x6000385")]
	public bool get_areVRStereoViewMatricesWithinSingleCullTolerance() { }

	[Address(RVA = "0x2FD6D60", Offset = "0x2FD6160", Length = "0x33")]
	[Token(Token = "0x6000453")]
	private static bool get_areVRStereoViewMatricesWithinSingleCullTolerance_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD6E60", Offset = "0x2FD6260", Length = "0x76")]
	[Token(Token = "0x60002FD")]
	public float get_aspect() { }

	[Address(RVA = "0x2FD6E20", Offset = "0x2FD6220", Length = "0x33")]
	[Token(Token = "0x60003E1")]
	private static float get_aspect_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD6F30", Offset = "0x2FD6330", Length = "0x8E")]
	[Token(Token = "0x600031B")]
	public Color get_backgroundColor() { }

	[Address(RVA = "0x2FD6EE0", Offset = "0x2FD62E0", Length = "0x42")]
	[Token(Token = "0x60003FA")]
	private static void get_backgroundColor_Injected(IntPtr _unity_self, out Color ret) { }

	[Address(RVA = "0x2FD7000", Offset = "0x2FD6400", Length = "0x76")]
	[Token(Token = "0x6000336")]
	public float get_barrelClipping() { }

	[Address(RVA = "0x2FD6FC0", Offset = "0x2FD63C0", Length = "0x33")]
	[Token(Token = "0x6000415")]
	private static float get_barrelClipping_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD70C0", Offset = "0x2FD64C0", Length = "0x76")]
	[Token(Token = "0x6000332")]
	public int get_bladeCount() { }

	[Address(RVA = "0x2FD7080", Offset = "0x2FD6480", Length = "0x33")]
	[Token(Token = "0x6000411")]
	private static int get_bladeCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD7190", Offset = "0x2FD6590", Length = "0x9A")]
	[Token(Token = "0x6000355")]
	public Matrix4x4 get_cameraToWorldMatrix() { }

	[Address(RVA = "0x2FD7140", Offset = "0x2FD6540", Length = "0x42")]
	[Token(Token = "0x6000432")]
	private static void get_cameraToWorldMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	[Address(RVA = "0x2FD7270", Offset = "0x2FD6670", Length = "0x76")]
	[Token(Token = "0x6000309")]
	public CameraType get_cameraType() { }

	[Address(RVA = "0x2FD7230", Offset = "0x2FD6630", Length = "0x33")]
	[Token(Token = "0x60003EB")]
	private static CameraType get_cameraType_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD7330", Offset = "0x2FD6730", Length = "0x76")]
	[Token(Token = "0x600031D")]
	public CameraClearFlags get_clearFlags() { }

	[Address(RVA = "0x2FD72F0", Offset = "0x2FD66F0", Length = "0x33")]
	[Token(Token = "0x60003FC")]
	private static CameraClearFlags get_clearFlags_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD73F0", Offset = "0x2FD67F0", Length = "0x76")]
	[Token(Token = "0x6000321")]
	public bool get_clearStencilAfterLightingPass() { }

	[Address(RVA = "0x2FD73B0", Offset = "0x2FD67B0", Length = "0x33")]
	[Token(Token = "0x6000400")]
	private static bool get_clearStencilAfterLightingPass_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD74B0", Offset = "0x2FD68B0", Length = "0x76")]
	[Token(Token = "0x60003AC")]
	public int get_commandBufferCount() { }

	[Address(RVA = "0x2FD7470", Offset = "0x2FD6870", Length = "0x33")]
	[Token(Token = "0x600046D")]
	private static int get_commandBufferCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD7570", Offset = "0x2FD6970", Length = "0x76")]
	[Token(Token = "0x6000301")]
	public int get_cullingMask() { }

	[Address(RVA = "0x2FD7530", Offset = "0x2FD6930", Length = "0x33")]
	[Token(Token = "0x60003E5")]
	private static int get_cullingMask_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD7640", Offset = "0x2FD6A40", Length = "0x9A")]
	[Token(Token = "0x6000318")]
	public Matrix4x4 get_cullingMatrix() { }

	[Address(RVA = "0x2FD75F0", Offset = "0x2FD69F0", Length = "0x42")]
	[Token(Token = "0x60003F7")]
	private static void get_cullingMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	[Address(RVA = "0x2FD7710", Offset = "0x2FD6B10", Length = "0x54")]
	[Token(Token = "0x600037C")]
	public static Camera get_current() { }

	[Address(RVA = "0x2FD7710", Offset = "0x2FD6B10", Length = "0x54")]
	[FreeFunction("GetCurrentCameraPPtr")]
	[Token(Token = "0x600037D")]
	private static Camera get_currentInternal() { }

	[Address(RVA = "0x2FD76E0", Offset = "0x2FD6AE0", Length = "0x2A")]
	[Token(Token = "0x600044B")]
	private static IntPtr get_currentInternal_Injected() { }

	[Address(RVA = "0x2FD77C0", Offset = "0x2FD6BC0", Length = "0x87")]
	[Token(Token = "0x6000334")]
	public Vector2 get_curvature() { }

	[Address(RVA = "0x2FD7770", Offset = "0x2FD6B70", Length = "0x42")]
	[Token(Token = "0x6000413")]
	private static void get_curvature_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x2FD7950", Offset = "0x2FD6D50", Length = "0x76")]
	[Token(Token = "0x60002FB")]
	public float get_depth() { }

	[Address(RVA = "0x2FD7910", Offset = "0x2FD6D10", Length = "0x33")]
	[Token(Token = "0x60003DF")]
	private static float get_depth_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD7890", Offset = "0x2FD6C90", Length = "0x76")]
	[Token(Token = "0x600031F")]
	public DepthTextureMode get_depthTextureMode() { }

	[Address(RVA = "0x2FD7850", Offset = "0x2FD6C50", Length = "0x33")]
	[Token(Token = "0x60003FE")]
	private static DepthTextureMode get_depthTextureMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD7A10", Offset = "0x2FD6E10", Length = "0x76")]
	[Token(Token = "0x6000303")]
	public int get_eventMask() { }

	[Address(RVA = "0x2FD79D0", Offset = "0x2FD6DD0", Length = "0x33")]
	[Token(Token = "0x60003E7")]
	private static int get_eventMask_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD7AD0", Offset = "0x2FD6ED0", Length = "0x76")]
	[Token(Token = "0x60002E0")]
	public float get_farClipPlane() { }

	[Address(RVA = "0x2FD7A90", Offset = "0x2FD6E90", Length = "0x33")]
	[Token(Token = "0x60003C4")]
	private static float get_farClipPlane_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD7B90", Offset = "0x2FD6F90", Length = "0x76")]
	[Token(Token = "0x60002E2")]
	public float get_fieldOfView() { }

	[Address(RVA = "0x2FD7B50", Offset = "0x2FD6F50", Length = "0x33")]
	[Token(Token = "0x60003C6")]
	private static float get_fieldOfView_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD7C50", Offset = "0x2FD7050", Length = "0x76")]
	[Token(Token = "0x6000330")]
	public float get_focalLength() { }

	[Address(RVA = "0x2FD7C10", Offset = "0x2FD7010", Length = "0x33")]
	[Token(Token = "0x600040F")]
	private static float get_focalLength_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD7D10", Offset = "0x2FD7110", Length = "0x76")]
	[Token(Token = "0x600032E")]
	public float get_focusDistance() { }

	[Address(RVA = "0x2FD7CD0", Offset = "0x2FD70D0", Length = "0x33")]
	[Token(Token = "0x600040D")]
	private static float get_focusDistance_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD7DD0", Offset = "0x2FD71D0", Length = "0x76")]
	[Token(Token = "0x60002EE")]
	public bool get_forceIntoRenderTexture() { }

	[Address(RVA = "0x2FD7D90", Offset = "0x2FD7190", Length = "0x33")]
	[Token(Token = "0x60003D2")]
	private static bool get_forceIntoRenderTexture_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD7E90", Offset = "0x2FD7290", Length = "0x76")]
	[Token(Token = "0x600033E")]
	public GateFitMode get_gateFit() { }

	[Address(RVA = "0x2FD7E50", Offset = "0x2FD7250", Length = "0x33")]
	[Token(Token = "0x600041D")]
	private static GateFitMode get_gateFit_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD8010", Offset = "0x2FD7410", Length = "0x76")]
	[Token(Token = "0x6000328")]
	public int get_iso() { }

	[Address(RVA = "0x2FD7FD0", Offset = "0x2FD73D0", Length = "0x33")]
	[Token(Token = "0x6000407")]
	private static int get_iso_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD7F50", Offset = "0x2FD7350", Length = "0x76")]
	[NativeMethod("IsProcessingRenderRequest")]
	[Token(Token = "0x60003A9")]
	public bool get_isProcessingRenderRequest() { }

	[Address(RVA = "0x2FD7F10", Offset = "0x2FD7310", Length = "0x33")]
	[Token(Token = "0x600046A")]
	private static bool get_isProcessingRenderRequest_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD8090", Offset = "0x2FD7490", Length = "0x9")]
	[Token(Token = "0x6000313")]
	public Single[] get_layerCullDistances() { }

	[Address(RVA = "0x2FD80E0", Offset = "0x2FD74E0", Length = "0x76")]
	[Token(Token = "0x6000305")]
	public bool get_layerCullSpherical() { }

	[Address(RVA = "0x2FD80E0", Offset = "0x2FD74E0", Length = "0x76")]
	[Token(Token = "0x6000307")]
	internal bool get_layerCullSphericalInternal() { }

	[Address(RVA = "0x2FD80A0", Offset = "0x2FD74A0", Length = "0x33")]
	[Token(Token = "0x60003E9")]
	private static bool get_layerCullSphericalInternal_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD81B0", Offset = "0x2FD75B0", Length = "0x87")]
	[Token(Token = "0x600033C")]
	public Vector2 get_lensShift() { }

	[Address(RVA = "0x2FD8160", Offset = "0x2FD7560", Length = "0x42")]
	[Token(Token = "0x600041B")]
	private static void get_lensShift_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x2FD8270", Offset = "0x2FD7670", Length = "0x54")]
	[FreeFunction("FindMainCamera")]
	[Token(Token = "0x600037B")]
	public static Camera get_main() { }

	[Address(RVA = "0x2FD8240", Offset = "0x2FD7640", Length = "0x2A")]
	[Token(Token = "0x600044A")]
	private static IntPtr get_main_Injected() { }

	[Address(RVA = "0x2FD8310", Offset = "0x2FD7710", Length = "0x76")]
	[Token(Token = "0x60002DE")]
	public float get_nearClipPlane() { }

	[Address(RVA = "0x2FD82D0", Offset = "0x2FD76D0", Length = "0x33")]
	[Token(Token = "0x60003C2")]
	private static float get_nearClipPlane_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD83E0", Offset = "0x2FD77E0", Length = "0x9A")]
	[Token(Token = "0x600035A")]
	public Matrix4x4 get_nonJitteredProjectionMatrix() { }

	[Address(RVA = "0x2FD8390", Offset = "0x2FD7790", Length = "0x42")]
	[Token(Token = "0x6000437")]
	private static void get_nonJitteredProjectionMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	[Address(RVA = "0x2FD84C0", Offset = "0x2FD78C0", Length = "0x76")]
	[Token(Token = "0x60002F4")]
	public OpaqueSortMode get_opaqueSortMode() { }

	[Address(RVA = "0x2FD8480", Offset = "0x2FD7880", Length = "0x33")]
	[Token(Token = "0x60003D8")]
	private static OpaqueSortMode get_opaqueSortMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD8640", Offset = "0x2FD7A40", Length = "0x76")]
	[Token(Token = "0x60002F2")]
	public bool get_orthographic() { }

	[Address(RVA = "0x2FD8600", Offset = "0x2FD7A00", Length = "0x33")]
	[Token(Token = "0x60003D6")]
	private static bool get_orthographic_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD8580", Offset = "0x2FD7980", Length = "0x76")]
	[Token(Token = "0x60002F0")]
	public float get_orthographicSize() { }

	[Address(RVA = "0x2FD8540", Offset = "0x2FD7940", Length = "0x33")]
	[Token(Token = "0x60003D4")]
	private static float get_orthographicSize_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD8700", Offset = "0x2FD7B00", Length = "0x76")]
	[Token(Token = "0x600030C")]
	public ulong get_overrideSceneCullingMask() { }

	[Address(RVA = "0x2FD86C0", Offset = "0x2FD7AC0", Length = "0x33")]
	[Token(Token = "0x60003EE")]
	private static ulong get_overrideSceneCullingMask_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD87C0", Offset = "0x2FD7BC0", Length = "0x76")]
	[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = True)]
	[Token(Token = "0x6000348")]
	public int get_pixelHeight() { }

	[Address(RVA = "0x2FD8780", Offset = "0x2FD7B80", Length = "0x33")]
	[Token(Token = "0x6000427")]
	private static int get_pixelHeight_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD8890", Offset = "0x2FD7C90", Length = "0x8E")]
	[Token(Token = "0x6000345")]
	public Rect get_pixelRect() { }

	[Address(RVA = "0x2FD8840", Offset = "0x2FD7C40", Length = "0x42")]
	[Token(Token = "0x6000424")]
	private static void get_pixelRect_Injected(IntPtr _unity_self, out Rect ret) { }

	[Address(RVA = "0x2FD8960", Offset = "0x2FD7D60", Length = "0x76")]
	[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = True)]
	[Token(Token = "0x6000347")]
	public int get_pixelWidth() { }

	[Address(RVA = "0x2FD8920", Offset = "0x2FD7D20", Length = "0x33")]
	[Token(Token = "0x6000426")]
	private static int get_pixelWidth_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD6730", Offset = "0x2FD5B30", Length = "0x8")]
	[Token(Token = "0x6000315")]
	internal static int get_PreviewCullingLayer() { }

	[Address(RVA = "0x2FD8A30", Offset = "0x2FD7E30", Length = "0x9A")]
	[Token(Token = "0x600035E")]
	public Matrix4x4 get_previousViewProjectionMatrix() { }

	[Address(RVA = "0x2FD89E0", Offset = "0x2FD7DE0", Length = "0x42")]
	[Token(Token = "0x600043B")]
	private static void get_previousViewProjectionMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	[Address(RVA = "0x2FD8BE0", Offset = "0x2FD7FE0", Length = "0x9A")]
	[Token(Token = "0x6000358")]
	public Matrix4x4 get_projectionMatrix() { }

	[Address(RVA = "0x2FD8B90", Offset = "0x2FD7F90", Length = "0x42")]
	[Token(Token = "0x6000435")]
	private static void get_projectionMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	[Address(RVA = "0x2FD8B10", Offset = "0x2FD7F10", Length = "0x76")]
	[Token(Token = "0x6000325")]
	internal ProjectionMatrixMode get_projectionMatrixMode() { }

	[Address(RVA = "0x2FD8AD0", Offset = "0x2FD7ED0", Length = "0x33")]
	[Token(Token = "0x6000404")]
	private static ProjectionMatrixMode get_projectionMatrixMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD8CD0", Offset = "0x2FD80D0", Length = "0x8E")]
	[Token(Token = "0x6000343")]
	public Rect get_rect() { }

	[Address(RVA = "0x2FD8C80", Offset = "0x2FD8080", Length = "0x42")]
	[Token(Token = "0x6000422")]
	private static void get_rect_Injected(IntPtr _unity_self, out Rect ret) { }

	[Address(RVA = "0x2FD8DA0", Offset = "0x2FD81A0", Length = "0x76")]
	[Token(Token = "0x600039F")]
	public bool get_renderCloudsInSceneView() { }

	[Address(RVA = "0x2FD8D60", Offset = "0x2FD8160", Length = "0x33")]
	[Token(Token = "0x6000462")]
	private static bool get_renderCloudsInSceneView_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD8E60", Offset = "0x2FD8260", Length = "0x76")]
	[Token(Token = "0x60002E4")]
	public RenderingPath get_renderingPath() { }

	[Address(RVA = "0x2FD8E20", Offset = "0x2FD8220", Length = "0x33")]
	[Token(Token = "0x60003C8")]
	private static RenderingPath get_renderingPath_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD8F20", Offset = "0x2FD8320", Length = "0x76")]
	[FreeFunction("CameraScripting::GetScaledPixelHeight", HasExplicitThis = True)]
	[Token(Token = "0x600034A")]
	public int get_scaledPixelHeight() { }

	[Address(RVA = "0x2FD8EE0", Offset = "0x2FD82E0", Length = "0x33")]
	[Token(Token = "0x6000429")]
	private static int get_scaledPixelHeight_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD8FE0", Offset = "0x2FD83E0", Length = "0x76")]
	[FreeFunction("CameraScripting::GetScaledPixelWidth", HasExplicitThis = True)]
	[Token(Token = "0x6000349")]
	public int get_scaledPixelWidth() { }

	[Address(RVA = "0x2FD8FA0", Offset = "0x2FD83A0", Length = "0x33")]
	[Token(Token = "0x6000428")]
	private static int get_scaledPixelWidth_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD9170", Offset = "0x2FD8570", Length = "0x87")]
	[FreeFunction("CameraScripting::GetScene", HasExplicitThis = True)]
	[Token(Token = "0x600037E")]
	public Scene get_scene() { }

	[Address(RVA = "0x2FD9120", Offset = "0x2FD8520", Length = "0x42")]
	[Token(Token = "0x600044C")]
	private static void get_scene_Injected(IntPtr _unity_self, out Scene ret) { }

	[Address(RVA = "0x2FD90A0", Offset = "0x2FD84A0", Length = "0x76")]
	[Token(Token = "0x600030E")]
	internal ulong get_sceneCullingMask() { }

	[Address(RVA = "0x2FD9060", Offset = "0x2FD8460", Length = "0x33")]
	[Token(Token = "0x60003F0")]
	private static ulong get_sceneCullingMask_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD2AE0", Offset = "0x2FD1EE0", Length = "0x76")]
	[Token(Token = "0x600039E")]
	public SceneViewFilterMode get_sceneViewFilterMode() { }

	[Address(RVA = "0x2FD9250", Offset = "0x2FD8650", Length = "0x87")]
	[Token(Token = "0x600033A")]
	public Vector2 get_sensorSize() { }

	[Address(RVA = "0x2FD9200", Offset = "0x2FD8600", Length = "0x42")]
	[Token(Token = "0x6000419")]
	private static void get_sensorSize_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x2FD9320", Offset = "0x2FD8720", Length = "0x76")]
	[Token(Token = "0x600032A")]
	public float get_shutterSpeed() { }

	[Address(RVA = "0x2FD92E0", Offset = "0x2FD86E0", Length = "0x33")]
	[Token(Token = "0x6000409")]
	private static float get_shutterSpeed_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD93E0", Offset = "0x2FD87E0", Length = "0x90")]
	[Token(Token = "0x600030B")]
	internal Material get_skyboxMaterial() { }

	[Address(RVA = "0x2FD93A0", Offset = "0x2FD87A0", Length = "0x33")]
	[Token(Token = "0x60003ED")]
	private static IntPtr get_skyboxMaterial_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD94C0", Offset = "0x2FD88C0", Length = "0x76")]
	[FreeFunction("CameraScripting::GetStereoActiveEye", HasExplicitThis = True)]
	[Token(Token = "0x600038A")]
	public MonoOrStereoscopicEye get_stereoActiveEye() { }

	[Address(RVA = "0x2FD9480", Offset = "0x2FD8880", Length = "0x33")]
	[Token(Token = "0x6000456")]
	private static MonoOrStereoscopicEye get_stereoActiveEye_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD9580", Offset = "0x2FD8980", Length = "0x76")]
	[Token(Token = "0x6000383")]
	public float get_stereoConvergence() { }

	[Address(RVA = "0x2FD9540", Offset = "0x2FD8940", Length = "0x33")]
	[Token(Token = "0x6000451")]
	private static float get_stereoConvergence_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD9640", Offset = "0x2FD8A40", Length = "0x76")]
	[NativeMethod("GetStereoEnabledForBuiltInOrSRP")]
	[Token(Token = "0x6000380")]
	public bool get_stereoEnabled() { }

	[Address(RVA = "0x2FD9600", Offset = "0x2FD8A00", Length = "0x33")]
	[Token(Token = "0x600044E")]
	private static bool get_stereoEnabled_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD9700", Offset = "0x2FD8B00", Length = "0x76")]
	[Token(Token = "0x6000381")]
	public float get_stereoSeparation() { }

	[Address(RVA = "0x2FD96C0", Offset = "0x2FD8AC0", Length = "0x33")]
	[Token(Token = "0x600044F")]
	private static float get_stereoSeparation_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD97C0", Offset = "0x2FD8BC0", Length = "0x76")]
	[Token(Token = "0x6000386")]
	public StereoTargetEyeMask get_stereoTargetEye() { }

	[Address(RVA = "0x2FD97C0", Offset = "0x2FD8BC0", Length = "0x76")]
	[Token(Token = "0x6000388")]
	internal StereoTargetEyeMask get_stereoTargetEyeInternal() { }

	[Address(RVA = "0x2FD9780", Offset = "0x2FD8B80", Length = "0x33")]
	[Token(Token = "0x6000454")]
	private static StereoTargetEyeMask get_stereoTargetEyeInternal_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD9880", Offset = "0x2FD8C80", Length = "0x76")]
	[Token(Token = "0x600034E")]
	public int get_targetDisplay() { }

	[Address(RVA = "0x2FD9840", Offset = "0x2FD8C40", Length = "0x33")]
	[Token(Token = "0x600042D")]
	private static int get_targetDisplay_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD9940", Offset = "0x2FD8D40", Length = "0x90")]
	[Token(Token = "0x600034B")]
	public RenderTexture get_targetTexture() { }

	[Address(RVA = "0x2FD9900", Offset = "0x2FD8D00", Length = "0x33")]
	[Token(Token = "0x600042A")]
	private static IntPtr get_targetTexture_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD9A30", Offset = "0x2FD8E30", Length = "0x90")]
	[Token(Token = "0x60002F8")]
	public Vector3 get_transparencySortAxis() { }

	[Address(RVA = "0x2FD99E0", Offset = "0x2FD8DE0", Length = "0x42")]
	[Token(Token = "0x60003DC")]
	private static void get_transparencySortAxis_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x2FD9B10", Offset = "0x2FD8F10", Length = "0x76")]
	[Token(Token = "0x60002F6")]
	public TransparencySortMode get_transparencySortMode() { }

	[Address(RVA = "0x2FD9AD0", Offset = "0x2FD8ED0", Length = "0x33")]
	[Token(Token = "0x60003DA")]
	private static TransparencySortMode get_transparencySortMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD9BD0", Offset = "0x2FD8FD0", Length = "0x76")]
	[Token(Token = "0x600030F")]
	internal bool get_useInteractiveLightBakingData() { }

	[Address(RVA = "0x2FD9B90", Offset = "0x2FD8F90", Length = "0x33")]
	[Token(Token = "0x60003F1")]
	private static bool get_useInteractiveLightBakingData_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD9C90", Offset = "0x2FD9090", Length = "0x76")]
	[Token(Token = "0x600035C")]
	public bool get_useJitteredProjectionMatrixForTransparentRendering() { }

	[Address(RVA = "0x2FD9C50", Offset = "0x2FD9050", Length = "0x33")]
	[Token(Token = "0x6000439")]
	private static bool get_useJitteredProjectionMatrixForTransparentRendering_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD9D50", Offset = "0x2FD9150", Length = "0x76")]
	[Token(Token = "0x6000316")]
	public bool get_useOcclusionCulling() { }

	[Address(RVA = "0x2FD9D10", Offset = "0x2FD9110", Length = "0x33")]
	[Token(Token = "0x60003F5")]
	private static bool get_useOcclusionCulling_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD9E10", Offset = "0x2FD9210", Length = "0x76")]
	[Token(Token = "0x6000326")]
	public bool get_usePhysicalProperties() { }

	[Address(RVA = "0x2FD9DD0", Offset = "0x2FD91D0", Length = "0x33")]
	[Token(Token = "0x6000405")]
	private static bool get_usePhysicalProperties_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD9EE0", Offset = "0x2FD92E0", Length = "0x90")]
	[Token(Token = "0x6000300")]
	public Vector3 get_velocity() { }

	[Address(RVA = "0x2FD9E90", Offset = "0x2FD9290", Length = "0x42")]
	[Token(Token = "0x60003E4")]
	private static void get_velocity_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x2FD9FD0", Offset = "0x2FD93D0", Length = "0x9A")]
	[Token(Token = "0x6000356")]
	public Matrix4x4 get_worldToCameraMatrix() { }

	[Address(RVA = "0x2FD9F80", Offset = "0x2FD9380", Length = "0x42")]
	[Token(Token = "0x6000433")]
	private static void get_worldToCameraMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	[Address(RVA = "0x2FD2600", Offset = "0x2FD1A00", Length = "0xFB")]
	[Token(Token = "0x6000397")]
	public static int GetAllCameras(Camera[] cameras) { }

	[Address(RVA = "0x2FD2520", Offset = "0x2FD1920", Length = "0x2A")]
	[FreeFunction("CameraScripting::GetAllCamerasCount")]
	[Token(Token = "0x6000393")]
	private static int GetAllCamerasCount() { }

	[Address(RVA = "0x2FD2590", Offset = "0x2FD1990", Length = "0x65")]
	[FreeFunction("CameraScripting::GetAllCameras")]
	[Token(Token = "0x6000394")]
	private static int GetAllCamerasImpl(out Camera[] cam) { }

	[Address(RVA = "0x2FD2550", Offset = "0x2FD1950", Length = "0x33")]
	[Token(Token = "0x600045F")]
	private static int GetAllCamerasImpl_Injected(out Camera[] cam) { }

	[Address(RVA = "0x2FD2740", Offset = "0x2FD1B40", Length = "0x76")]
	[Token(Token = "0x6000354")]
	internal String[] GetCameraBufferWarnings() { }

	[Address(RVA = "0x2FD2700", Offset = "0x2FD1B00", Length = "0x33")]
	[Token(Token = "0x6000431")]
	private static String[] GetCameraBufferWarnings_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD2890", Offset = "0x2FD1C90", Length = "0xFF")]
	[Token(Token = "0x60003B7")]
	public CommandBuffer[] GetCommandBuffers(CameraEvent evt) { }

	[Address(RVA = "0x2FD2800", Offset = "0x2FD1C00", Length = "0x83")]
	[FreeFunction("CameraScripting::GetCommandBuffers", HasExplicitThis = True)]
	[Token(Token = "0x60003B8")]
	internal CommandBuffer[] GetCommandBuffersImpl(CameraEvent evt) { }

	[Address(RVA = "0x2FD27C0", Offset = "0x2FD1BC0", Length = "0x40")]
	[Token(Token = "0x6000473")]
	private static CommandBuffer[] GetCommandBuffersImpl_Injected(IntPtr _unity_self, CameraEvent evt) { }

	[Address(RVA = "0x2FD2A00", Offset = "0x2FD1E00", Length = "0x9B")]
	[FreeFunction("ScriptableRenderPipeline_Bindings::GetCullingParameters_Internal")]
	[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
	[Token(Token = "0x60003C1")]
	private static bool GetCullingParameters_Internal(Camera camera, bool stereoAware, out ScriptableCullingParameters cullingParameters, int managedCullingParametersSize) { }

	[Address(RVA = "0x2FD2990", Offset = "0x2FD1D90", Length = "0x63")]
	[Token(Token = "0x6000474")]
	private static bool GetCullingParameters_Internal_Injected(IntPtr camera, bool stereoAware, out ScriptableCullingParameters cullingParameters, int managedCullingParametersSize) { }

	[Address(RVA = "0x2FD2AE0", Offset = "0x2FD1EE0", Length = "0x76")]
	[NativeConditional("UNITY_EDITOR")]
	[Token(Token = "0x600039D")]
	private int GetFilterMode() { }

	[Address(RVA = "0x2FD2AA0", Offset = "0x2FD1EA0", Length = "0x33")]
	[Token(Token = "0x6000461")]
	private static int GetFilterMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD2BC0", Offset = "0x2FD1FC0", Length = "0x97")]
	[Token(Token = "0x600036C")]
	internal Vector2 GetFrustumPlaneSizeAt(float distance) { }

	[Address(RVA = "0x2FD2B60", Offset = "0x2FD1F60", Length = "0x52")]
	[Token(Token = "0x6000445")]
	private static void GetFrustumPlaneSizeAt_Injected(IntPtr _unity_self, float distance, out Vector2 ret) { }

	[Address(RVA = "0x2FD2CA0", Offset = "0x2FD20A0", Length = "0x76")]
	[Token(Token = "0x6000340")]
	public float GetGateFittedFieldOfView() { }

	[Address(RVA = "0x2FD2C60", Offset = "0x2FD2060", Length = "0x33")]
	[Token(Token = "0x600041F")]
	private static float GetGateFittedFieldOfView_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD2D70", Offset = "0x2FD2170", Length = "0x87")]
	[Token(Token = "0x6000341")]
	public Vector2 GetGateFittedLensShift() { }

	[Address(RVA = "0x2FD2D20", Offset = "0x2FD2120", Length = "0x42")]
	[Token(Token = "0x6000420")]
	private static void GetGateFittedLensShift_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x2FD2E50", Offset = "0x2FD2250", Length = "0xF9")]
	[FreeFunction("CameraScripting::GetLayerCullDistances", HasExplicitThis = True)]
	[Token(Token = "0x6000311")]
	private Single[] GetLayerCullDistances() { }

	[Address(RVA = "0x2FD2E00", Offset = "0x2FD2200", Length = "0x42")]
	[Token(Token = "0x60003F3")]
	private static void GetLayerCullDistances_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x2FD2FA0", Offset = "0x2FD23A0", Length = "0x90")]
	[Token(Token = "0x6000342")]
	internal Vector3 GetLocalSpaceAim() { }

	[Address(RVA = "0x2FD2F50", Offset = "0x2FD2350", Length = "0x42")]
	[Token(Token = "0x6000421")]
	private static void GetLocalSpaceAim_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x2FD3090", Offset = "0x2FD2490", Length = "0xA9")]
	[Token(Token = "0x600038B")]
	public Matrix4x4 GetStereoNonJitteredProjectionMatrix(StereoscopicEye eye) { }

	[Address(RVA = "0x2FD3040", Offset = "0x2FD2440", Length = "0x50")]
	[Token(Token = "0x6000457")]
	private static void GetStereoNonJitteredProjectionMatrix_Injected(IntPtr _unity_self, StereoscopicEye eye, out Matrix4x4 ret) { }

	[Address(RVA = "0x2FD3190", Offset = "0x2FD2590", Length = "0xA9")]
	[FreeFunction("CameraScripting::GetStereoProjectionMatrix", HasExplicitThis = True)]
	[Token(Token = "0x600038E")]
	public Matrix4x4 GetStereoProjectionMatrix(StereoscopicEye eye) { }

	[Address(RVA = "0x2FD3140", Offset = "0x2FD2540", Length = "0x50")]
	[Token(Token = "0x600045A")]
	private static void GetStereoProjectionMatrix_Injected(IntPtr _unity_self, StereoscopicEye eye, out Matrix4x4 ret) { }

	[Address(RVA = "0x2FD3290", Offset = "0x2FD2690", Length = "0xA9")]
	[FreeFunction("CameraScripting::GetStereoViewMatrix", HasExplicitThis = True)]
	[Token(Token = "0x600038C")]
	public Matrix4x4 GetStereoViewMatrix(StereoscopicEye eye) { }

	[Address(RVA = "0x2FD3240", Offset = "0x2FD2640", Length = "0x50")]
	[Token(Token = "0x6000458")]
	private static void GetStereoViewMatrix_Injected(IntPtr _unity_self, StereoscopicEye eye, out Matrix4x4 ret) { }

	[Address(RVA = "0x2FD3340", Offset = "0x2FD2740", Length = "0x4A")]
	[NativeName("HorizontalToVerticalFieldOfView_Safe")]
	[Token(Token = "0x6000379")]
	public static float HorizontalToVerticalFieldOfView(float horizontalFieldOfView, float aspectRatio) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003BD")]
	internal void OnlyUsedForTesting1() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003BE")]
	internal void OnlyUsedForTesting2() { }

	[Address(RVA = "0x2FD3450", Offset = "0x2FD2850", Length = "0xF1")]
	[Token(Token = "0x60003B0")]
	public void RemoveAllCommandBuffers() { }

	[Address(RVA = "0x2FD33D0", Offset = "0x2FD27D0", Length = "0x76")]
	[NativeName("RemoveAllCommandBuffers")]
	[Token(Token = "0x60003AE")]
	private void RemoveAllCommandBuffersImpl() { }

	[Address(RVA = "0x2FD3390", Offset = "0x2FD2790", Length = "0x33")]
	[Token(Token = "0x600046F")]
	private static void RemoveAllCommandBuffersImpl_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD3680", Offset = "0x2FD2A80", Length = "0x22E")]
	[Token(Token = "0x60003B6")]
	public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	[Address(RVA = "0x2FD35A0", Offset = "0x2FD29A0", Length = "0xD5")]
	[NativeName("RemoveCommandBuffer")]
	[Token(Token = "0x60003B3")]
	private void RemoveCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	[Address(RVA = "0x2FD3550", Offset = "0x2FD2950", Length = "0x50")]
	[Token(Token = "0x6000472")]
	private static void RemoveCommandBufferImpl_Injected(IntPtr _unity_self, CameraEvent evt, IntPtr buffer) { }

	[Address(RVA = "0x2FD3980", Offset = "0x2FD2D80", Length = "0x103")]
	[Token(Token = "0x60003AF")]
	public void RemoveCommandBuffers(CameraEvent evt) { }

	[Address(RVA = "0x2FD38F0", Offset = "0x2FD2CF0", Length = "0x83")]
	[NativeName("RemoveCommandBuffers")]
	[Token(Token = "0x60003AD")]
	private void RemoveCommandBuffersImpl(CameraEvent evt) { }

	[Address(RVA = "0x2FD38B0", Offset = "0x2FD2CB0", Length = "0x40")]
	[Token(Token = "0x600046E")]
	private static void RemoveCommandBuffersImpl_Injected(IntPtr _unity_self, CameraEvent evt) { }

	[Address(RVA = "0x2FD4150", Offset = "0x2FD3550", Length = "0x76")]
	[FreeFunction("CameraScripting::Render", HasExplicitThis = True)]
	[Token(Token = "0x60003A3")]
	public void Render() { }

	[Address(RVA = "0x2FD4110", Offset = "0x2FD3510", Length = "0x33")]
	[Token(Token = "0x6000465")]
	private static void Render_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD3AD0", Offset = "0x2FD2ED0", Length = "0x76")]
	[FreeFunction("CameraScripting::RenderDontRestore", HasExplicitThis = True)]
	[Token(Token = "0x60003A5")]
	public void RenderDontRestore() { }

	[Address(RVA = "0x2FD3A90", Offset = "0x2FD2E90", Length = "0x33")]
	[Token(Token = "0x6000467")]
	private static void RenderDontRestore_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD3D00", Offset = "0x2FD3100", Length = "0xD0")]
	[Token(Token = "0x6000399")]
	public bool RenderToCubemap(Cubemap cubemap, int faceMask) { }

	[Address(RVA = "0x2FD3BC0", Offset = "0x2FD2FC0", Length = "0xD2")]
	[Token(Token = "0x60003A2")]
	public bool RenderToCubemap(RenderTexture cubemap, int faceMask, MonoOrStereoscopicEye stereoEye) { }

	[Address(RVA = "0x2FD3DE0", Offset = "0x2FD31E0", Length = "0xC0")]
	[Token(Token = "0x600039C")]
	public bool RenderToCubemap(RenderTexture cubemap) { }

	[Address(RVA = "0x2FD3D00", Offset = "0x2FD3100", Length = "0xD0")]
	[Token(Token = "0x600039B")]
	public bool RenderToCubemap(RenderTexture cubemap, int faceMask) { }

	[Address(RVA = "0x2FD3DE0", Offset = "0x2FD31E0", Length = "0xC0")]
	[Token(Token = "0x600039A")]
	public bool RenderToCubemap(Cubemap cubemap) { }

	[Address(RVA = "0x2FD3BC0", Offset = "0x2FD2FC0", Length = "0xD2")]
	[NativeName("RenderToCubemap")]
	[Token(Token = "0x60003A1")]
	private bool RenderToCubemapEyeImpl(RenderTexture cubemap, int faceMask, MonoOrStereoscopicEye stereoEye) { }

	[Address(RVA = "0x2FD3B50", Offset = "0x2FD2F50", Length = "0x62")]
	[Token(Token = "0x6000464")]
	private static bool RenderToCubemapEyeImpl_Injected(IntPtr _unity_self, IntPtr cubemap, int faceMask, MonoOrStereoscopicEye stereoEye) { }

	[Address(RVA = "0x2FD3D00", Offset = "0x2FD3100", Length = "0xD0")]
	[FreeFunction("CameraScripting::RenderToCubemap", HasExplicitThis = True)]
	[Token(Token = "0x6000398")]
	private bool RenderToCubemapImpl(Texture tex, int faceMask) { }

	[Address(RVA = "0x2FD3CA0", Offset = "0x2FD30A0", Length = "0x52")]
	[Token(Token = "0x6000460")]
	private static bool RenderToCubemapImpl_Injected(IntPtr _unity_self, IntPtr tex, int faceMask) { }

	[Address(RVA = "0x2FD3F10", Offset = "0x2FD3310", Length = "0x1F7")]
	[FreeFunction("CameraScripting::RenderWithShader", HasExplicitThis = True)]
	[Token(Token = "0x60003A4")]
	public void RenderWithShader(Shader shader, string replacementTag) { }

	[Address(RVA = "0x2FD3EB0", Offset = "0x2FD32B0", Length = "0x52")]
	[Token(Token = "0x6000466")]
	private static void RenderWithShader_Injected(IntPtr _unity_self, IntPtr shader, ref ManagedSpanWrapper replacementTag) { }

	[Address(RVA = "0x2FD4810", Offset = "0x2FD3C10", Length = "0x76")]
	[Token(Token = "0x60002E7")]
	public void Reset() { }

	[Address(RVA = "0x2FD47D0", Offset = "0x2FD3BD0", Length = "0x33")]
	[Token(Token = "0x60003CB")]
	private static void Reset_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD4210", Offset = "0x2FD3610", Length = "0x76")]
	[Token(Token = "0x60002FF")]
	public void ResetAspect() { }

	[Address(RVA = "0x2FD41D0", Offset = "0x2FD35D0", Length = "0x33")]
	[Token(Token = "0x60003E3")]
	private static void ResetAspect_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD42D0", Offset = "0x2FD36D0", Length = "0x76")]
	[Token(Token = "0x600031A")]
	public void ResetCullingMatrix() { }

	[Address(RVA = "0x2FD4290", Offset = "0x2FD3690", Length = "0x33")]
	[Token(Token = "0x60003F9")]
	private static void ResetCullingMatrix_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD4390", Offset = "0x2FD3790", Length = "0x76")]
	[Token(Token = "0x6000360")]
	public void ResetProjectionMatrix() { }

	[Address(RVA = "0x2FD4350", Offset = "0x2FD3750", Length = "0x33")]
	[Token(Token = "0x600043D")]
	private static void ResetProjectionMatrix_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD4450", Offset = "0x2FD3850", Length = "0x76")]
	[Token(Token = "0x6000324")]
	public void ResetReplacementShader() { }

	[Address(RVA = "0x2FD4410", Offset = "0x2FD3810", Length = "0x33")]
	[Token(Token = "0x6000403")]
	private static void ResetReplacementShader_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD4510", Offset = "0x2FD3910", Length = "0x76")]
	[Token(Token = "0x6000390")]
	public void ResetStereoProjectionMatrices() { }

	[Address(RVA = "0x2FD44D0", Offset = "0x2FD38D0", Length = "0x33")]
	[Token(Token = "0x600045C")]
	private static void ResetStereoProjectionMatrices_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD45D0", Offset = "0x2FD39D0", Length = "0x76")]
	[Token(Token = "0x6000392")]
	public void ResetStereoViewMatrices() { }

	[Address(RVA = "0x2FD4590", Offset = "0x2FD3990", Length = "0x33")]
	[Token(Token = "0x600045E")]
	private static void ResetStereoViewMatrices_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD4690", Offset = "0x2FD3A90", Length = "0x76")]
	[Token(Token = "0x60002FA")]
	public void ResetTransparencySortSettings() { }

	[Address(RVA = "0x2FD4650", Offset = "0x2FD3A50", Length = "0x33")]
	[Token(Token = "0x60003DE")]
	private static void ResetTransparencySortSettings_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD4750", Offset = "0x2FD3B50", Length = "0x76")]
	[Token(Token = "0x600035F")]
	public void ResetWorldToCameraMatrix() { }

	[Address(RVA = "0x2FD4710", Offset = "0x2FD3B10", Length = "0x33")]
	[Token(Token = "0x600043C")]
	private static void ResetWorldToCameraMatrix_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FD49F0", Offset = "0x2FD3DF0", Length = "0xF0")]
	[Token(Token = "0x6000371")]
	public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	[Address(RVA = "0x2FD4AF0", Offset = "0x2FD3EF0", Length = "0xAE")]
	[Token(Token = "0x6000370")]
	private Ray ScreenPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	[Address(RVA = "0x2FD4900", Offset = "0x2FD3D00", Length = "0xE6")]
	[Token(Token = "0x6000372")]
	public Ray ScreenPointToRay(Vector3 pos) { }

	[Address(RVA = "0x2FD4890", Offset = "0x2FD3C90", Length = "0x62")]
	[Token(Token = "0x6000447")]
	private static void ScreenPointToRay_Injected(IntPtr _unity_self, in Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret) { }

	[Address(RVA = "0x2FD4C00", Offset = "0x2FD4000", Length = "0xA0")]
	[Token(Token = "0x600036A")]
	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	[Address(RVA = "0x2FD4BA0", Offset = "0x2FD3FA0", Length = "0x52")]
	[Token(Token = "0x6000443")]
	private static void ScreenToViewportPoint_Injected(IntPtr _unity_self, in Vector3 position, out Vector3 ret) { }

	[Address(RVA = "0x2FD4DE0", Offset = "0x2FD41E0", Length = "0xCC")]
	[Token(Token = "0x6000369")]
	public Vector3 ScreenToWorldPoint(Vector3 position) { }

	[Address(RVA = "0x2FD4D20", Offset = "0x2FD4120", Length = "0xB2")]
	[Token(Token = "0x6000365")]
	public Vector3 ScreenToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	[Address(RVA = "0x2FD4CB0", Offset = "0x2FD40B0", Length = "0x62")]
	[Token(Token = "0x6000442")]
	private static void ScreenToWorldPoint_Injected(IntPtr _unity_self, in Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	[Address(RVA = "0x2FDA0C0", Offset = "0x2FD94C0", Length = "0x86")]
	[Token(Token = "0x60002ED")]
	public void set_allowDynamicResolution(bool value) { }

	[Address(RVA = "0x2FDA070", Offset = "0x2FD9470", Length = "0x42")]
	[Token(Token = "0x60003D1")]
	private static void set_allowDynamicResolution_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FDA1A0", Offset = "0x2FD95A0", Length = "0x86")]
	[Token(Token = "0x60002E9")]
	public void set_allowHDR(bool value) { }

	[Address(RVA = "0x2FDA150", Offset = "0x2FD9550", Length = "0x42")]
	[Token(Token = "0x60003CD")]
	private static void set_allowHDR_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FDA280", Offset = "0x2FD9680", Length = "0x86")]
	[Token(Token = "0x60002EB")]
	public void set_allowMSAA(bool value) { }

	[Address(RVA = "0x2FDA230", Offset = "0x2FD9630", Length = "0x42")]
	[Token(Token = "0x60003CF")]
	private static void set_allowMSAA_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FDA360", Offset = "0x2FD9760", Length = "0x86")]
	[Token(Token = "0x6000339")]
	public void set_anamorphism(float value) { }

	[Address(RVA = "0x2FDA310", Offset = "0x2FD9710", Length = "0x43")]
	[Token(Token = "0x6000418")]
	private static void set_anamorphism_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FDA440", Offset = "0x2FD9840", Length = "0x86")]
	[Token(Token = "0x600032D")]
	public void set_aperture(float value) { }

	[Address(RVA = "0x2FDA3F0", Offset = "0x2FD97F0", Length = "0x43")]
	[Token(Token = "0x600040C")]
	private static void set_aperture_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FDA520", Offset = "0x2FD9920", Length = "0x86")]
	[Token(Token = "0x60002FE")]
	public void set_aspect(float value) { }

	[Address(RVA = "0x2FDA4D0", Offset = "0x2FD98D0", Length = "0x43")]
	[Token(Token = "0x60003E2")]
	private static void set_aspect_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FDA600", Offset = "0x2FD9A00", Length = "0x85")]
	[Token(Token = "0x600031C")]
	public void set_backgroundColor(Color value) { }

	[Address(RVA = "0x2FDA5B0", Offset = "0x2FD99B0", Length = "0x42")]
	[Token(Token = "0x60003FB")]
	private static void set_backgroundColor_Injected(IntPtr _unity_self, in Color value) { }

	[Address(RVA = "0x2FDA6E0", Offset = "0x2FD9AE0", Length = "0x86")]
	[Token(Token = "0x6000337")]
	public void set_barrelClipping(float value) { }

	[Address(RVA = "0x2FDA690", Offset = "0x2FD9A90", Length = "0x43")]
	[Token(Token = "0x6000416")]
	private static void set_barrelClipping_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FDA7B0", Offset = "0x2FD9BB0", Length = "0x83")]
	[Token(Token = "0x6000333")]
	public void set_bladeCount(int value) { }

	[Address(RVA = "0x2FDA770", Offset = "0x2FD9B70", Length = "0x40")]
	[Token(Token = "0x6000412")]
	private static void set_bladeCount_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x2FDA880", Offset = "0x2FD9C80", Length = "0x83")]
	[Token(Token = "0x600030A")]
	public void set_cameraType(CameraType value) { }

	[Address(RVA = "0x2FDA840", Offset = "0x2FD9C40", Length = "0x40")]
	[Token(Token = "0x60003EC")]
	private static void set_cameraType_Injected(IntPtr _unity_self, CameraType value) { }

	[Address(RVA = "0x2FDA950", Offset = "0x2FD9D50", Length = "0x83")]
	[Token(Token = "0x600031E")]
	public void set_clearFlags(CameraClearFlags value) { }

	[Address(RVA = "0x2FDA910", Offset = "0x2FD9D10", Length = "0x40")]
	[Token(Token = "0x60003FD")]
	private static void set_clearFlags_Injected(IntPtr _unity_self, CameraClearFlags value) { }

	[Address(RVA = "0x2FDAA30", Offset = "0x2FD9E30", Length = "0x86")]
	[Token(Token = "0x6000322")]
	public void set_clearStencilAfterLightingPass(bool value) { }

	[Address(RVA = "0x2FDA9E0", Offset = "0x2FD9DE0", Length = "0x42")]
	[Token(Token = "0x6000401")]
	private static void set_clearStencilAfterLightingPass_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FDAB00", Offset = "0x2FD9F00", Length = "0x83")]
	[Token(Token = "0x6000302")]
	public void set_cullingMask(int value) { }

	[Address(RVA = "0x2FDAAC0", Offset = "0x2FD9EC0", Length = "0x40")]
	[Token(Token = "0x60003E6")]
	private static void set_cullingMask_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x2FDABE0", Offset = "0x2FD9FE0", Length = "0x85")]
	[Token(Token = "0x6000319")]
	public void set_cullingMatrix(Matrix4x4 value) { }

	[Address(RVA = "0x2FDAB90", Offset = "0x2FD9F90", Length = "0x42")]
	[Token(Token = "0x60003F8")]
	private static void set_cullingMatrix_Injected(IntPtr _unity_self, in Matrix4x4 value) { }

	[Address(RVA = "0x2FDACC0", Offset = "0x2FDA0C0", Length = "0x80")]
	[Token(Token = "0x6000335")]
	public void set_curvature(Vector2 value) { }

	[Address(RVA = "0x2FDAC70", Offset = "0x2FDA070", Length = "0x42")]
	[Token(Token = "0x6000414")]
	private static void set_curvature_Injected(IntPtr _unity_self, in Vector2 value) { }

	[Address(RVA = "0x2FDAE70", Offset = "0x2FDA270", Length = "0x86")]
	[Token(Token = "0x60002FC")]
	public void set_depth(float value) { }

	[Address(RVA = "0x2FDAE20", Offset = "0x2FDA220", Length = "0x43")]
	[Token(Token = "0x60003E0")]
	private static void set_depth_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FDAD90", Offset = "0x2FDA190", Length = "0x83")]
	[Token(Token = "0x6000320")]
	public void set_depthTextureMode(DepthTextureMode value) { }

	[Address(RVA = "0x2FDAD50", Offset = "0x2FDA150", Length = "0x40")]
	[Token(Token = "0x60003FF")]
	private static void set_depthTextureMode_Injected(IntPtr _unity_self, DepthTextureMode value) { }

	[Address(RVA = "0x2FDAF40", Offset = "0x2FDA340", Length = "0x83")]
	[Token(Token = "0x6000304")]
	public void set_eventMask(int value) { }

	[Address(RVA = "0x2FDAF00", Offset = "0x2FDA300", Length = "0x40")]
	[Token(Token = "0x60003E8")]
	private static void set_eventMask_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x2FDB020", Offset = "0x2FDA420", Length = "0x86")]
	[Token(Token = "0x60002E1")]
	public void set_farClipPlane(float value) { }

	[Address(RVA = "0x2FDAFD0", Offset = "0x2FDA3D0", Length = "0x43")]
	[Token(Token = "0x60003C5")]
	private static void set_farClipPlane_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FDB100", Offset = "0x2FDA500", Length = "0x86")]
	[Token(Token = "0x60002E3")]
	public void set_fieldOfView(float value) { }

	[Address(RVA = "0x2FDB0B0", Offset = "0x2FDA4B0", Length = "0x43")]
	[Token(Token = "0x60003C7")]
	private static void set_fieldOfView_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FDB1E0", Offset = "0x2FDA5E0", Length = "0x86")]
	[Token(Token = "0x6000331")]
	public void set_focalLength(float value) { }

	[Address(RVA = "0x2FDB190", Offset = "0x2FDA590", Length = "0x43")]
	[Token(Token = "0x6000410")]
	private static void set_focalLength_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FDB2C0", Offset = "0x2FDA6C0", Length = "0x86")]
	[Token(Token = "0x600032F")]
	public void set_focusDistance(float value) { }

	[Address(RVA = "0x2FDB270", Offset = "0x2FDA670", Length = "0x43")]
	[Token(Token = "0x600040E")]
	private static void set_focusDistance_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FDB3A0", Offset = "0x2FDA7A0", Length = "0x86")]
	[Token(Token = "0x60002EF")]
	public void set_forceIntoRenderTexture(bool value) { }

	[Address(RVA = "0x2FDB350", Offset = "0x2FDA750", Length = "0x42")]
	[Token(Token = "0x60003D3")]
	private static void set_forceIntoRenderTexture_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FDB470", Offset = "0x2FDA870", Length = "0x83")]
	[Token(Token = "0x600033F")]
	public void set_gateFit(GateFitMode value) { }

	[Address(RVA = "0x2FDB430", Offset = "0x2FDA830", Length = "0x40")]
	[Token(Token = "0x600041E")]
	private static void set_gateFit_Injected(IntPtr _unity_self, GateFitMode value) { }

	[Address(RVA = "0x2FDB540", Offset = "0x2FDA940", Length = "0x83")]
	[Token(Token = "0x6000329")]
	public void set_iso(int value) { }

	[Address(RVA = "0x2FDB500", Offset = "0x2FDA900", Length = "0x40")]
	[Token(Token = "0x6000408")]
	private static void set_iso_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x2FDB5D0", Offset = "0x2FDA9D0", Length = "0x163")]
	[Token(Token = "0x6000314")]
	public void set_layerCullDistances(Single[] value) { }

	[Address(RVA = "0x2FDB820", Offset = "0x2FDAC20", Length = "0x12E")]
	[Token(Token = "0x6000306")]
	public void set_layerCullSpherical(bool value) { }

	[Address(RVA = "0x2FDB790", Offset = "0x2FDAB90", Length = "0x86")]
	[Token(Token = "0x6000308")]
	internal void set_layerCullSphericalInternal(bool value) { }

	[Address(RVA = "0x2FDB740", Offset = "0x2FDAB40", Length = "0x42")]
	[Token(Token = "0x60003EA")]
	private static void set_layerCullSphericalInternal_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FDB9A0", Offset = "0x2FDADA0", Length = "0x80")]
	[Token(Token = "0x600033D")]
	public void set_lensShift(Vector2 value) { }

	[Address(RVA = "0x2FDB950", Offset = "0x2FDAD50", Length = "0x42")]
	[Token(Token = "0x600041C")]
	private static void set_lensShift_Injected(IntPtr _unity_self, in Vector2 value) { }

	[Address(RVA = "0x2FDBA80", Offset = "0x2FDAE80", Length = "0x86")]
	[Token(Token = "0x60002DF")]
	public void set_nearClipPlane(float value) { }

	[Address(RVA = "0x2FDBA30", Offset = "0x2FDAE30", Length = "0x43")]
	[Token(Token = "0x60003C3")]
	private static void set_nearClipPlane_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FDBB60", Offset = "0x2FDAF60", Length = "0x85")]
	[Token(Token = "0x600035B")]
	public void set_nonJitteredProjectionMatrix(Matrix4x4 value) { }

	[Address(RVA = "0x2FDBB10", Offset = "0x2FDAF10", Length = "0x42")]
	[Token(Token = "0x6000438")]
	private static void set_nonJitteredProjectionMatrix_Injected(IntPtr _unity_self, in Matrix4x4 value) { }

	[Address(RVA = "0x2FDBC30", Offset = "0x2FDB030", Length = "0x83")]
	[Token(Token = "0x60002F5")]
	public void set_opaqueSortMode(OpaqueSortMode value) { }

	[Address(RVA = "0x2FDBBF0", Offset = "0x2FDAFF0", Length = "0x40")]
	[Token(Token = "0x60003D9")]
	private static void set_opaqueSortMode_Injected(IntPtr _unity_self, OpaqueSortMode value) { }

	[Address(RVA = "0x2FDBDF0", Offset = "0x2FDB1F0", Length = "0x86")]
	[Token(Token = "0x60002F3")]
	public void set_orthographic(bool value) { }

	[Address(RVA = "0x2FDBDA0", Offset = "0x2FDB1A0", Length = "0x42")]
	[Token(Token = "0x60003D7")]
	private static void set_orthographic_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FDBD10", Offset = "0x2FDB110", Length = "0x86")]
	[Token(Token = "0x60002F1")]
	public void set_orthographicSize(float value) { }

	[Address(RVA = "0x2FDBCC0", Offset = "0x2FDB0C0", Length = "0x43")]
	[Token(Token = "0x60003D5")]
	private static void set_orthographicSize_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FDBED0", Offset = "0x2FDB2D0", Length = "0x85")]
	[Token(Token = "0x600030D")]
	public void set_overrideSceneCullingMask(ulong value) { }

	[Address(RVA = "0x2FDBE80", Offset = "0x2FDB280", Length = "0x42")]
	[Token(Token = "0x60003EF")]
	private static void set_overrideSceneCullingMask_Injected(IntPtr _unity_self, ulong value) { }

	[Address(RVA = "0x2FDBFB0", Offset = "0x2FDB3B0", Length = "0x85")]
	[Token(Token = "0x6000346")]
	public void set_pixelRect(Rect value) { }

	[Address(RVA = "0x2FDBF60", Offset = "0x2FDB360", Length = "0x42")]
	[Token(Token = "0x6000425")]
	private static void set_pixelRect_Injected(IntPtr _unity_self, in Rect value) { }

	[Address(RVA = "0x2FDC090", Offset = "0x2FDB490", Length = "0x85")]
	[Token(Token = "0x6000359")]
	public void set_projectionMatrix(Matrix4x4 value) { }

	[Address(RVA = "0x2FDC040", Offset = "0x2FDB440", Length = "0x42")]
	[Token(Token = "0x6000436")]
	private static void set_projectionMatrix_Injected(IntPtr _unity_self, in Matrix4x4 value) { }

	[Address(RVA = "0x2FDC170", Offset = "0x2FDB570", Length = "0x85")]
	[Token(Token = "0x6000344")]
	public void set_rect(Rect value) { }

	[Address(RVA = "0x2FDC120", Offset = "0x2FDB520", Length = "0x42")]
	[Token(Token = "0x6000423")]
	private static void set_rect_Injected(IntPtr _unity_self, in Rect value) { }

	[Address(RVA = "0x2FDC250", Offset = "0x2FDB650", Length = "0x86")]
	[Token(Token = "0x60003A0")]
	public void set_renderCloudsInSceneView(bool value) { }

	[Address(RVA = "0x2FDC200", Offset = "0x2FDB600", Length = "0x42")]
	[Token(Token = "0x6000463")]
	private static void set_renderCloudsInSceneView_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FDC320", Offset = "0x2FDB720", Length = "0x83")]
	[Token(Token = "0x60002E5")]
	public void set_renderingPath(RenderingPath value) { }

	[Address(RVA = "0x2FDC2E0", Offset = "0x2FDB6E0", Length = "0x40")]
	[Token(Token = "0x60003C9")]
	private static void set_renderingPath_Injected(IntPtr _unity_self, RenderingPath value) { }

	[Address(RVA = "0x2FDC400", Offset = "0x2FDB800", Length = "0x7E")]
	[FreeFunction("CameraScripting::SetScene", HasExplicitThis = True)]
	[Token(Token = "0x600037F")]
	public void set_scene(Scene value) { }

	[Address(RVA = "0x2FDC3B0", Offset = "0x2FDB7B0", Length = "0x42")]
	[Token(Token = "0x600044D")]
	private static void set_scene_Injected(IntPtr _unity_self, in Scene value) { }

	[Address(RVA = "0x2FDC4D0", Offset = "0x2FDB8D0", Length = "0x80")]
	[Token(Token = "0x600033B")]
	public void set_sensorSize(Vector2 value) { }

	[Address(RVA = "0x2FDC480", Offset = "0x2FDB880", Length = "0x42")]
	[Token(Token = "0x600041A")]
	private static void set_sensorSize_Injected(IntPtr _unity_self, in Vector2 value) { }

	[Address(RVA = "0x2FDC5B0", Offset = "0x2FDB9B0", Length = "0x86")]
	[Token(Token = "0x600032B")]
	public void set_shutterSpeed(float value) { }

	[Address(RVA = "0x2FDC560", Offset = "0x2FDB960", Length = "0x43")]
	[Token(Token = "0x600040A")]
	private static void set_shutterSpeed_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FDC690", Offset = "0x2FDBA90", Length = "0x86")]
	[Token(Token = "0x6000384")]
	public void set_stereoConvergence(float value) { }

	[Address(RVA = "0x2FDC640", Offset = "0x2FDBA40", Length = "0x43")]
	[Token(Token = "0x6000452")]
	private static void set_stereoConvergence_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FDC770", Offset = "0x2FDBB70", Length = "0x86")]
	[Token(Token = "0x6000382")]
	public void set_stereoSeparation(float value) { }

	[Address(RVA = "0x2FDC720", Offset = "0x2FDBB20", Length = "0x43")]
	[Token(Token = "0x6000450")]
	private static void set_stereoSeparation_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FDC8D0", Offset = "0x2FDBCD0", Length = "0x12B")]
	[Token(Token = "0x6000387")]
	public void set_stereoTargetEye(StereoTargetEyeMask value) { }

	[Address(RVA = "0x2FDC840", Offset = "0x2FDBC40", Length = "0x83")]
	[Token(Token = "0x6000389")]
	internal void set_stereoTargetEyeInternal(StereoTargetEyeMask value) { }

	[Address(RVA = "0x2FDC800", Offset = "0x2FDBC00", Length = "0x40")]
	[Token(Token = "0x6000455")]
	private static void set_stereoTargetEyeInternal_Injected(IntPtr _unity_self, StereoTargetEyeMask value) { }

	[Address(RVA = "0x2FDCA40", Offset = "0x2FDBE40", Length = "0x83")]
	[Token(Token = "0x600034F")]
	public void set_targetDisplay(int value) { }

	[Address(RVA = "0x2FDCA00", Offset = "0x2FDBE00", Length = "0x40")]
	[Token(Token = "0x600042E")]
	private static void set_targetDisplay_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x2FDCB20", Offset = "0x2FDBF20", Length = "0xBA")]
	[Token(Token = "0x600034C")]
	public void set_targetTexture(RenderTexture value) { }

	[Address(RVA = "0x2FDCAD0", Offset = "0x2FDBED0", Length = "0x42")]
	[Token(Token = "0x600042B")]
	private static void set_targetTexture_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x2FDCC30", Offset = "0x2FDC030", Length = "0x85")]
	[Token(Token = "0x60002F9")]
	public void set_transparencySortAxis(Vector3 value) { }

	[Address(RVA = "0x2FDCBE0", Offset = "0x2FDBFE0", Length = "0x42")]
	[Token(Token = "0x60003DD")]
	private static void set_transparencySortAxis_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x2FDCD00", Offset = "0x2FDC100", Length = "0x83")]
	[Token(Token = "0x60002F7")]
	public void set_transparencySortMode(TransparencySortMode value) { }

	[Address(RVA = "0x2FDCCC0", Offset = "0x2FDC0C0", Length = "0x40")]
	[Token(Token = "0x60003DB")]
	private static void set_transparencySortMode_Injected(IntPtr _unity_self, TransparencySortMode value) { }

	[Address(RVA = "0x2FDCDE0", Offset = "0x2FDC1E0", Length = "0x86")]
	[Token(Token = "0x6000310")]
	internal void set_useInteractiveLightBakingData(bool value) { }

	[Address(RVA = "0x2FDCD90", Offset = "0x2FDC190", Length = "0x42")]
	[Token(Token = "0x60003F2")]
	private static void set_useInteractiveLightBakingData_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FDCEC0", Offset = "0x2FDC2C0", Length = "0x86")]
	[Token(Token = "0x600035D")]
	public void set_useJitteredProjectionMatrixForTransparentRendering(bool value) { }

	[Address(RVA = "0x2FDCE70", Offset = "0x2FDC270", Length = "0x42")]
	[Token(Token = "0x600043A")]
	private static void set_useJitteredProjectionMatrixForTransparentRendering_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FDCFA0", Offset = "0x2FDC3A0", Length = "0x86")]
	[Token(Token = "0x6000317")]
	public void set_useOcclusionCulling(bool value) { }

	[Address(RVA = "0x2FDCF50", Offset = "0x2FDC350", Length = "0x42")]
	[Token(Token = "0x60003F6")]
	private static void set_useOcclusionCulling_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FDD080", Offset = "0x2FDC480", Length = "0x86")]
	[Token(Token = "0x6000327")]
	public void set_usePhysicalProperties(bool value) { }

	[Address(RVA = "0x2FDD030", Offset = "0x2FDC430", Length = "0x42")]
	[Token(Token = "0x6000406")]
	private static void set_usePhysicalProperties_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FDD160", Offset = "0x2FDC560", Length = "0x85")]
	[Token(Token = "0x6000357")]
	public void set_worldToCameraMatrix(Matrix4x4 value) { }

	[Address(RVA = "0x2FDD110", Offset = "0x2FDC510", Length = "0x42")]
	[Token(Token = "0x6000434")]
	private static void set_worldToCameraMatrix_Injected(IntPtr _unity_self, in Matrix4x4 value) { }

	[Address(RVA = "0x2FD4F00", Offset = "0x2FD4300", Length = "0x126")]
	[FreeFunction("CameraScripting::SetLayerCullDistances", HasExplicitThis = True)]
	[Token(Token = "0x6000312")]
	private void SetLayerCullDistances(Single[] d) { }

	[Address(RVA = "0x2FD4EB0", Offset = "0x2FD42B0", Length = "0x42")]
	[Token(Token = "0x60003F4")]
	private static void SetLayerCullDistances_Injected(IntPtr _unity_self, ref ManagedSpanWrapper d) { }

	[Address(RVA = "0x2FD5090", Offset = "0x2FD4490", Length = "0x1F7")]
	[Token(Token = "0x6000323")]
	public void SetReplacementShader(Shader shader, string replacementTag) { }

	[Address(RVA = "0x2FD5030", Offset = "0x2FD4430", Length = "0x52")]
	[Token(Token = "0x6000402")]
	private static void SetReplacementShader_Injected(IntPtr _unity_self, IntPtr shader, ref ManagedSpanWrapper replacementTag) { }

	[Address(RVA = "0x2FD52E0", Offset = "0x2FD46E0", Length = "0x93")]
	[Token(Token = "0x600038F")]
	public void SetStereoProjectionMatrix(StereoscopicEye eye, Matrix4x4 matrix) { }

	[Address(RVA = "0x2FD5290", Offset = "0x2FD4690", Length = "0x50")]
	[Token(Token = "0x600045B")]
	private static void SetStereoProjectionMatrix_Injected(IntPtr _unity_self, StereoscopicEye eye, in Matrix4x4 matrix) { }

	[Address(RVA = "0x2FD53D0", Offset = "0x2FD47D0", Length = "0x93")]
	[Token(Token = "0x6000391")]
	public void SetStereoViewMatrix(StereoscopicEye eye, Matrix4x4 matrix) { }

	[Address(RVA = "0x2FD5380", Offset = "0x2FD4780", Length = "0x50")]
	[Token(Token = "0x600045D")]
	private static void SetStereoViewMatrix_Injected(IntPtr _unity_self, StereoscopicEye eye, in Matrix4x4 matrix) { }

	[Address(RVA = "0x2FD56F0", Offset = "0x2FD4AF0", Length = "0x91")]
	[Token(Token = "0x6000351")]
	public void SetTargetBuffers(RenderBuffer colorBuffer, RenderBuffer depthBuffer) { }

	[Address(RVA = "0x2FD5790", Offset = "0x2FD4B90", Length = "0x112")]
	[Token(Token = "0x6000353")]
	public void SetTargetBuffers(RenderBuffer[] colorBuffer, RenderBuffer depthBuffer) { }

	[Address(RVA = "0x2FD54D0", Offset = "0x2FD48D0", Length = "0x95")]
	[FreeFunction("CameraScripting::SetTargetBuffers", HasExplicitThis = True)]
	[Token(Token = "0x6000350")]
	private void SetTargetBuffersImpl(RenderBuffer color, RenderBuffer depth) { }

	[Address(RVA = "0x2FD5470", Offset = "0x2FD4870", Length = "0x52")]
	[Token(Token = "0x600042F")]
	private static void SetTargetBuffersImpl_Injected(IntPtr _unity_self, in RenderBuffer color, in RenderBuffer depth) { }

	[Address(RVA = "0x2FD55D0", Offset = "0x2FD49D0", Length = "0x114")]
	[FreeFunction("CameraScripting::SetTargetBuffers", HasExplicitThis = True)]
	[Token(Token = "0x6000352")]
	private void SetTargetBuffersMRTImpl(RenderBuffer[] color, RenderBuffer depth) { }

	[Address(RVA = "0x2FD5570", Offset = "0x2FD4970", Length = "0x52")]
	[Token(Token = "0x6000430")]
	private static void SetTargetBuffersMRTImpl_Injected(IntPtr _unity_self, ref ManagedSpanWrapper color, in RenderBuffer depth) { }

	[Address(RVA = "0x2FD58F0", Offset = "0x2FD4CF0", Length = "0x6B")]
	[FreeFunction("CameraScripting::SetupCurrent")]
	[Token(Token = "0x60003AA")]
	public static void SetupCurrent(Camera cur) { }

	[Address(RVA = "0x2FD58B0", Offset = "0x2FD4CB0", Length = "0x33")]
	[Token(Token = "0x600046B")]
	private static void SetupCurrent_Injected(IntPtr cur) { }

	[Address(RVA = "0x2FD59D0", Offset = "0x2FD4DD0", Length = "0xD2")]
	[FreeFunction("CameraScripting::SubmitBuiltInObjectIDRenderRequest", HasExplicitThis = True)]
	[NativeConditional("UNITY_EDITOR")]
	[Token(Token = "0x60003A8")]
	private Object[] SubmitBuiltInObjectIDRenderRequest(RenderTexture target, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[Address(RVA = "0x2FD5960", Offset = "0x2FD4D60", Length = "0x62")]
	[Token(Token = "0x6000469")]
	private static Object[] SubmitBuiltInObjectIDRenderRequest_Injected(IntPtr _unity_self, IntPtr target, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[Address(RVA = "0x79C8D0", Offset = "0x79BCD0", Length = "0x3E6")]
	[Token(Token = "0x60003A6")]
	public void SubmitRenderRequest(RequestData renderRequest) { }

	[Address(RVA = "0x2FD5B00", Offset = "0x2FD4F00", Length = "0x85")]
	[FreeFunction("CameraScripting::SubmitRenderRequests", HasExplicitThis = True)]
	[Token(Token = "0x60003A7")]
	private void SubmitRenderRequestsInternal(object requests) { }

	[Address(RVA = "0x2FD5AB0", Offset = "0x2FD4EB0", Length = "0x42")]
	[Token(Token = "0x6000468")]
	private static void SubmitRenderRequestsInternal_Injected(IntPtr _unity_self, object requests) { }

	[Address(RVA = "0x2FD5C30", Offset = "0x2FD5030", Length = "0x82")]
	[Token(Token = "0x60003BF")]
	public bool TryGetCullingParameters(out ScriptableCullingParameters cullingParameters) { }

	[Address(RVA = "0x2FD5B90", Offset = "0x2FD4F90", Length = "0x91")]
	[Token(Token = "0x60003C0")]
	public bool TryGetCullingParameters(bool stereoAware, out ScriptableCullingParameters cullingParameters) { }

	[Address(RVA = "0x2FD5CC0", Offset = "0x2FD50C0", Length = "0x4A")]
	[Token(Token = "0x600037A")]
	public static float VerticalToHorizontalFieldOfView(float verticalFieldOfView, float aspectRatio) { }

	[Address(RVA = "0x2FD5D80", Offset = "0x2FD5180", Length = "0xAE")]
	[Token(Token = "0x600036D")]
	private Ray ViewportPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	[Address(RVA = "0x2FD5F20", Offset = "0x2FD5320", Length = "0xF0")]
	[Token(Token = "0x600036E")]
	public Ray ViewportPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	[Address(RVA = "0x2FD5E30", Offset = "0x2FD5230", Length = "0xE6")]
	[Token(Token = "0x600036F")]
	public Ray ViewportPointToRay(Vector3 pos) { }

	[Address(RVA = "0x2FD5D10", Offset = "0x2FD5110", Length = "0x62")]
	[Token(Token = "0x6000446")]
	private static void ViewportPointToRay_Injected(IntPtr _unity_self, in Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret) { }

	[Address(RVA = "0x2FD6080", Offset = "0x2FD5480", Length = "0xA0")]
	[Token(Token = "0x600036B")]
	public Vector3 ViewportToScreenPoint(Vector3 position) { }

	[Address(RVA = "0x2FD6020", Offset = "0x2FD5420", Length = "0x52")]
	[Token(Token = "0x6000444")]
	private static void ViewportToScreenPoint_Injected(IntPtr _unity_self, in Vector3 position, out Vector3 ret) { }

	[Address(RVA = "0x2FD61A0", Offset = "0x2FD55A0", Length = "0xCC")]
	[Token(Token = "0x6000368")]
	public Vector3 ViewportToWorldPoint(Vector3 position) { }

	[Address(RVA = "0x2FD6270", Offset = "0x2FD5670", Length = "0xB2")]
	[Token(Token = "0x6000364")]
	public Vector3 ViewportToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	[Address(RVA = "0x2FD6130", Offset = "0x2FD5530", Length = "0x62")]
	[Token(Token = "0x6000441")]
	private static void ViewportToWorldPoint_Injected(IntPtr _unity_self, in Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	[Address(RVA = "0x2FD63A0", Offset = "0x2FD57A0", Length = "0xCC")]
	[Token(Token = "0x6000366")]
	public Vector3 WorldToScreenPoint(Vector3 position) { }

	[Address(RVA = "0x2FD6470", Offset = "0x2FD5870", Length = "0xB2")]
	[Token(Token = "0x6000362")]
	public Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	[Address(RVA = "0x2FD6330", Offset = "0x2FD5730", Length = "0x62")]
	[Token(Token = "0x600043F")]
	private static void WorldToScreenPoint_Injected(IntPtr _unity_self, in Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	[Address(RVA = "0x2FD65A0", Offset = "0x2FD59A0", Length = "0xCC")]
	[Token(Token = "0x6000367")]
	public Vector3 WorldToViewportPoint(Vector3 position) { }

	[Address(RVA = "0x2FD6670", Offset = "0x2FD5A70", Length = "0xB2")]
	[Token(Token = "0x6000363")]
	public Vector3 WorldToViewportPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	[Address(RVA = "0x2FD6530", Offset = "0x2FD5930", Length = "0x62")]
	[Token(Token = "0x6000440")]
	private static void WorldToViewportPoint_Injected(IntPtr _unity_self, in Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

}


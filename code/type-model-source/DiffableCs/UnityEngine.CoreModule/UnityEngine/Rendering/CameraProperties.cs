namespace UnityEngine.Rendering;

[Token(Token = "0x20003C9")]
[UsedByNativeCode]
public struct CameraProperties : IEquatable<CameraProperties>
{
	[CompilerGenerated]
	[Token(Token = "0x20003CA")]
	[UnsafeValueType]
	internal struct <layerCullDistances>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C3E")]
		public float FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20003CB")]
	[UnsafeValueType]
	internal struct <m_CameraCullPlanes>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C3F")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20003CC")]
	[UnsafeValueType]
	internal struct <m_ShadowCullPlanes>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C40")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[Token(Token = "0x4000C1B")]
	private const int k_NumLayers = 32; //Field offset: 0x0
	[Token(Token = "0x4000C32")]
	private const int k_PlaneCount = 6; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C1C")]
	private Rect screenRect; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C1D")]
	private Vector3 viewDir; //Field offset: 0x10
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000C1E")]
	private float projectionNear; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C1F")]
	private float projectionFar; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000C20")]
	private float cameraNear; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000C21")]
	private float cameraFar; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000C22")]
	private float cameraAspect; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000C23")]
	private Matrix4x4 cameraToWorld; //Field offset: 0x30
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000C24")]
	private Matrix4x4 actualWorldToClip; //Field offset: 0x70
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000C25")]
	private Matrix4x4 cameraClipToWorld; //Field offset: 0xB0
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000C26")]
	private Matrix4x4 cameraWorldToClip; //Field offset: 0xF0
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000C27")]
	private Matrix4x4 implicitProjection; //Field offset: 0x130
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4000C28")]
	private Matrix4x4 stereoWorldToClipLeft; //Field offset: 0x170
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000C29")]
	private Matrix4x4 stereoWorldToClipRight; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000C2A")]
	private Matrix4x4 worldToCamera; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000C2B")]
	private Vector3 up; //Field offset: 0x230
	[FieldOffset(Offset = "0x23C")]
	[Token(Token = "0x4000C2C")]
	private Vector3 right; //Field offset: 0x23C
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000C2D")]
	private Vector3 transformDirection; //Field offset: 0x248
	[FieldOffset(Offset = "0x254")]
	[Token(Token = "0x4000C2E")]
	private Vector3 cameraEuler; //Field offset: 0x254
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4000C2F")]
	private Vector3 velocity; //Field offset: 0x260
	[FieldOffset(Offset = "0x26C")]
	[Token(Token = "0x4000C30")]
	private float farPlaneWorldSpaceLength; //Field offset: 0x26C
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4000C31")]
	private uint rendererCount; //Field offset: 0x270
	[FieldOffset(Offset = "0x274")]
	[FixedBuffer(typeof(byte), 96)]
	[Token(Token = "0x4000C33")]
	internal <m_ShadowCullPlanes>e__FixedBuffer m_ShadowCullPlanes; //Field offset: 0x274
	[FieldOffset(Offset = "0x2D4")]
	[FixedBuffer(typeof(byte), 96)]
	[Token(Token = "0x4000C34")]
	internal <m_CameraCullPlanes>e__FixedBuffer m_CameraCullPlanes; //Field offset: 0x2D4
	[FieldOffset(Offset = "0x334")]
	[Token(Token = "0x4000C35")]
	private float baseFarDistance; //Field offset: 0x334
	[FieldOffset(Offset = "0x338")]
	[Token(Token = "0x4000C36")]
	private Vector3 shadowCullCenter; //Field offset: 0x338
	[FieldOffset(Offset = "0x344")]
	[FixedBuffer(typeof(float), 32)]
	[Token(Token = "0x4000C37")]
	internal <layerCullDistances>e__FixedBuffer layerCullDistances; //Field offset: 0x344
	[FieldOffset(Offset = "0x3C4")]
	[Token(Token = "0x4000C38")]
	private int layerCullSpherical; //Field offset: 0x3C4
	[FieldOffset(Offset = "0x3C8")]
	[Token(Token = "0x4000C39")]
	private CoreCameraValues coreCameraValues; //Field offset: 0x3C8
	[FieldOffset(Offset = "0x3D4")]
	[Token(Token = "0x4000C3A")]
	private uint cameraType; //Field offset: 0x3D4
	[FieldOffset(Offset = "0x3D8")]
	[Token(Token = "0x4000C3B")]
	private int projectionIsOblique; //Field offset: 0x3D8
	[FieldOffset(Offset = "0x3DC")]
	[Token(Token = "0x4000C3C")]
	private int isImplicitProjectionMatrix; //Field offset: 0x3DC
	[FieldOffset(Offset = "0x3E0")]
	[Token(Token = "0x4000C3D")]
	internal bool useInteractiveLightBakingData; //Field offset: 0x3E0

	[Address(RVA = "0x30BA0D0", Offset = "0x30B94D0", Length = "0x1916")]
	[Token(Token = "0x6001D64")]
	public override bool Equals(CameraProperties other) { }

	[Address(RVA = "0x30BB9F0", Offset = "0x30BADF0", Length = "0x140")]
	[Token(Token = "0x6001D65")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x30BBB40", Offset = "0x30BAF40", Length = "0xF5")]
	[Token(Token = "0x6001D63")]
	public Plane GetCameraCullingPlane(int index) { }

	[Address(RVA = "0x30BBC40", Offset = "0x30BB040", Length = "0x587")]
	[Token(Token = "0x6001D66")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x30BC1D0", Offset = "0x30BB5D0", Length = "0xF5")]
	[Token(Token = "0x6001D62")]
	public Plane GetShadowCullingPlane(int index) { }

}


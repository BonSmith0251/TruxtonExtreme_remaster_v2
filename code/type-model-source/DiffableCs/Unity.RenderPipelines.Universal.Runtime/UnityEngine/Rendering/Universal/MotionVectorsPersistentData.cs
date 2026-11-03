namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000F5")]
internal sealed class MotionVectorsPersistentData
{
	[Token(Token = "0x4000590")]
	private const int k_MaxViewPerPass = 2; //Field offset: 0x0
	[Token(Token = "0x4000592")]
	private const int k_EyeCount = 4; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000591")]
	private Matrix4x4[] m_stagingMatrixArray; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000593")]
	private int m_numPreviousViews; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000594")]
	private readonly Matrix4x4[] m_Projection; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000595")]
	private readonly Matrix4x4[] m_View; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000596")]
	private readonly Matrix4x4[] m_ViewProjection; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000597")]
	private readonly Matrix4x4[] m_PreviousProjection; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000598")]
	private readonly Matrix4x4[] m_PreviousView; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000599")]
	private readonly Matrix4x4[] m_PreviousViewProjection; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400059A")]
	private readonly Matrix4x4[] m_PreviousPreviousProjection; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400059B")]
	private readonly Matrix4x4[] m_PreviousPreviousView; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400059C")]
	private readonly Int32[] m_LastFrameIndex; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400059D")]
	private readonly Single[] m_PrevAspectRatio; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400059E")]
	private float m_deltaTime; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x400059F")]
	private float m_lastDeltaTime; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40005A0")]
	private Vector3 m_worldSpaceCameraPos; //Field offset: 0x78
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x40005A1")]
	private Vector3 m_previousWorldSpaceCameraPos; //Field offset: 0x84
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40005A2")]
	private Vector3 m_previousPreviousWorldSpaceCameraPos; //Field offset: 0x90

	[Token(Token = "0x170001D3")]
	internal float deltaTime
	{
		[Address(RVA = "0x2D7E0B0", Offset = "0x2D7D4B0", Length = "0x6")]
		[Token(Token = "0x60006A4")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x170001D4")]
	internal float lastDeltaTime
	{
		[Address(RVA = "0x26DE200", Offset = "0x26DD600", Length = "0x6")]
		[Token(Token = "0x60006A5")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x170001C7")]
	internal int lastFrameIndex
	{
		[Address(RVA = "0x2DB5180", Offset = "0x2DB4580", Length = "0x26")]
		[Token(Token = "0x6000698")]
		internal get { } //Length: 38
	}

	[Token(Token = "0x170001CF")]
	internal Matrix4x4[] previousPreviousProjectionStereo
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60006A0")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170001D2")]
	internal Matrix4x4[] previousPreviousViewStereo
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x60006A3")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170001D7")]
	internal Vector3 previousPreviousWorldSpaceCameraPos
	{
		[Address(RVA = "0x2DB51B0", Offset = "0x2DB45B0", Length = "0x19")]
		[Token(Token = "0x60006A8")]
		internal get { } //Length: 25
	}

	[Token(Token = "0x170001CE")]
	internal Matrix4x4[] previousProjectionStereo
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x600069F")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170001C9")]
	internal Matrix4x4 previousViewProjection
	{
		[Address(RVA = "0x2DB51D0", Offset = "0x2DB45D0", Length = "0x45")]
		[Token(Token = "0x600069A")]
		internal get { } //Length: 69
	}

	[Token(Token = "0x170001CB")]
	internal Matrix4x4[] previousViewProjectionStereo
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x600069C")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170001D1")]
	internal Matrix4x4[] previousViewStereo
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x60006A2")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170001D6")]
	internal Vector3 previousWorldSpaceCameraPos
	{
		[Address(RVA = "0x2DB5220", Offset = "0x2DB4620", Length = "0x19")]
		[Token(Token = "0x60006A7")]
		internal get { } //Length: 25
	}

	[Token(Token = "0x170001CD")]
	internal Matrix4x4[] projectionStereo
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600069E")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170001CC")]
	internal Matrix4x4[] stagingMatrixStereo
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600069D")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170001C8")]
	internal Matrix4x4 viewProjection
	{
		[Address(RVA = "0x2DB5240", Offset = "0x2DB4640", Length = "0x45")]
		[Token(Token = "0x6000699")]
		internal get { } //Length: 69
	}

	[Token(Token = "0x170001CA")]
	internal Matrix4x4[] viewProjectionStereo
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600069B")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170001D0")]
	internal Matrix4x4[] viewStereo
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60006A1")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170001D5")]
	internal Vector3 worldSpaceCameraPos
	{
		[Address(RVA = "0x1DDF390", Offset = "0x1DDE790", Length = "0x16")]
		[Token(Token = "0x60006A6")]
		internal get { } //Length: 22
	}

	[Address(RVA = "0x2DB4FB0", Offset = "0x2DB43B0", Length = "0x1C1")]
	[Token(Token = "0x6000697")]
	internal MotionVectorsPersistentData() { }

	[Address(RVA = "0x2D7E0B0", Offset = "0x2D7D4B0", Length = "0x6")]
	[Token(Token = "0x60006A4")]
	internal float get_deltaTime() { }

	[Address(RVA = "0x26DE200", Offset = "0x26DD600", Length = "0x6")]
	[Token(Token = "0x60006A5")]
	internal float get_lastDeltaTime() { }

	[Address(RVA = "0x2DB5180", Offset = "0x2DB4580", Length = "0x26")]
	[Token(Token = "0x6000698")]
	internal int get_lastFrameIndex() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60006A0")]
	internal Matrix4x4[] get_previousPreviousProjectionStereo() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x60006A3")]
	internal Matrix4x4[] get_previousPreviousViewStereo() { }

	[Address(RVA = "0x2DB51B0", Offset = "0x2DB45B0", Length = "0x19")]
	[Token(Token = "0x60006A8")]
	internal Vector3 get_previousPreviousWorldSpaceCameraPos() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x600069F")]
	internal Matrix4x4[] get_previousProjectionStereo() { }

	[Address(RVA = "0x2DB51D0", Offset = "0x2DB45D0", Length = "0x45")]
	[Token(Token = "0x600069A")]
	internal Matrix4x4 get_previousViewProjection() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x600069C")]
	internal Matrix4x4[] get_previousViewProjectionStereo() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60006A2")]
	internal Matrix4x4[] get_previousViewStereo() { }

	[Address(RVA = "0x2DB5220", Offset = "0x2DB4620", Length = "0x19")]
	[Token(Token = "0x60006A7")]
	internal Vector3 get_previousWorldSpaceCameraPos() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600069E")]
	internal Matrix4x4[] get_projectionStereo() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600069D")]
	internal Matrix4x4[] get_stagingMatrixStereo() { }

	[Address(RVA = "0x2DB5240", Offset = "0x2DB4640", Length = "0x45")]
	[Token(Token = "0x6000699")]
	internal Matrix4x4 get_viewProjection() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600069B")]
	internal Matrix4x4[] get_viewProjectionStereo() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60006A1")]
	internal Matrix4x4[] get_viewStereo() { }

	[Address(RVA = "0x1DDF390", Offset = "0x1DDE790", Length = "0x16")]
	[Token(Token = "0x60006A6")]
	internal Vector3 get_worldSpaceCameraPos() { }

	[Address(RVA = "0x2DB4010", Offset = "0x2DB3410", Length = "0x2F")]
	[Token(Token = "0x60006AA")]
	private static int GetXRMultiPassId(XRPass xr) { }

	[Address(RVA = "0x2DB4040", Offset = "0x2DB3440", Length = "0x4EC")]
	[Token(Token = "0x60006A9")]
	public void Reset() { }

	[Address(RVA = "0x2DB4530", Offset = "0x2DB3930", Length = "0x27C")]
	[Token(Token = "0x60006AC")]
	public void SetGlobalMotionMatrices(RasterCommandBuffer cmd, XRPass xr) { }

	[Address(RVA = "0x2DB47B0", Offset = "0x2DB3BB0", Length = "0x7F7")]
	[Token(Token = "0x60006AB")]
	public void Update(UniversalCameraData cameraData) { }

}


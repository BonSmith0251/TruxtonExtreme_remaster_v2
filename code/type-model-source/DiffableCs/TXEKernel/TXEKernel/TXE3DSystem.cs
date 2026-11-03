namespace TXEKernel;

[Token(Token = "0x20000A9")]
public class TXE3DSystem : MonoBehaviourSingleton<TXE3DSystem>
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000376")]
	private Transform _collisionArea; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000377")]
	private Transform _systemRoot; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000378")]
	private Camera _mainCamera; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000379")]
	private CinemachineBrain _mainCameraBrain; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400037A")]
	private LayerMask _defaultMainMask; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400037B")]
	private Camera _baseCamera; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400037C")]
	private Camera _supportCamera; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400037D")]
	private CinemachineBrain _supportCameraBrain; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400037E")]
	private Camera _collisionCamera; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400037F")]
	private Camera _groundCamera; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000380")]
	private Camera _uiCamera; //Field offset: 0x70

	[Token(Token = "0x170001CA")]
	public Camera BaseCamera
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6000586")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001CB")]
	public CinemachineBrain CameraBrain
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x6000587")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001C7")]
	public Transform CollisionAreaTransform
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000583")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001CC")]
	public Camera CollisionCamera
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6000588")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001C9")]
	public Camera MainCamera
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000585")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001C8")]
	public Transform SystemRootTransform
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000584")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x26FEEC0", Offset = "0x26FE2C0", Length = "0x2AD")]
	[Token(Token = "0x600057F")]
	private void _InitializeCameras(Camera uiCamera) { }

	[Address(RVA = "0x26FF170", Offset = "0x26FE570", Length = "0x45")]
	[Token(Token = "0x6000589")]
	public TXE3DSystem() { }

	[Address(RVA = "0x26FDA90", Offset = "0x26FCE90", Length = "0xFB")]
	[Token(Token = "0x600057B")]
	private static void AddToStackUnique(List<Camera> cameraStack, Camera cam) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000581")]
	public void ApplyStageUpscalingIfNeeded(float tscale) { }

	[Address(RVA = "0x26FDB90", Offset = "0x26FCF90", Length = "0x9C")]
	[Token(Token = "0x600057D")]
	private static void AssertOverlayRendererSupported(UniversalAdditionalCameraData baseData, Camera overlayCamera) { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6000586")]
	public Camera get_BaseCamera() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6000587")]
	public CinemachineBrain get_CameraBrain() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000583")]
	public Transform get_CollisionAreaTransform() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6000588")]
	public Camera get_CollisionCamera() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000585")]
	public Camera get_MainCamera() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000584")]
	public Transform get_SystemRootTransform() { }

	[Address(RVA = "0x26FDC30", Offset = "0x26FD030", Length = "0x11A")]
	[Token(Token = "0x6000572")]
	public void InitializeSystem(Camera uiCamera) { }

	[Address(RVA = "0x26FDD50", Offset = "0x26FD150", Length = "0x1D0")]
	[Token(Token = "0x6000579")]
	private void ResetCameraStack(Camera baseCamera) { }

	[Address(RVA = "0x26FDF30", Offset = "0x26FD330", Length = "0x1BA")]
	[Token(Token = "0x6000574")]
	public void RestoreAfterStage() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000582")]
	public void RestoreUpscalingAfterStage() { }

	[Address(RVA = "0x26FE0F0", Offset = "0x26FD4F0", Length = "0x665")]
	[Token(Token = "0x6000578")]
	private void SetCameraStack(Camera baseCamera) { }

	[Address(RVA = "0x26FE760", Offset = "0x26FDB60", Length = "0x8E")]
	[Token(Token = "0x6000576")]
	public void SetClearColor(Color color) { }

	[Address(RVA = "0x26FE7F0", Offset = "0x26FDBF0", Length = "0x198")]
	[Token(Token = "0x6000580")]
	private static void SetGroundCameraRenderer(Camera camera) { }

	[Address(RVA = "0x26FE990", Offset = "0x26FDD90", Length = "0xC3")]
	[Token(Token = "0x600057A")]
	private static void SetupAsOverlay(Camera cam, bool clearDepth) { }

	[Address(RVA = "0x26FEA60", Offset = "0x26FDE60", Length = "0xC1")]
	[Token(Token = "0x6000577")]
	public void SetupCollisionCamera(Vector3 position, Quaternion rotation) { }

	[Address(RVA = "0x26FEB30", Offset = "0x26FDF30", Length = "0x211")]
	[Token(Token = "0x6000573")]
	public void SwitchToStageCamera(Camera stageCamera, Nullable<LayerMask> mainCullingMask = null) { }

	[Address(RVA = "0x26FED50", Offset = "0x26FE150", Length = "0xCB")]
	[Token(Token = "0x600057C")]
	private static bool TryGetCameraStack(UniversalAdditionalCameraData baseData, out List<Camera>& cameraStack) { }

	[Address(RVA = "0x26FEE20", Offset = "0x26FE220", Length = "0x11")]
	[Token(Token = "0x6000575")]
	public void UpdateCamera() { }

	[Address(RVA = "0x26FEE40", Offset = "0x26FE240", Length = "0x7F")]
	[Token(Token = "0x600057E")]
	private static void WarnIfBaseOverlayUnsupported(UniversalAdditionalCameraData baseData) { }

}


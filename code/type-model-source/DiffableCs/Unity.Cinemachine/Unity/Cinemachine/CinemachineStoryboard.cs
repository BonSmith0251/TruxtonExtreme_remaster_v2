namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Extensions/Cinemachine Storyboard")]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineStoryboard.html")]
[SaveDuringPlay]
[Token(Token = "0x200004E")]
public class CinemachineStoryboard : CinemachineExtension
{
	[Token(Token = "0x2000050")]
	private class CanvasInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400013B")]
		public GameObject Canvas; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400013C")]
		public Canvas CanvasComponent; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400013D")]
		public CinemachineBrain CanvasParent; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400013E")]
		public RectTransform Viewport; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400013F")]
		public RawImage RawImage; //Field offset: 0x30

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000157")]
		public CanvasInfo() { }

	}

	[Token(Token = "0x200004F")]
	internal enum FillStrategy : int
	{
		BestFit = 0,
		CropImageToFit = 1,
		StretchToFit = 2,
	}

	[Token(Token = "0x2000051")]
	internal enum StoryboardRenderMode : int
	{
		ScreenSpaceOverlay = 0,
		ScreenSpaceCamera = 1,
	}

	[Token(Token = "0x4000128")]
	[Tooltip("If checked, all storyboards are globally muted")]
	public static bool s_StoryboardGlobalMute; //Field offset: 0x0
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_ShowImage")]
	[Token(Token = "0x4000129")]
	[Tooltip("If checked, the specified image will be displayed as an overlay over the virtual camera's output")]
	public bool ShowImage; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("m_Image")]
	[Token(Token = "0x400012A")]
	[Tooltip("The image to display")]
	public Texture Image; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("m_Aspect")]
	[Token(Token = "0x400012B")]
	[Tooltip("How to handle differences between image aspect and screen aspect")]
	public FillStrategy Aspect; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[FormerlySerializedAs("m_Alpha")]
	[Range(0, 1)]
	[Token(Token = "0x400012C")]
	[Tooltip("The opacity of the image.  0 is transparent, 1 is opaque")]
	public float Alpha; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[FormerlySerializedAs("m_Center")]
	[Token(Token = "0x400012D")]
	[Tooltip("The screen-space position at which to display the image.  Zero is center")]
	public Vector2 Center; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[FormerlySerializedAs("m_Rotation")]
	[Token(Token = "0x400012E")]
	[Tooltip("The screen-space rotation to apply to the image")]
	public Vector3 Rotation; //Field offset: 0x50
	[FieldOffset(Offset = "0x5C")]
	[FormerlySerializedAs("m_Scale")]
	[Token(Token = "0x400012F")]
	[Tooltip("The screen-space scaling to apply to the image")]
	public Vector2 Scale; //Field offset: 0x5C
	[FieldOffset(Offset = "0x64")]
	[FormerlySerializedAs("m_SyncScale")]
	[Token(Token = "0x4000130")]
	[Tooltip("If checked, X and Y scale are synchronized")]
	public bool SyncScale; //Field offset: 0x64
	[FieldOffset(Offset = "0x65")]
	[FormerlySerializedAs("m_MuteCamera")]
	[Token(Token = "0x4000131")]
	[Tooltip("If checked, Camera transform will not be controlled by this virtual camera")]
	public bool MuteCamera; //Field offset: 0x65
	[FieldOffset(Offset = "0x68")]
	[FormerlySerializedAs("m_SplitView")]
	[Range(-1, 1)]
	[Token(Token = "0x4000132")]
	[Tooltip("Wipe the image on and off horizontally")]
	public float SplitView; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[FormerlySerializedAs("m_RenderMode")]
	[Token(Token = "0x4000133")]
	[Tooltip("The render mode of the canvas on which the storyboard is drawn.")]
	public StoryboardRenderMode RenderMode; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[FormerlySerializedAs("m_SortingOrder")]
	[Token(Token = "0x4000134")]
	[Tooltip("Allows ordering canvases to render on top or below other canvases.")]
	public int SortingOrder; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[FormerlySerializedAs("m_PlaneDistance")]
	[Token(Token = "0x4000135")]
	[Tooltip("How far away from the camera is the Canvas generated.")]
	public float PlaneDistance; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000136")]
	private List<CanvasInfo> m_CanvasInfo; //Field offset: 0x78

	[Token(Token = "0x1700002A")]
	private string CanvasName
	{
		[Address(RVA = "0x282C2C0", Offset = "0x282B6C0", Length = "0x73")]
		[Token(Token = "0x600014E")]
		private get { } //Length: 115
	}

	[Address(RVA = "0x282C180", Offset = "0x282B580", Length = "0x13F")]
	[Token(Token = "0x6000156")]
	public CinemachineStoryboard() { }

	[Address(RVA = "0x282A3B0", Offset = "0x28297B0", Length = "0x15C")]
	[Token(Token = "0x600014F")]
	private void CameraUpdatedCallback(CinemachineBrain brain) { }

	[Address(RVA = "0x282A510", Offset = "0x2829910", Length = "0x16E")]
	[Token(Token = "0x600014D")]
	protected virtual void ConnectToVcam(bool connect) { }

	[Address(RVA = "0x282A680", Offset = "0x2829A80", Length = "0x4ED")]
	[Token(Token = "0x6000151")]
	private void CreateCanvas(CanvasInfo ci) { }

	[Address(RVA = "0x282AB70", Offset = "0x2829F70", Length = "0x212")]
	[Token(Token = "0x6000152")]
	private void DestroyCanvas() { }

	[Address(RVA = "0x282C2C0", Offset = "0x282B6C0", Length = "0x73")]
	[Token(Token = "0x600014E")]
	private string get_CanvasName() { }

	[Address(RVA = "0x282AD90", Offset = "0x282A190", Length = "0x115")]
	[RuntimeInitializeOnLoadMethod]
	[Token(Token = "0x6000155")]
	private static void InitializeModule() { }

	[Address(RVA = "0x282AEB0", Offset = "0x282A2B0", Length = "0x496")]
	[Token(Token = "0x6000150")]
	private CanvasInfo LocateMyCanvas(CinemachineBrain parent, bool createIfNotFound) { }

	[Address(RVA = "0x282B350", Offset = "0x282A750", Length = "0x7B3")]
	[Token(Token = "0x6000153")]
	private void PlaceImage(CanvasInfo ci, float alpha) { }

	[Address(RVA = "0x282BB10", Offset = "0x282AF10", Length = "0x151")]
	[Token(Token = "0x600014B")]
	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	[Address(RVA = "0x282BC70", Offset = "0x282B070", Length = "0x334")]
	[Token(Token = "0x6000154")]
	private static void StaticBlendingHandler(CinemachineBrain brain) { }

	[Address(RVA = "0x282BFB0", Offset = "0x282B3B0", Length = "0x1CA")]
	[Token(Token = "0x600014C")]
	private void UpdateRenderCanvas() { }

}


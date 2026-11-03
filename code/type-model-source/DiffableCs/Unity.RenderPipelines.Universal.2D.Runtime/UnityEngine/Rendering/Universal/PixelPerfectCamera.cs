namespace UnityEngine.Rendering.Universal;

[AddComponentMenu("Rendering/2D/Pixel Perfect Camera")]
[DisallowMultipleComponent]
[ExecuteInEditMode]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@latest/index.html?subfolder=/manual/2d-pixelperfect.html%23properties")]
[MovedFrom(True, "UnityEngine.Experimental.Rendering.Universal", null, null)]
[RequireComponent(typeof(Camera))]
[Token(Token = "0x2000041")]
public class PixelPerfectCamera : MonoBehaviour, IPixelPerfectCamera, ISerializationCallbackReceiver
{
	[Token(Token = "0x2000045")]
	private enum ComponentVersions : int
	{
		Version_Unserialized = 0,
		Version_1 = 1,
	}

	[Token(Token = "0x2000042")]
	internal enum CropFrame : int
	{
		None = 0,
		Pillarbox = 1,
		Letterbox = 2,
		Windowbox = 3,
		StretchFill = 4,
	}

	[Token(Token = "0x2000043")]
	internal enum GridSnapping : int
	{
		None = 0,
		PixelSnapping = 1,
		UpscaleRenderTexture = 2,
	}

	[Token(Token = "0x2000044")]
	internal enum PixelPerfectFilterMode : int
	{
		RetroAA = 0,
		Point = 1,
	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400016A")]
	private int m_AssetsPPU; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x400016B")]
	private int m_RefResolutionX; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400016C")]
	private int m_RefResolutionY; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x400016D")]
	private CropFrame m_CropFrame; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400016E")]
	private GridSnapping m_GridSnapping; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x400016F")]
	private PixelPerfectFilterMode m_FilterMode; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000170")]
	private Camera m_Camera; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000171")]
	private PixelPerfectCameraInternal m_Internal; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000172")]
	private bool m_CinemachineCompatibilityMode; //Field offset: 0x48

	[Token(Token = "0x17000053")]
	public override int assetsPPU
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x60001B9")]
		 get { } //Length: 4
		[Address(RVA = "0x2D2C900", Offset = "0x2D2BD00", Length = "0x20")]
		[Token(Token = "0x60001BA")]
		 set { } //Length: 32
	}

	[Token(Token = "0x1700005F")]
	private Vector2Int cameraRTSize
	{
		[Address(RVA = "0x2D2C710", Offset = "0x2D2BB10", Length = "0xCC")]
		[Token(Token = "0x60001CF")]
		private get { } //Length: 204
	}

	[Token(Token = "0x17000050")]
	public CropFrame cropFrame
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[Token(Token = "0x60001B4")]
		 get { } //Length: 4
		[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
		[Token(Token = "0x60001B5")]
		 set { } //Length: 4
	}

	[Obsolete("Use cropFrame instead #from(2021.2)")]
	[Token(Token = "0x17000058")]
	public override bool cropFrameX
	{
		[Address(RVA = "0x2D2C7E0", Offset = "0x2D2BBE0", Length = "0x17")]
		[Token(Token = "0x60001C3")]
		 get { } //Length: 23
		[Address(RVA = "0x2D2C930", Offset = "0x2D2BD30", Length = "0x3F")]
		[Token(Token = "0x60001C4")]
		 set { } //Length: 63
	}

	[Obsolete("Use cropFrame instead #from(2021.2)")]
	[Token(Token = "0x17000059")]
	public override bool cropFrameY
	{
		[Address(RVA = "0x2D2C800", Offset = "0x2D2BC00", Length = "0x17")]
		[Token(Token = "0x60001C5")]
		 get { } //Length: 23
		[Address(RVA = "0x2D2C970", Offset = "0x2D2BD70", Length = "0x3F")]
		[Token(Token = "0x60001C6")]
		 set { } //Length: 63
	}

	[Token(Token = "0x1700005D")]
	internal FilterMode finalBlitFilterMode
	{
		[Address(RVA = "0x2D2C820", Offset = "0x2D2BC20", Length = "0x9")]
		[Token(Token = "0x60001CD")]
		internal get { } //Length: 9
	}

	[Token(Token = "0x17000051")]
	public GridSnapping gridSnapping
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x60001B6")]
		 get { } //Length: 4
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[Token(Token = "0x60001B7")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700005E")]
	internal Vector2Int offscreenRTSize
	{
		[Address(RVA = "0x2D2C830", Offset = "0x2D2BC30", Length = "0x2E")]
		[Token(Token = "0x60001CE")]
		internal get { } //Length: 46
	}

	[Token(Token = "0x17000052")]
	public float orthographicSize
	{
		[Address(RVA = "0x2D2C860", Offset = "0x2D2BC60", Length = "0x1C")]
		[Token(Token = "0x60001B8")]
		 get { } //Length: 28
	}

	[Token(Token = "0x1700005B")]
	public int pixelRatio
	{
		[Address(RVA = "0x2D2C880", Offset = "0x2D2BC80", Length = "0x3B")]
		[Token(Token = "0x60001C9")]
		 get { } //Length: 59
	}

	[Obsolete("Use gridSnapping instead #from(2021.2)")]
	[Token(Token = "0x17000057")]
	public override bool pixelSnapping
	{
		[Address(RVA = "0x2522A20", Offset = "0x2521E20", Length = "0x8")]
		[Token(Token = "0x60001C1")]
		 get { } //Length: 8
		[Address(RVA = "0x2D2C9B0", Offset = "0x2D2BDB0", Length = "0x19")]
		[Token(Token = "0x60001C2")]
		 set { } //Length: 25
	}

	[Token(Token = "0x17000054")]
	public override int refResolutionX
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x60001BB")]
		 get { } //Length: 4
		[Address(RVA = "0x2D2C9D0", Offset = "0x2D2BDD0", Length = "0x20")]
		[Token(Token = "0x60001BC")]
		 set { } //Length: 32
	}

	[Token(Token = "0x17000055")]
	public override int refResolutionY
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x60001BD")]
		 get { } //Length: 4
		[Address(RVA = "0x2D2CA00", Offset = "0x2D2BE00", Length = "0x20")]
		[Token(Token = "0x60001BE")]
		 set { } //Length: 32
	}

	[Token(Token = "0x1700005C")]
	public bool requiresUpscalePass
	{
		[Address(RVA = "0x2D2C8C0", Offset = "0x2D2BCC0", Length = "0x1B")]
		[Token(Token = "0x60001CA")]
		 get { } //Length: 27
	}

	[Obsolete("Use cropFrame instead. #from(2021.2)")]
	[Token(Token = "0x1700005A")]
	public override bool stretchFill
	{
		[Address(RVA = "0x2D2C8E0", Offset = "0x2D2BCE0", Length = "0x8")]
		[Token(Token = "0x60001C7")]
		 get { } //Length: 8
		[Address(RVA = "0x2D2CA30", Offset = "0x2D2BE30", Length = "0xA")]
		[Token(Token = "0x60001C8")]
		 set { } //Length: 10
	}

	[Obsolete("Use gridSnapping instead #from(2021.2)")]
	[Token(Token = "0x17000056")]
	public override bool upscaleRT
	{
		[Address(RVA = "0x2D2C8F0", Offset = "0x2D2BCF0", Length = "0x8")]
		[Token(Token = "0x60001BF")]
		 get { } //Length: 8
		[Address(RVA = "0x2D2CA40", Offset = "0x2D2BE40", Length = "0x1B")]
		[Token(Token = "0x60001C0")]
		 set { } //Length: 27
	}

	[Address(RVA = "0x2D2C6F0", Offset = "0x2D2BAF0", Length = "0x1C")]
	[Token(Token = "0x60001D9")]
	public PixelPerfectCamera() { }

	[Address(RVA = "0x2D2BAE0", Offset = "0x2D2AEE0", Length = "0x12D")]
	[Token(Token = "0x60001D1")]
	private void Awake() { }

	[Address(RVA = "0x2D2BC10", Offset = "0x2D2B010", Length = "0x1B")]
	[Token(Token = "0x60001CC")]
	public float CorrectCinemachineOrthoSize(float targetOrthoSize) { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x60001B9")]
	public override int get_assetsPPU() { }

	[Address(RVA = "0x2D2C710", Offset = "0x2D2BB10", Length = "0xCC")]
	[Token(Token = "0x60001CF")]
	private Vector2Int get_cameraRTSize() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x60001B4")]
	public CropFrame get_cropFrame() { }

	[Address(RVA = "0x2D2C7E0", Offset = "0x2D2BBE0", Length = "0x17")]
	[Token(Token = "0x60001C3")]
	public override bool get_cropFrameX() { }

	[Address(RVA = "0x2D2C800", Offset = "0x2D2BC00", Length = "0x17")]
	[Token(Token = "0x60001C5")]
	public override bool get_cropFrameY() { }

	[Address(RVA = "0x2D2C820", Offset = "0x2D2BC20", Length = "0x9")]
	[Token(Token = "0x60001CD")]
	internal FilterMode get_finalBlitFilterMode() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x60001B6")]
	public GridSnapping get_gridSnapping() { }

	[Address(RVA = "0x2D2C830", Offset = "0x2D2BC30", Length = "0x2E")]
	[Token(Token = "0x60001CE")]
	internal Vector2Int get_offscreenRTSize() { }

	[Address(RVA = "0x2D2C860", Offset = "0x2D2BC60", Length = "0x1C")]
	[Token(Token = "0x60001B8")]
	public float get_orthographicSize() { }

	[Address(RVA = "0x2D2C880", Offset = "0x2D2BC80", Length = "0x3B")]
	[Token(Token = "0x60001C9")]
	public int get_pixelRatio() { }

	[Address(RVA = "0x2522A20", Offset = "0x2521E20", Length = "0x8")]
	[Token(Token = "0x60001C1")]
	public override bool get_pixelSnapping() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x60001BB")]
	public override int get_refResolutionX() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x60001BD")]
	public override int get_refResolutionY() { }

	[Address(RVA = "0x2D2C8C0", Offset = "0x2D2BCC0", Length = "0x1B")]
	[Token(Token = "0x60001CA")]
	public bool get_requiresUpscalePass() { }

	[Address(RVA = "0x2D2C8E0", Offset = "0x2D2BCE0", Length = "0x8")]
	[Token(Token = "0x60001C7")]
	public override bool get_stretchFill() { }

	[Address(RVA = "0x2D2C8F0", Offset = "0x2D2BCF0", Length = "0x8")]
	[Token(Token = "0x60001BF")]
	public override bool get_upscaleRT() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001D8")]
	public override void OnAfterDeserialize() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001D7")]
	public override void OnBeforeSerialize() { }

	[Address(RVA = "0x2D2BC30", Offset = "0x2D2B030", Length = "0xBF")]
	[Token(Token = "0x60001D3")]
	private void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera) { }

	[Address(RVA = "0x2D2BCF0", Offset = "0x2D2B0F0", Length = "0xDF")]
	[Token(Token = "0x60001D6")]
	internal void OnDisable() { }

	[Address(RVA = "0x2D2BDD0", Offset = "0x2D2B1D0", Length = "0xAB")]
	[Token(Token = "0x60001D5")]
	private void OnEnable() { }

	[Address(RVA = "0x2D2BE80", Offset = "0x2D2B280", Length = "0x6C")]
	[Token(Token = "0x60001D4")]
	private void OnEndCameraRendering(ScriptableRenderContext context, Camera camera) { }

	[Address(RVA = "0x2D2BEF0", Offset = "0x2D2B2F0", Length = "0x58E")]
	[Token(Token = "0x60001D0")]
	private void PixelSnap() { }

	[Address(RVA = "0x2D2C480", Offset = "0x2D2B880", Length = "0xD3")]
	[Token(Token = "0x60001CB")]
	public Vector3 RoundToPixel(Vector3 position) { }

	[Address(RVA = "0x2D2C900", Offset = "0x2D2BD00", Length = "0x20")]
	[Token(Token = "0x60001BA")]
	public override void set_assetsPPU(int value) { }

	[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
	[Token(Token = "0x60001B5")]
	public void set_cropFrame(CropFrame value) { }

	[Address(RVA = "0x2D2C930", Offset = "0x2D2BD30", Length = "0x3F")]
	[Token(Token = "0x60001C4")]
	public override void set_cropFrameX(bool value) { }

	[Address(RVA = "0x2D2C970", Offset = "0x2D2BD70", Length = "0x3F")]
	[Token(Token = "0x60001C6")]
	public override void set_cropFrameY(bool value) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[Token(Token = "0x60001B7")]
	public void set_gridSnapping(GridSnapping value) { }

	[Address(RVA = "0x2D2C9B0", Offset = "0x2D2BDB0", Length = "0x19")]
	[Token(Token = "0x60001C2")]
	public override void set_pixelSnapping(bool value) { }

	[Address(RVA = "0x2D2C9D0", Offset = "0x2D2BDD0", Length = "0x20")]
	[Token(Token = "0x60001BC")]
	public override void set_refResolutionX(int value) { }

	[Address(RVA = "0x2D2CA00", Offset = "0x2D2BE00", Length = "0x20")]
	[Token(Token = "0x60001BE")]
	public override void set_refResolutionY(int value) { }

	[Address(RVA = "0x2D2CA30", Offset = "0x2D2BE30", Length = "0xA")]
	[Token(Token = "0x60001C8")]
	public override void set_stretchFill(bool value) { }

	[Address(RVA = "0x2D2CA40", Offset = "0x2D2BE40", Length = "0x1B")]
	[Token(Token = "0x60001C0")]
	public override void set_upscaleRT(bool value) { }

	[Address(RVA = "0x2D2C560", Offset = "0x2D2B960", Length = "0x183")]
	[Token(Token = "0x60001D2")]
	private void UpdateCameraProperties() { }

}


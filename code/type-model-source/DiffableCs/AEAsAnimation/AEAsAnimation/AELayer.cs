namespace AEAsAnimation;

[Token(Token = "0x2000033")]
public class AELayer : MonoBehaviour
{
	[Token(Token = "0x2000034")]
	internal sealed class SelfEventHandler : MulticastDelegate
	{

		[Address(RVA = "0x5BC6F0", Offset = "0x5BBAF0", Length = "0x124")]
		[Token(Token = "0x60000DA")]
		public SelfEventHandler(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6A0", Offset = "0x5BBAA0", Length = "0x21")]
		[Token(Token = "0x60000DC")]
		public override IAsyncResult BeginInvoke(AELayer layer, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x60000DD")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x60000DB")]
		public override void Invoke(AELayer layer) { }

	}

	[Token(Token = "0x2000035")]
	internal class TransformPack
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000162")]
		public Transform node; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000163")]
		public Vector3 position; //Field offset: 0x18
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000164")]
		public Vector3 scale; //Field offset: 0x24
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000165")]
		public Quaternion rotation; //Field offset: 0x30

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000DF")]
		public TransformPack() { }

		[Address(RVA = "0x5BC820", Offset = "0x5BBC20", Length = "0x14C")]
		[Token(Token = "0x60000DE")]
		public virtual string ToString() { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400014C")]
	private SelfEventHandler OnUpdated; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400014D")]
	private LayerData _data; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400014E")]
	private AEItemsAccessor _accessor; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400014F")]
	private AELayerReflector _reflector; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000150")]
	private PositionFrameProcessor _position; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000151")]
	private AngleFrameProcessor _rotation; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000152")]
	private SizeFrameProcessor _scale; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000153")]
	private PositionFrameProcessor _anchor; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000154")]
	private OpacityFrameProcessor _opacity; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000155")]
	private List<AEMaskProcessor> _masks; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000156")]
	private bool _defaultMask; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000157")]
	private AVLayerStyleStrokeData _stroke; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000158")]
	private Transform _nodeTreeRoot; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000159")]
	private AEComposition _parentComposition; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400015A")]
	private AEFootage _footage; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400015B")]
	private AEAudio _audio; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400015C")]
	private bool _isLoop; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x400015D")]
	private Vector3 _positionOffset; //Field offset: 0xA4
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400015E")]
	private float _elaspedSeconds; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x400015F")]
	private float _layerSeconds; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000160")]
	private float _footageSeconds; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x4000161")]
	private int _lastFrame; //Field offset: 0xBC

	[Token(Token = "0x14000001")]
	public event SelfEventHandler OnUpdated
	{
		[Address(RVA = "0x5BAA50", Offset = "0x5B9E50", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60000AD")]
		 add { } //Length: 158
		[Address(RVA = "0x5BAF80", Offset = "0x5BA380", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60000AE")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000027")]
	public List<String> allImageFiles
	{
		[Address(RVA = "0x5BAAF0", Offset = "0x5B9EF0", Length = "0x12B")]
		[Token(Token = "0x60000D6")]
		 get { } //Length: 299
	}

	[Token(Token = "0x17000028")]
	public List<String> allLayerMetaData
	{
		[Address(RVA = "0x5BAC20", Offset = "0x5BA020", Length = "0xAA")]
		[Token(Token = "0x60000D7")]
		 get { } //Length: 170
	}

	[Token(Token = "0x17000020")]
	public float anchorX
	{
		[Address(RVA = "0x5BACD0", Offset = "0x5BA0D0", Length = "0x1D")]
		[Token(Token = "0x60000CE")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000021")]
	public float anchorY
	{
		[Address(RVA = "0x5BACF0", Offset = "0x5BA0F0", Length = "0x1D")]
		[Token(Token = "0x60000CF")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000019")]
	public LayerData data
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60000C7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700001A")]
	public AEFootage footage
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x60000C8")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000026")]
	public string imageFile
	{
		[Address(RVA = "0x5BAD20", Offset = "0x5BA120", Length = "0x5B")]
		[Token(Token = "0x60000D5")]
		 get { } //Length: 91
	}

	[Token(Token = "0x17000023")]
	public Vector2 leftTop
	{
		[Address(RVA = "0x5BAD80", Offset = "0x5BA180", Length = "0x41")]
		[Token(Token = "0x60000D1")]
		 get { } //Length: 65
	}

	[Token(Token = "0x17000022")]
	public float opacity
	{
		[Address(RVA = "0x5BADD0", Offset = "0x5BA1D0", Length = "0x70")]
		[Token(Token = "0x60000D0")]
		 get { } //Length: 112
	}

	[Token(Token = "0x17000024")]
	public Vector3 positionOffset
	{
		[Address(RVA = "0x5BAE50", Offset = "0x5BA250", Length = "0x19")]
		[Token(Token = "0x60000D3")]
		 get { } //Length: 25
		[Address(RVA = "0x5BB050", Offset = "0x5BA450", Length = "0x16")]
		[Token(Token = "0x60000D2")]
		 set { } //Length: 22
	}

	[Token(Token = "0x1700001D")]
	public float rotation
	{
		[Address(RVA = "0x5BAE70", Offset = "0x5BA270", Length = "0x1D")]
		[Token(Token = "0x60000CB")]
		 get { } //Length: 29
	}

	[Token(Token = "0x1700001E")]
	public float scaleX
	{
		[Address(RVA = "0x5BAE90", Offset = "0x5BA290", Length = "0x1D")]
		[Token(Token = "0x60000CC")]
		 get { } //Length: 29
	}

	[Token(Token = "0x1700001F")]
	public float scaleY
	{
		[Address(RVA = "0x5BAEB0", Offset = "0x5BA2B0", Length = "0x1D")]
		[Token(Token = "0x60000CD")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000025")]
	public int totalFrame
	{
		[Address(RVA = "0x5BAED0", Offset = "0x5BA2D0", Length = "0x57")]
		[Token(Token = "0x60000D4")]
		 get { } //Length: 87
	}

	[Token(Token = "0x1700001B")]
	public float x
	{
		[Address(RVA = "0x5BAF30", Offset = "0x5BA330", Length = "0x1D")]
		[Token(Token = "0x60000C9")]
		 get { } //Length: 29
	}

	[Token(Token = "0x1700001C")]
	public float y
	{
		[Address(RVA = "0x5BAF50", Offset = "0x5BA350", Length = "0x26")]
		[Token(Token = "0x60000CA")]
		 get { } //Length: 38
	}

	[Address(RVA = "0x5BA9F0", Offset = "0x5B9DF0", Length = "0x57")]
	[Token(Token = "0x60000D9")]
	public AELayer() { }

	[Address(RVA = "0x5BAA50", Offset = "0x5B9E50", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60000AD")]
	public void add_OnUpdated(SelfEventHandler value) { }

	[Address(RVA = "0x5B7B60", Offset = "0x5B6F60", Length = "0x2CA")]
	[Token(Token = "0x60000AF")]
	public static AELayer Attach(Transform parent, LayerData data, AEItemsAccessor accessor, AEComposition parentComposition) { }

	[Address(RVA = "0x5B7E30", Offset = "0x5B7230", Length = "0x298")]
	[Token(Token = "0x60000C3")]
	private float CalcAudioLevel(float remapSeconds) { }

	[Address(RVA = "0x5B80D0", Offset = "0x5B74D0", Length = "0xC7")]
	[Token(Token = "0x60000BC")]
	private float CalcFootageTime(float remapSeconds) { }

	[Address(RVA = "0x5B81A0", Offset = "0x5B75A0", Length = "0x9A")]
	[Token(Token = "0x60000BA")]
	public float CalcParentRemapedTime(float remapSeconds) { }

	[Address(RVA = "0x5B8240", Offset = "0x5B7640", Length = "0x1F5")]
	[Token(Token = "0x60000BB")]
	private float CalcRemapedTime(float remapSeconds) { }

	[Address(RVA = "0x5BAAF0", Offset = "0x5B9EF0", Length = "0x12B")]
	[Token(Token = "0x60000D6")]
	public List<String> get_allImageFiles() { }

	[Address(RVA = "0x5BAC20", Offset = "0x5BA020", Length = "0xAA")]
	[Token(Token = "0x60000D7")]
	public List<String> get_allLayerMetaData() { }

	[Address(RVA = "0x5BACD0", Offset = "0x5BA0D0", Length = "0x1D")]
	[Token(Token = "0x60000CE")]
	public float get_anchorX() { }

	[Address(RVA = "0x5BACF0", Offset = "0x5BA0F0", Length = "0x1D")]
	[Token(Token = "0x60000CF")]
	public float get_anchorY() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60000C7")]
	public LayerData get_data() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x60000C8")]
	public AEFootage get_footage() { }

	[Address(RVA = "0x5BAD20", Offset = "0x5BA120", Length = "0x5B")]
	[Token(Token = "0x60000D5")]
	public string get_imageFile() { }

	[Address(RVA = "0x5BAD80", Offset = "0x5BA180", Length = "0x41")]
	[Token(Token = "0x60000D1")]
	public Vector2 get_leftTop() { }

	[Address(RVA = "0x5BADD0", Offset = "0x5BA1D0", Length = "0x70")]
	[Token(Token = "0x60000D0")]
	public float get_opacity() { }

	[Address(RVA = "0x5BAE50", Offset = "0x5BA250", Length = "0x19")]
	[Token(Token = "0x60000D3")]
	public Vector3 get_positionOffset() { }

	[Address(RVA = "0x5BAE70", Offset = "0x5BA270", Length = "0x1D")]
	[Token(Token = "0x60000CB")]
	public float get_rotation() { }

	[Address(RVA = "0x5BAE90", Offset = "0x5BA290", Length = "0x1D")]
	[Token(Token = "0x60000CC")]
	public float get_scaleX() { }

	[Address(RVA = "0x5BAEB0", Offset = "0x5BA2B0", Length = "0x1D")]
	[Token(Token = "0x60000CD")]
	public float get_scaleY() { }

	[Address(RVA = "0x5BAED0", Offset = "0x5BA2D0", Length = "0x57")]
	[Token(Token = "0x60000D4")]
	public int get_totalFrame() { }

	[Address(RVA = "0x5BAF30", Offset = "0x5BA330", Length = "0x1D")]
	[Token(Token = "0x60000C9")]
	public float get_x() { }

	[Address(RVA = "0x5BAF50", Offset = "0x5BA350", Length = "0x26")]
	[Token(Token = "0x60000CA")]
	public float get_y() { }

	[Address(RVA = "0x5B8440", Offset = "0x5B7840", Length = "0x103")]
	[Token(Token = "0x60000BD")]
	public float GetOpacity() { }

	[Address(RVA = "0x5B8550", Offset = "0x5B7950", Length = "0x122")]
	[Token(Token = "0x60000B4")]
	public TransformPack GetParentTransformData(Transform child) { }

	[Address(RVA = "0x5B8680", Offset = "0x5B7A80", Length = "0x72E")]
	[Token(Token = "0x60000B5")]
	public TransformPack GetTransformDataFrom(Transform child, Transform root) { }

	[Address(RVA = "0x5B8DB0", Offset = "0x5B81B0", Length = "0x5B")]
	[Token(Token = "0x60000C6")]
	public bool IsDown(LayerData data) { }

	[Address(RVA = "0x5B8E10", Offset = "0x5B8210", Length = "0x36")]
	[Token(Token = "0x60000BF")]
	public bool IsEnd() { }

	[Address(RVA = "0x5B8E50", Offset = "0x5B8250", Length = "0x1E")]
	[Token(Token = "0x60000D8")]
	public bool IsFilterEnable() { }

	[Address(RVA = "0x5B8E70", Offset = "0x5B8270", Length = "0x3C")]
	[Token(Token = "0x60000BE")]
	public bool IsInTime() { }

	[Address(RVA = "0x5BAF80", Offset = "0x5BA380", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60000AE")]
	public void remove_OnUpdated(SelfEventHandler value) { }

	[Address(RVA = "0x5BB020", Offset = "0x5BA420", Length = "0x27")]
	[Token(Token = "0x60000B6")]
	private bool scaleEffectedByRotation() { }

	[Address(RVA = "0x5BB050", Offset = "0x5BA450", Length = "0x16")]
	[Token(Token = "0x60000D2")]
	public void set_positionOffset(Vector3 value) { }

	[Address(RVA = "0x5B8EB0", Offset = "0x5B82B0", Length = "0x7")]
	[Token(Token = "0x60000C5")]
	public void SetLoop(bool loop) { }

	[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
	[Token(Token = "0x60000B0")]
	public void SetNodeTreeRoot(Transform root) { }

	[Address(RVA = "0x5B8ED0", Offset = "0x5B82D0", Length = "0x40")]
	[Token(Token = "0x60000B1")]
	public void SetReflector(AELayerReflector reflector) { }

	[Address(RVA = "0x5B8F10", Offset = "0x5B8310", Length = "0x879")]
	[Token(Token = "0x60000B2")]
	public AELayer SetUp(LayerData data, AEItemsAccessor accessor, AEComposition parentComposition) { }

	[Address(RVA = "0x5B9790", Offset = "0x5B8B90", Length = "0xE4")]
	[Token(Token = "0x60000C2")]
	private void UpdateActive() { }

	[Address(RVA = "0x5B9880", Offset = "0x5B8C80", Length = "0x18F")]
	[Token(Token = "0x60000C1")]
	private void UpdateAudio(float time) { }

	[Address(RVA = "0x5B9A10", Offset = "0x5B8E10", Length = "0x2DE")]
	[Token(Token = "0x60000B7")]
	private void UpdateColors() { }

	[Address(RVA = "0x5B9CF0", Offset = "0x5B90F0", Length = "0xB5")]
	[Token(Token = "0x60000C0")]
	private void UpdateFootage(float time) { }

	[Address(RVA = "0x5B9DB0", Offset = "0x5B91B0", Length = "0x2F5")]
	[Token(Token = "0x60000C4")]
	private void UpdateFrame(int frame) { }

	[Address(RVA = "0x5BA0B0", Offset = "0x5B94B0", Length = "0xE8")]
	[Token(Token = "0x60000B8")]
	private void UpdateMask() { }

	[Address(RVA = "0x5BA1A0", Offset = "0x5B95A0", Length = "0x2A1")]
	[Token(Token = "0x60000B9")]
	public void UpdateTime(float currentSeconds) { }

	[Address(RVA = "0x5BA450", Offset = "0x5B9850", Length = "0x592")]
	[Token(Token = "0x60000B3")]
	public void UpdateTransforms() { }

}


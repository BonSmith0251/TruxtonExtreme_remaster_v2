namespace UnityEngine.UI;

[AddComponentMenu("Layout/Aspect Ratio Fitter", 142)]
[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x200003A")]
public class AspectRatioFitter : UIBehaviour, ILayoutSelfController, ILayoutController
{
	[Token(Token = "0x200003B")]
	internal enum AspectMode : int
	{
		None = 0,
		WidthControlsHeight = 1,
		HeightControlsWidth = 2,
		FitInParent = 3,
		EnvelopeParent = 4,
	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000128")]
	private AspectMode m_AspectMode; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000129")]
	private float m_AspectRatio; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400012A")]
	private RectTransform m_Rect; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400012B")]
	private bool m_DelayedSetDirty; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x400012C")]
	private bool m_DoesParentExist; //Field offset: 0x31
	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x400012D")]
	private DrivenRectTransformTracker m_Tracker; //Field offset: 0x32

	[Token(Token = "0x17000099")]
	public AspectMode aspectMode
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x600024A")]
		 get { } //Length: 4
		[Address(RVA = "0x3434620", Offset = "0x3433A20", Length = "0x56")]
		[Token(Token = "0x600024B")]
		 set { } //Length: 86
	}

	[Token(Token = "0x1700009A")]
	public float aspectRatio
	{
		[Address(RVA = "0x1C1AA40", Offset = "0x1C19E40", Length = "0x6")]
		[Token(Token = "0x600024C")]
		 get { } //Length: 6
		[Address(RVA = "0x3434680", Offset = "0x3433A80", Length = "0x59")]
		[Token(Token = "0x600024D")]
		 set { } //Length: 89
	}

	[Token(Token = "0x1700009B")]
	private RectTransform rectTransform
	{
		[Address(RVA = "0x3434590", Offset = "0x3433990", Length = "0x8D")]
		[Token(Token = "0x600024E")]
		private get { } //Length: 141
	}

	[Address(RVA = "0x3434580", Offset = "0x3433980", Length = "0xE")]
	[Token(Token = "0x600024F")]
	protected AspectRatioFitter() { }

	[Address(RVA = "0x1E075B0", Offset = "0x1E069B0", Length = "0x5")]
	[Token(Token = "0x600025E")]
	private bool DoesParentExists() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x600024A")]
	public AspectMode get_aspectMode() { }

	[Address(RVA = "0x1C1AA40", Offset = "0x1C19E40", Length = "0x6")]
	[Token(Token = "0x600024C")]
	public float get_aspectRatio() { }

	[Address(RVA = "0x3434590", Offset = "0x3433990", Length = "0x8D")]
	[Token(Token = "0x600024E")]
	private RectTransform get_rectTransform() { }

	[Address(RVA = "0x3433B20", Offset = "0x3432F20", Length = "0x12A")]
	[Token(Token = "0x6000258")]
	private Vector2 GetParentSize() { }

	[Address(RVA = "0x3433C50", Offset = "0x3433050", Length = "0x1CD")]
	[Token(Token = "0x6000257")]
	private float GetSizeDeltaToProduceSize(float size, int axis) { }

	[Address(RVA = "0x3433E20", Offset = "0x3433220", Length = "0x1A")]
	[Token(Token = "0x600025D")]
	public bool IsAspectModeValid() { }

	[Address(RVA = "0x3433E40", Offset = "0x3433240", Length = "0xAB")]
	[Token(Token = "0x600025C")]
	public bool IsComponentValidOnObject() { }

	[Address(RVA = "0x3433EF0", Offset = "0x34332F0", Length = "0x74")]
	[Token(Token = "0x6000252")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x3433F70", Offset = "0x3433370", Length = "0x90")]
	[Token(Token = "0x6000250")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x3434010", Offset = "0x3433410", Length = "0x7")]
	[Token(Token = "0x6000255")]
	protected virtual void OnRectTransformDimensionsChange() { }

	[Address(RVA = "0x3434020", Offset = "0x3433420", Length = "0x90")]
	[Token(Token = "0x6000253")]
	protected virtual void OnTransformParentChanged() { }

	[Address(RVA = "0x3434620", Offset = "0x3433A20", Length = "0x56")]
	[Token(Token = "0x600024B")]
	public void set_aspectMode(AspectMode value) { }

	[Address(RVA = "0x3434680", Offset = "0x3433A80", Length = "0x59")]
	[Token(Token = "0x600024D")]
	public void set_aspectRatio(float value) { }

	[Address(RVA = "0x3434010", Offset = "0x3433410", Length = "0x7")]
	[Token(Token = "0x600025B")]
	protected void SetDirty() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000259")]
	public override void SetLayoutHorizontal() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600025A")]
	public override void SetLayoutVertical() { }

	[Address(RVA = "0x34340C0", Offset = "0x34334C0", Length = "0x48")]
	[Token(Token = "0x6000251")]
	protected virtual void Start() { }

	[Address(RVA = "0x3434560", Offset = "0x3433960", Length = "0x12")]
	[Token(Token = "0x6000254")]
	protected override void Update() { }

	[Address(RVA = "0x3434110", Offset = "0x3433510", Length = "0x442")]
	[Token(Token = "0x6000256")]
	private void UpdateRect() { }

}


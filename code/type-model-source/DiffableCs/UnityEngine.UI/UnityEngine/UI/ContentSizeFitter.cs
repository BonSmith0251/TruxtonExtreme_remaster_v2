namespace UnityEngine.UI;

[AddComponentMenu("Layout/Content Size Fitter", 141)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x2000040")]
public class ContentSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController
{
	[Token(Token = "0x2000041")]
	internal enum FitMode : int
	{
		Unconstrained = 0,
		MinSize = 1,
		PreferredSize = 2,
	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000151")]
	protected FitMode m_HorizontalFit; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000152")]
	protected FitMode m_VerticalFit; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000153")]
	private RectTransform m_Rect; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000154")]
	private DrivenRectTransformTracker m_Tracker; //Field offset: 0x30

	[Token(Token = "0x170000A6")]
	public FitMode horizontalFit
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x600027E")]
		 get { } //Length: 4
		[Address(RVA = "0x3435290", Offset = "0x3434690", Length = "0x56")]
		[Token(Token = "0x600027F")]
		 set { } //Length: 86
	}

	[Token(Token = "0x170000A8")]
	private RectTransform rectTransform
	{
		[Address(RVA = "0x3435200", Offset = "0x3434600", Length = "0x8D")]
		[Token(Token = "0x6000282")]
		private get { } //Length: 141
	}

	[Token(Token = "0x170000A7")]
	public FitMode verticalFit
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x6000280")]
		 get { } //Length: 4
		[Address(RVA = "0x34352F0", Offset = "0x34346F0", Length = "0x56")]
		[Token(Token = "0x6000281")]
		 set { } //Length: 86
	}

	[Address(RVA = "0xE31DA0", Offset = "0xE311A0", Length = "0x7")]
	[Token(Token = "0x6000283")]
	protected ContentSizeFitter() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x600027E")]
	public FitMode get_horizontalFit() { }

	[Address(RVA = "0x3435200", Offset = "0x3434600", Length = "0x8D")]
	[Token(Token = "0x6000282")]
	private RectTransform get_rectTransform() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x6000280")]
	public FitMode get_verticalFit() { }

	[Address(RVA = "0x3434FB0", Offset = "0x34343B0", Length = "0xDB")]
	[Token(Token = "0x6000287")]
	private void HandleSelfFittingAlongAxis(int axis) { }

	[Address(RVA = "0x3435090", Offset = "0x3434490", Length = "0x74")]
	[Token(Token = "0x6000285")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x3435110", Offset = "0x3434510", Length = "0x1F")]
	[Token(Token = "0x6000284")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x3435130", Offset = "0x3434530", Length = "0x7")]
	[Token(Token = "0x6000286")]
	protected virtual void OnRectTransformDimensionsChange() { }

	[Address(RVA = "0x3435290", Offset = "0x3434690", Length = "0x56")]
	[Token(Token = "0x600027F")]
	public void set_horizontalFit(FitMode value) { }

	[Address(RVA = "0x34352F0", Offset = "0x34346F0", Length = "0x56")]
	[Token(Token = "0x6000281")]
	public void set_verticalFit(FitMode value) { }

	[Address(RVA = "0x3435140", Offset = "0x3434540", Length = "0x76")]
	[Token(Token = "0x600028A")]
	protected void SetDirty() { }

	[Address(RVA = "0x34351C0", Offset = "0x34345C0", Length = "0x26")]
	[Token(Token = "0x6000288")]
	public override void SetLayoutHorizontal() { }

	[Address(RVA = "0x34351F0", Offset = "0x34345F0", Length = "0xD")]
	[Token(Token = "0x6000289")]
	public override void SetLayoutVertical() { }

}


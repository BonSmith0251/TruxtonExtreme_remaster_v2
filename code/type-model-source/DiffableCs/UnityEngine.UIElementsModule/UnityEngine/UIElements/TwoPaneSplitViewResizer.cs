namespace UnityEngine.UIElements;

[Token(Token = "0x2000175")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class TwoPaneSplitViewResizer : PointerManipulator
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400075D")]
	private Vector3 m_Start; //Field offset: 0x28
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400075E")]
	protected bool m_Active; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400075F")]
	private TwoPaneSplitView m_SplitView; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000760")]
	private int m_Direction; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000761")]
	private float m_Delta; //Field offset: 0x44

	[Token(Token = "0x170001F6")]
	private VisualElement fixedPane
	{
		[Address(RVA = "0x33BE580", Offset = "0x33BD980", Length = "0x1E")]
		[Token(Token = "0x6000B41")]
		private get { } //Length: 30
	}

	[Token(Token = "0x170001F9")]
	private float fixedPaneMargins
	{
		[Address(RVA = "0x33BE3B0", Offset = "0x33BD7B0", Length = "0x114")]
		[Token(Token = "0x6000B44")]
		private get { } //Length: 276
	}

	[Token(Token = "0x170001F8")]
	private float fixedPaneMinDimension
	{
		[Address(RVA = "0x33BE4D0", Offset = "0x33BD8D0", Length = "0xA0")]
		[Token(Token = "0x6000B43")]
		private get { } //Length: 160
	}

	[Token(Token = "0x170001F7")]
	private VisualElement flexedPane
	{
		[Address(RVA = "0x33BE770", Offset = "0x33BDB70", Length = "0x1E")]
		[Token(Token = "0x6000B42")]
		private get { } //Length: 30
	}

	[Token(Token = "0x170001FB")]
	private float flexedPaneMargin
	{
		[Address(RVA = "0x33BE5A0", Offset = "0x33BD9A0", Length = "0x114")]
		[Token(Token = "0x6000B46")]
		private get { } //Length: 276
	}

	[Token(Token = "0x170001FA")]
	private float flexedPaneMinDimension
	{
		[Address(RVA = "0x33BE6C0", Offset = "0x33BDAC0", Length = "0xA0")]
		[Token(Token = "0x6000B45")]
		private get { } //Length: 160
	}

	[Token(Token = "0x170001F5")]
	private TwoPaneSplitViewOrientation orientation
	{
		[Address(RVA = "0x33BE790", Offset = "0x33BDB90", Length = "0x1D")]
		[Token(Token = "0x6000B40")]
		private get { } //Length: 29
	}

	[Address(RVA = "0x33BE290", Offset = "0x33BD690", Length = "0x11F")]
	[Token(Token = "0x6000B47")]
	public TwoPaneSplitViewResizer(TwoPaneSplitView splitView, int dir) { }

	[Address(RVA = "0x33BCFD0", Offset = "0x33BC3D0", Length = "0x986")]
	[Token(Token = "0x6000B4A")]
	public void ApplyDelta(float delta) { }

	[Address(RVA = "0x33BE580", Offset = "0x33BD980", Length = "0x1E")]
	[Token(Token = "0x6000B41")]
	private VisualElement get_fixedPane() { }

	[Address(RVA = "0x33BE3B0", Offset = "0x33BD7B0", Length = "0x114")]
	[Token(Token = "0x6000B44")]
	private float get_fixedPaneMargins() { }

	[Address(RVA = "0x33BE4D0", Offset = "0x33BD8D0", Length = "0xA0")]
	[Token(Token = "0x6000B43")]
	private float get_fixedPaneMinDimension() { }

	[Address(RVA = "0x33BE770", Offset = "0x33BDB70", Length = "0x1E")]
	[Token(Token = "0x6000B42")]
	private VisualElement get_flexedPane() { }

	[Address(RVA = "0x33BE5A0", Offset = "0x33BD9A0", Length = "0x114")]
	[Token(Token = "0x6000B46")]
	private float get_flexedPaneMargin() { }

	[Address(RVA = "0x33BE6C0", Offset = "0x33BDAC0", Length = "0xA0")]
	[Token(Token = "0x6000B45")]
	private float get_flexedPaneMinDimension() { }

	[Address(RVA = "0x33BE790", Offset = "0x33BDB90", Length = "0x1D")]
	[Token(Token = "0x6000B40")]
	private TwoPaneSplitViewOrientation get_orientation() { }

	[Address(RVA = "0x33BD960", Offset = "0x33BCD60", Length = "0x7C")]
	[Token(Token = "0x6000B4E")]
	protected void InterruptPointerMove(PointerMoveEvent e) { }

	[Address(RVA = "0x33BD9E0", Offset = "0x33BCDE0", Length = "0xBD")]
	[Token(Token = "0x6000B4B")]
	protected void OnPointerDown(PointerDownEvent e) { }

	[Address(RVA = "0x33BDAA0", Offset = "0x33BCEA0", Length = "0x41E")]
	[Token(Token = "0x6000B4C")]
	protected void OnPointerMove(PointerMoveEvent e) { }

	[Address(RVA = "0x33BDEC0", Offset = "0x33BD2C0", Length = "0xA1")]
	[Token(Token = "0x6000B4D")]
	protected void OnPointerUp(PointerUpEvent e) { }

	[Address(RVA = "0x33BDF70", Offset = "0x33BD370", Length = "0x187")]
	[Token(Token = "0x6000B48")]
	protected virtual void RegisterCallbacksOnTarget() { }

	[Address(RVA = "0x33BE100", Offset = "0x33BD500", Length = "0x187")]
	[Token(Token = "0x6000B49")]
	protected virtual void UnregisterCallbacksFromTarget() { }

}


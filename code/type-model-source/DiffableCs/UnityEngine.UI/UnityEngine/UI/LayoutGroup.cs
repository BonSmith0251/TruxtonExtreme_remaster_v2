namespace UnityEngine.UI;

[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x200004E")]
public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup, ILayoutController
{
	[CompilerGenerated]
	[Token(Token = "0x200004F")]
	private sealed class <DelayedSetDirty>d__57 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000183")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000184")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000185")]
		public RectTransform rectTransform; //Field offset: 0x20

		[Token(Token = "0x170000D3")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000304")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000D4")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000306")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000301")]
		public <DelayedSetDirty>d__57(int <>1__state) { }

		[Address(RVA = "0x3449A80", Offset = "0x3448E80", Length = "0x8C")]
		[Token(Token = "0x6000303")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000304")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000306")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x3449B10", Offset = "0x3448F10", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000305")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000302")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400017B")]
	protected RectOffset m_Padding; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400017C")]
	protected TextAnchor m_ChildAlignment; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400017D")]
	private RectTransform m_Rect; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400017E")]
	protected DrivenRectTransformTracker m_Tracker; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400017F")]
	private Vector2 m_TotalMinSize; //Field offset: 0x3C
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000180")]
	private Vector2 m_TotalPreferredSize; //Field offset: 0x44
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000181")]
	private Vector2 m_TotalFlexibleSize; //Field offset: 0x4C
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000182")]
	private List<RectTransform> m_RectChildren; //Field offset: 0x58

	[Token(Token = "0x170000C8")]
	public TextAnchor childAlignment
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x60002DD")]
		 get { } //Length: 4
		[Address(RVA = "0x3444200", Offset = "0x3443600", Length = "0x4B")]
		[Token(Token = "0x60002DE")]
		 set { } //Length: 75
	}

	[Token(Token = "0x170000D0")]
	public override float flexibleHeight
	{
		[Address(RVA = "0x316C340", Offset = "0x316B740", Length = "0x8")]
		[Token(Token = "0x60002E8")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000CD")]
	public override float flexibleWidth
	{
		[Address(RVA = "0x316C330", Offset = "0x316B730", Length = "0x8")]
		[Token(Token = "0x60002E5")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000D2")]
	private bool isRootLayoutGroup
	{
		[Address(RVA = "0x3444050", Offset = "0x3443450", Length = "0x11A")]
		[Token(Token = "0x60002FA")]
		private get { } //Length: 282
	}

	[Token(Token = "0x170000D1")]
	public override int layoutPriority
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60002E9")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000CE")]
	public override float minHeight
	{
		[Address(RVA = "0x31132B0", Offset = "0x31126B0", Length = "0x8")]
		[Token(Token = "0x60002E6")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000CB")]
	public override float minWidth
	{
		[Address(RVA = "0x31132A0", Offset = "0x31126A0", Length = "0x8")]
		[Token(Token = "0x60002E3")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000C7")]
	public RectOffset padding
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60002DB")]
		 get { } //Length: 5
		[Address(RVA = "0x3444250", Offset = "0x3443650", Length = "0x4C")]
		[Token(Token = "0x60002DC")]
		 set { } //Length: 76
	}

	[Token(Token = "0x170000CF")]
	public override float preferredHeight
	{
		[Address(RVA = "0x316C310", Offset = "0x316B710", Length = "0x8")]
		[Token(Token = "0x60002E7")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000CC")]
	public override float preferredWidth
	{
		[Address(RVA = "0x316C300", Offset = "0x316B700", Length = "0x8")]
		[Token(Token = "0x60002E4")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000CA")]
	protected List<RectTransform> rectChildren
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x60002E0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000C9")]
	protected RectTransform rectTransform
	{
		[Address(RVA = "0x3444170", Offset = "0x3443570", Length = "0x8D")]
		[Token(Token = "0x60002DF")]
		 get { } //Length: 141
	}

	[Address(RVA = "0x3443EB0", Offset = "0x34432B0", Length = "0x194")]
	[Token(Token = "0x60002EC")]
	protected LayoutGroup() { }

	[Address(RVA = "0x3442E20", Offset = "0x3442220", Length = "0x335")]
	[Token(Token = "0x60002E1")]
	public override void CalculateLayoutInputHorizontal() { }

	[Token(Token = "0x60002E2")]
	public abstract void CalculateLayoutInputVertical() { }

	[Address(RVA = "0x3443160", Offset = "0x3442560", Length = "0x67")]
	[IteratorStateMachine(typeof(<DelayedSetDirty>d__57))]
	[Token(Token = "0x6000300")]
	private IEnumerator DelayedSetDirty(RectTransform rectTransform) { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x60002DD")]
	public TextAnchor get_childAlignment() { }

	[Address(RVA = "0x316C340", Offset = "0x316B740", Length = "0x8")]
	[Token(Token = "0x60002E8")]
	public override float get_flexibleHeight() { }

	[Address(RVA = "0x316C330", Offset = "0x316B730", Length = "0x8")]
	[Token(Token = "0x60002E5")]
	public override float get_flexibleWidth() { }

	[Address(RVA = "0x3444050", Offset = "0x3443450", Length = "0x11A")]
	[Token(Token = "0x60002FA")]
	private bool get_isRootLayoutGroup() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60002E9")]
	public override int get_layoutPriority() { }

	[Address(RVA = "0x31132B0", Offset = "0x31126B0", Length = "0x8")]
	[Token(Token = "0x60002E6")]
	public override float get_minHeight() { }

	[Address(RVA = "0x31132A0", Offset = "0x31126A0", Length = "0x8")]
	[Token(Token = "0x60002E3")]
	public override float get_minWidth() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60002DB")]
	public RectOffset get_padding() { }

	[Address(RVA = "0x316C310", Offset = "0x316B710", Length = "0x8")]
	[Token(Token = "0x60002E7")]
	public override float get_preferredHeight() { }

	[Address(RVA = "0x316C300", Offset = "0x316B700", Length = "0x8")]
	[Token(Token = "0x60002E4")]
	public override float get_preferredWidth() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x60002E0")]
	protected List<RectTransform> get_rectChildren() { }

	[Address(RVA = "0x3444170", Offset = "0x3443570", Length = "0x8D")]
	[Token(Token = "0x60002DF")]
	protected RectTransform get_rectTransform() { }

	[Address(RVA = "0x34431D0", Offset = "0x34425D0", Length = "0x42")]
	[Token(Token = "0x60002F4")]
	protected float GetAlignmentOnAxis(int axis) { }

	[Address(RVA = "0x3443220", Offset = "0x3442620", Length = "0x190")]
	[Token(Token = "0x60002F3")]
	protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding) { }

	[Address(RVA = "0x34433C0", Offset = "0x34427C0", Length = "0xC")]
	[Token(Token = "0x60002F2")]
	protected float GetTotalFlexibleSize(int axis) { }

	[Address(RVA = "0x34433D0", Offset = "0x34427D0", Length = "0xC")]
	[Token(Token = "0x60002F0")]
	protected float GetTotalMinSize(int axis) { }

	[Address(RVA = "0x34433E0", Offset = "0x34427E0", Length = "0xC")]
	[Token(Token = "0x60002F1")]
	protected float GetTotalPreferredSize(int axis) { }

	[Address(RVA = "0x34433F0", Offset = "0x34427F0", Length = "0x5A")]
	[Token(Token = "0x60002FD")]
	protected override void OnChildRectTransformDimensionsChange() { }

	[Address(RVA = "0x3443450", Offset = "0x3442850", Length = "0x7")]
	[Token(Token = "0x60002EF")]
	protected virtual void OnDidApplyAnimationProperties() { }

	[Address(RVA = "0x3443460", Offset = "0x3442860", Length = "0x95")]
	[Token(Token = "0x60002EE")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x3443500", Offset = "0x3442900", Length = "0x40")]
	[Token(Token = "0x60002ED")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x3443550", Offset = "0x3442950", Length = "0x12D")]
	[Token(Token = "0x60002FB")]
	protected virtual void OnRectTransformDimensionsChange() { }

	[Address(RVA = "0x3443450", Offset = "0x3442850", Length = "0x7")]
	[Token(Token = "0x60002FC")]
	protected override void OnTransformChildrenChanged() { }

	[Address(RVA = "0x3444200", Offset = "0x3443600", Length = "0x4B")]
	[Token(Token = "0x60002DE")]
	public void set_childAlignment(TextAnchor value) { }

	[Address(RVA = "0x3444250", Offset = "0x3443650", Length = "0x4C")]
	[Token(Token = "0x60002DC")]
	public void set_padding(RectOffset value) { }

	[Address(RVA = "0x3443BA0", Offset = "0x3442FA0", Length = "0x9F")]
	[Token(Token = "0x60002F6")]
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos) { }

	[Address(RVA = "0x3443C40", Offset = "0x3443040", Length = "0xAE")]
	[Token(Token = "0x60002F8")]
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size) { }

	[Address(RVA = "0x3443680", Offset = "0x3442A80", Length = "0x2C5")]
	[Token(Token = "0x60002F9")]
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor) { }

	[Address(RVA = "0x3443950", Offset = "0x3442D50", Length = "0x242")]
	[Token(Token = "0x60002F7")]
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor) { }

	[Address(RVA = "0x3443CF0", Offset = "0x34430F0", Length = "0x121")]
	[Token(Token = "0x60002FF")]
	protected void SetDirty() { }

	[Token(Token = "0x60002EA")]
	public abstract void SetLayoutHorizontal() { }

	[Address(RVA = "0x3443E20", Offset = "0x3443220", Length = "0x8B")]
	[Token(Token = "0x60002F5")]
	protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis) { }

	[Token(Token = "0x60002EB")]
	public abstract void SetLayoutVertical() { }

	[Address(RVA = "0x851880", Offset = "0x850C80", Length = "0x94")]
	[Token(Token = "0x60002FE")]
	protected void SetProperty(ref T currentValue, T newValue) { }

}


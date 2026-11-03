namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002D1")]
public class DebugUIHandlerCanvas : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x20002D2")]
	private sealed class <>c
	{
		[Token(Token = "0x4000D21")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000D22")]
		public static Func<Widget, Boolean> <>9__12_0; //Field offset: 0x8
		[Token(Token = "0x4000D23")]
		public static Action<DebugUIHandlerPanel> <>9__15_0; //Field offset: 0x10

		[Address(RVA = "0x2CBFAC0", Offset = "0x2CBEEC0", Length = "0x67")]
		[Token(Token = "0x60013EE")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60013EF")]
		public <>c() { }

		[Address(RVA = "0x2CBF980", Offset = "0x2CBED80", Length = "0x31")]
		[Token(Token = "0x60013F1")]
		internal void <ActivatePanel>b__15_0(DebugUIHandlerPanel p) { }

		[Address(RVA = "0x2CBF9C0", Offset = "0x2CBEDC0", Length = "0x3B")]
		[Token(Token = "0x60013F0")]
		internal bool <Rebuild>b__12_0(Widget x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002D3")]
	private sealed class <>c__DisplayClass14_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000D24")]
		public string queryPath; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60013F2")]
		public <>c__DisplayClass14_0() { }

		[Address(RVA = "0x2CBFA00", Offset = "0x2CBEE00", Length = "0x2E")]
		[Token(Token = "0x60013F3")]
		internal bool <GetWidgetFromPath>b__0(DebugUIHandlerWidget w) { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D19")]
	private int m_DebugTreeState; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D1A")]
	private Dictionary<Type, Transform> m_PrefabsMap; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D1B")]
	public Transform panelPrefab; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000D1C")]
	public List<DebugUIPrefabBundle> prefabs; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000D1D")]
	private List<DebugUIHandlerPanel> m_UIPanels; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000D1E")]
	private int m_SelectedPanel; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000D1F")]
	private DebugUIHandlerWidget m_SelectedWidget; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000D20")]
	private string m_CurrentQueryPath; //Field offset: 0x58

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60013ED")]
	public DebugUIHandlerCanvas() { }

	[Address(RVA = "0x2CAD070", Offset = "0x2CAC470", Length = "0x24B")]
	[Token(Token = "0x60013E3")]
	private void ActivatePanel(int index, DebugUIHandlerWidget selectedWidget = null) { }

	[Address(RVA = "0x2CAD2C0", Offset = "0x2CAC6C0", Length = "0x7F")]
	[Token(Token = "0x60013EA")]
	private void ActivateSelection() { }

	[Address(RVA = "0x2CAD450", Offset = "0x2CAC850", Length = "0x242")]
	[Token(Token = "0x60013E4")]
	internal void ChangeSelection(DebugUIHandlerWidget widget, bool fromNext) { }

	[Address(RVA = "0x2CAD340", Offset = "0x2CAC740", Length = "0x106")]
	[Token(Token = "0x60013E9")]
	private void ChangeSelectionValue(float multiplier) { }

	[Address(RVA = "0x2CAD6A0", Offset = "0x2CACAA0", Length = "0x139")]
	[Token(Token = "0x60013E2")]
	private DebugUIHandlerWidget GetWidgetFromPath(string queryPath) { }

	[Address(RVA = "0x2CAD7E0", Offset = "0x2CACBE0", Length = "0x3E4")]
	[Token(Token = "0x60013EB")]
	private void HandleInput() { }

	[Address(RVA = "0x2CADBD0", Offset = "0x2CACFD0", Length = "0x14F")]
	[Token(Token = "0x60013DC")]
	private void OnEnable() { }

	[Address(RVA = "0x2CADD20", Offset = "0x2CAD120", Length = "0x7F3")]
	[Token(Token = "0x60013E0")]
	private void Rebuild() { }

	[Address(RVA = "0x1960180", Offset = "0x195F580", Length = "0x8")]
	[Token(Token = "0x60013DE")]
	internal void RequestHierarchyReset() { }

	[Address(RVA = "0x2CAE520", Offset = "0x2CAD920", Length = "0x256")]
	[Token(Token = "0x60013DF")]
	private void ResetAllHierarchy() { }

	[Address(RVA = "0x2CAE780", Offset = "0x2CADB80", Length = "0xB9")]
	[Token(Token = "0x60013E8")]
	internal void SelectNextItem() { }

	[Address(RVA = "0x2CAE840", Offset = "0x2CADC40", Length = "0x66")]
	[Token(Token = "0x60013E6")]
	internal void SelectNextPanel() { }

	[Address(RVA = "0x2CAE8B0", Offset = "0x2CADCB0", Length = "0xB9")]
	[Token(Token = "0x60013E5")]
	internal void SelectPreviousItem() { }

	[Address(RVA = "0x2CAE970", Offset = "0x2CADD70", Length = "0x6D")]
	[Token(Token = "0x60013E7")]
	internal void SelectPreviousPanel() { }

	[Address(RVA = "0x2CAE9E0", Offset = "0x2CADDE0", Length = "0xD9")]
	[Token(Token = "0x60013EC")]
	internal void SetScrollTarget(DebugUIHandlerWidget widget) { }

	[Address(RVA = "0x2CAEAC0", Offset = "0x2CADEC0", Length = "0x626")]
	[Token(Token = "0x60013E1")]
	private void Traverse(IContainer container, Transform parentTransform, DebugUIHandlerWidget parentUIHandler, ref DebugUIHandlerWidget selectedHandler) { }

	[Address(RVA = "0x2CAF0F0", Offset = "0x2CAE4F0", Length = "0x120")]
	[Token(Token = "0x60013DD")]
	private void Update() { }

}


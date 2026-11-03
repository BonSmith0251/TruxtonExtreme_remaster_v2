namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002E6")]
public class DebugUIHandlerPanel : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D62")]
	public Text nameLabel; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D63")]
	public ScrollRect scrollRect; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D64")]
	public RectTransform viewport; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000D65")]
	public DebugUIHandlerCanvas Canvas; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000D66")]
	private RectTransform m_ScrollTransform; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000D67")]
	private RectTransform m_ContentTransform; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000D68")]
	private RectTransform m_MaskTransform; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000D69")]
	private DebugUIHandlerWidget m_ScrollTarget; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D6A")]
	protected private Panel m_Panel; //Field offset: 0x60

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6001475")]
	public DebugUIHandlerPanel() { }

	[Address(RVA = "0x2CB3120", Offset = "0x2CB2520", Length = "0x4D")]
	[Token(Token = "0x6001473")]
	internal DebugUIHandlerWidget GetFirstItem() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x600146C")]
	internal Panel GetPanel() { }

	[Address(RVA = "0x2CB3170", Offset = "0x2CB2570", Length = "0x18A")]
	[Token(Token = "0x6001472")]
	private float GetYPosInScroll(RectTransform target) { }

	[Address(RVA = "0x2CB3300", Offset = "0x2CB2700", Length = "0xC1")]
	[Token(Token = "0x600146A")]
	private void OnEnable() { }

	[Address(RVA = "0x2CB33D0", Offset = "0x2CB27D0", Length = "0x57")]
	[Token(Token = "0x600146F")]
	public void OnScrollbarClicked() { }

	[Address(RVA = "0x2CB3430", Offset = "0x2CB2830", Length = "0x54")]
	[Token(Token = "0x6001474")]
	public void ResetDebugManager() { }

	[Address(RVA = "0x2CB3490", Offset = "0x2CB2890", Length = "0x6C")]
	[Token(Token = "0x600146D")]
	public void SelectNextItem() { }

	[Address(RVA = "0x2CB3500", Offset = "0x2CB2900", Length = "0x7B")]
	[Token(Token = "0x600146E")]
	public void SelectPreviousItem() { }

	[Address(RVA = "0x2CB3580", Offset = "0x2CB2980", Length = "0x52")]
	[Token(Token = "0x600146B")]
	internal void SetPanel(Panel panel) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x6001470")]
	internal void SetScrollTarget(DebugUIHandlerWidget target) { }

	[Address(RVA = "0x2CB35E0", Offset = "0x2CB29E0", Length = "0x1F6")]
	[Token(Token = "0x6001471")]
	internal void UpdateScroll() { }

}


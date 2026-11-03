namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002E0")]
public class DebugUIHandlerIndirectToggle : DebugUIHandlerWidget
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D4F")]
	public Text nameLabel; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D50")]
	public Toggle valueToggle; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000D51")]
	public Image checkmarkImage; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000D52")]
	public Func<Int32, Boolean> getter; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000D53")]
	public Action<Int32, Boolean> setter; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000D54")]
	internal int index; //Field offset: 0x88

	[Address(RVA = "0x2CACF30", Offset = "0x2CAC330", Length = "0x1F")]
	[Token(Token = "0x600144D")]
	public DebugUIHandlerIndirectToggle() { }

	[Address(RVA = "0x2CB2320", Offset = "0x2CB1720", Length = "0xB0")]
	[Token(Token = "0x6001447")]
	public void Init() { }

	[Address(RVA = "0x2CB23E0", Offset = "0x2CB17E0", Length = "0x60")]
	[Token(Token = "0x600144B")]
	public virtual void OnAction() { }

	[Address(RVA = "0x2CB2450", Offset = "0x2CB1850", Length = "0x68")]
	[Token(Token = "0x600144A")]
	public virtual void OnDeselection() { }

	[Address(RVA = "0x2CB24C0", Offset = "0x2CB18C0", Length = "0x6A")]
	[Token(Token = "0x6001449")]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[Address(RVA = "0x2CB2530", Offset = "0x2CB1930", Length = "0x35")]
	[Token(Token = "0x6001448")]
	private void OnToggleValueChanged(bool value) { }

	[Address(RVA = "0x2CB2570", Offset = "0x2CB1970", Length = "0x97")]
	[Token(Token = "0x600144C")]
	internal void UpdateValueLabel() { }

}


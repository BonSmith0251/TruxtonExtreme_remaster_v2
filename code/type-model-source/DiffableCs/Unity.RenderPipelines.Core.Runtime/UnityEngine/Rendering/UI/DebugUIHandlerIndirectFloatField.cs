namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002DF")]
public class DebugUIHandlerIndirectFloatField : DebugUIHandlerWidget
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D48")]
	public Text nameLabel; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D49")]
	public Text valueLabel; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000D4A")]
	public Func<Single> getter; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000D4B")]
	public Action<Single> setter; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000D4C")]
	public Func<Single> incStepGetter; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000D4D")]
	public Func<Single> incStepMultGetter; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000D4E")]
	public Func<Single> decimalsGetter; //Field offset: 0x90

	[Address(RVA = "0x2CACF30", Offset = "0x2CAC330", Length = "0x1F")]
	[Token(Token = "0x6001446")]
	public DebugUIHandlerIndirectFloatField() { }

	[Address(RVA = "0x2CB20F0", Offset = "0x2CB14F0", Length = "0xDC")]
	[Token(Token = "0x6001444")]
	private void ChangeValue(bool fast, float multiplier) { }

	[Address(RVA = "0x2CB21D0", Offset = "0x2CB15D0", Length = "0x7")]
	[Token(Token = "0x600143F")]
	public void Init() { }

	[Address(RVA = "0x2CB21E0", Offset = "0x2CB15E0", Length = "0x10")]
	[Token(Token = "0x6001443")]
	public virtual void OnDecrement(bool fast) { }

	[Address(RVA = "0x2CB11F0", Offset = "0x2CB05F0", Length = "0x68")]
	[Token(Token = "0x6001441")]
	public virtual void OnDeselection() { }

	[Address(RVA = "0x2CB21F0", Offset = "0x2CB15F0", Length = "0x10")]
	[Token(Token = "0x6001442")]
	public virtual void OnIncrement(bool fast) { }

	[Address(RVA = "0x2CB1270", Offset = "0x2CB0670", Length = "0x6A")]
	[Token(Token = "0x6001440")]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[Address(RVA = "0x2CB2200", Offset = "0x2CB1600", Length = "0x115")]
	[Token(Token = "0x6001445")]
	private void UpdateValueLabel() { }

}


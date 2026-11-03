namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002D7")]
public class DebugUIHandlerEnumField : DebugUIHandlerField<EnumField>
{

	[Address(RVA = "0x2CB0A50", Offset = "0x2CAFE50", Length = "0x39")]
	[Token(Token = "0x6001414")]
	public DebugUIHandlerEnumField() { }

	[Address(RVA = "0x2CB0640", Offset = "0x2CAFA40", Length = "0x1E1")]
	[Token(Token = "0x6001412")]
	public virtual void OnDecrement(bool fast) { }

	[Address(RVA = "0x2CB0830", Offset = "0x2CAFC30", Length = "0x181")]
	[Token(Token = "0x6001411")]
	public virtual void OnIncrement(bool fast) { }

	[Address(RVA = "0x2CB09C0", Offset = "0x2CAFDC0", Length = "0x8F")]
	[Token(Token = "0x6001413")]
	public virtual void UpdateValueLabel() { }

}


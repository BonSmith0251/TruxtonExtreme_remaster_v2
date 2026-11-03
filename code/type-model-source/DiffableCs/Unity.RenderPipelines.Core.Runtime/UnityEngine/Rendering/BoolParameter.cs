namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x20001FD")]
public class BoolParameter : VolumeParameter<Boolean>
{
	[Token(Token = "0x20001FE")]
	internal enum DisplayType : int
	{
		Checkbox = 0,
		EnumPopup = 1,
	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400097F")]
	public DisplayType displayType; //Field offset: 0x20

	[Address(RVA = "0x2C54100", Offset = "0x2C53500", Length = "0x5B")]
	[Token(Token = "0x6000F0F")]
	public BoolParameter(bool value, bool overrideState = false) { }

	[Address(RVA = "0x2C54160", Offset = "0x2C53560", Length = "0x6C")]
	[Token(Token = "0x6000F10")]
	public BoolParameter(bool value, DisplayType displayType, bool overrideState = false) { }

}


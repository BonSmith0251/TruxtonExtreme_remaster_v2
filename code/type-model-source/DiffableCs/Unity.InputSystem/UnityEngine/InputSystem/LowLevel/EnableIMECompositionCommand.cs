namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x2000179")]
public struct EnableIMECompositionCommand : IInputDeviceCommandInfo
{
	[Token(Token = "0x400094F")]
	internal const int kSize = 12; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000950")]
	public InputDeviceCommand baseCommand; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000951")]
	private byte m_ImeEnabled; //Field offset: 0x8

	[Token(Token = "0x17000440")]
	public bool imeEnabled
	{
		[Address(RVA = "0x29EEB00", Offset = "0x29EDF00", Length = "0x8")]
		[Token(Token = "0x6000FB5")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700043F")]
	public static FourCC Type
	{
		[Address(RVA = "0x29EEAC0", Offset = "0x29EDEC0", Length = "0x3A")]
		[Token(Token = "0x6000FB4")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000441")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29EEB10", Offset = "0x29EDF10", Length = "0x3A")]
		[Token(Token = "0x6000FB6")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29EEA40", Offset = "0x29EDE40", Length = "0x72")]
	[Token(Token = "0x6000FB7")]
	public static EnableIMECompositionCommand Create(bool enabled) { }

	[Address(RVA = "0x29EEB00", Offset = "0x29EDF00", Length = "0x8")]
	[Token(Token = "0x6000FB5")]
	public bool get_imeEnabled() { }

	[Address(RVA = "0x29EEAC0", Offset = "0x29EDEC0", Length = "0x3A")]
	[Token(Token = "0x6000FB4")]
	public static FourCC get_Type() { }

	[Address(RVA = "0x29EEB10", Offset = "0x29EDF10", Length = "0x3A")]
	[Token(Token = "0x6000FB6")]
	public override FourCC get_typeStatic() { }

}


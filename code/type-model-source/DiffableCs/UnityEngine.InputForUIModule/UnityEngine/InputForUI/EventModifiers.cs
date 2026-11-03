namespace UnityEngine.InputForUI;

[Token(Token = "0x200000B")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct EventModifiers
{
	[Flags]
	[Token(Token = "0x200000C")]
	internal enum Modifiers : uint
	{
		LeftShift = 1,
		RightShift = 2,
		Shift = 3,
		LeftCtrl = 4,
		RightCtrl = 8,
		Ctrl = 12,
		LeftAlt = 16,
		RightAlt = 32,
		Alt = 48,
		LeftMeta = 64,
		RightMeta = 128,
		Meta = 192,
		CapsLock = 256,
		Numlock = 512,
		FunctionKey = 1024,
		Numeric = 2048,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000033")]
	private uint _state; //Field offset: 0x0

	[Token(Token = "0x17000011")]
	public bool isAltPressed
	{
		[Address(RVA = "0x3107520", Offset = "0x3106920", Length = "0x7")]
		[Token(Token = "0x6000025")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000013")]
	public bool isCapsLockEnabled
	{
		[Address(RVA = "0x3107530", Offset = "0x3106930", Length = "0xA")]
		[Token(Token = "0x6000027")]
		 get { } //Length: 10
	}

	[Token(Token = "0x17000010")]
	public bool isCtrlPressed
	{
		[Address(RVA = "0x3107540", Offset = "0x3106940", Length = "0x7")]
		[Token(Token = "0x6000024")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000014")]
	public bool isFunctionKeyPressed
	{
		[Address(RVA = "0x3107550", Offset = "0x3106950", Length = "0xA")]
		[Token(Token = "0x6000028")]
		 get { } //Length: 10
	}

	[Token(Token = "0x17000012")]
	public bool isMetaPressed
	{
		[Address(RVA = "0x3107560", Offset = "0x3106960", Length = "0xA")]
		[Token(Token = "0x6000026")]
		 get { } //Length: 10
	}

	[Token(Token = "0x17000015")]
	public bool isNumericPressed
	{
		[Address(RVA = "0x3107570", Offset = "0x3106970", Length = "0xA")]
		[Token(Token = "0x6000029")]
		 get { } //Length: 10
	}

	[Token(Token = "0x1700000F")]
	public bool isShiftPressed
	{
		[Address(RVA = "0x3107580", Offset = "0x3106980", Length = "0x7")]
		[Token(Token = "0x6000023")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x3106F20", Offset = "0x3106320", Length = "0x6A")]
	[Token(Token = "0x600002C")]
	private static void Append(ref string str, string value) { }

	[Address(RVA = "0x3107520", Offset = "0x3106920", Length = "0x7")]
	[Token(Token = "0x6000025")]
	public bool get_isAltPressed() { }

	[Address(RVA = "0x3107530", Offset = "0x3106930", Length = "0xA")]
	[Token(Token = "0x6000027")]
	public bool get_isCapsLockEnabled() { }

	[Address(RVA = "0x3107540", Offset = "0x3106940", Length = "0x7")]
	[Token(Token = "0x6000024")]
	public bool get_isCtrlPressed() { }

	[Address(RVA = "0x3107550", Offset = "0x3106950", Length = "0xA")]
	[Token(Token = "0x6000028")]
	public bool get_isFunctionKeyPressed() { }

	[Address(RVA = "0x3107560", Offset = "0x3106960", Length = "0xA")]
	[Token(Token = "0x6000026")]
	public bool get_isMetaPressed() { }

	[Address(RVA = "0x3107570", Offset = "0x3106970", Length = "0xA")]
	[Token(Token = "0x6000029")]
	public bool get_isNumericPressed() { }

	[Address(RVA = "0x3107580", Offset = "0x3106980", Length = "0x7")]
	[Token(Token = "0x6000023")]
	public bool get_isShiftPressed() { }

	[Address(RVA = "0x3106F90", Offset = "0x3106390", Length = "0x6")]
	[Token(Token = "0x6000022")]
	public bool IsPressed(Modifiers mod) { }

	[Address(RVA = "0x1CA23C0", Offset = "0x1CA17C0", Length = "0x7")]
	[Token(Token = "0x600002B")]
	public void Reset() { }

	[Address(RVA = "0x2679C40", Offset = "0x2679040", Length = "0x13")]
	[Token(Token = "0x600002A")]
	public void SetPressed(Modifiers modifier, bool pressed) { }

	[Address(RVA = "0x3106FA0", Offset = "0x31063A0", Length = "0x579")]
	[Token(Token = "0x600002D")]
	public virtual string ToString() { }

}


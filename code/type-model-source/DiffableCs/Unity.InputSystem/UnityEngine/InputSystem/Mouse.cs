namespace UnityEngine.InputSystem;

[InputControlLayout(stateType = typeof(MouseState), isGenericTypeOfDevice = True)]
[Token(Token = "0x2000091")]
public class Mouse : Pointer, IInputStateCallbackReceiver
{
	[CompilerGenerated]
	[Token(Token = "0x40003E5")]
	private static Mouse <current>k__BackingField; //Field offset: 0x0
	[Token(Token = "0x40003E6")]
	internal static Mouse s_PlatformMouseDevice; //Field offset: 0x8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x40003DE")]
	private DeltaControl <scroll>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x40003DF")]
	private ButtonControl <leftButton>k__BackingField; //Field offset: 0x1C8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x40003E0")]
	private ButtonControl <middleButton>k__BackingField; //Field offset: 0x1D0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x40003E1")]
	private ButtonControl <rightButton>k__BackingField; //Field offset: 0x1D8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x40003E2")]
	private ButtonControl <backButton>k__BackingField; //Field offset: 0x1E0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x40003E3")]
	private ButtonControl <forwardButton>k__BackingField; //Field offset: 0x1E8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x40003E4")]
	private IntegerControl <clickCount>k__BackingField; //Field offset: 0x1F0

	[Token(Token = "0x17000274")]
	public ButtonControl backButton
	{
		[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000768")]
		 get { } //Length: 8
		[Address(RVA = "0x1CDAE80", Offset = "0x1CDA280", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000769")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000276")]
	public IntegerControl clickCount
	{
		[Address(RVA = "0x28D9940", Offset = "0x28D8D40", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600076C")]
		 get { } //Length: 8
		[Address(RVA = "0x28D99A0", Offset = "0x28D8DA0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600076D")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000277")]
	public private static Mouse current
	{
		[Address(RVA = "0x29AEC70", Offset = "0x29AE070", Length = "0x36")]
		[CompilerGenerated]
		[Token(Token = "0x600076E")]
		 get { } //Length: 54
		[Address(RVA = "0x29AECB0", Offset = "0x29AE0B0", Length = "0x51")]
		[CompilerGenerated]
		[Token(Token = "0x600076F")]
		private set { } //Length: 81
	}

	[Token(Token = "0x17000275")]
	public ButtonControl forwardButton
	{
		[Address(RVA = "0x28D9930", Offset = "0x28D8D30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600076A")]
		 get { } //Length: 8
		[Address(RVA = "0x1D59410", Offset = "0x1D58810", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600076B")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000271")]
	public ButtonControl leftButton
	{
		[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000762")]
		 get { } //Length: 8
		[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000763")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000272")]
	public ButtonControl middleButton
	{
		[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000764")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEA770", Offset = "0x1CE9B70", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000765")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000273")]
	public ButtonControl rightButton
	{
		[Address(RVA = "0x28D98F0", Offset = "0x28D8CF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000766")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEB220", Offset = "0x1CEA620", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000767")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000270")]
	public DeltaControl scroll
	{
		[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000760")]
		 get { } //Length: 8
		[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000761")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x6000779")]
	public Mouse() { }

	[Address(RVA = "0x29AE710", Offset = "0x29ADB10", Length = "0x210")]
	[Token(Token = "0x6000774")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000768")]
	public ButtonControl get_backButton() { }

	[Address(RVA = "0x28D9940", Offset = "0x28D8D40", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600076C")]
	public IntegerControl get_clickCount() { }

	[Address(RVA = "0x29AEC70", Offset = "0x29AE070", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x600076E")]
	public static Mouse get_current() { }

	[Address(RVA = "0x28D9930", Offset = "0x28D8D30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600076A")]
	public ButtonControl get_forwardButton() { }

	[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000762")]
	public ButtonControl get_leftButton() { }

	[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000764")]
	public ButtonControl get_middleButton() { }

	[Address(RVA = "0x28D98F0", Offset = "0x28D8CF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000766")]
	public ButtonControl get_rightButton() { }

	[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000760")]
	public DeltaControl get_scroll() { }

	[Address(RVA = "0x29AE920", Offset = "0x29ADD20", Length = "0x9B")]
	[Token(Token = "0x6000770")]
	public virtual void MakeCurrent() { }

	[Address(RVA = "0x29AE9C0", Offset = "0x29ADDC0", Length = "0x7B")]
	[Token(Token = "0x6000771")]
	protected virtual void OnAdded() { }

	[Address(RVA = "0x29AEA40", Offset = "0x29ADE40", Length = "0x91")]
	[Token(Token = "0x6000775")]
	protected void OnNextUpdate() { }

	[Address(RVA = "0x29AEAE0", Offset = "0x29ADEE0", Length = "0x90")]
	[Token(Token = "0x6000772")]
	protected virtual void OnRemoved() { }

	[Address(RVA = "0x29AEB70", Offset = "0x29ADF70", Length = "0x76")]
	[Token(Token = "0x6000776")]
	protected void OnStateEvent(InputEventPtr eventPtr) { }

	[Address(RVA = "0x1CDAE80", Offset = "0x1CDA280", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000769")]
	protected void set_backButton(ButtonControl value) { }

	[Address(RVA = "0x28D99A0", Offset = "0x28D8DA0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600076D")]
	protected void set_clickCount(IntegerControl value) { }

	[Address(RVA = "0x29AECB0", Offset = "0x29AE0B0", Length = "0x51")]
	[CompilerGenerated]
	[Token(Token = "0x600076F")]
	private static void set_current(Mouse value) { }

	[Address(RVA = "0x1D59410", Offset = "0x1D58810", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600076B")]
	protected void set_forwardButton(ButtonControl value) { }

	[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000763")]
	protected void set_leftButton(ButtonControl value) { }

	[Address(RVA = "0x1CEA770", Offset = "0x1CE9B70", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000765")]
	protected void set_middleButton(ButtonControl value) { }

	[Address(RVA = "0x1CEB220", Offset = "0x1CEA620", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000767")]
	protected void set_rightButton(ButtonControl value) { }

	[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000761")]
	protected void set_scroll(DeltaControl value) { }

	[Address(RVA = "0x29AEA40", Offset = "0x29ADE40", Length = "0x91")]
	[Token(Token = "0x6000777")]
	private override void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	[Address(RVA = "0x29AEBF0", Offset = "0x29ADFF0", Length = "0x8")]
	[Token(Token = "0x6000778")]
	private override void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

	[Address(RVA = "0x29AEC00", Offset = "0x29AE000", Length = "0x70")]
	[Token(Token = "0x6000773")]
	public void WarpCursorPosition(Vector2 position) { }

}


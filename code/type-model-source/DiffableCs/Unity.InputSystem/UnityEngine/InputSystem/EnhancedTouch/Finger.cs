namespace UnityEngine.InputSystem.EnhancedTouch;

[Token(Token = "0x2000153")]
public class Finger
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000886")]
	private readonly Touchscreen <screen>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000887")]
	private readonly int <index>k__BackingField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000888")]
	internal readonly InputStateHistory<TouchState> m_StateHistory; //Field offset: 0x20

	[Token(Token = "0x170003F2")]
	public Touch currentTouch
	{
		[Address(RVA = "0x29F10B0", Offset = "0x29F04B0", Length = "0x240")]
		[Token(Token = "0x6000ED8")]
		 get { } //Length: 576
	}

	[Token(Token = "0x170003EE")]
	public int index
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000ED4")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170003EF")]
	public bool isActive
	{
		[Address(RVA = "0x29F12F0", Offset = "0x29F06F0", Length = "0x9F")]
		[Token(Token = "0x6000ED5")]
		 get { } //Length: 159
	}

	[Token(Token = "0x170003F1")]
	public Touch lastTouch
	{
		[Address(RVA = "0x29F1390", Offset = "0x29F0790", Length = "0xE5")]
		[Token(Token = "0x6000ED7")]
		 get { } //Length: 229
	}

	[Token(Token = "0x170003ED")]
	public Touchscreen screen
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000ED3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003F0")]
	public Vector2 screenPosition
	{
		[Address(RVA = "0x29F1480", Offset = "0x29F0880", Length = "0x139")]
		[Token(Token = "0x6000ED6")]
		 get { } //Length: 313
	}

	[Token(Token = "0x170003F3")]
	public TouchHistory touchHistory
	{
		[Address(RVA = "0x29F15C0", Offset = "0x29F09C0", Length = "0x75")]
		[Token(Token = "0x6000ED9")]
		 get { } //Length: 117
	}

	[Address(RVA = "0x29F0D40", Offset = "0x29F0140", Length = "0x365")]
	[Token(Token = "0x6000EDA")]
	internal Finger(Touchscreen screen, int index, InputUpdateType updateMask) { }

	[Address(RVA = "0x29F0470", Offset = "0x29EF870", Length = "0x2A6")]
	[Token(Token = "0x6000EDD")]
	private Touch FindTouch(uint uniqueId) { }

	[Address(RVA = "0x29F10B0", Offset = "0x29F04B0", Length = "0x240")]
	[Token(Token = "0x6000ED8")]
	public Touch get_currentTouch() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000ED4")]
	public int get_index() { }

	[Address(RVA = "0x29F12F0", Offset = "0x29F06F0", Length = "0x9F")]
	[Token(Token = "0x6000ED5")]
	public bool get_isActive() { }

	[Address(RVA = "0x29F1390", Offset = "0x29F0790", Length = "0xE5")]
	[Token(Token = "0x6000ED7")]
	public Touch get_lastTouch() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000ED3")]
	public Touchscreen get_screen() { }

	[Address(RVA = "0x29F1480", Offset = "0x29F0880", Length = "0x139")]
	[Token(Token = "0x6000ED6")]
	public Vector2 get_screenPosition() { }

	[Address(RVA = "0x29F15C0", Offset = "0x29F09C0", Length = "0x75")]
	[Token(Token = "0x6000ED9")]
	public TouchHistory get_touchHistory() { }

	[Address(RVA = "0x29F0720", Offset = "0x29EFB20", Length = "0x2AF")]
	[Token(Token = "0x6000EDE")]
	internal TouchHistory GetTouchHistory(Touch touch) { }

	[Address(RVA = "0x29F09D0", Offset = "0x29EFDD0", Length = "0x2CF")]
	[Token(Token = "0x6000EDC")]
	private void OnTouchRecorded(Record record) { }

	[Address(RVA = "0x29F0CA0", Offset = "0x29F00A0", Length = "0x9B")]
	[Token(Token = "0x6000EDB")]
	private static bool ShouldRecordTouch(InputControl control, double time, InputEventPtr eventPtr) { }

}


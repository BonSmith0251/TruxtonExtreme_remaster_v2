namespace UnityEngine.InputSystem.UI;

[Token(Token = "0x2000117")]
public class ExtendedPointerEventData : PointerEventData
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000668")]
	private InputControl <control>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000669")]
	private InputDevice <device>k__BackingField; //Field offset: 0x1C8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x400066A")]
	private int <touchId>k__BackingField; //Field offset: 0x1D0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D4")]
	[Token(Token = "0x400066B")]
	private UIPointerType <pointerType>k__BackingField; //Field offset: 0x1D4
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x400066C")]
	private int <uiToolkitPointerId>k__BackingField; //Field offset: 0x1D8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1DC")]
	[Token(Token = "0x400066D")]
	private Vector3 <trackedDevicePosition>k__BackingField; //Field offset: 0x1DC
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x400066E")]
	private Quaternion <trackedDeviceOrientation>k__BackingField; //Field offset: 0x1E8

	[Token(Token = "0x1700037F")]
	public InputControl control
	{
		[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000D48")]
		 get { } //Length: 8
		[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000D49")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000380")]
	public InputDevice device
	{
		[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000D4A")]
		 get { } //Length: 8
		[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000D4B")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000382")]
	public UIPointerType pointerType
	{
		[Address(RVA = "0x29D6300", Offset = "0x29D5700", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000D4E")]
		 get { } //Length: 7
		[Address(RVA = "0x29D6350", Offset = "0x29D5750", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000D4F")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000381")]
	public int touchId
	{
		[Address(RVA = "0x29D6310", Offset = "0x29D5710", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000D4C")]
		 get { } //Length: 7
		[Address(RVA = "0x29D6360", Offset = "0x29D5760", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000D4D")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000385")]
	public Quaternion trackedDeviceOrientation
	{
		[Address(RVA = "0x29D6320", Offset = "0x29D5720", Length = "0xE")]
		[CompilerGenerated]
		[Token(Token = "0x6000D54")]
		 get { } //Length: 14
		[Address(RVA = "0x29D6370", Offset = "0x29D5770", Length = "0xB")]
		[CompilerGenerated]
		[Token(Token = "0x6000D55")]
		 set { } //Length: 11
	}

	[Token(Token = "0x17000384")]
	public Vector3 trackedDevicePosition
	{
		[Address(RVA = "0x29D6330", Offset = "0x29D5730", Length = "0x19")]
		[CompilerGenerated]
		[Token(Token = "0x6000D52")]
		 get { } //Length: 25
		[Address(RVA = "0x29D6380", Offset = "0x29D5780", Length = "0x16")]
		[CompilerGenerated]
		[Token(Token = "0x6000D53")]
		 set { } //Length: 22
	}

	[Token(Token = "0x17000383")]
	public int uiToolkitPointerId
	{
		[Address(RVA = "0x1DBB2B0", Offset = "0x1DBA6B0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000D50")]
		 get { } //Length: 7
		[Address(RVA = "0x29D63A0", Offset = "0x29D57A0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000D51")]
		 set { } //Length: 7
	}

	[Address(RVA = "0x29D62F0", Offset = "0x29D56F0", Length = "0x8")]
	[Token(Token = "0x6000D47")]
	public ExtendedPointerEventData(EventSystem eventSystem) { }

	[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000D48")]
	public InputControl get_control() { }

	[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000D4A")]
	public InputDevice get_device() { }

	[Address(RVA = "0x29D6300", Offset = "0x29D5700", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000D4E")]
	public UIPointerType get_pointerType() { }

	[Address(RVA = "0x29D6310", Offset = "0x29D5710", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000D4C")]
	public int get_touchId() { }

	[Address(RVA = "0x29D6320", Offset = "0x29D5720", Length = "0xE")]
	[CompilerGenerated]
	[Token(Token = "0x6000D54")]
	public Quaternion get_trackedDeviceOrientation() { }

	[Address(RVA = "0x29D6330", Offset = "0x29D5730", Length = "0x19")]
	[CompilerGenerated]
	[Token(Token = "0x6000D52")]
	public Vector3 get_trackedDevicePosition() { }

	[Address(RVA = "0x1DBB2B0", Offset = "0x1DBA6B0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000D50")]
	public int get_uiToolkitPointerId() { }

	[Address(RVA = "0x29D5630", Offset = "0x29D4A30", Length = "0x218")]
	[Token(Token = "0x6000D5A")]
	private static int GetPenPointerId(Pen pen) { }

	[Address(RVA = "0x29D5850", Offset = "0x29D4C50", Length = "0xFD")]
	[Token(Token = "0x6000D5B")]
	private static int GetTouchPointerId(TouchControl touchControl) { }

	[Address(RVA = "0x29D5950", Offset = "0x29D4D50", Length = "0x7")]
	[Token(Token = "0x6000D57")]
	internal static int MakePointerIdForTouch(int deviceId, int touchId) { }

	[Address(RVA = "0x29D5960", Offset = "0x29D4D60", Length = "0x353")]
	[Token(Token = "0x6000D59")]
	internal void ReadDeviceState() { }

	[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000D49")]
	public void set_control(InputControl value) { }

	[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000D4B")]
	public void set_device(InputDevice value) { }

	[Address(RVA = "0x29D6350", Offset = "0x29D5750", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000D4F")]
	public void set_pointerType(UIPointerType value) { }

	[Address(RVA = "0x29D6360", Offset = "0x29D5760", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000D4D")]
	public void set_touchId(int value) { }

	[Address(RVA = "0x29D6370", Offset = "0x29D5770", Length = "0xB")]
	[CompilerGenerated]
	[Token(Token = "0x6000D55")]
	public void set_trackedDeviceOrientation(Quaternion value) { }

	[Address(RVA = "0x29D6380", Offset = "0x29D5780", Length = "0x16")]
	[CompilerGenerated]
	[Token(Token = "0x6000D53")]
	public void set_trackedDevicePosition(Vector3 value) { }

	[Address(RVA = "0x29D63A0", Offset = "0x29D57A0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000D51")]
	public void set_uiToolkitPointerId(int value) { }

	[Address(RVA = "0x29D5CC0", Offset = "0x29D50C0", Length = "0x627")]
	[Token(Token = "0x6000D56")]
	public virtual string ToString() { }

	[Address(RVA = "0x732D80", Offset = "0x732180", Length = "0x4")]
	[Token(Token = "0x6000D58")]
	internal static int TouchIdFromPointerId(int pointerId) { }

}


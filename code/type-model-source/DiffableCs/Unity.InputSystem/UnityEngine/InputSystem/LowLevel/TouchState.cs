namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001A9")]
public struct TouchState : IInputStateTypeInfo
{
	[Token(Token = "0x40009EC")]
	internal const int kSizeInBytes = 56; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[InputControl(displayName = "Touch ID", layout = "Integer", synthetic = True, dontReset = True)]
	[Token(Token = "0x40009ED")]
	public int touchId; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[InputControl(displayName = "Position", dontReset = True)]
	[Token(Token = "0x40009EE")]
	public Vector2 position; //Field offset: 0x4
	[FieldOffset(Offset = "0xC")]
	[InputControl(displayName = "Delta", layout = "Delta")]
	[Token(Token = "0x40009EF")]
	public Vector2 delta; //Field offset: 0xC
	[FieldOffset(Offset = "0x14")]
	[InputControl(displayName = "Pressure", layout = "Axis")]
	[Token(Token = "0x40009F0")]
	public float pressure; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[InputControl(displayName = "Radius")]
	[Token(Token = "0x40009F1")]
	public Vector2 radius; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[InputControl(name = "phase", displayName = "Touch Phase", layout = "TouchPhase", synthetic = True)]
	[InputControl(name = "press", displayName = "Touch Contact?", layout = "TouchPress", useStateFrom = "phase")]
	[Token(Token = "0x40009F2")]
	public byte phaseId; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[InputControl(name = "tapCount", displayName = "Tap Count", layout = "Integer")]
	[Token(Token = "0x40009F3")]
	public byte tapCount; //Field offset: 0x21
	[FieldOffset(Offset = "0x22")]
	[InputControl(name = "displayIndex", displayName = "Display Index", layout = "Integer")]
	[Token(Token = "0x40009F4")]
	public byte displayIndex; //Field offset: 0x22
	[FieldOffset(Offset = "0x23")]
	[InputControl(name = "indirectTouch", displayName = "Indirect Touch?", layout = "Button", bit = 0, synthetic = True)]
	[InputControl(name = "tap", displayName = "Tap", layout = "Button", bit = 4)]
	[Token(Token = "0x40009F5")]
	public byte flags; //Field offset: 0x23
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40009F6")]
	internal uint updateStepCount; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[InputControl(displayName = "Start Time", layout = "Double", synthetic = True)]
	[Token(Token = "0x40009F7")]
	public double startTime; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[InputControl(displayName = "Start Position", synthetic = True)]
	[Token(Token = "0x40009F8")]
	public Vector2 startPosition; //Field offset: 0x30

	[Token(Token = "0x17000487")]
	internal bool beganInSameFrame
	{
		[Address(RVA = "0x29FE930", Offset = "0x29FDD30", Length = "0x8")]
		[Token(Token = "0x6001033")]
		internal get { } //Length: 8
		[Address(RVA = "0x29FEA10", Offset = "0x29FDE10", Length = "0x21")]
		[Token(Token = "0x6001034")]
		internal set { } //Length: 33
	}

	[Token(Token = "0x17000488")]
	public override FourCC format
	{
		[Address(RVA = "0x29FE940", Offset = "0x29FDD40", Length = "0x3A")]
		[Token(Token = "0x6001035")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700047D")]
	public static FourCC Format
	{
		[Address(RVA = "0x29FE8F0", Offset = "0x29FDCF0", Length = "0x3A")]
		[Token(Token = "0x6001022")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000483")]
	public bool isIndirectTouch
	{
		[Address(RVA = "0x29FE9A0", Offset = "0x29FDDA0", Length = "0x7")]
		[Token(Token = "0x600102B")]
		 get { } //Length: 7
		[Address(RVA = "0x29FEA40", Offset = "0x29FDE40", Length = "0x21")]
		[Token(Token = "0x600102C")]
		 set { } //Length: 33
	}

	[Token(Token = "0x17000480")]
	public bool isInProgress
	{
		[Address(RVA = "0x29FE980", Offset = "0x29FDD80", Length = "0x17")]
		[Token(Token = "0x6001026")]
		 get { } //Length: 23
	}

	[Token(Token = "0x1700047F")]
	public bool isNoneEndedOrCanceled
	{
		[Address(RVA = "0x29FE9B0", Offset = "0x29FDDB0", Length = "0x17")]
		[Token(Token = "0x6001025")]
		 get { } //Length: 23
	}

	[Token(Token = "0x17000482")]
	internal bool isOrphanedPrimaryTouch
	{
		[Address(RVA = "0x29FE9D0", Offset = "0x29FDDD0", Length = "0x8")]
		[Token(Token = "0x6001029")]
		internal get { } //Length: 8
		[Address(RVA = "0x29FEA70", Offset = "0x29FDE70", Length = "0x21")]
		[Token(Token = "0x600102A")]
		internal set { } //Length: 33
	}

	[Token(Token = "0x17000481")]
	public bool isPrimaryTouch
	{
		[Address(RVA = "0x29FE9E0", Offset = "0x29FDDE0", Length = "0x8")]
		[Token(Token = "0x6001027")]
		 get { } //Length: 8
		[Address(RVA = "0x29FEAA0", Offset = "0x29FDEA0", Length = "0x21")]
		[Token(Token = "0x6001028")]
		 set { } //Length: 33
	}

	[Token(Token = "0x17000484")]
	public bool isTap
	{
		[Address(RVA = "0x29FE9F0", Offset = "0x29FDDF0", Length = "0x8")]
		[Token(Token = "0x600102D")]
		 get { } //Length: 8
		[Address(RVA = "0x29FEAD0", Offset = "0x29FDED0", Length = "0x21")]
		[Token(Token = "0x600102E")]
		 set { } //Length: 33
	}

	[Token(Token = "0x17000485")]
	internal bool isTapPress
	{
		[Address(RVA = "0x29FE9F0", Offset = "0x29FDDF0", Length = "0x8")]
		[Token(Token = "0x600102F")]
		internal get { } //Length: 8
		[Address(RVA = "0x29FEAD0", Offset = "0x29FDED0", Length = "0x21")]
		[Token(Token = "0x6001030")]
		internal set { } //Length: 33
	}

	[Token(Token = "0x17000486")]
	internal bool isTapRelease
	{
		[Address(RVA = "0x29FEA00", Offset = "0x29FDE00", Length = "0x8")]
		[Token(Token = "0x6001031")]
		internal get { } //Length: 8
		[Address(RVA = "0x29FEB00", Offset = "0x29FDF00", Length = "0x21")]
		[Token(Token = "0x6001032")]
		internal set { } //Length: 33
	}

	[Token(Token = "0x1700047E")]
	public TouchPhase phase
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x6001023")]
		 get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[Token(Token = "0x6001024")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x29FE930", Offset = "0x29FDD30", Length = "0x8")]
	[Token(Token = "0x6001033")]
	internal bool get_beganInSameFrame() { }

	[Address(RVA = "0x29FE940", Offset = "0x29FDD40", Length = "0x3A")]
	[Token(Token = "0x6001035")]
	public override FourCC get_format() { }

	[Address(RVA = "0x29FE8F0", Offset = "0x29FDCF0", Length = "0x3A")]
	[Token(Token = "0x6001022")]
	public static FourCC get_Format() { }

	[Address(RVA = "0x29FE9A0", Offset = "0x29FDDA0", Length = "0x7")]
	[Token(Token = "0x600102B")]
	public bool get_isIndirectTouch() { }

	[Address(RVA = "0x29FE980", Offset = "0x29FDD80", Length = "0x17")]
	[Token(Token = "0x6001026")]
	public bool get_isInProgress() { }

	[Address(RVA = "0x29FE9B0", Offset = "0x29FDDB0", Length = "0x17")]
	[Token(Token = "0x6001025")]
	public bool get_isNoneEndedOrCanceled() { }

	[Address(RVA = "0x29FE9D0", Offset = "0x29FDDD0", Length = "0x8")]
	[Token(Token = "0x6001029")]
	internal bool get_isOrphanedPrimaryTouch() { }

	[Address(RVA = "0x29FE9E0", Offset = "0x29FDDE0", Length = "0x8")]
	[Token(Token = "0x6001027")]
	public bool get_isPrimaryTouch() { }

	[Address(RVA = "0x29FE9F0", Offset = "0x29FDDF0", Length = "0x8")]
	[Token(Token = "0x600102D")]
	public bool get_isTap() { }

	[Address(RVA = "0x29FE9F0", Offset = "0x29FDDF0", Length = "0x8")]
	[Token(Token = "0x600102F")]
	internal bool get_isTapPress() { }

	[Address(RVA = "0x29FEA00", Offset = "0x29FDE00", Length = "0x8")]
	[Token(Token = "0x6001031")]
	internal bool get_isTapRelease() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x6001023")]
	public TouchPhase get_phase() { }

	[Address(RVA = "0x29FEA10", Offset = "0x29FDE10", Length = "0x21")]
	[Token(Token = "0x6001034")]
	internal void set_beganInSameFrame(bool value) { }

	[Address(RVA = "0x29FEA40", Offset = "0x29FDE40", Length = "0x21")]
	[Token(Token = "0x600102C")]
	public void set_isIndirectTouch(bool value) { }

	[Address(RVA = "0x29FEA70", Offset = "0x29FDE70", Length = "0x21")]
	[Token(Token = "0x600102A")]
	internal void set_isOrphanedPrimaryTouch(bool value) { }

	[Address(RVA = "0x29FEAA0", Offset = "0x29FDEA0", Length = "0x21")]
	[Token(Token = "0x6001028")]
	public void set_isPrimaryTouch(bool value) { }

	[Address(RVA = "0x29FEAD0", Offset = "0x29FDED0", Length = "0x21")]
	[Token(Token = "0x600102E")]
	public void set_isTap(bool value) { }

	[Address(RVA = "0x29FEAD0", Offset = "0x29FDED0", Length = "0x21")]
	[Token(Token = "0x6001030")]
	internal void set_isTapPress(bool value) { }

	[Address(RVA = "0x29FEB00", Offset = "0x29FDF00", Length = "0x21")]
	[Token(Token = "0x6001032")]
	internal void set_isTapRelease(bool value) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[Token(Token = "0x6001024")]
	public void set_phase(TouchPhase value) { }

	[Address(RVA = "0x29FE5A0", Offset = "0x29FD9A0", Length = "0x34D")]
	[Token(Token = "0x6001036")]
	public virtual string ToString() { }

}


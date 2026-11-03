namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001B2")]
public struct DeviceRemoveEvent : IInputEventTypeInfo
{
	[Token(Token = "0x4000A10")]
	public const int Type = 1146242381; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A11")]
	public InputEvent baseEvent; //Field offset: 0x0

	[Token(Token = "0x1700049B")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29EAFF0", Offset = "0x29EA3F0", Length = "0x6")]
		[Token(Token = "0x6001058")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x29EAF30", Offset = "0x29EA330", Length = "0xBE")]
	[Token(Token = "0x600105A")]
	public static DeviceRemoveEvent Create(int deviceId, double time = -1) { }

	[Address(RVA = "0x29EAFF0", Offset = "0x29EA3F0", Length = "0x6")]
	[Token(Token = "0x6001058")]
	public override FourCC get_typeStatic() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6001059")]
	public InputEventPtr ToEventPtr() { }

}


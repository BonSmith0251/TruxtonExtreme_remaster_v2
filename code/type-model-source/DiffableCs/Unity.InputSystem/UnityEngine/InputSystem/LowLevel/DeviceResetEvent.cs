namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001B3")]
public struct DeviceResetEvent : IInputEventTypeInfo
{
	[Token(Token = "0x4000A12")]
	public const int Type = 1146245972; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A13")]
	public InputEvent baseEvent; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A14")]
	public bool hardReset; //Field offset: 0x8

	[Token(Token = "0x1700049C")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29EB0E0", Offset = "0x29EA4E0", Length = "0x6")]
		[Token(Token = "0x600105B")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x29EB000", Offset = "0x29EA400", Length = "0xD0")]
	[Token(Token = "0x600105C")]
	public static DeviceResetEvent Create(int deviceId, bool hardReset = false, double time = -1) { }

	[Address(RVA = "0x29EB0E0", Offset = "0x29EA4E0", Length = "0x6")]
	[Token(Token = "0x600105B")]
	public override FourCC get_typeStatic() { }

}


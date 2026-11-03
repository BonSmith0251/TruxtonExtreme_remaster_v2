namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001B1")]
public struct DeviceConfigurationEvent : IInputEventTypeInfo
{
	[Token(Token = "0x4000A0E")]
	public const int Type = 1145259591; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A0F")]
	public InputEvent baseEvent; //Field offset: 0x0

	[Token(Token = "0x1700049A")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29EAF20", Offset = "0x29EA320", Length = "0x6")]
		[Token(Token = "0x6001055")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x29EAE60", Offset = "0x29EA260", Length = "0xBE")]
	[Token(Token = "0x6001057")]
	public static DeviceConfigurationEvent Create(int deviceId, double time) { }

	[Address(RVA = "0x29EAF20", Offset = "0x29EA320", Length = "0x6")]
	[Token(Token = "0x6001055")]
	public override FourCC get_typeStatic() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6001056")]
	public InputEventPtr ToEventPtr() { }

}


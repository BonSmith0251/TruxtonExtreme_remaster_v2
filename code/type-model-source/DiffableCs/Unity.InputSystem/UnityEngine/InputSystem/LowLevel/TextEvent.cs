namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001CB")]
public struct TextEvent : IInputEventTypeInfo
{
	[Token(Token = "0x4000A75")]
	public const int Type = 1413830740; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A76")]
	public InputEvent baseEvent; //Field offset: 0x0
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000A77")]
	public int character; //Field offset: 0x14

	[Token(Token = "0x170004DE")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x2A171D0", Offset = "0x2A165D0", Length = "0x6")]
		[Token(Token = "0x600112B")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2A16FB0", Offset = "0x2A163B0", Length = "0x69")]
	[Token(Token = "0x600112D")]
	public static TextEvent Create(int deviceId, char character, double time = -1) { }

	[Address(RVA = "0x2A17020", Offset = "0x2A16420", Length = "0x68")]
	[Token(Token = "0x600112E")]
	public static TextEvent Create(int deviceId, int character, double time = -1) { }

	[Address(RVA = "0x2A17090", Offset = "0x2A16490", Length = "0x136")]
	[Token(Token = "0x600112C")]
	public static TextEvent* From(InputEventPtr eventPtr) { }

	[Address(RVA = "0x2A171D0", Offset = "0x2A165D0", Length = "0x6")]
	[Token(Token = "0x600112B")]
	public override FourCC get_typeStatic() { }

}


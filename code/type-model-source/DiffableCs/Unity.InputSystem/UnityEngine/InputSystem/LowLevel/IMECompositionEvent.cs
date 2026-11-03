namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001B5")]
public struct IMECompositionEvent : IInputEventTypeInfo
{
	[Token(Token = "0x4000A15")]
	internal const int kIMECharBufferSize = 64; //Field offset: 0x0
	[Token(Token = "0x4000A16")]
	public const int Type = 1229800787; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A17")]
	public InputEvent baseEvent; //Field offset: 0x0
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000A18")]
	public IMECompositionString compositionString; //Field offset: 0x14

	[Token(Token = "0x1700049E")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29F6440", Offset = "0x29F5840", Length = "0x6")]
		[Token(Token = "0x600105E")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x29F61D0", Offset = "0x29F55D0", Length = "0x269")]
	[Token(Token = "0x600105F")]
	public static IMECompositionEvent Create(int deviceId, string compositionString, double time) { }

	[Address(RVA = "0x29F6440", Offset = "0x29F5840", Length = "0x6")]
	[Token(Token = "0x600105E")]
	public override FourCC get_typeStatic() { }

}


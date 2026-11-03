namespace Steamworks;

[Token(Token = "0x20001CB")]
public struct SteamInputActionEvent_t
{
	[Token(Token = "0x20001CC")]
	internal struct AnalogAction_t
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AF7")]
		public InputAnalogActionHandle_t actionHandle; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000AF8")]
		public InputAnalogActionData_t analogActionData; //Field offset: 0x8

	}

	[Token(Token = "0x20001CD")]
	internal struct DigitalAction_t
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AF9")]
		public InputDigitalActionHandle_t actionHandle; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000AFA")]
		public InputDigitalActionData_t digitalActionData; //Field offset: 0x8

	}

	[Token(Token = "0x20001CE")]
	internal struct OptionValue
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AFB")]
		public AnalogAction_t analogAction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AFC")]
		public DigitalAction_t digitalAction; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AF4")]
	public InputHandle_t controllerHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000AF5")]
	public ESteamInputActionEventType eEventType; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000AF6")]
	public OptionValue m_val; //Field offset: 0x10

}


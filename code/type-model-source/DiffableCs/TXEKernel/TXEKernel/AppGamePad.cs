namespace TXEKernel;

[Token(Token = "0x200000C")]
public class AppGamePad : UIGamePad
{
	[Token(Token = "0x4000043")]
	private static UIKeyboard[] assignableKey; //Field offset: 0x0
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000042")]
	private TXEDirectionKey _directionkey; //Field offset: 0x90

	[Token(Token = "0x17000001")]
	public static AppGamePad GetInstance
	{
		[Address(RVA = "0x26D2820", Offset = "0x26D1C20", Length = "0xB9")]
		[Token(Token = "0x600000C")]
		 get { } //Length: 185
	}

	[Token(Token = "0x17000002")]
	public static AppGamePad Instance
	{
		[Address(RVA = "0x26D28E0", Offset = "0x26D1CE0", Length = "0x79")]
		[Token(Token = "0x600000D")]
		 get { } //Length: 121
	}

	[Address(RVA = "0x26D2350", Offset = "0x26D1750", Length = "0x8C")]
	[Token(Token = "0x6000019")]
	private static AppGamePad() { }

	[Address(RVA = "0x26D23E0", Offset = "0x26D17E0", Length = "0x49")]
	[Token(Token = "0x6000018")]
	public AppGamePad() { }

	[Address(RVA = "0x26D1B10", Offset = "0x26D0F10", Length = "0x20A")]
	[Token(Token = "0x600000E")]
	public static bool CreateInstance(Transform parent, bool isDontDestroy = false) { }

	[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
	[Token(Token = "0x6000012")]
	public TXEDirectionKey directionkey() { }

	[Address(RVA = "0x26D2430", Offset = "0x26D1830", Length = "0x3EB")]
	[Token(Token = "0x6000013")]
	public void directionkey(TXEDirectionKey code) { }

	[Address(RVA = "0x26D2820", Offset = "0x26D1C20", Length = "0xB9")]
	[Token(Token = "0x600000C")]
	public static AppGamePad get_GetInstance() { }

	[Address(RVA = "0x26D28E0", Offset = "0x26D1CE0", Length = "0x79")]
	[Token(Token = "0x600000D")]
	public static AppGamePad get_Instance() { }

	[Address(RVA = "0x26D1D20", Offset = "0x26D1120", Length = "0xCE")]
	[Token(Token = "0x6000011")]
	public override UIKeyboard GetAssignableKeyPresent() { }

	[Address(RVA = "0x26D1DF0", Offset = "0x26D11F0", Length = "0x7")]
	[Token(Token = "0x6000010")]
	public virtual void Initialize() { }

	[Address(RVA = "0x26D1E00", Offset = "0x26D1200", Length = "0x5D")]
	[Token(Token = "0x6000015")]
	public void KeyboardResetMapping() { }

	[Address(RVA = "0x26D1E60", Offset = "0x26D1260", Length = "0x20")]
	[Token(Token = "0x6000016")]
	public void KeyboardSetDefaultMapping() { }

	[Address(RVA = "0x26D1E90", Offset = "0x26D1290", Length = "0x2BC")]
	[Token(Token = "0x6000014")]
	public void KeyboardSetMenuMapping() { }

	[Address(RVA = "0x26D2150", Offset = "0x26D1550", Length = "0x155")]
	[Token(Token = "0x6000017")]
	public void SetButtonAction(TXEButtons txeButton, UIKeyboard key) { }

	[Address(RVA = "0x26D22B0", Offset = "0x26D16B0", Length = "0x9E")]
	[Token(Token = "0x600000F")]
	public static void SetInstance(GameObject newObject, Transform parent, bool isDontDestroy) { }

}


namespace KANAI.Kernel;

[Token(Token = "0x2000018")]
public class DontDestroyMe : MonoBehaviour
{
	[Token(Token = "0x400006F")]
	private static bool isQuiting; //Field offset: 0x0
	[Token(Token = "0x4000070")]
	private static T _instance; //Field offset: 0x0

	[Token(Token = "0x1700001A")]
	public static T GetInstance
	{
		[Address(RVA = "0x193D860", Offset = "0x193CC60", Length = "0x52")]
		[Token(Token = "0x60000C5")]
		 get { } //Length: 82
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60000CD")]
	public DontDestroyMe`1() { }

	[Address(RVA = "0x193CF20", Offset = "0x193C320", Length = "0x28C")]
	[Token(Token = "0x60000CA")]
	protected override void Awake() { }

	[Address(RVA = "0x193D1B0", Offset = "0x193C5B0", Length = "0x2F8")]
	[Token(Token = "0x60000C6")]
	public static void Create() { }

	[Address(RVA = "0x193D4B0", Offset = "0x193C8B0", Length = "0x10F")]
	[Token(Token = "0x60000C8")]
	public static void DisposeInstance() { }

	[Address(RVA = "0x193D860", Offset = "0x193CC60", Length = "0x52")]
	[Token(Token = "0x60000C5")]
	public static T get_GetInstance() { }

	[Address(RVA = "0x193D5C0", Offset = "0x193C9C0", Length = "0x102")]
	[Token(Token = "0x60000C7")]
	public static T Instance() { }

	[Address(RVA = "0x193D6D0", Offset = "0x193CAD0", Length = "0x88")]
	[Token(Token = "0x60000C9")]
	public static bool IsInstanceNull() { }

	[Address(RVA = "0x193D760", Offset = "0x193CB60", Length = "0x3F")]
	[Token(Token = "0x60000CC")]
	private void OnApplicationQuit() { }

	[Address(RVA = "0x193D7A0", Offset = "0x193CBA0", Length = "0xC0")]
	[Token(Token = "0x60000CB")]
	protected override void OnDestroy() { }

}


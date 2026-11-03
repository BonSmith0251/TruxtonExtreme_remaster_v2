namespace KANAI.Kernel;

[Token(Token = "0x2000020")]
public class MonoBehaviourSingleton : MonoBehaviour
{
	[Token(Token = "0x4000094")]
	private static ClassType _instance; //Field offset: 0x0

	[Token(Token = "0x1700001B")]
	public static ClassType GetInstance
	{
		[Address(RVA = "0xD10490", Offset = "0xD0F890", Length = "0x50")]
		[Token(Token = "0x600011A")]
		 get { } //Length: 80
	}

	[Token(Token = "0x1700001C")]
	public static ClassType Instance
	{
		[Address(RVA = "0xD104E0", Offset = "0xD0F8E0", Length = "0x226")]
		[Token(Token = "0x600011B")]
		 get { } //Length: 550
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000123")]
	public MonoBehaviourSingleton`1() { }

	[Address(RVA = "0xD0FE20", Offset = "0xD0F220", Length = "0xE5")]
	[Token(Token = "0x6000120")]
	protected override void Awake() { }

	[Address(RVA = "0xD0FF10", Offset = "0xD0F310", Length = "0x261")]
	[Token(Token = "0x600011C")]
	public static bool CreateInstance(Transform parent, bool isDontDestroy = false) { }

	[Address(RVA = "0xD10180", Offset = "0xD0F580", Length = "0x164")]
	[Token(Token = "0x600011E")]
	public static void DestroyInstance() { }

	[Address(RVA = "0xD10490", Offset = "0xD0F890", Length = "0x50")]
	[Token(Token = "0x600011A")]
	public static ClassType get_GetInstance() { }

	[Address(RVA = "0xD104E0", Offset = "0xD0F8E0", Length = "0x226")]
	[Token(Token = "0x600011B")]
	public static ClassType get_Instance() { }

	[Address(RVA = "0xD102F0", Offset = "0xD0F6F0", Length = "0x48")]
	[Token(Token = "0x600011F")]
	public static bool IsInstanceNull() { }

	[Address(RVA = "0xD10340", Offset = "0xD0F740", Length = "0x5B")]
	[Token(Token = "0x6000121")]
	protected override void OnDestroy() { }

	[Address(RVA = "0xD103A0", Offset = "0xD0F7A0", Length = "0x46")]
	[Token(Token = "0x6000122")]
	protected static void ResetInstance() { }

	[Address(RVA = "0xD103F0", Offset = "0xD0F7F0", Length = "0x9E")]
	[Token(Token = "0x600011D")]
	public static void SetInstance(GameObject newObject, Transform parent, bool isDontDestroy) { }

}


namespace UnityEngine.ResourceManagement.Util;

[ExecuteInEditMode]
[Token(Token = "0x200002B")]
public abstract class ComponentSingleton : MonoBehaviour
{
	[Token(Token = "0x400007E")]
	private static T s_Instance; //Field offset: 0x0

	[Token(Token = "0x17000022")]
	public static bool Exists
	{
		[Address(RVA = "0x17A58E0", Offset = "0x17A4CE0", Length = "0x87")]
		[Token(Token = "0x6000112")]
		 get { } //Length: 135
	}

	[Token(Token = "0x17000023")]
	public static T Instance
	{
		[Address(RVA = "0x17A5970", Offset = "0x17A4D70", Length = "0x30D")]
		[Token(Token = "0x6000113")]
		 get { } //Length: 781
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000119")]
	protected ComponentSingleton`1() { }

	[Address(RVA = "0x17A5220", Offset = "0x17A4620", Length = "0x1E3")]
	[Token(Token = "0x6000117")]
	private void Awake() { }

	[Address(RVA = "0x17A5410", Offset = "0x17A4810", Length = "0x126")]
	[Token(Token = "0x6000116")]
	private static T CreateNewSingleton() { }

	[Address(RVA = "0x17A5540", Offset = "0x17A4940", Length = "0x16D")]
	[Token(Token = "0x6000118")]
	public static void DestroySingleton() { }

	[Address(RVA = "0x17A56B0", Offset = "0x17A4AB0", Length = "0x64")]
	[Token(Token = "0x6000114")]
	private static T FindInstance() { }

	[Address(RVA = "0x17A58E0", Offset = "0x17A4CE0", Length = "0x87")]
	[Token(Token = "0x6000112")]
	public static bool get_Exists() { }

	[Address(RVA = "0x17A5970", Offset = "0x17A4D70", Length = "0x30D")]
	[Token(Token = "0x6000113")]
	public static T get_Instance() { }

	[Address(RVA = "0x17A5720", Offset = "0x17A4B20", Length = "0x5A")]
	[Token(Token = "0x6000115")]
	protected override string GetGameObjectName() { }

}


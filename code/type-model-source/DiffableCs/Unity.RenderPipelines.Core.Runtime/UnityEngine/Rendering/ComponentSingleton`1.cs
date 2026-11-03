namespace UnityEngine.Rendering;

[Token(Token = "0x200002B")]
public static class ComponentSingleton
{
	[Token(Token = "0x40000B7")]
	private static TType s_Instance; //Field offset: 0x0

	[Token(Token = "0x1700002D")]
	public static TType instance
	{
		[Address(RVA = "0x17A5C80", Offset = "0x17A5080", Length = "0x277")]
		[Token(Token = "0x600044C")]
		 get { } //Length: 631
	}

	[Address(RVA = "0x17A5C80", Offset = "0x17A5080", Length = "0x277")]
	[Token(Token = "0x600044C")]
	public static TType get_instance() { }

	[Address(RVA = "0x17A5780", Offset = "0x17A4B80", Length = "0x150")]
	[Token(Token = "0x600044D")]
	public static void Release() { }

}


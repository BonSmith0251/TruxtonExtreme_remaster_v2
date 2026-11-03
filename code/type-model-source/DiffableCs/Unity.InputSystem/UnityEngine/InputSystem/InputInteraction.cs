namespace UnityEngine.InputSystem;

[Token(Token = "0x200001B")]
internal static class InputInteraction
{
	[Token(Token = "0x4000084")]
	public static TypeTable s_Interactions; //Field offset: 0x0

	[Address(RVA = "0x28EA2B0", Offset = "0x28E96B0", Length = "0xE4")]
	[Token(Token = "0x6000130")]
	public static string GetDisplayName(string interaction) { }

	[Address(RVA = "0x28EA120", Offset = "0x28E9520", Length = "0x18E")]
	[Token(Token = "0x6000131")]
	public static string GetDisplayName(Type interactionType) { }

	[Address(RVA = "0x28EA3A0", Offset = "0x28E97A0", Length = "0xD9")]
	[Token(Token = "0x600012F")]
	public static Type GetValueType(Type interactionType) { }

}


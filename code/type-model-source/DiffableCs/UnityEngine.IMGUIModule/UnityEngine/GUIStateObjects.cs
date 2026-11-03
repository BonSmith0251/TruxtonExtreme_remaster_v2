namespace UnityEngine;

[Token(Token = "0x2000017")]
internal class GUIStateObjects
{
	[Token(Token = "0x400009C")]
	private static Dictionary<Int32, Object> s_StateCache; //Field offset: 0x0

	[Address(RVA = "0x30EA990", Offset = "0x30E9D90", Length = "0x84")]
	[Token(Token = "0x600010F")]
	private static GUIStateObjects() { }

	[Address(RVA = "0x30EA840", Offset = "0x30E9C40", Length = "0x146")]
	[Token(Token = "0x600010E")]
	internal static object GetStateObject(Type t, int controlID) { }

}


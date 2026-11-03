namespace UnityEngine;

[NativeHeader("Runtime/Export/Input/Cursor.bindings.h")]
[Token(Token = "0x2000146")]
public class Cursor
{

	[Token(Token = "0x1700026E")]
	public static CursorLockMode lockState
	{
		[Address(RVA = "0x3048340", Offset = "0x3047740", Length = "0x2A")]
		[Token(Token = "0x6000FBB")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x3048340", Offset = "0x3047740", Length = "0x2A")]
	[Token(Token = "0x6000FBB")]
	public static CursorLockMode get_lockState() { }

	[Address(RVA = "0x30482B0", Offset = "0x30476B0", Length = "0x84")]
	[Token(Token = "0x6000FBA")]
	public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode) { }

	[Address(RVA = "0x3048250", Offset = "0x3047650", Length = "0x52")]
	[Token(Token = "0x6000FBC")]
	private static void SetCursor_Injected(IntPtr texture, in Vector2 hotspot, CursorMode cursorMode) { }

}


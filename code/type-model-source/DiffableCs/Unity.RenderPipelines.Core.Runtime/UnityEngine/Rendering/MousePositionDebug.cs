namespace UnityEngine.Rendering;

[Token(Token = "0x20000D6")]
public class MousePositionDebug
{
	[Token(Token = "0x40002A8")]
	private static MousePositionDebug s_Instance; //Field offset: 0x0

	[Token(Token = "0x170000BC")]
	public static MousePositionDebug instance
	{
		[Address(RVA = "0x2BE54B0", Offset = "0x2BE48B0", Length = "0x8D")]
		[Token(Token = "0x60007A5")]
		 get { } //Length: 141
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60007AB")]
	public MousePositionDebug() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007A6")]
	public void Build() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007A7")]
	public void Cleanup() { }

	[Address(RVA = "0x2BE54B0", Offset = "0x2BE48B0", Length = "0x8D")]
	[Token(Token = "0x60007A5")]
	public static MousePositionDebug get_instance() { }

	[Address(RVA = "0x2BE5320", Offset = "0x2BE4720", Length = "0xB9")]
	[Token(Token = "0x60007A9")]
	private Vector2 GetInputMousePosition() { }

	[Address(RVA = "0x5AA690", Offset = "0x5A9A90", Length = "0x2EB")]
	[Token(Token = "0x60007AA")]
	public Vector2 GetMouseClickPosition(float ScreenHeight) { }

	[Address(RVA = "0x2BE53E0", Offset = "0x2BE47E0", Length = "0xC4")]
	[Token(Token = "0x60007A8")]
	public Vector2 GetMousePosition(float ScreenHeight, bool sceneView) { }

}


namespace KANAI.UI;

[CreateAssetMenu(menuName = "KANAI/UI/SpritePalette", fileName = "UISpritePalette")]
[Token(Token = "0x2000040")]
public class UISpritePalette : ScriptableObject
{
	[CompilerGenerated]
	[Token(Token = "0x2000042")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001A7")]
		public string v; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60001C5")]
		public <>c__DisplayClass2_0() { }

		[Address(RVA = "0x1D73DE0", Offset = "0x1D731E0", Length = "0x25")]
		[Token(Token = "0x60001C6")]
		internal bool <GetSprite>b__0(Sheet p) { }

	}

	[Token(Token = "0x2000041")]
	internal class Sheet
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001A5")]
		public string targetName; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001A6")]
		public Sprite targetSprite; //Field offset: 0x18

		[Address(RVA = "0x1D39B10", Offset = "0x1D38F10", Length = "0x36")]
		[Token(Token = "0x60001C4")]
		public Sheet() { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001A4")]
	public List<Sheet> palette; //Field offset: 0x18

	[Address(RVA = "0x1E27840", Offset = "0x1E26C40", Length = "0x77")]
	[Token(Token = "0x60001C3")]
	public UISpritePalette() { }

	[Address(RVA = "0x1E27750", Offset = "0x1E26B50", Length = "0xEB")]
	[Token(Token = "0x60001C2")]
	public Sprite GetSprite(string v) { }

}


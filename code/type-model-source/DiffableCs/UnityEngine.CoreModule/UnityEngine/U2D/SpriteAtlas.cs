namespace UnityEngine.U2D;

[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
[NativeType(Header = "Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
[Token(Token = "0x200043F")]
public class SpriteAtlas : object
{

	[Token(Token = "0x170004B0")]
	public bool isVariant
	{
		[Address(RVA = "0x30CE450", Offset = "0x30CD850", Length = "0x76")]
		[NativeMethod("IsVariant")]
		[Token(Token = "0x6001FB3")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170004B2")]
	public int spriteCount
	{
		[Address(RVA = "0x30CE510", Offset = "0x30CD910", Length = "0x76")]
		[Token(Token = "0x6001FB5")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170004B1")]
	public string tag
	{
		[Address(RVA = "0x30CE5E0", Offset = "0x30CD9E0", Length = "0x106")]
		[Token(Token = "0x6001FB4")]
		 get { } //Length: 262
	}

	[Address(RVA = "0x30CE3C0", Offset = "0x30CD7C0", Length = "0x49")]
	[Token(Token = "0x6001FBC")]
	public SpriteAtlas() { }

	[Address(RVA = "0x30CDD70", Offset = "0x30CD170", Length = "0xD3")]
	[Token(Token = "0x6001FB6")]
	public bool CanBindTo(Sprite sprite) { }

	[Address(RVA = "0x30CDD20", Offset = "0x30CD120", Length = "0x42")]
	[Token(Token = "0x6001FC0")]
	private static bool CanBindTo_Injected(IntPtr _unity_self, IntPtr sprite) { }

	[Address(RVA = "0x30CE450", Offset = "0x30CD850", Length = "0x76")]
	[NativeMethod("IsVariant")]
	[Token(Token = "0x6001FB3")]
	public bool get_isVariant() { }

	[Address(RVA = "0x30CE410", Offset = "0x30CD810", Length = "0x33")]
	[Token(Token = "0x6001FBD")]
	private static bool get_isVariant_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30CE510", Offset = "0x30CD910", Length = "0x76")]
	[Token(Token = "0x6001FB5")]
	public int get_spriteCount() { }

	[Address(RVA = "0x30CE4D0", Offset = "0x30CD8D0", Length = "0x33")]
	[Token(Token = "0x6001FBF")]
	private static int get_spriteCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30CE5E0", Offset = "0x30CD9E0", Length = "0x106")]
	[Token(Token = "0x6001FB4")]
	public string get_tag() { }

	[Address(RVA = "0x30CE590", Offset = "0x30CD990", Length = "0x42")]
	[Token(Token = "0x6001FBE")]
	private static void get_tag_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x30CDEA0", Offset = "0x30CD2A0", Length = "0x1FF")]
	[Token(Token = "0x6001FB7")]
	public Sprite GetSprite(string name) { }

	[Address(RVA = "0x30CDE50", Offset = "0x30CD250", Length = "0x42")]
	[Token(Token = "0x6001FC1")]
	private static IntPtr GetSprite_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x30CE0F0", Offset = "0x30CD4F0", Length = "0x85")]
	[Token(Token = "0x6001FB8")]
	public int GetSprites(Sprite[] sprites) { }

	[Address(RVA = "0x30CE3B0", Offset = "0x30CD7B0", Length = "0xA")]
	[Token(Token = "0x6001FB9")]
	public int GetSprites(Sprite[] sprites, string name) { }

	[Address(RVA = "0x30CE0F0", Offset = "0x30CD4F0", Length = "0x85")]
	[Token(Token = "0x6001FBA")]
	private int GetSpritesScripting(Sprite[] sprites) { }

	[Address(RVA = "0x30CE0A0", Offset = "0x30CD4A0", Length = "0x42")]
	[Token(Token = "0x6001FC2")]
	private static int GetSpritesScripting_Injected(IntPtr _unity_self, Sprite[] sprites) { }

	[Address(RVA = "0x30CE1E0", Offset = "0x30CD5E0", Length = "0x1CF")]
	[Token(Token = "0x6001FBB")]
	private int GetSpritesWithNameScripting(Sprite[] sprites, string name) { }

	[Address(RVA = "0x30CE180", Offset = "0x30CD580", Length = "0x52")]
	[Token(Token = "0x6001FC3")]
	private static int GetSpritesWithNameScripting_Injected(IntPtr _unity_self, Sprite[] sprites, ref ManagedSpanWrapper name) { }

}


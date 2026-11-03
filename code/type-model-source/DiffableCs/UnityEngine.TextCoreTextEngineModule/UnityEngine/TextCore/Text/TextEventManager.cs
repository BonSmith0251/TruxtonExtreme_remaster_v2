namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000047")]
public static class TextEventManager
{
	[Token(Token = "0x40001FF")]
	public static readonly FastAction<Boolean, Material> MATERIAL_PROPERTY_EVENT; //Field offset: 0x0
	[Token(Token = "0x4000200")]
	public static readonly FastAction<Boolean, Object> FONT_PROPERTY_EVENT; //Field offset: 0x8
	[Token(Token = "0x4000201")]
	public static readonly FastAction<Boolean, Object> SPRITE_ASSET_PROPERTY_EVENT; //Field offset: 0x10
	[Token(Token = "0x4000202")]
	public static readonly FastAction<Boolean, Object> TEXTMESHPRO_PROPERTY_EVENT; //Field offset: 0x18
	[Token(Token = "0x4000203")]
	public static readonly FastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT; //Field offset: 0x20
	[Token(Token = "0x4000204")]
	public static readonly FastAction<Boolean> TEXT_STYLE_PROPERTY_EVENT; //Field offset: 0x28
	[Token(Token = "0x4000205")]
	public static readonly FastAction<Object> COLOR_GRADIENT_PROPERTY_EVENT; //Field offset: 0x30
	[Token(Token = "0x4000206")]
	public static readonly FastAction TMP_SETTINGS_PROPERTY_EVENT; //Field offset: 0x38
	[Token(Token = "0x4000207")]
	public static readonly FastAction RESOURCE_LOAD_EVENT; //Field offset: 0x40
	[Token(Token = "0x4000208")]
	public static readonly FastAction<Boolean, Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT; //Field offset: 0x48
	[Token(Token = "0x4000209")]
	public static readonly FastAction OnPreRenderObject_Event; //Field offset: 0x50
	[Token(Token = "0x400020A")]
	public static readonly FastAction<Object> TEXT_CHANGED_EVENT; //Field offset: 0x58

	[Address(RVA = "0x31B5620", Offset = "0x31B4A20", Length = "0x413")]
	[Token(Token = "0x60001EB")]
	private static TextEventManager() { }

	[Address(RVA = "0x31B5590", Offset = "0x31B4990", Length = "0x89")]
	[Token(Token = "0x60001EA")]
	public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, object font) { }

}


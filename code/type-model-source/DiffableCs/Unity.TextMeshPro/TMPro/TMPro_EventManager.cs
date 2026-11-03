namespace TMPro;

[Token(Token = "0x200001C")]
public static class TMPro_EventManager
{
	[Token(Token = "0x40000A5")]
	public static readonly FastAction<Object, Compute_DT_EventArgs> COMPUTE_DT_EVENT; //Field offset: 0x0
	[Token(Token = "0x40000A6")]
	public static readonly FastAction<Boolean, Material> MATERIAL_PROPERTY_EVENT; //Field offset: 0x8
	[Token(Token = "0x40000A7")]
	public static readonly FastAction<Boolean, Object> FONT_PROPERTY_EVENT; //Field offset: 0x10
	[Token(Token = "0x40000A8")]
	public static readonly FastAction<Boolean, Object> SPRITE_ASSET_PROPERTY_EVENT; //Field offset: 0x18
	[Token(Token = "0x40000A9")]
	public static readonly FastAction<Boolean, Object> TEXTMESHPRO_PROPERTY_EVENT; //Field offset: 0x20
	[Token(Token = "0x40000AA")]
	public static readonly FastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT; //Field offset: 0x28
	[Token(Token = "0x40000AB")]
	public static readonly FastAction<Boolean> TEXT_STYLE_PROPERTY_EVENT; //Field offset: 0x30
	[Token(Token = "0x40000AC")]
	public static readonly FastAction<Object> COLOR_GRADIENT_PROPERTY_EVENT; //Field offset: 0x38
	[Token(Token = "0x40000AD")]
	public static readonly FastAction TMP_SETTINGS_PROPERTY_EVENT; //Field offset: 0x40
	[Token(Token = "0x40000AE")]
	public static readonly FastAction RESOURCE_LOAD_EVENT; //Field offset: 0x48
	[Token(Token = "0x40000AF")]
	public static readonly FastAction<Boolean, Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT; //Field offset: 0x50
	[Token(Token = "0x40000B0")]
	public static readonly FastAction<Object> TEXT_CHANGED_EVENT; //Field offset: 0x58

	[Address(RVA = "0x2EC4440", Offset = "0x2EC3840", Length = "0x430")]
	[Token(Token = "0x6000123")]
	private static TMPro_EventManager() { }

	[Address(RVA = "0x2EC3E00", Offset = "0x2EC3200", Length = "0x79")]
	[Token(Token = "0x600011D")]
	public static void ON_COLOR_GRADIENT_PROPERTY_CHANGED(object obj) { }

	[Address(RVA = "0x2EC3E80", Offset = "0x2EC3280", Length = "0x87")]
	[Token(Token = "0x6000122")]
	public static void ON_COMPUTE_DT_EVENT(object Sender, Compute_DT_EventArgs e) { }

	[Address(RVA = "0x2EC3F10", Offset = "0x2EC3310", Length = "0x9E")]
	[Token(Token = "0x600011B")]
	public static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial) { }

	[Address(RVA = "0x2EC3FB0", Offset = "0x2EC33B0", Length = "0x89")]
	[Token(Token = "0x6000118")]
	public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, object obj) { }

	[Address(RVA = "0x2EC4040", Offset = "0x2EC3440", Length = "0x89")]
	[Token(Token = "0x6000117")]
	public static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat) { }

	[Address(RVA = "0x2EC40D0", Offset = "0x2EC34D0", Length = "0x5F")]
	[Token(Token = "0x6000120")]
	public static void ON_RESOURCES_LOADED() { }

	[Address(RVA = "0x2EC4130", Offset = "0x2EC3530", Length = "0x89")]
	[Token(Token = "0x6000119")]
	public static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, object obj) { }

	[Address(RVA = "0x2EC42E0", Offset = "0x2EC36E0", Length = "0x79")]
	[Token(Token = "0x600011E")]
	public static void ON_TEXT_CHANGED(object obj) { }

	[Address(RVA = "0x2EC4360", Offset = "0x2EC3760", Length = "0x79")]
	[Token(Token = "0x600011C")]
	public static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged) { }

	[Address(RVA = "0x2EC41C0", Offset = "0x2EC35C0", Length = "0x89")]
	[Token(Token = "0x600011A")]
	public static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, object obj) { }

	[Address(RVA = "0x2EC4250", Offset = "0x2EC3650", Length = "0x89")]
	[Token(Token = "0x6000121")]
	public static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, object obj) { }

	[Address(RVA = "0x2EC43E0", Offset = "0x2EC37E0", Length = "0x5F")]
	[Token(Token = "0x600011F")]
	public static void ON_TMP_SETTINGS_CHANGED() { }

}


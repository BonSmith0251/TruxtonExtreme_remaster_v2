namespace UnityEngine.UIElements;

[Token(Token = "0x2000006")]
internal abstract class AtlasBase
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000002")]
	internal TextureRegistry textureRegistry; //Field offset: 0x10

	[Address(RVA = "0x31ED750", Offset = "0x31ECB50", Length = "0x98")]
	[Token(Token = "0x6000012")]
	protected AtlasBase() { }

	[Address(RVA = "0x31ED5D0", Offset = "0x31EC9D0", Length = "0x14")]
	[Token(Token = "0x600000D")]
	internal void InvokeAssignedToPanel(IPanel panel) { }

	[Address(RVA = "0x240CAA0", Offset = "0x240BEA0", Length = "0x14")]
	[Token(Token = "0x600000E")]
	internal void InvokeRemovedFromPanel(IPanel panel) { }

	[Address(RVA = "0x2610AD0", Offset = "0x260FED0", Length = "0x14")]
	[Token(Token = "0x600000F")]
	internal void InvokeUpdateDynamicTextures(IPanel panel) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600000A")]
	protected override void OnAssignedToPanel(IPanel panel) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600000B")]
	protected override void OnRemovedFromPanel(IPanel panel) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600000C")]
	protected override void OnUpdateDynamicTextures(IPanel panel) { }

	[Address(RVA = "0x31ED5F0", Offset = "0x31EC9F0", Length = "0xC9")]
	[Token(Token = "0x6000010")]
	protected static void RepaintTexturedElements(IPanel panel) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000009")]
	public override void Reset() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000008")]
	public override void ReturnAtlas(VisualElement ctx, Texture2D src, TextureId atlas) { }

	[Address(RVA = "0x31ED6C0", Offset = "0x31ECAC0", Length = "0x1E")]
	[Token(Token = "0x6000011")]
	protected void SetDynamicTexture(TextureId id, Texture texture) { }

	[Address(RVA = "0x31ED6E0", Offset = "0x31ECAE0", Length = "0x62")]
	[Token(Token = "0x6000007")]
	public override bool TryGetAtlas(VisualElement ctx, Texture2D src, out TextureId atlas, out RectInt atlasRect) { }

}


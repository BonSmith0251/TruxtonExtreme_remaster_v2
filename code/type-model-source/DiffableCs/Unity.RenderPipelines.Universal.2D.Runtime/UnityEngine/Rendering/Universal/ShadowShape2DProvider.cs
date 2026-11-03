namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200007A")]
public abstract class ShadowShape2DProvider
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60002F1")]
	protected ShadowShape2DProvider() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002ED")]
	public override void Disabled(Component sourceComponent, ShadowShape2D persistantShadowShape) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002EC")]
	public override void Enabled(Component sourceComponent, ShadowShape2D persistantShadowShape) { }

	[Token(Token = "0x60002EE")]
	public abstract bool IsShapeSource(Component sourceComponent) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002F0")]
	public override void OnBeforeRender(Component sourceComponent, Bounds worldCullingBounds, ShadowShape2D persistantShadowShape) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002EF")]
	public override void OnPersistantDataCreated(Component sourceComponent, ShadowShape2D persistantShadowShape) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60002EB")]
	public override int Priority() { }

	[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
	[Token(Token = "0x60002EA")]
	public override string ProviderName(string componentName) { }

}


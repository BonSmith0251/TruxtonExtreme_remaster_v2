namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200057E")]
internal abstract class BaseElementBuilder
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60027FB")]
	protected BaseElementBuilder() { }

	[Address(RVA = "0x32D65C0", Offset = "0x32D59C0", Length = "0x33")]
	[Token(Token = "0x60027F1")]
	public void Build(MeshGenerationContext mgc) { }

	[Address(RVA = "0x32D5720", Offset = "0x32D4B20", Length = "0x6F4")]
	[Token(Token = "0x60027F2")]
	private void BuildRenderTreeQuadElement(MeshGenerationContext mgc) { }

	[Address(RVA = "0x32D5E20", Offset = "0x32D5220", Length = "0x793")]
	[Token(Token = "0x60027F3")]
	private void BuildStandardElement(MeshGenerationContext mgc) { }

	[Token(Token = "0x60027F4")]
	protected abstract void DrawVisualElementBackground(MeshGenerationContext mgc) { }

	[Token(Token = "0x60027F5")]
	protected abstract void DrawVisualElementBorder(MeshGenerationContext mgc) { }

	[Token(Token = "0x60027F6")]
	protected abstract void DrawVisualElementStencilMask(MeshGenerationContext mgc) { }

	[Address(RVA = "0x32D6600", Offset = "0x32D5A00", Length = "0xF8")]
	[Token(Token = "0x60027FA")]
	private static void InvokeGenerateVisualContent(MeshGenerationContext mgc) { }

	[Address(RVA = "0x32D6700", Offset = "0x32D5B00", Length = "0xF1")]
	[Token(Token = "0x60027F9")]
	private static void PopVisualElementClipping(MeshGenerationContext mgc) { }

	[Address(RVA = "0x32D6800", Offset = "0x32D5C00", Length = "0x156")]
	[Token(Token = "0x60027F8")]
	private void PushVisualElementClipping(MeshGenerationContext mgc) { }

	[Token(Token = "0x60027F0")]
	public abstract bool RequiresStencilMask(VisualElement ve) { }

	[Token(Token = "0x60027F7")]
	public abstract void ScheduleMeshGenerationJobs(MeshGenerationContext mgc) { }

}


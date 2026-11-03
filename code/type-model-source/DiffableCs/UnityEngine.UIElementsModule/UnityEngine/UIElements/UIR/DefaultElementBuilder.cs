namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200057F")]
internal class DefaultElementBuilder : BaseElementBuilder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400125E")]
	private RenderTreeManager m_RenderTreeManager; //Field offset: 0x10

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60027FC")]
	public DefaultElementBuilder(RenderTreeManager renderTreeManager) { }

	[Address(RVA = "0x32DAA70", Offset = "0x32D9E70", Length = "0x15A0")]
	[Token(Token = "0x60027FE")]
	protected virtual void DrawVisualElementBackground(MeshGenerationContext mgc) { }

	[Address(RVA = "0x32DC020", Offset = "0x32DB420", Length = "0x7D3")]
	[Token(Token = "0x60027FF")]
	protected virtual void DrawVisualElementBorder(MeshGenerationContext mgc) { }

	[Address(RVA = "0x32DC800", Offset = "0x32DBC00", Length = "0x133")]
	[Token(Token = "0x6002800")]
	protected virtual void DrawVisualElementStencilMask(MeshGenerationContext mgc) { }

	[Address(RVA = "0x32DC940", Offset = "0x32DBD40", Length = "0x6DE")]
	[Token(Token = "0x6002801")]
	private static void GenerateStencilClipEntryForRoundedRectBackground(MeshGenerationContext mgc) { }

	[Address(RVA = "0x32DD020", Offset = "0x32DC420", Length = "0x1CB")]
	[Token(Token = "0x60027FD")]
	public virtual bool RequiresStencilMask(VisualElement ve) { }

	[Address(RVA = "0x32DD1F0", Offset = "0x32DC5F0", Length = "0xEF")]
	[Token(Token = "0x6002802")]
	public virtual void ScheduleMeshGenerationJobs(MeshGenerationContext mgc) { }

}


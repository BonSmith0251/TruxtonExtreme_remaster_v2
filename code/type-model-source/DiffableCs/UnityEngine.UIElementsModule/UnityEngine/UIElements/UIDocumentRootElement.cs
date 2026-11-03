namespace UnityEngine.UIElements;

[Token(Token = "0x2000285")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIToolkitAuthoringModule"})]
internal class UIDocumentRootElement : TemplateContainer
{
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x40009F6")]
	public readonly UIDocument document; //Field offset: 0x2F0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x40009F7")]
	private UIRenderer <uiRenderer>k__BackingField; //Field offset: 0x2F8

	[Token(Token = "0x17000362")]
	internal UIRenderer uiRenderer
	{
		[Address(RVA = "0x336AEC0", Offset = "0x336A2C0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600119E")]
		internal get { } //Length: 8
		[Address(RVA = "0x336AFB0", Offset = "0x336A3B0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600119F")]
		internal set { } //Length: 19
	}

	[Address(RVA = "0x33F4BF0", Offset = "0x33F3FF0", Length = "0x9F")]
	[Token(Token = "0x60011A0")]
	public UIDocumentRootElement(UIDocument document, VisualTreeAsset sourceAsset) { }

	[Address(RVA = "0x336AEC0", Offset = "0x336A2C0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600119E")]
	internal UIRenderer get_uiRenderer() { }

	[Address(RVA = "0x336AFB0", Offset = "0x336A3B0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600119F")]
	internal void set_uiRenderer(UIRenderer value) { }

}


namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x2000040")]
public struct BindingInfo
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000148")]
	private readonly VisualElement <targetElement>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000149")]
	private readonly BindingId <bindingId>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400014A")]
	private readonly Binding <binding>k__BackingField; //Field offset: 0xA0

	[Token(Token = "0x17000043")]
	public Binding binding
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000204")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x321F390", Offset = "0x321E790", Length = "0xDD")]
	[Token(Token = "0x6000205")]
	private BindingInfo(VisualElement targetElement, in BindingId bindingId, Binding binding) { }

	[Address(RVA = "0x321F020", Offset = "0x321E420", Length = "0x109")]
	[Token(Token = "0x6000207")]
	internal static BindingInfo FromBindingData(in BindingData bindingData) { }

	[Address(RVA = "0x321F130", Offset = "0x321E530", Length = "0x254")]
	[Token(Token = "0x6000206")]
	internal static BindingInfo FromRequest(VisualElement target, in PropertyPath targetPath, Binding binding) { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000204")]
	public Binding get_binding() { }

}


namespace UnityEngine.UIElements.Internal;

[Token(Token = "0x2000678")]
internal class MultiColumnHeaderColumnResizeHandle : VisualElement
{
	[Token(Token = "0x400185E")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x400185F")]
	public static readonly string dragAreaUssClassName; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x4001860")]
	private readonly VisualElement <dragArea>k__BackingField; //Field offset: 0x2C8

	[Token(Token = "0x17000BB3")]
	public VisualElement dragArea
	{
		[Address(RVA = "0x102C7D0", Offset = "0x102BBD0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002E20")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x3374A00", Offset = "0x3373E00", Length = "0xF0")]
	[Token(Token = "0x6002E22")]
	private static MultiColumnHeaderColumnResizeHandle() { }

	[Address(RVA = "0x3374AF0", Offset = "0x3373EF0", Length = "0x130")]
	[Token(Token = "0x6002E21")]
	public MultiColumnHeaderColumnResizeHandle() { }

	[Address(RVA = "0x102C7D0", Offset = "0x102BBD0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6002E20")]
	public VisualElement get_dragArea() { }

}


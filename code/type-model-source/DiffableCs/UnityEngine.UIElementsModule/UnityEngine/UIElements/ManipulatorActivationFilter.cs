namespace UnityEngine.UIElements;

[Token(Token = "0x200029F")]
public struct ManipulatorActivationFilter : IEquatable<ManipulatorActivationFilter>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A69")]
	private MouseButton <button>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000A6A")]
	private EventModifiers <modifiers>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A6B")]
	private int <clickCount>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x1700037E")]
	public MouseButton button
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001240")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x6001241")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000380")]
	public int clickCount
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001244")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700037F")]
	public EventModifiers modifiers
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001242")]
		 get { } //Length: 4
		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001243")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x3404940", Offset = "0x3403D40", Length = "0xA3")]
	[Token(Token = "0x6001245")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x30757F0", Offset = "0x3074BF0", Length = "0x1B")]
	[Token(Token = "0x6001246")]
	public override bool Equals(ManipulatorActivationFilter other) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001240")]
	public MouseButton get_button() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001244")]
	public int get_clickCount() { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001242")]
	public EventModifiers get_modifiers() { }

	[Address(RVA = "0x34049F0", Offset = "0x3403DF0", Length = "0x73")]
	[Token(Token = "0x6001247")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3404A70", Offset = "0x3403E70", Length = "0xE8")]
	[Token(Token = "0x6001249")]
	private bool HasModifiers(IPointerEvent e) { }

	[Address(RVA = "0x3404BE0", Offset = "0x3403FE0", Length = "0xD0")]
	[Token(Token = "0x6001248")]
	public bool Matches(IPointerEvent e) { }

	[Address(RVA = "0x3404B60", Offset = "0x3403F60", Length = "0x7F")]
	[Token(Token = "0x600124A")]
	private bool MatchModifiers(bool alt, bool ctrl, bool shift, bool command) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[CompilerGenerated]
	[Token(Token = "0x6001241")]
	public void set_button(MouseButton value) { }

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001243")]
	public void set_modifiers(EventModifiers value) { }

}


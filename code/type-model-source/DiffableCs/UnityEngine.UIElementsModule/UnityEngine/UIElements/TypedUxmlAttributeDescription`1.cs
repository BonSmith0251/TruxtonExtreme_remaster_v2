namespace UnityEngine.UIElements;

[Token(Token = "0x20004ED")]
public abstract class TypedUxmlAttributeDescription : UxmlAttributeDescription
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001089")]
	private T <defaultValue>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x170009CC")]
	public T defaultValue
	{
		[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002534")]
		 get { } //Length: 5
		[Address(RVA = "0x11169B0", Offset = "0x1115DB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002535")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x1116910", Offset = "0x1115D10", Length = "0x7")]
	[Token(Token = "0x6002536")]
	protected TypedUxmlAttributeDescription`1() { }

	[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002534")]
	public T get_defaultValue() { }

	[Token(Token = "0x6002533")]
	public abstract T GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	[Address(RVA = "0x11169B0", Offset = "0x1115DB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002535")]
	public void set_defaultValue(T value) { }

}


namespace UnityEngine.UIElements;

[Token(Token = "0x200025A")]
public class FocusChangeDirection : IDisposable
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000927")]
	private static readonly FocusChangeDirection <unspecified>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000928")]
	private static readonly FocusChangeDirection <none>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000929")]
	private static readonly FocusChangeDirection <lastValue>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400092A")]
	private readonly int m_Value; //Field offset: 0x10

	[Token(Token = "0x17000303")]
	protected static FocusChangeDirection lastValue
	{
		[Address(RVA = "0x33E4780", Offset = "0x33E3B80", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x6001030")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000302")]
	public static FocusChangeDirection none
	{
		[Address(RVA = "0x33E47D0", Offset = "0x33E3BD0", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x600102F")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000301")]
	public static FocusChangeDirection unspecified
	{
		[Address(RVA = "0x33E4820", Offset = "0x33E3C20", Length = "0x4E")]
		[CompilerGenerated]
		[Token(Token = "0x600102E")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x33E4660", Offset = "0x33E3A60", Length = "0x118")]
	[Token(Token = "0x6001036")]
	private static FocusChangeDirection() { }

	[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
	[Token(Token = "0x6001031")]
	protected FocusChangeDirection(int value) { }

	[Address(RVA = "0x33E4620", Offset = "0x33E3A20", Length = "0x3B")]
	[Token(Token = "0x6001035")]
	internal override void ApplyTo(FocusController focusController, Focusable f) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001034")]
	protected override void Dispose() { }

	[Address(RVA = "0x33E4780", Offset = "0x33E3B80", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x6001030")]
	protected static FocusChangeDirection get_lastValue() { }

	[Address(RVA = "0x33E47D0", Offset = "0x33E3BD0", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x600102F")]
	public static FocusChangeDirection get_none() { }

	[Address(RVA = "0x33E4820", Offset = "0x33E3C20", Length = "0x4E")]
	[CompilerGenerated]
	[Token(Token = "0x600102E")]
	public static FocusChangeDirection get_unspecified() { }

	[Address(RVA = "0x33E4870", Offset = "0x33E3C70", Length = "0xC")]
	[Token(Token = "0x6001032")]
	public static int op_Implicit(FocusChangeDirection fcd) { }

	[Address(RVA = "0x1D214A0", Offset = "0x1D208A0", Length = "0x14")]
	[Token(Token = "0x6001033")]
	private override void System.IDisposable.Dispose() { }

}


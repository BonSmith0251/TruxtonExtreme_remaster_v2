namespace UnityEngine.UIElements;

[Token(Token = "0x200017E")]
internal class SetValueVisitor : PathVisitor
{
	[CompilerGenerated]
	[Token(Token = "0x200017F")]
	private sealed class <>c
	{
		[Token(Token = "0x400076B")]
		public static readonly <>c<TSrcValue> <>9; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x6000B76")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000B77")]
		public <>c() { }

		[Address(RVA = "0xA36BE0", Offset = "0xA35FE0", Length = "0x5D")]
		[Token(Token = "0x6000B78")]
		internal SetValueVisitor<TSrcValue> <.cctor>b__9_0() { }

		[Address(RVA = "0xA36C90", Offset = "0xA36090", Length = "0x2C")]
		[Token(Token = "0x6000B79")]
		internal void <.cctor>b__9_1(SetValueVisitor<TSrcValue> v) { }

	}

	[Token(Token = "0x4000768")]
	public static readonly ObjectPool<SetValueVisitor`1<TSrcValue>> Pool; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000769")]
	public TSrcValue Value; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400076A")]
	private ConverterGroup <group>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000202")]
	public ConverterGroup group
	{
		[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000B70")]
		 get { } //Length: 8
		[Address(RVA = "0xF5D8E0", Offset = "0xF5CCE0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000B71")]
		 set { } //Length: 19
	}

	[Address(RVA = "0xF5D220", Offset = "0xF5C620", Length = "0x30E")]
	[Token(Token = "0x6000B75")]
	private static SetValueVisitor`1() { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000B74")]
	public SetValueVisitor`1() { }

	[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000B70")]
	public ConverterGroup get_group() { }

	[Address(RVA = "0xF5D0C0", Offset = "0xF5C4C0", Length = "0x3C")]
	[Token(Token = "0x6000B72")]
	public virtual void Reset() { }

	[Address(RVA = "0xF5D8E0", Offset = "0xF5CCE0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000B71")]
	public void set_group(ConverterGroup value) { }

	[Address(RVA = "0x6A1E60", Offset = "0x6A1260", Length = "0x28D")]
	[Token(Token = "0x6000B73")]
	protected virtual void VisitPath(Property<TContainer, TValue> property, ref TContainer container, ref TValue value) { }

}


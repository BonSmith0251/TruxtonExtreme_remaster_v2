namespace UnityEngine.InputSystem;

[Token(Token = "0x2000056")]
public abstract class InputBindingComposite
{
	[CompilerGenerated]
	[Token(Token = "0x2000057")]
	private sealed class <GetPartNames>d__12 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000210")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000211")]
		private string <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000212")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000213")]
		private string composite; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000214")]
		public string <>3__composite; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000215")]
		private FieldInfo[] <>7__wrap1; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000216")]
		private int <>7__wrap2; //Field offset: 0x40

		[Token(Token = "0x17000138")]
		private override string System.Collections.Generic.IEnumerator<System.String>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000419")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000139")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600041B")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000416")]
		public <GetPartNames>d__12(int <>1__state) { }

		[Address(RVA = "0x2943B60", Offset = "0x2942F60", Length = "0x1E4")]
		[Token(Token = "0x6000418")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2943D50", Offset = "0x2943150", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x600041C")]
		private override IEnumerator<String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000419")]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[Address(RVA = "0x2943D50", Offset = "0x2943150", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x600041D")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600041B")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2943DF0", Offset = "0x29431F0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600041A")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000417")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x400020F")]
	internal static TypeTable s_Composites; //Field offset: 0x0

	[Token(Token = "0x17000137")]
	public abstract int valueSizeInBytes
	{
		[Token(Token = "0x600040B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000136")]
	public abstract Type valueType
	{
		[Token(Token = "0x600040A")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000415")]
	protected InputBindingComposite() { }

	[Address(RVA = "0x2610AD0", Offset = "0x260FED0", Length = "0x14")]
	[Token(Token = "0x6000410")]
	internal void CallFinishSetup(ref InputBindingCompositeContext context) { }

	[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
	[Token(Token = "0x600040E")]
	public override float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600040F")]
	protected override void FinishSetup(ref InputBindingCompositeContext context) { }

	[Token(Token = "0x600040B")]
	public abstract int get_valueSizeInBytes() { }

	[Token(Token = "0x600040A")]
	public abstract Type get_valueType() { }

	[Address(RVA = "0x292E370", Offset = "0x292D770", Length = "0xEF")]
	[Token(Token = "0x6000414")]
	internal static string GetDisplayFormatString(string composite) { }

	[Address(RVA = "0x292E460", Offset = "0x292D860", Length = "0x1A3")]
	[Token(Token = "0x6000412")]
	public static string GetExpectedControlLayoutName(string composite, string part) { }

	[Address(RVA = "0x292E610", Offset = "0x292DA10", Length = "0x71")]
	[IteratorStateMachine(typeof(<GetPartNames>d__12))]
	[Token(Token = "0x6000413")]
	internal static IEnumerable<String> GetPartNames(string composite) { }

	[Address(RVA = "0x292E690", Offset = "0x292DA90", Length = "0x120")]
	[Token(Token = "0x6000411")]
	internal static Type GetValueType(string composite) { }

	[Token(Token = "0x600040C")]
	public abstract void ReadValue(ref InputBindingCompositeContext context, Void* buffer, int bufferSize) { }

	[Token(Token = "0x600040D")]
	public abstract object ReadValueAsObject(ref InputBindingCompositeContext context) { }

}


namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000199")]
internal class FieldMultipleFilter : PathFilter
{
	[CompilerGenerated]
	[Token(Token = "0x200019A")]
	private sealed class <>c
	{
		[Nullable(0)]
		[Token(Token = "0x400079A")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		[Token(Token = "0x400079B")]
		public static Func<String, String> <>9__2_0; //Field offset: 0x8

		[Address(RVA = "0x21A8EE0", Offset = "0x21A82E0", Length = "0x67")]
		[Token(Token = "0x6000E2D")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000E2E")]
		public <>c() { }

		[Address(RVA = "0x21A8E70", Offset = "0x21A8270", Length = "0x3F")]
		[NullableContext(0)]
		[Token(Token = "0x6000E2F")]
		internal string <ExecuteFilter>b__2_0(string n) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200019B")]
	private sealed class <ExecuteFilter>d__2 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400079C")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400079D")]
		private JToken <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400079E")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x400079F")]
		private IEnumerable<JToken> current; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40007A0")]
		public IEnumerable<JToken> <>3__current; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x40007A1")]
		public FieldMultipleFilter <>4__this; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Nullable(0)]
		[Token(Token = "0x40007A2")]
		private JsonSelectSettings settings; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Nullable(0)]
		[Token(Token = "0x40007A3")]
		public JsonSelectSettings <>3__settings; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40007A4")]
		private IEnumerator<JToken> <>7__wrap1; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Nullable(0)]
		[Token(Token = "0x40007A5")]
		private JObject <o>5__3; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40007A6")]
		private Enumerator<String> <>7__wrap3; //Field offset: 0x60
		[FieldOffset(Offset = "0x78")]
		[Nullable(0)]
		[Token(Token = "0x40007A7")]
		private string <name>5__5; //Field offset: 0x78

		[Token(Token = "0x17000240")]
		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000E35")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000241")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000E37")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000E30")]
		public <ExecuteFilter>d__2(int <>1__state) { }

		[Address(RVA = "0x21A83A0", Offset = "0x21A77A0", Length = "0x50")]
		[Token(Token = "0x6000E33")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x21A84E0", Offset = "0x21A78E0", Length = "0x41")]
		[Token(Token = "0x6000E34")]
		private void <>m__Finally2() { }

		[Address(RVA = "0x21A55E0", Offset = "0x21A49E0", Length = "0x72B")]
		[Token(Token = "0x6000E32")]
		private override bool MoveNext() { }

		[Address(RVA = "0x21A76F0", Offset = "0x21A6AF0", Length = "0xBE")]
		[DebuggerHidden]
		[Token(Token = "0x6000E38")]
		private override IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000E35")]
		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

		[Address(RVA = "0x21A76F0", Offset = "0x21A6AF0", Length = "0xBE")]
		[DebuggerHidden]
		[Token(Token = "0x6000E39")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000E37")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21A7880", Offset = "0x21A6C80", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000E36")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x21A7E30", Offset = "0x21A7230", Length = "0x143")]
		[DebuggerHidden]
		[Token(Token = "0x6000E31")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000799")]
	internal List<String> Names; //Field offset: 0x10

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000E2B")]
	public FieldMultipleFilter(List<String> names) { }

	[Address(RVA = "0x2195880", Offset = "0x2194C80", Length = "0xAB")]
	[IteratorStateMachine(typeof(<ExecuteFilter>d__2))]
	[Token(Token = "0x6000E2C")]
	public virtual IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }

}


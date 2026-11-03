namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x2000197")]
internal class FieldFilter : PathFilter
{
	[CompilerGenerated]
	[Token(Token = "0x2000198")]
	private sealed class <ExecuteFilter>d__2 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400078F")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Nullable(1)]
		[Token(Token = "0x4000790")]
		private JToken <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000791")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x4000792")]
		private IEnumerable<JToken> current; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x4000793")]
		public IEnumerable<JToken> <>3__current; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x4000794")]
		public FieldFilter <>4__this; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Nullable(0)]
		[Token(Token = "0x4000795")]
		private JsonSelectSettings settings; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Nullable(0)]
		[Token(Token = "0x4000796")]
		public JsonSelectSettings <>3__settings; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x4000797")]
		private IEnumerator<JToken> <>7__wrap1; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 0, 1, 2})]
		[Token(Token = "0x4000798")]
		private IEnumerator<KeyValuePair`2<String, JToken>> <>7__wrap2; //Field offset: 0x58

		[Token(Token = "0x1700023E")]
		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000E26")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700023F")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000E28")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000E21")]
		public <ExecuteFilter>d__2(int <>1__state) { }

		[Address(RVA = "0x21A83F0", Offset = "0x21A77F0", Length = "0x50")]
		[Token(Token = "0x6000E24")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x21A85D0", Offset = "0x21A79D0", Length = "0x50")]
		[Token(Token = "0x6000E25")]
		private void <>m__Finally2() { }

		[Address(RVA = "0x21A6840", Offset = "0x21A5C40", Length = "0x608")]
		[Token(Token = "0x6000E23")]
		private override bool MoveNext() { }

		[Address(RVA = "0x21A73F0", Offset = "0x21A67F0", Length = "0xBE")]
		[DebuggerHidden]
		[Token(Token = "0x6000E29")]
		private override IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000E26")]
		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

		[Address(RVA = "0x21A73F0", Offset = "0x21A67F0", Length = "0xBE")]
		[DebuggerHidden]
		[Token(Token = "0x6000E2A")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000E28")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21A7940", Offset = "0x21A6D40", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000E27")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x21A7B90", Offset = "0x21A6F90", Length = "0x14D")]
		[DebuggerHidden]
		[Token(Token = "0x6000E22")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400078E")]
	internal string Name; //Field offset: 0x10

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000E1F")]
	public FieldFilter(string name) { }

	[Address(RVA = "0x21957D0", Offset = "0x2194BD0", Length = "0xAB")]
	[IteratorStateMachine(typeof(<ExecuteFilter>d__2))]
	[NullableContext(1)]
	[Token(Token = "0x6000E20")]
	public virtual IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }

}


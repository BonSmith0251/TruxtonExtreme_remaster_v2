namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000193")]
internal class ArrayMultipleIndexFilter : PathFilter
{
	[CompilerGenerated]
	[Token(Token = "0x2000194")]
	private sealed class <ExecuteFilter>d__2 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000772")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000773")]
		private JToken <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000774")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x4000775")]
		private IEnumerable<JToken> current; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x4000776")]
		public IEnumerable<JToken> <>3__current; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x4000777")]
		public ArrayMultipleIndexFilter <>4__this; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Nullable(0)]
		[Token(Token = "0x4000778")]
		private JsonSelectSettings settings; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Nullable(0)]
		[Token(Token = "0x4000779")]
		public JsonSelectSettings <>3__settings; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x400077A")]
		private IEnumerator<JToken> <>7__wrap1; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Nullable(0)]
		[Token(Token = "0x400077B")]
		private JToken <t>5__3; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Nullable(0)]
		[Token(Token = "0x400077C")]
		private Enumerator<Int32> <>7__wrap3; //Field offset: 0x60

		[Token(Token = "0x17000237")]
		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000E08")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000238")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000E0A")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000E03")]
		public <ExecuteFilter>d__2(int <>1__state) { }

		[Address(RVA = "0x21A8440", Offset = "0x21A7840", Length = "0x50")]
		[Token(Token = "0x6000E06")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x21A8670", Offset = "0x21A7A70", Length = "0x41")]
		[Token(Token = "0x6000E07")]
		private void <>m__Finally2() { }

		[Address(RVA = "0x21A52B0", Offset = "0x21A46B0", Length = "0x32F")]
		[Token(Token = "0x6000E05")]
		private override bool MoveNext() { }

		[Address(RVA = "0x21A7630", Offset = "0x21A6A30", Length = "0xBE")]
		[DebuggerHidden]
		[Token(Token = "0x6000E0B")]
		private override IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000E08")]
		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

		[Address(RVA = "0x21A7630", Offset = "0x21A6A30", Length = "0xBE")]
		[DebuggerHidden]
		[Token(Token = "0x6000E0C")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000E0A")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21A79C0", Offset = "0x21A6DC0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000E09")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x21A8160", Offset = "0x21A7560", Length = "0x143")]
		[DebuggerHidden]
		[Token(Token = "0x6000E04")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000771")]
	internal List<Int32> Indexes; //Field offset: 0x10

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000E01")]
	public ArrayMultipleIndexFilter(List<Int32> indexes) { }

	[Address(RVA = "0x218EF30", Offset = "0x218E330", Length = "0xAB")]
	[IteratorStateMachine(typeof(<ExecuteFilter>d__2))]
	[Token(Token = "0x6000E02")]
	public virtual IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }

}


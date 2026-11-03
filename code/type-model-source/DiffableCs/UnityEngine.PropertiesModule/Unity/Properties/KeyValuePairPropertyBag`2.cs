namespace Unity.Properties;

[Token(Token = "0x200003C")]
public class KeyValuePairPropertyBag : PropertyBag<KeyValuePair`2<TKey, TValue>>, INamedProperties<KeyValuePair`2<TKey, TValue>>
{
	[CompilerGenerated]
	[Token(Token = "0x200003D")]
	private sealed class <>c
	{
		[Token(Token = "0x400005B")]
		public static readonly <>c<TKey, TValue> <>9; //Field offset: 0x0

		[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
		[Token(Token = "0x60000DF")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000E0")]
		public <>c() { }

		[Address(RVA = "0xA36D20", Offset = "0xA36120", Length = "0x9A")]
		[Token(Token = "0x60000E1")]
		internal TKey <.cctor>b__7_0(ref KeyValuePair<TKey, TValue>& container) { }

		[Address(RVA = "0xA36DC0", Offset = "0xA361C0", Length = "0x9A")]
		[Token(Token = "0x60000E2")]
		internal TValue <.cctor>b__7_1(ref KeyValuePair<TKey, TValue>& container) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003E")]
	private sealed class <GetPropertiesEnumerable>d__4 : IEnumerable<IProperty`1<KeyValuePair`2<TKey, TValue>>>, IEnumerable, IEnumerator<IProperty`1<KeyValuePair`2<TKey, TValue>>>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005C")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005D")]
		private IProperty<KeyValuePair`2<TKey, TValue>> <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005E")]
		private int <>l__initialThreadId; //Field offset: 0x0

		[Token(Token = "0x1700002E")]
		private override IProperty<KeyValuePair`2<TKey, TValue>> System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<System.Collections.Generic.KeyValuePair<TKey,TValue>>>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000E6")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700002F")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000E8")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x60000E3")]
		public <GetPropertiesEnumerable>d__4(int <>1__state) { }

		[Address(RVA = "0x1808870", Offset = "0x1807C70", Length = "0x144")]
		[Token(Token = "0x60000E5")]
		private override bool MoveNext() { }

		[Address(RVA = "0x18089C0", Offset = "0x1807DC0", Length = "0x9A")]
		[DebuggerHidden]
		[Token(Token = "0x60000E9")]
		private override IEnumerator<IProperty`1<KeyValuePair`2<TKey, TValue>>> System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<System.Collections.Generic.KeyValuePair<TKey,TValue>>>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000E6")]
		private override IProperty<KeyValuePair`2<TKey, TValue>> System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<System.Collections.Generic.KeyValuePair<TKey,TValue>>>.get_Current() { }

		[Address(RVA = "0x16F5FF0", Offset = "0x16F53F0", Length = "0x18")]
		[DebuggerHidden]
		[Token(Token = "0x60000EA")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000E8")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x60000E7")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60000E4")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x4000059")]
	private static readonly DelegateProperty<KeyValuePair`2<TKey, TValue>, TKey> s_KeyProperty; //Field offset: 0x0
	[Token(Token = "0x400005A")]
	private static readonly DelegateProperty<KeyValuePair`2<TKey, TValue>, TValue> s_ValueProperty; //Field offset: 0x0

	[Address(RVA = "0xAE9270", Offset = "0xAE8670", Length = "0x4B3")]
	[Token(Token = "0x60000DE")]
	private static KeyValuePairPropertyBag`2() { }

	[Address(RVA = "0xAE9730", Offset = "0xAE8B30", Length = "0x63")]
	[Token(Token = "0x60000DD")]
	public KeyValuePairPropertyBag`2() { }

	[Address(RVA = "0xAE8E90", Offset = "0xAE8290", Length = "0x13F")]
	[Token(Token = "0x60000D9")]
	public virtual PropertyCollection<KeyValuePair`2<TKey, TValue>> GetProperties() { }

	[Address(RVA = "0xAE8FD0", Offset = "0xAE83D0", Length = "0x13F")]
	[Token(Token = "0x60000DA")]
	public virtual PropertyCollection<KeyValuePair`2<TKey, TValue>> GetProperties(ref KeyValuePair<TKey, TValue>& container) { }

	[Address(RVA = "0xAE8DE0", Offset = "0xAE81E0", Length = "0xAE")]
	[IteratorStateMachine(typeof(<GetPropertiesEnumerable>d__4))]
	[Token(Token = "0x60000DB")]
	private static IEnumerable<IProperty`1<KeyValuePair`2<TKey, TValue>>> GetPropertiesEnumerable() { }

	[Address(RVA = "0xAE9110", Offset = "0xAE8510", Length = "0x152")]
	[Token(Token = "0x60000DC")]
	public override bool TryGetProperty(ref KeyValuePair<TKey, TValue>& container, string name, out IProperty<KeyValuePair`2<TKey, TValue>>& property) { }

}


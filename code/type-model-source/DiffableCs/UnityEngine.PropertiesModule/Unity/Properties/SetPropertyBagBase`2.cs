namespace Unity.Properties;

[Token(Token = "0x2000045")]
public class SetPropertyBagBase : PropertyBag<TSet>, ISetPropertyBag<TSet, TElement>, ICollectionPropertyBag<TSet, TElement>, IPropertyBag<TSet>, IPropertyBag, ICollectionPropertyBagAccept<TSet>, ISetPropertyBagAccept<TSet>, IKeyedProperties<TSet, Object>
{
	[CompilerGenerated]
	[Token(Token = "0x2000047")]
	private sealed class <GetPropertiesEnumerable>d__4 : IEnumerable<IProperty`1<TSet>>, IEnumerable, IEnumerator<IProperty`1<TSet>>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000071")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000072")]
		private IProperty<TSet> <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000073")]
		private int <>l__initialThreadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000074")]
		private TSet container; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000075")]
		public TSet <>3__container; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000076")]
		public SetPropertyBagBase<TSet, TElement> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000077")]
		private IEnumerator<TElement> <>s__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000078")]
		private TElement <element>5__2; //Field offset: 0x0

		[Token(Token = "0x17000039")]
		private override IProperty<TSet> System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<TSet>>.Current
		{
			[Address(RVA = "0xF53FC0", Offset = "0xF533C0", Length = "0x2A")]
			[DebuggerHidden]
			[Token(Token = "0x6000126")]
			private get { } //Length: 42
		}

		[Token(Token = "0x1700003A")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xF53FC0", Offset = "0xF533C0", Length = "0x2A")]
			[DebuggerHidden]
			[Token(Token = "0x6000128")]
			private get { } //Length: 42
		}

		[Address(RVA = "0x113F950", Offset = "0x113ED50", Length = "0xBE")]
		[DebuggerHidden]
		[Token(Token = "0x6000122")]
		public <GetPropertiesEnumerable>d__4(int <>1__state) { }

		[Address(RVA = "0x1808C90", Offset = "0x1808090", Length = "0xEC")]
		[Token(Token = "0x6000125")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x1808230", Offset = "0x1807630", Length = "0x63C")]
		[Token(Token = "0x6000124")]
		private override bool MoveNext() { }

		[Address(RVA = "0x1808A60", Offset = "0x1807E60", Length = "0x227")]
		[DebuggerHidden]
		[Token(Token = "0x6000129")]
		private override IEnumerator<IProperty`1<TSet>> System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TSet>>.GetEnumerator() { }

		[Address(RVA = "0xF53FC0", Offset = "0xF533C0", Length = "0x2A")]
		[DebuggerHidden]
		[Token(Token = "0x6000126")]
		private override IProperty<TSet> System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<TSet>>.get_Current() { }

		[Address(RVA = "0x16F3C10", Offset = "0x16F3010", Length = "0x18")]
		[DebuggerHidden]
		[Token(Token = "0x600012A")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0xF53FC0", Offset = "0xF533C0", Length = "0x2A")]
		[DebuggerHidden]
		[Token(Token = "0x6000128")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x6000127")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x113F5E0", Offset = "0x113E9E0", Length = "0x95")]
		[DebuggerHidden]
		[Token(Token = "0x6000123")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000046")]
	private class SetElementProperty : Property<TSet, TElement>, ISetElementProperty
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000070")]
		internal TElement m_Value; //Field offset: 0x0

		[Token(Token = "0x17000037")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x600011D")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000036")]
		public virtual string Name
		{
			[Address(RVA = "0xF5C8D0", Offset = "0xF5BCD0", Length = "0xE6")]
			[Token(Token = "0x600011C")]
			 get { } //Length: 230
		}

		[Token(Token = "0x17000038")]
		public override object ObjectKey
		{
			[Address(RVA = "0xF5C9C0", Offset = "0xF5BDC0", Length = "0xA9")]
			[Token(Token = "0x6000120")]
			 get { } //Length: 169
		}

		[Address(RVA = "0xB0D4D0", Offset = "0xB0C8D0", Length = "0x15")]
		[Token(Token = "0x6000121")]
		public SetElementProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600011D")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0xF5C8D0", Offset = "0xF5BCD0", Length = "0xE6")]
		[Token(Token = "0x600011C")]
		public virtual string get_Name() { }

		[Address(RVA = "0xF5C9C0", Offset = "0xF5BDC0", Length = "0xA9")]
		[Token(Token = "0x6000120")]
		public override object get_ObjectKey() { }

		[Address(RVA = "0xF5C7E0", Offset = "0xF5BBE0", Length = "0xA0")]
		[Token(Token = "0x600011E")]
		public virtual TElement GetValue(ref TSet container) { }

		[Address(RVA = "0xF5C880", Offset = "0xF5BC80", Length = "0x49")]
		[Token(Token = "0x600011F")]
		public virtual void SetValue(ref TSet container, TElement value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400006F")]
	private readonly SetElementProperty<TSet, TElement> m_Property; //Field offset: 0x0

	[Address(RVA = "0xF5CFB0", Offset = "0xF5C3B0", Length = "0xCC")]
	[Token(Token = "0x600011B")]
	public SetPropertyBagBase`2() { }

	[Address(RVA = "0xAE8190", Offset = "0xAE7590", Length = "0x11E")]
	[Token(Token = "0x6000115")]
	public virtual PropertyCollection<TSet> GetProperties() { }

	[Address(RVA = "0xF5CBF0", Offset = "0xF5BFF0", Length = "0x179")]
	[Token(Token = "0x6000116")]
	public virtual PropertyCollection<TSet> GetProperties(ref TSet container) { }

	[Address(RVA = "0xF5CA70", Offset = "0xF5BE70", Length = "0x171")]
	[IteratorStateMachine(typeof(<GetPropertiesEnumerable>d__4))]
	[Token(Token = "0x6000117")]
	private IEnumerable<IProperty`1<TSet>> GetPropertiesEnumerable(TSet container) { }

	[Address(RVA = "0xF5CD70", Offset = "0xF5C170", Length = "0x231")]
	[Token(Token = "0x600011A")]
	public override bool TryGetProperty(ref TSet container, object key, out IProperty<TSet>& property) { }

	[Address(RVA = "0xAE82B0", Offset = "0xAE76B0", Length = "0x2F")]
	[Token(Token = "0x6000118")]
	private override void Unity.Properties.ICollectionPropertyBagAccept<TSet>.Accept(ICollectionPropertyBagVisitor visitor, ref TSet container) { }

	[Address(RVA = "0xAE82E0", Offset = "0xAE76E0", Length = "0x2F")]
	[Token(Token = "0x6000119")]
	private override void Unity.Properties.ISetPropertyBagAccept<TSet>.Accept(ISetPropertyBagVisitor visitor, ref TSet container) { }

}


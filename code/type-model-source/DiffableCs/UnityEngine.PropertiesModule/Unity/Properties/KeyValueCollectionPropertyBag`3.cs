namespace Unity.Properties;

[Token(Token = "0x2000038")]
public class KeyValueCollectionPropertyBag : PropertyBag<TDictionary>, IDictionaryPropertyBag<TDictionary, TKey, TValue>, ICollectionPropertyBag<TDictionary, KeyValuePair`2<TKey, TValue>>, IPropertyBag<TDictionary>, IPropertyBag, ICollectionPropertyBagAccept<TDictionary>, IDictionaryPropertyBagAccept<TDictionary>, IKeyedProperties<TDictionary, Object>
{
	[IsReadOnly]
	[Token(Token = "0x200003A")]
	private struct Enumerable : IEnumerable<IProperty`1<TDictionary>>, IEnumerable
	{
		[Token(Token = "0x200003B")]
		private class Enumerator : IEnumerator<IProperty`1<TDictionary>>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000054")]
			private readonly TDictionary m_Dictionary; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000055")]
			private readonly KeyValuePairProperty<TDictionary, TKey, TValue> m_Property; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000056")]
			private readonly TKey m_Previous; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000057")]
			private readonly List<TKey> m_Keys; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000058")]
			private int m_Position; //Field offset: 0x0

			[Token(Token = "0x1700002C")]
			public override IProperty<TDictionary> Current
			{
				[Address(RVA = "0x19D2B10", Offset = "0x19D1F10", Length = "0x2B")]
				[Token(Token = "0x60000D4")]
				 get { } //Length: 43
			}

			[Token(Token = "0x1700002D")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x16F3C10", Offset = "0x16F3010", Length = "0x18")]
				[Token(Token = "0x60000D5")]
				private get { } //Length: 24
			}

			[Address(RVA = "0x19D2730", Offset = "0x19D1B30", Length = "0x383")]
			[Token(Token = "0x60000D3")]
			public Enumerator(TDictionary dictionary, KeyValuePairProperty<TDictionary, TKey, TValue> property) { }

			[Address(RVA = "0x19C85B0", Offset = "0x19C79B0", Length = "0x85")]
			[Token(Token = "0x60000D8")]
			public override void Dispose() { }

			[Address(RVA = "0x19D2B10", Offset = "0x19D1F10", Length = "0x2B")]
			[Token(Token = "0x60000D4")]
			public override IProperty<TDictionary> get_Current() { }

			[Address(RVA = "0x19C8F10", Offset = "0x19C8310", Length = "0x3C6")]
			[Token(Token = "0x60000D6")]
			public override bool MoveNext() { }

			[Address(RVA = "0x19CB480", Offset = "0x19CA880", Length = "0x164")]
			[Token(Token = "0x60000D7")]
			public override void Reset() { }

			[Address(RVA = "0x16F3C10", Offset = "0x16F3010", Length = "0x18")]
			[Token(Token = "0x60000D5")]
			private override object System.Collections.IEnumerator.get_Current() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000052")]
		private readonly TDictionary m_Dictionary; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000053")]
		private readonly KeyValuePairProperty<TDictionary, TKey, TValue> m_Property; //Field offset: 0x0

		[Address(RVA = "0xE28E10", Offset = "0xE28210", Length = "0x145")]
		[Token(Token = "0x60000D0")]
		public Enumerable(TDictionary dictionary, KeyValuePairProperty<TDictionary, TKey, TValue> property) { }

		[Address(RVA = "0x1957690", Offset = "0x1956A90", Length = "0x1BE")]
		[Token(Token = "0x60000D2")]
		private override IEnumerator<IProperty`1<TDictionary>> System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TDictionary>>.GetEnumerator() { }

		[Address(RVA = "0x1957690", Offset = "0x1956A90", Length = "0x1BE")]
		[Token(Token = "0x60000D1")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[Token(Token = "0x2000039")]
	private class KeyValuePairProperty : Property<TDictionary, KeyValuePair`2<TKey, TValue>>, IDictionaryElementProperty
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000051")]
		private TKey <Key>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000029")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60000C9")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700002A")]
		public internal override TKey Key
		{
			[Address(RVA = "0xAE9CF0", Offset = "0xAE90F0", Length = "0xA9")]
			[CompilerGenerated]
			[Token(Token = "0x60000CC")]
			 get { } //Length: 169
			[Address(RVA = "0xAE9FC0", Offset = "0xAE93C0", Length = "0xB6")]
			[CompilerGenerated]
			[Token(Token = "0x60000CD")]
			internal set { } //Length: 182
		}

		[Token(Token = "0x17000028")]
		public virtual string Name
		{
			[Address(RVA = "0xAE9DA0", Offset = "0xAE91A0", Length = "0x162")]
			[Token(Token = "0x60000C8")]
			 get { } //Length: 354
		}

		[Token(Token = "0x1700002B")]
		public override object ObjectKey
		{
			[Address(RVA = "0xAE9F10", Offset = "0xAE9310", Length = "0xA6")]
			[Token(Token = "0x60000CE")]
			 get { } //Length: 166
		}

		[Address(RVA = "0xAE9CD0", Offset = "0xAE90D0", Length = "0x15")]
		[Token(Token = "0x60000CF")]
		public KeyValuePairProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60000C9")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0xAE9CF0", Offset = "0xAE90F0", Length = "0xA9")]
		[CompilerGenerated]
		[Token(Token = "0x60000CC")]
		public override TKey get_Key() { }

		[Address(RVA = "0xAE9DA0", Offset = "0xAE91A0", Length = "0x162")]
		[Token(Token = "0x60000C8")]
		public virtual string get_Name() { }

		[Address(RVA = "0xAE9F10", Offset = "0xAE9310", Length = "0xA6")]
		[Token(Token = "0x60000CE")]
		public override object get_ObjectKey() { }

		[Address(RVA = "0xAE97A0", Offset = "0xAE8BA0", Length = "0x354")]
		[Token(Token = "0x60000CA")]
		public virtual KeyValuePair<TKey, TValue> GetValue(ref TDictionary container) { }

		[Address(RVA = "0xAE9FC0", Offset = "0xAE93C0", Length = "0xB6")]
		[CompilerGenerated]
		[Token(Token = "0x60000CD")]
		internal void set_Key(TKey value) { }

		[Address(RVA = "0xAE9B00", Offset = "0xAE8F00", Length = "0x1C1")]
		[Token(Token = "0x60000CB")]
		public virtual void SetValue(ref TDictionary container, KeyValuePair<TKey, TValue> value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000050")]
	private readonly KeyValuePairProperty<TDictionary, TKey, TValue> m_KeyValuePairProperty; //Field offset: 0x0

	[Address(RVA = "0xAE8560", Offset = "0xAE7960", Length = "0xC9")]
	[Token(Token = "0x60000C7")]
	public KeyValueCollectionPropertyBag`3() { }

	[Address(RVA = "0xAE8190", Offset = "0xAE7590", Length = "0x11E")]
	[Token(Token = "0x60000C2")]
	public virtual PropertyCollection<TDictionary> GetProperties() { }

	[Address(RVA = "0xAE7F70", Offset = "0xAE7370", Length = "0x217")]
	[Token(Token = "0x60000C3")]
	public virtual PropertyCollection<TDictionary> GetProperties(ref TDictionary container) { }

	[Address(RVA = "0xAE82B0", Offset = "0xAE76B0", Length = "0x2F")]
	[Token(Token = "0x60000C4")]
	private override void Unity.Properties.ICollectionPropertyBagAccept<TDictionary>.Accept(ICollectionPropertyBagVisitor visitor, ref TDictionary container) { }

	[Address(RVA = "0xAE82E0", Offset = "0xAE76E0", Length = "0x2F")]
	[Token(Token = "0x60000C5")]
	private override void Unity.Properties.IDictionaryPropertyBagAccept<TDictionary>.Accept(IDictionaryPropertyBagVisitor visitor, ref TDictionary container) { }

	[Address(RVA = "0xAE8310", Offset = "0xAE7710", Length = "0x246")]
	[Token(Token = "0x60000C6")]
	private override bool Unity.Properties.IKeyedProperties<TDictionary,System.Object>.TryGetProperty(ref TDictionary container, object key, out IProperty<TDictionary>& property) { }

}


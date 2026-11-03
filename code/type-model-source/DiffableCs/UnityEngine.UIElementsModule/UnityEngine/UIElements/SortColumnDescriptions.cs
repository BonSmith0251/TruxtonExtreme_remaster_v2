namespace UnityEngine.UIElements;

[DefaultMember("Item")]
[Token(Token = "0x2000128")]
[UxmlObject]
public class SortColumnDescriptions : ICollection<SortColumnDescription>, IEnumerable<SortColumnDescription>, IEnumerable
{
	[Obsolete("UxmlObjectFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200012A")]
	public class UxmlObjectFactory : UxmlObjectFactory<SortColumnDescriptions>
	{

		[Address(RVA = "0x33A8280", Offset = "0x33A7680", Length = "0x39")]
		[Token(Token = "0x6000948")]
		public UxmlObjectFactory() { }

	}

	[Obsolete("UxmlObjectFactory<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000129")]
	public class UxmlObjectFactory : UxmlObjectFactory<T, UxmlObjectTraits`1<T>>
	{

		[Address(RVA = "0x11E5050", Offset = "0x11E4450", Length = "0x22")]
		[Token(Token = "0x6000947")]
		public UxmlObjectFactory`1() { }

	}

	[Obsolete("UxmlObjectTraits<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200012B")]
	public class UxmlObjectTraits : UxmlObjectTraits<T>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005D2")]
		private readonly UxmlObjectListAttributeDescription<SortColumnDescription> m_SortColumnDescriptions; //Field offset: 0x0

		[Address(RVA = "0x11E73A0", Offset = "0x11E67A0", Length = "0x72")]
		[Token(Token = "0x600094A")]
		public UxmlObjectTraits`1() { }

		[Address(RVA = "0x11E5DD0", Offset = "0x11E51D0", Length = "0x1B0")]
		[Token(Token = "0x6000949")]
		public virtual void Init(ref T obj, IUxmlAttributes bag, CreationContext cc) { }

	}

	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40005D0")]
	private readonly IList<SortColumnDescription> m_Descriptions; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005D1")]
	private Action changed; //Field offset: 0x18

	[Token(Token = "0x14000023")]
	internal event Action changed
	{
		[Address(RVA = "0x33A53A0", Offset = "0x33A47A0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000939")]
		internal add { } //Length: 158
		[Address(RVA = "0x33A54E0", Offset = "0x33A48E0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600093A")]
		internal remove { } //Length: 158
	}

	[Token(Token = "0x17000191")]
	public override int Count
	{
		[Address(RVA = "0x33A5440", Offset = "0x33A4840", Length = "0x46")]
		[Token(Token = "0x6000943")]
		 get { } //Length: 70
	}

	[Token(Token = "0x17000192")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x33A5490", Offset = "0x33A4890", Length = "0x49")]
		[Token(Token = "0x6000944")]
		 get { } //Length: 73
	}

	[Address(RVA = "0x33A5320", Offset = "0x33A4720", Length = "0x77")]
	[Token(Token = "0x6000946")]
	public SortColumnDescriptions() { }

	[Address(RVA = "0x33A4B10", Offset = "0x33A3F10", Length = "0x62")]
	[Token(Token = "0x600093D")]
	public override void Add(SortColumnDescription item) { }

	[Address(RVA = "0x33A53A0", Offset = "0x33A47A0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000939")]
	internal void add_changed(Action value) { }

	[Address(RVA = "0x33A4B80", Offset = "0x33A3F80", Length = "0x189")]
	[Token(Token = "0x600093E")]
	public override void Clear() { }

	[Address(RVA = "0x33A4D10", Offset = "0x33A4110", Length = "0x58")]
	[Token(Token = "0x600093F")]
	public override bool Contains(SortColumnDescription item) { }

	[Address(RVA = "0x33A4D70", Offset = "0x33A4170", Length = "0xCC")]
	[Token(Token = "0x6000940")]
	public override void CopyTo(SortColumnDescription[] array, int arrayIndex) { }

	[Address(RVA = "0x33A5440", Offset = "0x33A4840", Length = "0x46")]
	[Token(Token = "0x6000943")]
	public override int get_Count() { }

	[Address(RVA = "0x33A5490", Offset = "0x33A4890", Length = "0x49")]
	[Token(Token = "0x6000944")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x33A4E40", Offset = "0x33A4240", Length = "0x46")]
	[Token(Token = "0x600093B")]
	public override IEnumerator<SortColumnDescription> GetEnumerator() { }

	[Address(RVA = "0x33A4E90", Offset = "0x33A4290", Length = "0x2B0")]
	[Token(Token = "0x6000945")]
	public void Insert(int index, SortColumnDescription desc) { }

	[Address(RVA = "0xE106E0", Offset = "0xE0FAE0", Length = "0x19")]
	[Token(Token = "0x6000942")]
	private void OnDescriptionChanged(SortColumnDescription desc) { }

	[Address(RVA = "0x33A5150", Offset = "0x33A4550", Length = "0x1CE")]
	[Token(Token = "0x6000941")]
	public override bool Remove(SortColumnDescription desc) { }

	[Address(RVA = "0x33A54E0", Offset = "0x33A48E0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600093A")]
	internal void remove_changed(Action value) { }

	[Address(RVA = "0x33A4E40", Offset = "0x33A4240", Length = "0x46")]
	[Token(Token = "0x600093C")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}


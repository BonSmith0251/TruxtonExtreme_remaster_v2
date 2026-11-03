namespace Unity.Hierarchy;

[IsReadOnly]
[Token(Token = "0x2000011")]
public struct HierarchyViewModelNodesEnumerable
{
	[Token(Token = "0x2000013")]
	internal struct Enumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000027")]
		private readonly HierarchyViewModel m_HierarchyViewModel; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000028")]
		private readonly Predicate m_Predicate; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000029")]
		private readonly HierarchyNodeFlags m_Flags; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400002A")]
		private readonly ReadOnlyNativeVector<HierarchyFlattenedNode> m_FlattenedNodes; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400002B")]
		private readonly int m_Version; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x400002C")]
		private int m_Index; //Field offset: 0x2C

		[IsReadOnly]
		[Token(Token = "0x17000007")]
		public HierarchyNode Current
		{
			[Address(RVA = "0x30D5430", Offset = "0x30D4830", Length = "0x47")]
			[Token(Token = "0x600004A")]
			 get { } //Length: 71
		}

		[Address(RVA = "0x30D51E0", Offset = "0x30D45E0", Length = "0x5F")]
		[Token(Token = "0x6000049")]
		internal Enumerator(HierarchyViewModelNodesEnumerable enumerable) { }

		[Address(RVA = "0x30D5430", Offset = "0x30D4830", Length = "0x47")]
		[Token(Token = "0x600004A")]
		public HierarchyNode get_Current() { }

		[Address(RVA = "0x30D4E50", Offset = "0x30D4250", Length = "0x9D")]
		[Token(Token = "0x600004B")]
		public bool MoveNext() { }

		[Address(RVA = "0x30D43A0", Offset = "0x30D37A0", Length = "0xEA")]
		[Token(Token = "0x600004C")]
		private void ThrowIfVersionChanged() { }

	}

	[Token(Token = "0x2000012")]
	public sealed class Predicate : MulticastDelegate
	{

		[Address(RVA = "0x30DBF70", Offset = "0x30DB370", Length = "0xB5")]
		[Token(Token = "0x6000047")]
		public Predicate(object object, IntPtr method) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x6000048")]
		public override bool Invoke(in HierarchyNode node, HierarchyNodeFlags flags) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000024")]
	private readonly HierarchyViewModel m_HierarchyViewModel; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000025")]
	private readonly Predicate m_Predicate; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000026")]
	private readonly HierarchyNodeFlags m_Flags; //Field offset: 0x10

	[Address(RVA = "0x30D9360", Offset = "0x30D8760", Length = "0xDE")]
	[Token(Token = "0x6000045")]
	internal HierarchyViewModelNodesEnumerable(HierarchyViewModel viewModel, HierarchyNodeFlags flags, Predicate predicate) { }

	[Address(RVA = "0x30D92C0", Offset = "0x30D86C0", Length = "0x92")]
	[Token(Token = "0x6000046")]
	public Enumerator GetEnumerator() { }

}


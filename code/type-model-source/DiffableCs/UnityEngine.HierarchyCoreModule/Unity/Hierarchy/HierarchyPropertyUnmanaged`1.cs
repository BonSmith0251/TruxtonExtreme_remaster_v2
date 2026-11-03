namespace Unity.Hierarchy;

[IsReadOnly]
[Token(Token = "0x200000E")]
public struct HierarchyPropertyUnmanaged : IEquatable<HierarchyPropertyUnmanaged`1<T>>, IHierarchyProperty<T>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000021")]
	private readonly Hierarchy m_Hierarchy; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000022")]
	internal readonly HierarchyPropertyId m_Property; //Field offset: 0x0

	[Address(RVA = "0x1C71CD0", Offset = "0x1C710D0", Length = "0xDF")]
	[Token(Token = "0x600003A")]
	internal HierarchyPropertyUnmanaged`1(Hierarchy hierarchy, in HierarchyPropertyId property) { }

	[Address(RVA = "0x1C711F0", Offset = "0x1C705F0", Length = "0x28")]
	[ExcludeFromDocs]
	[Token(Token = "0x600003D")]
	public override bool Equals(HierarchyPropertyUnmanaged<T> other) { }

	[Address(RVA = "0x1C71220", Offset = "0x1C70620", Length = "0x112")]
	[ExcludeFromDocs]
	[Token(Token = "0x600003F")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1C71470", Offset = "0x1C70870", Length = "0xB")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000040")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1C716D0", Offset = "0x1C70AD0", Length = "0x115")]
	[Token(Token = "0x600003C")]
	public T GetValue(in HierarchyNode node) { }

	[Address(RVA = "0x1C717F0", Offset = "0x1C70BF0", Length = "0xEA")]
	[Token(Token = "0x600003B")]
	public void SetValue(in HierarchyNode node, T value) { }

	[Address(RVA = "0x1C71A10", Offset = "0x1C70E10", Length = "0xB")]
	[ExcludeFromDocs]
	[Token(Token = "0x600003E")]
	public virtual string ToString() { }

	[Address(RVA = "0x1C71A20", Offset = "0x1C70E20", Length = "0x45")]
	[Token(Token = "0x6000041")]
	private override T Unity.Hierarchy.IHierarchyProperty<T>.GetValue(in HierarchyNode node) { }

	[Address(RVA = "0x1C71C70", Offset = "0x1C71070", Length = "0x55")]
	[Token(Token = "0x6000042")]
	private override void Unity.Hierarchy.IHierarchyProperty<T>.SetValue(in HierarchyNode node, T value) { }

}


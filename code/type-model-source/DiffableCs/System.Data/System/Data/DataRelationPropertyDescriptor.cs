namespace System.Data;

[Token(Token = "0x200003A")]
internal sealed class DataRelationPropertyDescriptor : PropertyDescriptor
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000133")]
	private readonly DataRelation <Relation>k__BackingField; //Field offset: 0x88

	[Token(Token = "0x170000AE")]
	public virtual Type ComponentType
	{
		[Address(RVA = "0x231B5A0", Offset = "0x231A9A0", Length = "0x4D")]
		[Token(Token = "0x6000424")]
		 get { } //Length: 77
	}

	[Token(Token = "0x170000AF")]
	public virtual bool IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000425")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000B0")]
	public virtual Type PropertyType
	{
		[Address(RVA = "0x231B5F0", Offset = "0x231A9F0", Length = "0x4D")]
		[Token(Token = "0x6000426")]
		 get { } //Length: 77
	}

	[Token(Token = "0x170000AD")]
	internal DataRelation Relation
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000423")]
		internal get { } //Length: 8
	}

	[Address(RVA = "0x231B530", Offset = "0x231A930", Length = "0x61")]
	[Token(Token = "0x6000422")]
	internal DataRelationPropertyDescriptor(DataRelation dataRelation) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000429")]
	public virtual bool CanResetValue(object component) { }

	[Address(RVA = "0x231B400", Offset = "0x231A800", Length = "0x91")]
	[Token(Token = "0x6000427")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x231B5A0", Offset = "0x231A9A0", Length = "0x4D")]
	[Token(Token = "0x6000424")]
	public virtual Type get_ComponentType() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000425")]
	public virtual bool get_IsReadOnly() { }

	[Address(RVA = "0x231B5F0", Offset = "0x231A9F0", Length = "0x4D")]
	[Token(Token = "0x6000426")]
	public virtual Type get_PropertyType() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000423")]
	internal DataRelation get_Relation() { }

	[Address(RVA = "0x2318220", Offset = "0x2317620", Length = "0x2D")]
	[Token(Token = "0x6000428")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x231B4A0", Offset = "0x231A8A0", Length = "0x89")]
	[Token(Token = "0x600042A")]
	public virtual object GetValue(object component) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600042B")]
	public virtual void ResetValue(object component) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600042C")]
	public virtual void SetValue(object component, object value) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600042D")]
	public virtual bool ShouldSerializeValue(object component) { }

}


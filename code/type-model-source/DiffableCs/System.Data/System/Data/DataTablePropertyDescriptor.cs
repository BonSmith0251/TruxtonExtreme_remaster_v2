namespace System.Data;

[Token(Token = "0x200004E")]
internal sealed class DataTablePropertyDescriptor : PropertyDescriptor
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000176")]
	private readonly DataTable <Table>k__BackingField; //Field offset: 0x88

	[Token(Token = "0x170000C9")]
	public virtual Type ComponentType
	{
		[Address(RVA = "0x2333D10", Offset = "0x2333110", Length = "0x4D")]
		[Token(Token = "0x60004CB")]
		 get { } //Length: 77
	}

	[Token(Token = "0x170000CA")]
	public virtual bool IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60004CC")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000CB")]
	public virtual Type PropertyType
	{
		[Address(RVA = "0x2333D60", Offset = "0x2333160", Length = "0x4D")]
		[Token(Token = "0x60004CD")]
		 get { } //Length: 77
	}

	[Token(Token = "0x170000C8")]
	public DataTable Table
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60004CA")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60004CE")]
	public virtual bool CanResetValue(object component) { }

	[Address(RVA = "0x2333D10", Offset = "0x2333110", Length = "0x4D")]
	[Token(Token = "0x60004CB")]
	public virtual Type get_ComponentType() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60004CC")]
	public virtual bool get_IsReadOnly() { }

	[Address(RVA = "0x2333D60", Offset = "0x2333160", Length = "0x4D")]
	[Token(Token = "0x60004CD")]
	public virtual Type get_PropertyType() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60004CA")]
	public DataTable get_Table() { }

	[Address(RVA = "0x2333BF0", Offset = "0x2332FF0", Length = "0x116")]
	[Token(Token = "0x60004CF")]
	public virtual object GetValue(object component) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60004D0")]
	public virtual void ResetValue(object component) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60004D1")]
	public virtual void SetValue(object component, object value) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60004D2")]
	public virtual bool ShouldSerializeValue(object component) { }

}


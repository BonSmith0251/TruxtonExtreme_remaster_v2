namespace System.Data;

[DefaultProperty("ConstraintName")]
[Token(Token = "0x2000028")]
[TypeConverter(typeof(ConstraintConverter))]
public abstract class Constraint
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000ED")]
	private string _schemaName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000EE")]
	private bool _inCollection; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000EF")]
	private DataSet _dataSet; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000F0")]
	internal string _name; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000F1")]
	internal PropertyCollection _extendedProperties; //Field offset: 0x30

	[CLSCompliant(False)]
	[Token(Token = "0x1700007A")]
	protected override DataSet _DataSet
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000343")]
		 get { } //Length: 5
	}

	[DefaultValue(null)]
	[Token(Token = "0x17000075")]
	public override string ConstraintName
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000331")]
		 get { } //Length: 5
		[Address(RVA = "0x2314CA0", Offset = "0x23140A0", Length = "0x221")]
		[Token(Token = "0x6000332")]
		 set { } //Length: 545
	}

	[Browsable(False)]
	[Token(Token = "0x17000079")]
	public PropertyCollection ExtendedProperties
	{
		[Address(RVA = "0x2314BF0", Offset = "0x2313FF0", Length = "0x6A")]
		[Token(Token = "0x6000338")]
		 get { } //Length: 106
	}

	[Token(Token = "0x17000077")]
	internal override bool InCollection
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[Token(Token = "0x6000335")]
		internal get { } //Length: 5
		[Address(RVA = "0x2314ED0", Offset = "0x23142D0", Length = "0x57")]
		[Token(Token = "0x6000336")]
		internal set { } //Length: 87
	}

	[Token(Token = "0x17000076")]
	internal string SchemaName
	{
		[Address(RVA = "0x2314C60", Offset = "0x2314060", Length = "0x3E")]
		[Token(Token = "0x6000333")]
		internal get { } //Length: 62
		[Address(RVA = "0x2314F30", Offset = "0x2314330", Length = "0x39")]
		[Token(Token = "0x6000334")]
		internal set { } //Length: 57
	}

	[Token(Token = "0x17000078")]
	public abstract DataTable Table
	{
		[Token(Token = "0x6000337")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x2314B90", Offset = "0x2313F90", Length = "0x54")]
	[Token(Token = "0x6000346")]
	protected Constraint() { }

	[Token(Token = "0x600033F")]
	internal abstract bool CanBeRemovedFromCollection(ConstraintCollection constraint, bool fThrowException) { }

	[Token(Token = "0x600033A")]
	internal abstract bool CanEnableConstraint() { }

	[Token(Token = "0x600033E")]
	internal abstract void CheckCanAddToCollection(ConstraintCollection constraint) { }

	[Token(Token = "0x6000340")]
	internal abstract void CheckConstraint(DataRow row, DataRowAction action) { }

	[Address(RVA = "0x2314AC0", Offset = "0x2313EC0", Length = "0x57")]
	[Token(Token = "0x600033D")]
	internal void CheckConstraint() { }

	[Token(Token = "0x6000341")]
	internal abstract void CheckState() { }

	[Address(RVA = "0x2314B20", Offset = "0x2313F20", Length = "0x68")]
	[Token(Token = "0x6000342")]
	protected void CheckStateForProperty() { }

	[Token(Token = "0x600033C")]
	internal abstract Constraint Clone(DataSet destination, bool ignoreNSforTableLookup) { }

	[Token(Token = "0x600033B")]
	internal abstract Constraint Clone(DataSet destination) { }

	[Token(Token = "0x6000339")]
	internal abstract bool ContainsColumn(DataColumn column) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000343")]
	protected override DataSet get__DataSet() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000331")]
	public override string get_ConstraintName() { }

	[Address(RVA = "0x2314BF0", Offset = "0x2313FF0", Length = "0x6A")]
	[Token(Token = "0x6000338")]
	public PropertyCollection get_ExtendedProperties() { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[Token(Token = "0x6000335")]
	internal override bool get_InCollection() { }

	[Address(RVA = "0x2314C60", Offset = "0x2314060", Length = "0x3E")]
	[Token(Token = "0x6000333")]
	internal string get_SchemaName() { }

	[Token(Token = "0x6000337")]
	public abstract DataTable get_Table() { }

	[Token(Token = "0x6000344")]
	internal abstract bool IsConstraintViolated() { }

	[Address(RVA = "0x2314CA0", Offset = "0x23140A0", Length = "0x221")]
	[Token(Token = "0x6000332")]
	public override void set_ConstraintName(string value) { }

	[Address(RVA = "0x2314ED0", Offset = "0x23142D0", Length = "0x57")]
	[Token(Token = "0x6000336")]
	internal override void set_InCollection(bool value) { }

	[Address(RVA = "0x2314F30", Offset = "0x2314330", Length = "0x39")]
	[Token(Token = "0x6000334")]
	internal void set_SchemaName(string value) { }

	[Address(RVA = "0x22918F0", Offset = "0x2290CF0", Length = "0x14")]
	[Token(Token = "0x6000345")]
	public virtual string ToString() { }

}


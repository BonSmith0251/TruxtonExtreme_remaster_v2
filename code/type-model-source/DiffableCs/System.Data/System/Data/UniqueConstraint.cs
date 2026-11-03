namespace System.Data;

[DefaultProperty("ConstraintName")]
[Token(Token = "0x2000090")]
public class UniqueConstraint : Constraint
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002CB")]
	private DataKey _key; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002CC")]
	private Index _constraintIndex; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002CD")]
	internal bool _bPrimaryKey; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002CE")]
	internal string _constraintName; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40002CF")]
	internal String[] _columnNames; //Field offset: 0x58

	[Token(Token = "0x17000120")]
	internal String[] ColumnNames
	{
		[Address(RVA = "0x2350B90", Offset = "0x234FF90", Length = "0xB")]
		[Token(Token = "0x6000755")]
		internal get { } //Length: 11
	}

	[ReadOnly(True)]
	[Token(Token = "0x17000122")]
	public override DataColumn[] Columns
	{
		[Address(RVA = "0x2350BA0", Offset = "0x234FFA0", Length = "0xB")]
		[Token(Token = "0x6000764")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000123")]
	internal DataColumn[] ColumnsReference
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000765")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000121")]
	internal Index ConstraintIndex
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6000756")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000125")]
	internal virtual bool InCollection
	{
		[Address(RVA = "0x2350C40", Offset = "0x2350040", Length = "0x47")]
		[Token(Token = "0x600076A")]
		internal set { } //Length: 71
	}

	[Token(Token = "0x17000124")]
	public bool IsPrimaryKey
	{
		[Address(RVA = "0x2350BB0", Offset = "0x234FFB0", Length = "0x57")]
		[Token(Token = "0x6000766")]
		 get { } //Length: 87
	}

	[Token(Token = "0x17000126")]
	internal DataKey Key
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x600076B")]
		internal get { } //Length: 5
	}

	[ReadOnly(True)]
	[Token(Token = "0x17000127")]
	public virtual DataTable Table
	{
		[Address(RVA = "0x2350C10", Offset = "0x2350010", Length = "0x30")]
		[Token(Token = "0x600076C")]
		 get { } //Length: 48
	}

	[Address(RVA = "0x23509D0", Offset = "0x234FDD0", Length = "0xBD")]
	[Token(Token = "0x6000750")]
	public UniqueConstraint(DataColumn column) { }

	[Address(RVA = "0x2350A90", Offset = "0x234FE90", Length = "0x3F")]
	[Token(Token = "0x6000751")]
	public UniqueConstraint(string name, DataColumn[] columns) { }

	[Address(RVA = "0x2350990", Offset = "0x234FD90", Length = "0x31")]
	[Token(Token = "0x6000752")]
	public UniqueConstraint(DataColumn[] columns) { }

	[Address(RVA = "0x2350B20", Offset = "0x234FF20", Length = "0x61")]
	[Browsable(False)]
	[Token(Token = "0x6000753")]
	public UniqueConstraint(string name, String[] columnNames, bool isPrimaryKey) { }

	[Address(RVA = "0x2350AD0", Offset = "0x234FED0", Length = "0x50")]
	[Token(Token = "0x6000754")]
	public UniqueConstraint(string name, DataColumn[] columns, bool isPrimaryKey) { }

	[Address(RVA = "0x234F6F0", Offset = "0x234EAF0", Length = "0x1B0")]
	[Token(Token = "0x600075C")]
	internal virtual bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	[Address(RVA = "0x234F8B0", Offset = "0x234ECB0", Length = "0x7E")]
	[Token(Token = "0x600075D")]
	internal virtual bool CanEnableConstraint() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600075B")]
	internal virtual void CheckCanAddToCollection(ConstraintCollection constraints) { }

	[Address(RVA = "0x234F930", Offset = "0x234ED30", Length = "0x1D6")]
	[Token(Token = "0x600075F")]
	internal virtual void CheckConstraint(DataRow row, DataRowAction action) { }

	[Address(RVA = "0x234FB10", Offset = "0x234EF10", Length = "0xB")]
	[Token(Token = "0x6000759")]
	internal virtual void CheckState() { }

	[Address(RVA = "0x2342740", Offset = "0x2341B40", Length = "0x17")]
	[Token(Token = "0x6000761")]
	internal virtual Constraint Clone(DataSet destination) { }

	[Address(RVA = "0x234FF50", Offset = "0x234F350", Length = "0x4D1")]
	[Token(Token = "0x6000762")]
	internal virtual Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	[Address(RVA = "0x234FB20", Offset = "0x234EF20", Length = "0x421")]
	[Token(Token = "0x6000763")]
	internal UniqueConstraint Clone(DataTable table) { }

	[Address(RVA = "0x2350430", Offset = "0x234F830", Length = "0x39")]
	[Token(Token = "0x6000757")]
	internal void ConstraintIndexClear() { }

	[Address(RVA = "0x2350470", Offset = "0x234F870", Length = "0x4B")]
	[Token(Token = "0x6000758")]
	internal void ConstraintIndexInitialize() { }

	[Address(RVA = "0x23504C0", Offset = "0x234F8C0", Length = "0xC")]
	[Token(Token = "0x6000760")]
	internal virtual bool ContainsColumn(DataColumn column) { }

	[Address(RVA = "0x23504D0", Offset = "0x234F8D0", Length = "0x105")]
	[Token(Token = "0x6000767")]
	private void Create(string constraintName, DataColumn[] columns) { }

	[Address(RVA = "0x23505E0", Offset = "0x234F9E0", Length = "0xC0")]
	[Token(Token = "0x6000768")]
	public virtual bool Equals(object key2) { }

	[Address(RVA = "0x2350B90", Offset = "0x234FF90", Length = "0xB")]
	[Token(Token = "0x6000755")]
	internal String[] get_ColumnNames() { }

	[Address(RVA = "0x2350BA0", Offset = "0x234FFA0", Length = "0xB")]
	[Token(Token = "0x6000764")]
	public override DataColumn[] get_Columns() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000765")]
	internal DataColumn[] get_ColumnsReference() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6000756")]
	internal Index get_ConstraintIndex() { }

	[Address(RVA = "0x2350BB0", Offset = "0x234FFB0", Length = "0x57")]
	[Token(Token = "0x6000766")]
	public bool get_IsPrimaryKey() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x600076B")]
	internal DataKey get_Key() { }

	[Address(RVA = "0x2350C10", Offset = "0x2350010", Length = "0x30")]
	[Token(Token = "0x600076C")]
	public virtual DataTable get_Table() { }

	[Address(RVA = "0x1E9E150", Offset = "0x1E9D550", Length = "0x7")]
	[Token(Token = "0x6000769")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x23506B0", Offset = "0x234FAB0", Length = "0x2DB")]
	[Token(Token = "0x600075E")]
	internal virtual bool IsConstraintViolated() { }

	[Address(RVA = "0x234FB10", Offset = "0x234EF10", Length = "0xB")]
	[Token(Token = "0x600075A")]
	private void NonVirtualCheckState() { }

	[Address(RVA = "0x2350C40", Offset = "0x2350040", Length = "0x47")]
	[Token(Token = "0x600076A")]
	internal virtual void set_InCollection(bool value) { }

}


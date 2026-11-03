namespace System.Data;

[DefaultProperty("ConstraintName")]
[Token(Token = "0x2000071")]
public class ForeignKeyConstraint : Constraint
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400023E")]
	internal Rule _deleteRule; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400023F")]
	internal Rule _updateRule; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000240")]
	internal AcceptRejectRule _acceptRejectRule; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000241")]
	private DataKey _childKey; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000242")]
	private DataKey _parentKey; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000243")]
	internal string _constraintName; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000244")]
	internal String[] _parentColumnNames; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000245")]
	internal String[] _childColumnNames; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000246")]
	internal string _parentTableName; //Field offset: 0x70

	[DefaultValue(AcceptRejectRule::None (0))]
	[Token(Token = "0x170000F8")]
	public override AcceptRejectRule AcceptRejectRule
	{
		[Address(RVA = "0x2343370", Offset = "0x2342770", Length = "0x19")]
		[Token(Token = "0x600064C")]
		 get { } //Length: 25
		[Address(RVA = "0x23434B0", Offset = "0x23428B0", Length = "0x4D")]
		[Token(Token = "0x600064D")]
		 set { } //Length: 77
	}

	[Token(Token = "0x170000F7")]
	internal String[] ChildColumnNames
	{
		[Address(RVA = "0x2343390", Offset = "0x2342790", Length = "0xB")]
		[Token(Token = "0x600063C")]
		internal get { } //Length: 11
	}

	[Token(Token = "0x170000F3")]
	internal DataKey ChildKey
	{
		[Address(RVA = "0x23433A0", Offset = "0x23427A0", Length = "0x1A")]
		[Token(Token = "0x6000638")]
		internal get { } //Length: 26
	}

	[ReadOnly(True)]
	[Token(Token = "0x170000F4")]
	public override DataColumn[] Columns
	{
		[Address(RVA = "0x23433C0", Offset = "0x23427C0", Length = "0x20")]
		[Token(Token = "0x6000639")]
		 get { } //Length: 32
	}

	[DefaultValue(Rule::Cascade (1))]
	[Token(Token = "0x170000F9")]
	public override Rule DeleteRule
	{
		[Address(RVA = "0x23433E0", Offset = "0x23427E0", Length = "0x19")]
		[Token(Token = "0x6000653")]
		 get { } //Length: 25
		[Address(RVA = "0x2343500", Offset = "0x2342900", Length = "0x4D")]
		[Token(Token = "0x6000654")]
		 set { } //Length: 77
	}

	[Token(Token = "0x170000F6")]
	internal String[] ParentColumnNames
	{
		[Address(RVA = "0x2343400", Offset = "0x2342800", Length = "0xB")]
		[Token(Token = "0x600063B")]
		internal get { } //Length: 11
	}

	[Token(Token = "0x170000FC")]
	internal DataKey ParentKey
	{
		[Address(RVA = "0x2343410", Offset = "0x2342810", Length = "0x1A")]
		[Token(Token = "0x6000659")]
		internal get { } //Length: 26
	}

	[ReadOnly(True)]
	[Token(Token = "0x170000FA")]
	public override DataColumn[] RelatedColumns
	{
		[Address(RVA = "0x2343430", Offset = "0x2342830", Length = "0x20")]
		[Token(Token = "0x6000657")]
		 get { } //Length: 32
	}

	[Token(Token = "0x170000FB")]
	internal DataColumn[] RelatedColumnsReference
	{
		[Address(RVA = "0x2343410", Offset = "0x2342810", Length = "0x1A")]
		[Token(Token = "0x6000658")]
		internal get { } //Length: 26
	}

	[ReadOnly(True)]
	[Token(Token = "0x170000FD")]
	public override DataTable RelatedTable
	{
		[Address(RVA = "0x2343450", Offset = "0x2342850", Length = "0x20")]
		[Token(Token = "0x600065B")]
		 get { } //Length: 32
	}

	[ReadOnly(True)]
	[Token(Token = "0x170000F5")]
	public virtual DataTable Table
	{
		[Address(RVA = "0x2343470", Offset = "0x2342870", Length = "0x20")]
		[Token(Token = "0x600063A")]
		 get { } //Length: 32
	}

	[DefaultValue(Rule::Cascade (1))]
	[Token(Token = "0x170000FE")]
	public override Rule UpdateRule
	{
		[Address(RVA = "0x2343490", Offset = "0x2342890", Length = "0x19")]
		[Token(Token = "0x600065C")]
		 get { } //Length: 25
		[Address(RVA = "0x2343550", Offset = "0x2342950", Length = "0x4D")]
		[Token(Token = "0x600065D")]
		 set { } //Length: 77
	}

	[Address(RVA = "0x23432A0", Offset = "0x23426A0", Length = "0x56")]
	[Token(Token = "0x6000635")]
	public ForeignKeyConstraint(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	[Address(RVA = "0x2343300", Offset = "0x2342700", Length = "0x63")]
	[Token(Token = "0x6000636")]
	public ForeignKeyConstraint(string constraintName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	[Address(RVA = "0x23431F0", Offset = "0x23425F0", Length = "0xA1")]
	[Browsable(False)]
	[Token(Token = "0x6000637")]
	public ForeignKeyConstraint(string constraintName, string parentTableName, String[] parentColumnNames, String[] childColumnNames, AcceptRejectRule acceptRejectRule, Rule deleteRule, Rule updateRule) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600063E")]
	internal virtual bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	[Address(RVA = "0x2340040", Offset = "0x233F440", Length = "0x205")]
	[Token(Token = "0x6000641")]
	internal virtual bool CanEnableConstraint() { }

	[Address(RVA = "0x2340250", Offset = "0x233F650", Length = "0x171")]
	[Token(Token = "0x6000642")]
	internal void CascadeCommit(DataRow row) { }

	[Address(RVA = "0x23403D0", Offset = "0x233F7D0", Length = "0x5A2")]
	[Token(Token = "0x6000643")]
	internal void CascadeDelete(DataRow row) { }

	[Address(RVA = "0x2340980", Offset = "0x233FD80", Length = "0x25F")]
	[Token(Token = "0x6000644")]
	internal void CascadeRollback(DataRow row) { }

	[Address(RVA = "0x2340BE0", Offset = "0x233FFE0", Length = "0x582")]
	[Token(Token = "0x6000645")]
	internal void CascadeUpdate(DataRow row) { }

	[Address(RVA = "0x2341170", Offset = "0x2340570", Length = "0x174")]
	[Token(Token = "0x600063D")]
	internal virtual void CheckCanAddToCollection(ConstraintCollection constraints) { }

	[Address(RVA = "0x23412F0", Offset = "0x23406F0", Length = "0x10E")]
	[Token(Token = "0x6000646")]
	internal void CheckCanClearParentTable(DataTable table) { }

	[Address(RVA = "0x2341400", Offset = "0x2340800", Length = "0xBC")]
	[Token(Token = "0x6000647")]
	internal void CheckCanRemoveParentRow(DataRow row) { }

	[Address(RVA = "0x23414C0", Offset = "0x23408C0", Length = "0x2F4")]
	[Token(Token = "0x6000648")]
	internal void CheckCascade(DataRow row, DataRowAction action) { }

	[Address(RVA = "0x23417C0", Offset = "0x2340BC0", Length = "0x2EB")]
	[Token(Token = "0x6000649")]
	internal virtual void CheckConstraint(DataRow childRow, DataRowAction action) { }

	[Address(RVA = "0x2341AB0", Offset = "0x2340EB0", Length = "0x7")]
	[Token(Token = "0x600064B")]
	internal virtual void CheckState() { }

	[Address(RVA = "0x2341AC0", Offset = "0x2340EC0", Length = "0x6BF")]
	[Token(Token = "0x6000650")]
	internal virtual Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	[Address(RVA = "0x2342180", Offset = "0x2341580", Length = "0x5B5")]
	[Token(Token = "0x6000651")]
	internal ForeignKeyConstraint Clone(DataTable destination) { }

	[Address(RVA = "0x2342740", Offset = "0x2341B40", Length = "0x17")]
	[Token(Token = "0x600064F")]
	internal virtual Constraint Clone(DataSet destination) { }

	[Address(RVA = "0x2342760", Offset = "0x2341B60", Length = "0x46")]
	[Token(Token = "0x600064E")]
	internal virtual bool ContainsColumn(DataColumn column) { }

	[Address(RVA = "0x23427B0", Offset = "0x2341BB0", Length = "0x217")]
	[Token(Token = "0x6000652")]
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	[Address(RVA = "0x23429D0", Offset = "0x2341DD0", Length = "0x116")]
	[Token(Token = "0x6000655")]
	public virtual bool Equals(object key) { }

	[Address(RVA = "0x2342AF0", Offset = "0x2341EF0", Length = "0xE0")]
	[Token(Token = "0x600065A")]
	internal DataRelation FindParentRelation() { }

	[Address(RVA = "0x2343370", Offset = "0x2342770", Length = "0x19")]
	[Token(Token = "0x600064C")]
	public override AcceptRejectRule get_AcceptRejectRule() { }

	[Address(RVA = "0x2343390", Offset = "0x2342790", Length = "0xB")]
	[Token(Token = "0x600063C")]
	internal String[] get_ChildColumnNames() { }

	[Address(RVA = "0x23433A0", Offset = "0x23427A0", Length = "0x1A")]
	[Token(Token = "0x6000638")]
	internal DataKey get_ChildKey() { }

	[Address(RVA = "0x23433C0", Offset = "0x23427C0", Length = "0x20")]
	[Token(Token = "0x6000639")]
	public override DataColumn[] get_Columns() { }

	[Address(RVA = "0x23433E0", Offset = "0x23427E0", Length = "0x19")]
	[Token(Token = "0x6000653")]
	public override Rule get_DeleteRule() { }

	[Address(RVA = "0x2343400", Offset = "0x2342800", Length = "0xB")]
	[Token(Token = "0x600063B")]
	internal String[] get_ParentColumnNames() { }

	[Address(RVA = "0x2343410", Offset = "0x2342810", Length = "0x1A")]
	[Token(Token = "0x6000659")]
	internal DataKey get_ParentKey() { }

	[Address(RVA = "0x2343430", Offset = "0x2342830", Length = "0x20")]
	[Token(Token = "0x6000657")]
	public override DataColumn[] get_RelatedColumns() { }

	[Address(RVA = "0x2343410", Offset = "0x2342810", Length = "0x1A")]
	[Token(Token = "0x6000658")]
	internal DataColumn[] get_RelatedColumnsReference() { }

	[Address(RVA = "0x2343450", Offset = "0x2342850", Length = "0x20")]
	[Token(Token = "0x600065B")]
	public override DataTable get_RelatedTable() { }

	[Address(RVA = "0x2343470", Offset = "0x2342870", Length = "0x20")]
	[Token(Token = "0x600063A")]
	public virtual DataTable get_Table() { }

	[Address(RVA = "0x2343490", Offset = "0x2342890", Length = "0x19")]
	[Token(Token = "0x600065C")]
	public override Rule get_UpdateRule() { }

	[Address(RVA = "0x1E9E150", Offset = "0x1E9D550", Length = "0x7")]
	[Token(Token = "0x6000656")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2342BE0", Offset = "0x2341FE0", Length = "0x29B")]
	[Token(Token = "0x6000640")]
	internal virtual bool IsConstraintViolated() { }

	[Address(RVA = "0x2342E80", Offset = "0x2342280", Length = "0xA0")]
	[Token(Token = "0x600063F")]
	internal bool IsKeyNull(Object[] values) { }

	[Address(RVA = "0x2342F30", Offset = "0x2342330", Length = "0x2B7")]
	[Token(Token = "0x600064A")]
	private void NonVirtualCheckState() { }

	[Address(RVA = "0x23434B0", Offset = "0x23428B0", Length = "0x4D")]
	[Token(Token = "0x600064D")]
	public override void set_AcceptRejectRule(AcceptRejectRule value) { }

	[Address(RVA = "0x2343500", Offset = "0x2342900", Length = "0x4D")]
	[Token(Token = "0x6000654")]
	public override void set_DeleteRule(Rule value) { }

	[Address(RVA = "0x2343550", Offset = "0x2342950", Length = "0x4D")]
	[Token(Token = "0x600065D")]
	public override void set_UpdateRule(Rule value) { }

}


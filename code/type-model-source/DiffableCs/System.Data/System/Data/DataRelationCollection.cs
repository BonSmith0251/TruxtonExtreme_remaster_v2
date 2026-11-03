namespace System.Data;

[DefaultEvent("CollectionChanged")]
[DefaultMember("Item")]
[DefaultProperty("Table")]
[Token(Token = "0x2000037")]
public abstract class DataRelationCollection : InternalDataCollectionBase
{
	[DefaultMember("Item")]
	[Token(Token = "0x2000039")]
	public sealed class DataSetRelationCollection : DataRelationCollection
	{
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000130")]
		private readonly DataSet _dataSet; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000131")]
		private readonly ArrayList _relations; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000132")]
		private DataRelation[] _delayLoadingRelations; //Field offset: 0x48

		[Token(Token = "0x170000AB")]
		public virtual DataRelation Item
		{
			[Address(RVA = "0x2324F10", Offset = "0x2324310", Length = "0x102")]
			[Token(Token = "0x600041E")]
			 get { } //Length: 258
		}

		[Token(Token = "0x170000AC")]
		public virtual DataRelation Item
		{
			[Address(RVA = "0x2324E10", Offset = "0x2324210", Length = "0xF9")]
			[Token(Token = "0x600041F")]
			 get { } //Length: 249
		}

		[Token(Token = "0x170000AA")]
		protected virtual ArrayList List
		{
			[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
			[Token(Token = "0x600041B")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x2324D70", Offset = "0x2324170", Length = "0x9F")]
		[Token(Token = "0x600041A")]
		internal DataSetRelationCollection(DataSet dataSet) { }

		[Address(RVA = "0x2324340", Offset = "0x2323740", Length = "0x67E")]
		[Token(Token = "0x6000420")]
		protected virtual void AddCore(DataRelation relation) { }

		[Address(RVA = "0x23249C0", Offset = "0x2323DC0", Length = "0x49")]
		[Token(Token = "0x600041C")]
		public virtual void Clear() { }

		[Address(RVA = "0x2324F10", Offset = "0x2324310", Length = "0x102")]
		[Token(Token = "0x600041E")]
		public virtual DataRelation get_Item(int index) { }

		[Address(RVA = "0x2324E10", Offset = "0x2324210", Length = "0xF9")]
		[Token(Token = "0x600041F")]
		public virtual DataRelation get_Item(string name) { }

		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x600041B")]
		protected virtual ArrayList get_List() { }

		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x600041D")]
		protected virtual DataSet GetDataSet() { }

		[Address(RVA = "0x2324A10", Offset = "0x2323E10", Length = "0x35E")]
		[Token(Token = "0x6000421")]
		protected virtual void RemoveCore(DataRelation relation) { }

	}

	[DefaultMember("Item")]
	[Token(Token = "0x2000038")]
	public sealed class DataTableRelationCollection : DataRelationCollection
	{
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400012C")]
		private readonly DataTable _table; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400012D")]
		private readonly ArrayList _relations; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400012E")]
		private readonly bool _fParentCollection; //Field offset: 0x48
		[CompilerGenerated]
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400012F")]
		private CollectionChangeEventHandler RelationPropertyChanged; //Field offset: 0x50

		[Token(Token = "0x14000004")]
		internal event CollectionChangeEventHandler RelationPropertyChanged
		{
			[Address(RVA = "0x23281A0", Offset = "0x23275A0", Length = "0x9E")]
			[CompilerGenerated]
			[Token(Token = "0x6000414")]
			internal add { } //Length: 158
			[Address(RVA = "0x2328450", Offset = "0x2327850", Length = "0x9E")]
			[CompilerGenerated]
			[Token(Token = "0x6000415")]
			internal remove { } //Length: 158
		}

		[Token(Token = "0x170000A8")]
		public virtual DataRelation Item
		{
			[Address(RVA = "0x2328340", Offset = "0x2327740", Length = "0x102")]
			[Token(Token = "0x6000412")]
			 get { } //Length: 258
		}

		[Token(Token = "0x170000A9")]
		public virtual DataRelation Item
		{
			[Address(RVA = "0x2328240", Offset = "0x2327640", Length = "0xF9")]
			[Token(Token = "0x6000413")]
			 get { } //Length: 249
		}

		[Token(Token = "0x170000A7")]
		protected virtual ArrayList List
		{
			[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
			[Token(Token = "0x600040F")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x23280E0", Offset = "0x23274E0", Length = "0xB1")]
		[Token(Token = "0x600040E")]
		internal DataTableRelationCollection(DataTable table, bool fParentCollection) { }

		[Address(RVA = "0x23281A0", Offset = "0x23275A0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000414")]
		internal void add_RelationPropertyChanged(CollectionChangeEventHandler value) { }

		[Address(RVA = "0x2327C20", Offset = "0x2327020", Length = "0x4B")]
		[Token(Token = "0x6000416")]
		private void AddCache(DataRelation relation) { }

		[Address(RVA = "0x2327C70", Offset = "0x2327070", Length = "0x113")]
		[Token(Token = "0x6000417")]
		protected virtual void AddCore(DataRelation relation) { }

		[Address(RVA = "0x2327D90", Offset = "0x2327190", Length = "0x49")]
		[Token(Token = "0x6000410")]
		private void EnsureDataSet() { }

		[Address(RVA = "0x2328340", Offset = "0x2327740", Length = "0x102")]
		[Token(Token = "0x6000412")]
		public virtual DataRelation get_Item(int index) { }

		[Address(RVA = "0x2328240", Offset = "0x2327640", Length = "0xF9")]
		[Token(Token = "0x6000413")]
		public virtual DataRelation get_Item(string name) { }

		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x600040F")]
		protected virtual ArrayList get_List() { }

		[Address(RVA = "0x2327DE0", Offset = "0x23271E0", Length = "0x4E")]
		[Token(Token = "0x6000411")]
		protected virtual DataSet GetDataSet() { }

		[Address(RVA = "0x2328450", Offset = "0x2327850", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000415")]
		internal void remove_RelationPropertyChanged(CollectionChangeEventHandler value) { }

		[Address(RVA = "0x2327E30", Offset = "0x2327230", Length = "0xE9")]
		[Token(Token = "0x6000418")]
		private void RemoveCache(DataRelation relation) { }

		[Address(RVA = "0x2327F20", Offset = "0x2327320", Length = "0x1BA")]
		[Token(Token = "0x6000419")]
		protected virtual void RemoveCore(DataRelation relation) { }

	}

	[Token(Token = "0x400012A")]
	private static int s_objectTypeCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000126")]
	private DataRelation _inTransition; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000127")]
	private int _defaultNameIndex; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000128")]
	private CollectionChangeEventHandler _onCollectionChangedDelegate; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000129")]
	private CollectionChangeEventHandler _onCollectionChangingDelegate; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400012B")]
	private readonly int _objectID; //Field offset: 0x30

	[Token(Token = "0x14000003")]
	public event CollectionChangeEventHandler CollectionChanged
	{
		[Address(RVA = "0x231B1E0", Offset = "0x231A5E0", Length = "0x10E")]
		[Token(Token = "0x60003FE")]
		 add { } //Length: 270
		[Address(RVA = "0x231B2F0", Offset = "0x231A6F0", Length = "0x10E")]
		[Token(Token = "0x60003FF")]
		 remove { } //Length: 270
	}

	[Token(Token = "0x170000A5")]
	public abstract DataRelation Item
	{
		[Token(Token = "0x60003FA")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000A6")]
	public abstract DataRelation Item
	{
		[Token(Token = "0x60003FB")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000A4")]
	internal int ObjectID
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x60003F9")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x231B160", Offset = "0x231A560", Length = "0x74")]
	[Token(Token = "0x600040D")]
	protected DataRelationCollection() { }

	[Address(RVA = "0x231A090", Offset = "0x2319490", Length = "0x2A4")]
	[Token(Token = "0x60003FC")]
	public void Add(DataRelation relation) { }

	[Address(RVA = "0x231B1E0", Offset = "0x231A5E0", Length = "0x10E")]
	[Token(Token = "0x60003FE")]
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	[Address(RVA = "0x2319D70", Offset = "0x2319170", Length = "0x314")]
	[Token(Token = "0x60003FD")]
	protected override void AddCore(DataRelation relation) { }

	[Address(RVA = "0x231A340", Offset = "0x2319740", Length = "0x1D")]
	[Token(Token = "0x6000400")]
	internal string AssignName() { }

	[Address(RVA = "0x231A360", Offset = "0x2319760", Length = "0x226")]
	[Token(Token = "0x6000401")]
	public override void Clear() { }

	[Address(RVA = "0x231A590", Offset = "0x2319990", Length = "0x16")]
	[Token(Token = "0x6000402")]
	public override bool Contains(string name) { }

	[Token(Token = "0x60003FA")]
	public abstract DataRelation get_Item(int index) { }

	[Token(Token = "0x60003FB")]
	public abstract DataRelation get_Item(string name) { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x60003F9")]
	internal int get_ObjectID() { }

	[Token(Token = "0x6000404")]
	protected abstract DataSet GetDataSet() { }

	[Address(RVA = "0x231A5B0", Offset = "0x23199B0", Length = "0x20C")]
	[Token(Token = "0x6000403")]
	internal int InternalIndexOf(string name) { }

	[Address(RVA = "0x231A7C0", Offset = "0x2319BC0", Length = "0x94")]
	[Token(Token = "0x6000405")]
	private string MakeName(int index) { }

	[Address(RVA = "0x231A860", Offset = "0x2319C60", Length = "0xBD")]
	[Token(Token = "0x6000406")]
	protected override void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	[Address(RVA = "0x231A920", Offset = "0x2319D20", Length = "0xBD")]
	[Token(Token = "0x6000407")]
	protected override void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	[Address(RVA = "0x231A9E0", Offset = "0x2319DE0", Length = "0x1DD")]
	[Token(Token = "0x6000408")]
	internal void RegisterName(string name) { }

	[Address(RVA = "0x231AE40", Offset = "0x231A240", Length = "0x1DE")]
	[Token(Token = "0x6000409")]
	public void Remove(DataRelation relation) { }

	[Address(RVA = "0x231B2F0", Offset = "0x231A6F0", Length = "0x10E")]
	[Token(Token = "0x60003FF")]
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	[Address(RVA = "0x231ABC0", Offset = "0x2319FC0", Length = "0x78")]
	[Token(Token = "0x600040A")]
	public void RemoveAt(int index) { }

	[Address(RVA = "0x231AC40", Offset = "0x231A040", Length = "0x1F0")]
	[Token(Token = "0x600040B")]
	protected override void RemoveCore(DataRelation relation) { }

	[Address(RVA = "0x231B020", Offset = "0x231A420", Length = "0x13B")]
	[Token(Token = "0x600040C")]
	internal void UnregisterName(string name) { }

}


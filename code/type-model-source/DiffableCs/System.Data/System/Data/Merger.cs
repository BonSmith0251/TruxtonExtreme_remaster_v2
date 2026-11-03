namespace System.Data;

[Token(Token = "0x2000075")]
internal sealed class Merger
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400024E")]
	private DataSet _dataSet; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400024F")]
	private DataTable _dataTable; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000250")]
	private bool _preserveChanges; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000251")]
	private MissingSchemaAction _missingSchemaAction; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000252")]
	private bool _isStandAlonetable; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4000253")]
	private bool _IgnoreNSforTableLookup; //Field offset: 0x29

	[Address(RVA = "0x234A210", Offset = "0x2349610", Length = "0x5F")]
	[Token(Token = "0x6000662")]
	internal Merger(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	[Address(RVA = "0x234A1A0", Offset = "0x23495A0", Length = "0x63")]
	[Token(Token = "0x6000663")]
	internal Merger(DataTable dataTable, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	[Address(RVA = "0x23474C0", Offset = "0x23468C0", Length = "0x19B")]
	[Token(Token = "0x600066D")]
	private DataKey GetSrcKey(DataTable src, DataTable dst) { }

	[Address(RVA = "0x2347660", Offset = "0x2346A60", Length = "0x84")]
	[Token(Token = "0x6000669")]
	private void MergeConstraints(DataSet source) { }

	[Address(RVA = "0x23476F0", Offset = "0x2346AF0", Length = "0x2CA")]
	[Token(Token = "0x600066A")]
	private void MergeConstraints(DataTable table) { }

	[Address(RVA = "0x23479C0", Offset = "0x2346DC0", Length = "0xC4E")]
	[Token(Token = "0x6000664")]
	internal void MergeDataSet(DataSet source) { }

	[Address(RVA = "0x2348610", Offset = "0x2347A10", Length = "0x1B9")]
	[Token(Token = "0x600066C")]
	private void MergeExtendedProperties(PropertyCollection src, PropertyCollection dst) { }

	[Address(RVA = "0x23487D0", Offset = "0x2347BD0", Length = "0x849")]
	[Token(Token = "0x600066B")]
	private void MergeRelation(DataRelation relation) { }

	[Address(RVA = "0x2349020", Offset = "0x2348420", Length = "0x8AB")]
	[Token(Token = "0x6000667")]
	private DataTable MergeSchema(DataTable table) { }

	[Address(RVA = "0x2349980", Offset = "0x2348D80", Length = "0x26F")]
	[Token(Token = "0x6000665")]
	internal void MergeTable(DataTable src) { }

	[Address(RVA = "0x2349BF0", Offset = "0x2348FF0", Length = "0x5A0")]
	[Token(Token = "0x6000666")]
	private void MergeTable(DataTable src, DataTable dst) { }

	[Address(RVA = "0x23498D0", Offset = "0x2348CD0", Length = "0xA2")]
	[Token(Token = "0x6000668")]
	private void MergeTableData(DataTable src) { }

}


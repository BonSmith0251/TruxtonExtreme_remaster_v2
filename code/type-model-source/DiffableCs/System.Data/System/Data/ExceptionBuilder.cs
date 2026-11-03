namespace System.Data;

[Token(Token = "0x2000017")]
internal static class ExceptionBuilder
{

	[Address(RVA = "0x230A470", Offset = "0x2309870", Length = "0x5A")]
	[Token(Token = "0x60000C5")]
	internal static Exception _Argument(string error) { }

	[Address(RVA = "0x230A400", Offset = "0x2309800", Length = "0x6A")]
	[Token(Token = "0x60000C6")]
	internal static Exception _Argument(string error, Exception innerException) { }

	[Address(RVA = "0x230A320", Offset = "0x2309720", Length = "0x6A")]
	[Token(Token = "0x60000C7")]
	private static Exception _ArgumentNull(string paramName, string msg) { }

	[Address(RVA = "0x230A390", Offset = "0x2309790", Length = "0x6A")]
	[Token(Token = "0x60000C8")]
	internal static Exception _ArgumentOutOfRange(string paramName, string msg) { }

	[Address(RVA = "0x230A4D0", Offset = "0x23098D0", Length = "0x61")]
	[Token(Token = "0x60000CF")]
	private static Exception _Constraint(string error) { }

	[Address(RVA = "0x2306050", Offset = "0x2305450", Length = "0x61")]
	[Token(Token = "0x60000CE")]
	private static Exception _Data(string error) { }

	[Address(RVA = "0x230A540", Offset = "0x2309940", Length = "0x61")]
	[Token(Token = "0x60000D1")]
	private static Exception _DeletedRowInaccessible(string error) { }

	[Address(RVA = "0x230A5B0", Offset = "0x23099B0", Length = "0x61")]
	[Token(Token = "0x60000D2")]
	private static Exception _DuplicateName(string error) { }

	[Address(RVA = "0x230A690", Offset = "0x2309A90", Length = "0x5A")]
	[Token(Token = "0x60000C9")]
	private static Exception _IndexOutOfRange(string error) { }

	[Address(RVA = "0x230A620", Offset = "0x2309A20", Length = "0x61")]
	[Token(Token = "0x60000D3")]
	private static Exception _InRowChangingEvent(string error) { }

	[Address(RVA = "0x230A6F0", Offset = "0x2309AF0", Length = "0x61")]
	[Token(Token = "0x60000D0")]
	private static Exception _InvalidConstraint(string error) { }

	[Address(RVA = "0x230A760", Offset = "0x2309B60", Length = "0x5A")]
	[Token(Token = "0x60000CB")]
	private static Exception _InvalidEnumArgumentException(string error) { }

	[Address(RVA = "0x7EA4E0", Offset = "0x7E98E0", Length = "0xEA")]
	[Token(Token = "0x60000CC")]
	private static Exception _InvalidEnumArgumentException(T value) { }

	[Address(RVA = "0x230A7C0", Offset = "0x2309BC0", Length = "0x5A")]
	[Token(Token = "0x60000CA")]
	private static Exception _InvalidOperation(string error) { }

	[Address(RVA = "0x230A820", Offset = "0x2309C20", Length = "0x61")]
	[Token(Token = "0x60000D4")]
	private static Exception _NoNullAllowed(string error) { }

	[Address(RVA = "0x230A890", Offset = "0x2309C90", Length = "0x61")]
	[Token(Token = "0x60000D5")]
	private static Exception _ReadOnly(string error) { }

	[Address(RVA = "0x230A900", Offset = "0x2309D00", Length = "0x61")]
	[Token(Token = "0x60000D6")]
	private static Exception _RowNotInTable(string error) { }

	[Address(RVA = "0x230A970", Offset = "0x2309D70", Length = "0x61")]
	[Token(Token = "0x60000D7")]
	private static Exception _VersionNotFound(string error) { }

	[Address(RVA = "0x2300110", Offset = "0x22FF510", Length = "0x7A")]
	[Token(Token = "0x6000134")]
	public static Exception AddExternalObject() { }

	[Address(RVA = "0x2300190", Offset = "0x22FF590", Length = "0x81")]
	[Token(Token = "0x600012F")]
	public static Exception AddNewNotAllowNull() { }

	[Address(RVA = "0x2300220", Offset = "0x22FF620", Length = "0x7A")]
	[Token(Token = "0x60000EF")]
	public static Exception AddPrimaryKeyConstraint() { }

	[Address(RVA = "0x23002A0", Offset = "0x22FF6A0", Length = "0xF1")]
	[Token(Token = "0x6000192")]
	public static Exception AggregateException(AggregateType aggregateType, Type type) { }

	[Address(RVA = "0x23003A0", Offset = "0x22FF7A0", Length = "0xD6")]
	[Token(Token = "0x60000D8")]
	public static Exception ArgumentNull(string paramName) { }

	[Address(RVA = "0x2300480", Offset = "0x22FF880", Length = "0xD6")]
	[Token(Token = "0x60000D9")]
	public static Exception ArgumentOutOfRange(string paramName) { }

	[Address(RVA = "0x2300560", Offset = "0x22FF960", Length = "0xAE")]
	[Token(Token = "0x600019D")]
	public static Exception AttributeValues(string name, string value1, string value2) { }

	[Address(RVA = "0x2300610", Offset = "0x22FFA10", Length = "0x7A")]
	[Token(Token = "0x6000107")]
	public static Exception AutoIncrementAndDefaultValue() { }

	[Address(RVA = "0x2300690", Offset = "0x22FFA90", Length = "0x7A")]
	[Token(Token = "0x6000106")]
	public static Exception AutoIncrementAndExpression() { }

	[Address(RVA = "0x2300710", Offset = "0x22FFB10", Length = "0xC9")]
	[Token(Token = "0x6000123")]
	public static Exception AutoIncrementCannotSetIfHasData(string typeName) { }

	[Address(RVA = "0x23007E0", Offset = "0x22FFBE0", Length = "0x7A")]
	[Token(Token = "0x6000108")]
	public static Exception AutoIncrementSeed() { }

	[Address(RVA = "0x2300860", Offset = "0x22FFC60", Length = "0xC9")]
	[Token(Token = "0x60000DA")]
	public static Exception BadObjectPropertyAccess(string error) { }

	[Address(RVA = "0x2300930", Offset = "0x22FFD30", Length = "0x81")]
	[Token(Token = "0x6000151")]
	public static Exception BeginEditInRowChanging() { }

	[Address(RVA = "0x2300DE0", Offset = "0x23001E0", Length = "0x81")]
	[Token(Token = "0x6000152")]
	public static Exception CancelEditInRowChanging() { }

	[Address(RVA = "0x2300E70", Offset = "0x2300270", Length = "0xC9")]
	[Token(Token = "0x60000E3")]
	public static Exception CannotAddColumn1(string column) { }

	[Address(RVA = "0x2300F40", Offset = "0x2300340", Length = "0xC9")]
	[Token(Token = "0x60000E4")]
	public static Exception CannotAddColumn2(string column) { }

	[Address(RVA = "0x2301010", Offset = "0x2300410", Length = "0x7A")]
	[Token(Token = "0x60000E5")]
	public static Exception CannotAddColumn3() { }

	[Address(RVA = "0x2301090", Offset = "0x2300490", Length = "0xC9")]
	[Token(Token = "0x60000E6")]
	public static Exception CannotAddColumn4(string column) { }

	[Address(RVA = "0x2301300", Offset = "0x2300700", Length = "0xD0")]
	[Token(Token = "0x60000E7")]
	public static Exception CannotAddDuplicate(string column) { }

	[Address(RVA = "0x2301160", Offset = "0x2300560", Length = "0xD0")]
	[Token(Token = "0x60000E8")]
	public static Exception CannotAddDuplicate2(string table) { }

	[Address(RVA = "0x2301230", Offset = "0x2300630", Length = "0xD0")]
	[Token(Token = "0x60000E9")]
	public static Exception CannotAddDuplicate3(string table) { }

	[Address(RVA = "0x23013E0", Offset = "0x23007E0", Length = "0x8A")]
	[Token(Token = "0x600017C")]
	public static Exception CannotChangeCaseLocale(Exception innerException) { }

	[Address(RVA = "0x23013D0", Offset = "0x23007D0", Length = "0x9")]
	[Token(Token = "0x600017B")]
	public static Exception CannotChangeCaseLocale() { }

	[Address(RVA = "0x2301470", Offset = "0x2300870", Length = "0xC9")]
	[Token(Token = "0x6000121")]
	public static Exception CannotChangeNamespace(string columnName) { }

	[Address(RVA = "0x23009C0", Offset = "0x22FFDC0", Length = "0x7A")]
	[Token(Token = "0x6000135")]
	public static Exception CanNotClear() { }

	[Address(RVA = "0x2301540", Offset = "0x2300940", Length = "0x98")]
	[Token(Token = "0x60001AF")]
	public static Exception CannotConvert(string name, string type) { }

	[Address(RVA = "0x2300A40", Offset = "0x22FFE40", Length = "0x81")]
	[Token(Token = "0x6000132")]
	public static Exception CanNotDelete() { }

	[Address(RVA = "0x2300AD0", Offset = "0x22FFED0", Length = "0x7A")]
	[Token(Token = "0x60001B2")]
	public static Exception CanNotDeserializeObjectType() { }

	[Address(RVA = "0x23015E0", Offset = "0x23009E0", Length = "0xD0")]
	[Token(Token = "0x60001A9")]
	public static Exception CannotInstantiateAbstract(string name) { }

	[Address(RVA = "0x2300B50", Offset = "0x22FFF50", Length = "0x7A")]
	[Token(Token = "0x600018E")]
	public static Exception CanNotRemoteDataTable() { }

	[Address(RVA = "0x23016B0", Offset = "0x2300AB0", Length = "0xC9")]
	[Token(Token = "0x60000EC")]
	public static Exception CannotRemoveChildKey(string relation) { }

	[Address(RVA = "0x2301780", Offset = "0x2300B80", Length = "0x7A")]
	[Token(Token = "0x60000EA")]
	public static Exception CannotRemoveColumn() { }

	[Address(RVA = "0x2301800", Offset = "0x2300C00", Length = "0x91")]
	[Token(Token = "0x60000ED")]
	public static Exception CannotRemoveConstraint(string constraint, string table) { }

	[Address(RVA = "0x23018A0", Offset = "0x2300CA0", Length = "0x91")]
	[Token(Token = "0x60000EE")]
	public static Exception CannotRemoveExpression(string column, string expression) { }

	[Address(RVA = "0x2301940", Offset = "0x2300D40", Length = "0x7A")]
	[Token(Token = "0x60000EB")]
	public static Exception CannotRemovePrimaryKey() { }

	[Address(RVA = "0x2300BD0", Offset = "0x22FFFD0", Length = "0x7A")]
	[Token(Token = "0x600018D")]
	public static Exception CanNotSerializeDataTableHierarchy() { }

	[Address(RVA = "0x2300C50", Offset = "0x2300050", Length = "0x7A")]
	[Token(Token = "0x6000190")]
	public static Exception CanNotSerializeDataTableWithEmptyName() { }

	[Address(RVA = "0x23019C0", Offset = "0x2300DC0", Length = "0x7A")]
	[Token(Token = "0x6000128")]
	public static Exception CannotSetDateTimeModeForNonDateTimeColumns() { }

	[Address(RVA = "0x2301B20", Offset = "0x2300F20", Length = "0xDD")]
	[Token(Token = "0x600011D")]
	public static Exception CannotSetMaxLength(DataColumn column, int value) { }

	[Address(RVA = "0x2301A40", Offset = "0x2300E40", Length = "0xDC")]
	[Token(Token = "0x600011E")]
	public static Exception CannotSetMaxLength2(DataColumn column) { }

	[Address(RVA = "0x2300CD0", Offset = "0x23000D0", Length = "0x7A")]
	[Token(Token = "0x600018F")]
	public static Exception CanNotSetRemotingFormat() { }

	[Address(RVA = "0x2301CA0", Offset = "0x23010A0", Length = "0x91")]
	[Token(Token = "0x6000120")]
	public static Exception CannotSetSimpleContent(string columnName, Type type) { }

	[Address(RVA = "0x2301C00", Offset = "0x2301000", Length = "0x91")]
	[Token(Token = "0x600011F")]
	public static Exception CannotSetSimpleContentType(string columnName, Type type) { }

	[Address(RVA = "0x2301D40", Offset = "0x2301140", Length = "0xDC")]
	[Token(Token = "0x600011B")]
	public static Exception CannotSetToNull(DataColumn column) { }

	[Address(RVA = "0x2300D50", Offset = "0x2300150", Length = "0x81")]
	[Token(Token = "0x600012D")]
	public static Exception CanNotUse() { }

	[Address(RVA = "0x2301E20", Offset = "0x2301220", Length = "0xC9")]
	[Token(Token = "0x6000105")]
	public static Exception CantAddConstraintToMultipleNestedTable(string tableName) { }

	[Address(RVA = "0x2301EF0", Offset = "0x23012F0", Length = "0x7A")]
	[Token(Token = "0x6000109")]
	public static Exception CantChangeDataType() { }

	[Address(RVA = "0x2301F70", Offset = "0x2301370", Length = "0xE9")]
	[Token(Token = "0x600012A")]
	public static Exception CantChangeDateTimeMode(DataSetDateTime oldValue, DataSetDateTime newValue) { }

	[Address(RVA = "0x2302060", Offset = "0x2301460", Length = "0xC9")]
	[Token(Token = "0x60000DC")]
	public static Exception CaseInsensitiveNameConflict(string name) { }

	[Address(RVA = "0x2302130", Offset = "0x2301530", Length = "0x7A")]
	[Token(Token = "0x600017A")]
	public static Exception CaseLocaleMismatch() { }

	[Address(RVA = "0x23021B0", Offset = "0x23015B0", Length = "0x7A")]
	[Token(Token = "0x6000178")]
	public static Exception ChildTableMismatch() { }

	[Address(RVA = "0x2302230", Offset = "0x2301630", Length = "0xD0")]
	[Token(Token = "0x60001A8")]
	public static Exception CircularComplexType(string name) { }

	[Address(RVA = "0x2302300", Offset = "0x2301700", Length = "0x7A")]
	[Token(Token = "0x600010B")]
	public static Exception ColumnNameRequired() { }

	[Address(RVA = "0x2302380", Offset = "0x2301780", Length = "0x7A")]
	[Token(Token = "0x60000E0")]
	public static Exception ColumnNotInAnyTable() { }

	[Address(RVA = "0x2302400", Offset = "0x2301800", Length = "0x91")]
	[Token(Token = "0x60000DF")]
	public static Exception ColumnNotInTheTable(string column, string table) { }

	[Address(RVA = "0x23025B0", Offset = "0x23019B0", Length = "0xC9")]
	[Token(Token = "0x60000E2")]
	public static Exception ColumnOutOfRange(string column) { }

	[Address(RVA = "0x23024A0", Offset = "0x23018A0", Length = "0x106")]
	[Token(Token = "0x60000E1")]
	public static Exception ColumnOutOfRange(int index) { }

	[Address(RVA = "0x23027B0", Offset = "0x2301BB0", Length = "0x81")]
	[Token(Token = "0x600013D")]
	public static Exception ColumnsTypeMismatch() { }

	[Address(RVA = "0x2302680", Offset = "0x2301A80", Length = "0xD0")]
	[Token(Token = "0x60001AE")]
	public static Exception ColumnTypeConflict(string name) { }

	[Address(RVA = "0x2302750", Offset = "0x2301B50", Length = "0x53")]
	[Token(Token = "0x600012B")]
	public static Exception ColumnTypeNotSupported() { }

	[Address(RVA = "0x2302840", Offset = "0x2301C40", Length = "0xE6")]
	[Token(Token = "0x60000FC")]
	public static Exception ConstraintAddFailed(DataTable table) { }

	[Address(RVA = "0x2302930", Offset = "0x2301D30", Length = "0x7A")]
	[Token(Token = "0x60000FA")]
	public static Exception ConstraintForeignTable() { }

	[Address(RVA = "0x23029B0", Offset = "0x2301DB0", Length = "0x106")]
	[Token(Token = "0x60000F5")]
	public static Exception ConstraintOutOfRange(int index) { }

	[Address(RVA = "0x2302AC0", Offset = "0x2301EC0", Length = "0x7A")]
	[Token(Token = "0x60000FB")]
	public static Exception ConstraintParentValues() { }

	[Address(RVA = "0x2302B40", Offset = "0x2301F40", Length = "0x7A")]
	[Token(Token = "0x60000FD")]
	public static Exception ConstraintRemoveFailed() { }

	[Address(RVA = "0x2302BC0", Offset = "0x2301FC0", Length = "0x69")]
	[Token(Token = "0x60000F4")]
	public static Exception ConstraintViolation(DataColumn[] columns, Object[] values) { }

	[Address(RVA = "0x2302C30", Offset = "0x2302030", Length = "0xD0")]
	[Token(Token = "0x60000F1")]
	public static Exception ConstraintViolation(string constraint) { }

	[Address(RVA = "0x2302D00", Offset = "0x2302100", Length = "0xDF")]
	[Token(Token = "0x60001BD")]
	public static Exception ConvertFailed(Type type1, Type type2) { }

	[Address(RVA = "0x2302DE0", Offset = "0x23021E0", Length = "0x7A")]
	[Token(Token = "0x6000131")]
	public static Exception CreateChildView() { }

	[Address(RVA = "0x2302FB0", Offset = "0x23023B0", Length = "0xD0")]
	[Token(Token = "0x6000186")]
	public static Exception DatasetConflictingName(string table) { }

	[Address(RVA = "0x2302E60", Offset = "0x2302260", Length = "0xC9")]
	[Token(Token = "0x6000166")]
	public static Exception DataSetUnsupportedSchema(string ns) { }

	[Address(RVA = "0x2302F30", Offset = "0x2302330", Length = "0x7A")]
	[Token(Token = "0x60001B8")]
	public static Exception DataTableInferenceNotSupported() { }

	[Address(RVA = "0x2303080", Offset = "0x2302480", Length = "0x81")]
	[Token(Token = "0x60001A4")]
	public static Exception DatatypeNotDefined() { }

	[Address(RVA = "0x2303110", Offset = "0x2302510", Length = "0x7A")]
	[Token(Token = "0x600010C")]
	public static Exception DefaultValueAndAutoIncrement() { }

	[Address(RVA = "0x2303190", Offset = "0x2302590", Length = "0xFE")]
	[Token(Token = "0x600010E")]
	public static Exception DefaultValueColumnDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	[Address(RVA = "0x2303290", Offset = "0x2302690", Length = "0x116")]
	[Token(Token = "0x600010D")]
	public static Exception DefaultValueDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	[Address(RVA = "0x2303440", Offset = "0x2302840", Length = "0x81")]
	[Token(Token = "0x6000159")]
	public static Exception DeletedRowInaccessible() { }

	[Address(RVA = "0x23033B0", Offset = "0x23027B0", Length = "0x81")]
	[Token(Token = "0x6000153")]
	public static Exception DeleteInRowDeleting() { }

	[Address(RVA = "0x23034D0", Offset = "0x23028D0", Length = "0x81")]
	[Token(Token = "0x60001AC")]
	public static Exception DiffgramMissingSQL() { }

	[Address(RVA = "0x2303560", Offset = "0x2302960", Length = "0xD0")]
	[Token(Token = "0x60001AB")]
	public static Exception DiffgramMissingTable(string name) { }

	[Address(RVA = "0x23037D0", Offset = "0x2302BD0", Length = "0xD0")]
	[Token(Token = "0x60000F6")]
	public static Exception DuplicateConstraint(string constraint) { }

	[Address(RVA = "0x2303630", Offset = "0x2302A30", Length = "0xD0")]
	[Token(Token = "0x60000F7")]
	public static Exception DuplicateConstraintName(string constraint) { }

	[Address(RVA = "0x2303700", Offset = "0x2302B00", Length = "0xD0")]
	[Token(Token = "0x60001AD")]
	public static Exception DuplicateConstraintRead(string str) { }

	[Address(RVA = "0x23038A0", Offset = "0x2302CA0", Length = "0xD0")]
	[Token(Token = "0x60001BA")]
	public static Exception DuplicateDeclaration(string name) { }

	[Address(RVA = "0x2303970", Offset = "0x2302D70", Length = "0xD0")]
	[Token(Token = "0x6000173")]
	public static Exception DuplicateRelation(string relation) { }

	[Address(RVA = "0x2303AE0", Offset = "0x2302EE0", Length = "0xD0")]
	[Token(Token = "0x6000183")]
	public static Exception DuplicateTableName(string table) { }

	[Address(RVA = "0x2303A40", Offset = "0x2302E40", Length = "0x98")]
	[Token(Token = "0x6000184")]
	public static Exception DuplicateTableName2(string table, string ns) { }

	[Address(RVA = "0x2303BB0", Offset = "0x2302FB0", Length = "0x81")]
	[Token(Token = "0x600014F")]
	public static Exception EditInRowChanging() { }

	[Address(RVA = "0x2303C40", Offset = "0x2303040", Length = "0xD0")]
	[Token(Token = "0x600019E")]
	public static Exception ElementTypeNotFound(string name) { }

	[Address(RVA = "0x2303D10", Offset = "0x2303110", Length = "0x81")]
	[Token(Token = "0x6000150")]
	public static Exception EndEditInRowChanging() { }

	[Address(RVA = "0x2303DA0", Offset = "0x23031A0", Length = "0x81")]
	[Token(Token = "0x6000179")]
	public static Exception EnforceConstraint() { }

	[Address(RVA = "0x2303E30", Offset = "0x2303230", Length = "0x7A")]
	[Token(Token = "0x60001C0")]
	public static Exception EnumeratorModified() { }

	[Address(RVA = "0x2303EB0", Offset = "0x23032B0", Length = "0xBE")]
	[Token(Token = "0x6000111")]
	public static Exception ExpressionAndConstraint(DataColumn column, Constraint constraint) { }

	[Address(RVA = "0x2303F70", Offset = "0x2303370", Length = "0x7A")]
	[Token(Token = "0x6000110")]
	public static Exception ExpressionAndReadOnly() { }

	[Address(RVA = "0x2303FF0", Offset = "0x23033F0", Length = "0x7A")]
	[Token(Token = "0x600010F")]
	public static Exception ExpressionAndUnique() { }

	[Address(RVA = "0x2304070", Offset = "0x2303470", Length = "0x7A")]
	[Token(Token = "0x6000113")]
	public static Exception ExpressionCircular() { }

	[Address(RVA = "0x23040F0", Offset = "0x23034F0", Length = "0xDC")]
	[Token(Token = "0x6000112")]
	public static Exception ExpressionInConstraint(DataColumn column) { }

	[Address(RVA = "0x23041D0", Offset = "0x23035D0", Length = "0xD0")]
	[Token(Token = "0x60000FE")]
	public static Exception FailedCascadeDelete(string constraint) { }

	[Address(RVA = "0x23042A0", Offset = "0x23036A0", Length = "0xD0")]
	[Token(Token = "0x60000FF")]
	public static Exception FailedCascadeUpdate(string constraint) { }

	[Address(RVA = "0x2304370", Offset = "0x2303770", Length = "0xAE")]
	[Token(Token = "0x6000100")]
	public static Exception FailedClearParentTable(string table, string constraint, string childTable) { }

	[Address(RVA = "0x2304420", Offset = "0x2303820", Length = "0xA2")]
	[Token(Token = "0x6000101")]
	public static Exception ForeignKeyViolation(string constraint, Object[] keys) { }

	[Address(RVA = "0x23044D0", Offset = "0x23038D0", Length = "0x7A")]
	[Token(Token = "0x6000140")]
	public static Exception ForeignRelation() { }

	[Address(RVA = "0x2304550", Offset = "0x2303950", Length = "0x81")]
	[Token(Token = "0x60001BB")]
	public static Exception FoundEntity() { }

	[Address(RVA = "0x23045E0", Offset = "0x23039E0", Length = "0x106")]
	[Token(Token = "0x6000133")]
	public static Exception GetElementIndex(int index) { }

	[Address(RVA = "0x23046F0", Offset = "0x2303AF0", Length = "0x98")]
	[Token(Token = "0x6000143")]
	public static Exception GetParentRowTableMismatch(string t1, string t2) { }

	[Address(RVA = "0x2304790", Offset = "0x2303B90", Length = "0xDC")]
	[Token(Token = "0x6000122")]
	public static Exception HasToBeStringType(DataColumn column) { }

	[Address(RVA = "0x2304870", Offset = "0x2303C70", Length = "0xD0")]
	[Token(Token = "0x6000125")]
	public static Exception IComparableNotImplemented(string typeName) { }

	[Address(RVA = "0x2304AE0", Offset = "0x2303EE0", Length = "0x10B")]
	[Token(Token = "0x600016D")]
	public static Exception IndexKeyLength(int length, int keyLength) { }

	[Address(RVA = "0x2304BF0", Offset = "0x2303FF0", Length = "0x7A")]
	[Token(Token = "0x6000136")]
	public static Exception InsertExternalObject() { }

	[Address(RVA = "0x2304C70", Offset = "0x2304070", Length = "0xE1")]
	[Token(Token = "0x60001BF")]
	internal static Exception InternalRBTreeError(RBTreeError internalError) { }

	[Address(RVA = "0x2304940", Offset = "0x2303D40", Length = "0xC9")]
	[Token(Token = "0x6000124")]
	public static Exception INullableUDTwithoutStaticNull(string typeName) { }

	[Address(RVA = "0x2304D60", Offset = "0x2304160", Length = "0x98")]
	[Token(Token = "0x600019C")]
	public static Exception InvalidAttributeValue(string name, string value) { }

	[Address(RVA = "0x2304E00", Offset = "0x2304200", Length = "0xF1")]
	[Token(Token = "0x6000127")]
	public static Exception InvalidDataColumnMapping(Type type) { }

	[Address(RVA = "0x2304F00", Offset = "0x2304300", Length = "0x37")]
	[Token(Token = "0x6000129")]
	public static Exception InvalidDateTimeMode(DataSetDateTime mode) { }

	[Address(RVA = "0x2304F40", Offset = "0x2304340", Length = "0x91")]
	[Token(Token = "0x60001BE")]
	internal static Exception InvalidDuplicateNamedSimpleTypeDelaration(string stName, string errorStr) { }

	[Address(RVA = "0x2304FE0", Offset = "0x23043E0", Length = "0xD0")]
	[Token(Token = "0x60001A6")]
	public static Exception InvalidField(string name) { }

	[Address(RVA = "0x23050B0", Offset = "0x23044B0", Length = "0xD0")]
	[Token(Token = "0x60001AA")]
	public static Exception InvalidKey(string name) { }

	[Address(RVA = "0x2304A10", Offset = "0x2303E10", Length = "0xC9")]
	[Token(Token = "0x600014B")]
	public static Exception InValidNestedRelation(string childTableName) { }

	[Address(RVA = "0x2305180", Offset = "0x2304580", Length = "0x7A")]
	[Token(Token = "0x60000DE")]
	public static Exception InvalidOffsetLength() { }

	[Address(RVA = "0x2305200", Offset = "0x2304600", Length = "0xC9")]
	[Token(Token = "0x600014C")]
	public static Exception InvalidParentNamespaceinNestedRelation(string childTableName) { }

	[Address(RVA = "0x23052D0", Offset = "0x23046D0", Length = "0xD0")]
	[Token(Token = "0x60001B1")]
	public static Exception InvalidPrefix(string name) { }

	[Address(RVA = "0x23053A0", Offset = "0x23047A0", Length = "0x37")]
	[Token(Token = "0x600017D")]
	public static Exception InvalidRemotingFormat(SerializationFormat mode) { }

	[Address(RVA = "0x23053E0", Offset = "0x23047E0", Length = "0x7A")]
	[Token(Token = "0x6000163")]
	public static Exception InvalidRowBitPattern() { }

	[Address(RVA = "0x2305460", Offset = "0x2304860", Length = "0x37")]
	[Token(Token = "0x6000162")]
	public static Exception InvalidRowState(DataRowState state) { }

	[Address(RVA = "0x23054A0", Offset = "0x23048A0", Length = "0x81")]
	[Token(Token = "0x600015C")]
	public static Exception InvalidRowVersion() { }

	[Address(RVA = "0x2305530", Offset = "0x2304930", Length = "0xD0")]
	[Token(Token = "0x60001A7")]
	public static Exception InvalidSelector(string name) { }

	[Address(RVA = "0x2305600", Offset = "0x2304A00", Length = "0xC9")]
	[Token(Token = "0x6000182")]
	public static Exception InvalidSortString(string sort) { }

	[Address(RVA = "0x23056D0", Offset = "0x2304AD0", Length = "0x104")]
	[Token(Token = "0x6000193")]
	public static Exception InvalidStorageType(TypeCode typecode) { }

	[Address(RVA = "0x23057E0", Offset = "0x2304BE0", Length = "0x81")]
	[Token(Token = "0x60001B3")]
	public static Exception IsDataSetAttributeMissingInSchema() { }

	[Address(RVA = "0x2305870", Offset = "0x2304C70", Length = "0x81")]
	[Token(Token = "0x6000141")]
	public static Exception KeyColumnsIdentical() { }

	[Address(RVA = "0x2305900", Offset = "0x2304D00", Length = "0xD0")]
	[Token(Token = "0x600013B")]
	public static Exception KeyDuplicateColumns(string columnName) { }

	[Address(RVA = "0x23059D0", Offset = "0x2304DD0", Length = "0x7A")]
	[Token(Token = "0x600013E")]
	public static Exception KeyLengthMismatch() { }

	[Address(RVA = "0x2305A50", Offset = "0x2304E50", Length = "0x7A")]
	[Token(Token = "0x600013F")]
	public static Exception KeyLengthZero() { }

	[Address(RVA = "0x2305AD0", Offset = "0x2304ED0", Length = "0x81")]
	[Token(Token = "0x6000139")]
	public static Exception KeyNoColumns() { }

	[Address(RVA = "0x2305D00", Offset = "0x2305100", Length = "0x104")]
	[Token(Token = "0x60000F2")]
	public static string KeysToString(Object[] keys) { }

	[Address(RVA = "0x2305B60", Offset = "0x2304F60", Length = "0x81")]
	[Token(Token = "0x6000138")]
	public static Exception KeyTableMismatch() { }

	[Address(RVA = "0x2305BF0", Offset = "0x2304FF0", Length = "0x10D")]
	[Token(Token = "0x600013A")]
	public static Exception KeyTooManyColumns(int cols) { }

	[Address(RVA = "0x2305E10", Offset = "0x2305210", Length = "0xDC")]
	[Token(Token = "0x600011C")]
	public static Exception LongerThanMaxLength(DataColumn column) { }

	[Address(RVA = "0x2305EF0", Offset = "0x23052F0", Length = "0xC9")]
	[Token(Token = "0x6000148")]
	public static Exception LoopInNestedRelations(string tableName) { }

	[Address(RVA = "0x2305FC0", Offset = "0x23053C0", Length = "0x83")]
	[Token(Token = "0x6000103")]
	public static string MaxLengthViolationText(string columnName) { }

	[Address(RVA = "0x2306050", Offset = "0x2305450", Length = "0x61")]
	[Token(Token = "0x60001BC")]
	public static Exception MergeFailed(string name) { }

	[Address(RVA = "0x23060C0", Offset = "0x23054C0", Length = "0xC9")]
	[Token(Token = "0x6000167")]
	public static Exception MergeMissingDefinition(string obj) { }

	[Address(RVA = "0x2306190", Offset = "0x2305590", Length = "0x81")]
	[Token(Token = "0x60001A5")]
	public static Exception MismatchKeyLength() { }

	[Address(RVA = "0x2306220", Offset = "0x2305620", Length = "0x98")]
	[Token(Token = "0x600019B")]
	public static Exception MissingAttribute(string element, string attribute) { }

	[Address(RVA = "0x23062C0", Offset = "0x23056C0", Length = "0xA6")]
	[Token(Token = "0x600019A")]
	public static Exception MissingAttribute(string attribute) { }

	[Address(RVA = "0x2306370", Offset = "0x2305770", Length = "0xBE")]
	[Token(Token = "0x60001B0")]
	public static Exception MissingRefer(string name) { }

	[Address(RVA = "0x2306430", Offset = "0x2305830", Length = "0xD0")]
	[Token(Token = "0x60001B6")]
	public static Exception MultipleParentRows(string tableQName) { }

	[Address(RVA = "0x2306500", Offset = "0x2305900", Length = "0x81")]
	[Token(Token = "0x6000161")]
	public static Exception MultipleParents() { }

	[Address(RVA = "0x2306590", Offset = "0x2305990", Length = "0x7A")]
	[Token(Token = "0x6000181")]
	public static Exception MultipleTextOnlyColumns() { }

	[Address(RVA = "0x2306610", Offset = "0x2305A10", Length = "0xC9")]
	[Token(Token = "0x60000DD")]
	public static Exception NamespaceNameConflict(string name) { }

	[Address(RVA = "0x23066E0", Offset = "0x2305AE0", Length = "0xD4")]
	[Token(Token = "0x60000F8")]
	public static Exception NeededForForeignKeyConstraint(UniqueConstraint key, ForeignKeyConstraint fk) { }

	[Address(RVA = "0x23067C0", Offset = "0x2305BC0", Length = "0x7A")]
	[Token(Token = "0x6000196")]
	public static Exception NegativeMinimumCapacity() { }

	[Address(RVA = "0x2306840", Offset = "0x2305C40", Length = "0xD0")]
	[Token(Token = "0x60001B5")]
	public static Exception NestedCircular(string name) { }

	[Address(RVA = "0x2306910", Offset = "0x2305D10", Length = "0x7A")]
	[Token(Token = "0x60000F0")]
	public static Exception NoConstraintName() { }

	[Address(RVA = "0x2306990", Offset = "0x2305D90", Length = "0x81")]
	[Token(Token = "0x6000155")]
	public static Exception NoCurrentData() { }

	[Address(RVA = "0x2306BC0", Offset = "0x2305FC0", Length = "0xD0")]
	[Token(Token = "0x6000114")]
	public static Exception NonUniqueValues(string column) { }

	[Address(RVA = "0x2306A20", Offset = "0x2305E20", Length = "0x81")]
	[Token(Token = "0x6000156")]
	public static Exception NoOriginalData() { }

	[Address(RVA = "0x2306AB0", Offset = "0x2305EB0", Length = "0x81")]
	[Token(Token = "0x6000157")]
	public static Exception NoProposedData() { }

	[Address(RVA = "0x2306B40", Offset = "0x2305F40", Length = "0x7A")]
	[Token(Token = "0x6000180")]
	public static Exception NoTableName() { }

	[Address(RVA = "0x2306C90", Offset = "0x2306090", Length = "0x83")]
	[Token(Token = "0x6000104")]
	public static string NotAllowDBNullViolationText(string columnName) { }

	[Address(RVA = "0x2306D20", Offset = "0x2306120", Length = "0x81")]
	[Token(Token = "0x6000130")]
	public static Exception NotOpen() { }

	[Address(RVA = "0x2306DB0", Offset = "0x23061B0", Length = "0x7A")]
	[Token(Token = "0x600010A")]
	public static Exception NullDataType() { }

	[Address(RVA = "0x2306E30", Offset = "0x2306230", Length = "0xD0")]
	[Token(Token = "0x6000115")]
	public static Exception NullKeyValues(string column) { }

	[Address(RVA = "0x2306F00", Offset = "0x2306300", Length = "0x81")]
	[Token(Token = "0x6000195")]
	public static Exception NullRange() { }

	[Address(RVA = "0x2306F90", Offset = "0x2306390", Length = "0xD0")]
	[Token(Token = "0x6000116")]
	public static Exception NullValues(string column) { }

	[Address(RVA = "0x2307060", Offset = "0x2306460", Length = "0x81")]
	[Token(Token = "0x600014A")]
	public static Exception ParentOrChildColumnsDoNotHaveDataSet() { }

	[Address(RVA = "0x23070F0", Offset = "0x23064F0", Length = "0x7A")]
	[Token(Token = "0x6000177")]
	public static Exception ParentTableMismatch() { }

	[Address(RVA = "0x2307170", Offset = "0x2306570", Length = "0xC9")]
	[Token(Token = "0x60001B7")]
	public static Exception PolymorphismNotSupported(string typeName) { }

	[Address(RVA = "0x2307240", Offset = "0x2306640", Length = "0x13B")]
	[Token(Token = "0x6000197")]
	public static Exception ProblematicChars(char charValue) { }

	[Address(RVA = "0x2307380", Offset = "0x2306780", Length = "0xE6")]
	[Token(Token = "0x6000194")]
	public static Exception RangeArgument(int min, int max) { }

	[Address(RVA = "0x2307500", Offset = "0x2306900", Length = "0xD0")]
	[Token(Token = "0x6000118")]
	public static Exception ReadOnly(string column) { }

	[Address(RVA = "0x2307470", Offset = "0x2306870", Length = "0x81")]
	[Token(Token = "0x6000117")]
	public static Exception ReadOnlyAndExpression() { }

	[Address(RVA = "0x23075D0", Offset = "0x23069D0", Length = "0x7A")]
	[Token(Token = "0x600016C")]
	public static Exception RecordStateRange() { }

	[Address(RVA = "0x2307650", Offset = "0x2306A50", Length = "0x7A")]
	[Token(Token = "0x6000169")]
	public static Exception RelationAlreadyExists() { }

	[Address(RVA = "0x23076D0", Offset = "0x2306AD0", Length = "0x7A")]
	[Token(Token = "0x600016F")]
	public static Exception RelationAlreadyInOtherDataSet() { }

	[Address(RVA = "0x2307750", Offset = "0x2306B50", Length = "0x7A")]
	[Token(Token = "0x6000170")]
	public static Exception RelationAlreadyInTheDataSet() { }

	[Address(RVA = "0x23077D0", Offset = "0x2306BD0", Length = "0xD0")]
	[Token(Token = "0x60001A2")]
	public static Exception RelationChildKeyMissing(string rel) { }

	[Address(RVA = "0x23078A0", Offset = "0x2306CA0", Length = "0xD0")]
	[Token(Token = "0x60001A0")]
	public static Exception RelationChildNameMissing(string rel) { }

	[Address(RVA = "0x2307970", Offset = "0x2306D70", Length = "0x81")]
	[Token(Token = "0x600013C")]
	public static Exception RelationDataSetMismatch() { }

	[Address(RVA = "0x2307A00", Offset = "0x2306E00", Length = "0x7A")]
	[Token(Token = "0x6000175")]
	public static Exception RelationDataSetNull() { }

	[Address(RVA = "0x2307A80", Offset = "0x2306E80", Length = "0x7A")]
	[Token(Token = "0x6000149")]
	public static Exception RelationDoesNotExist() { }

	[Address(RVA = "0x2307B00", Offset = "0x2306F00", Length = "0x7A")]
	[Token(Token = "0x6000145")]
	public static Exception RelationForeignRow() { }

	[Address(RVA = "0x2307B80", Offset = "0x2306F80", Length = "0x98")]
	[Token(Token = "0x6000142")]
	public static Exception RelationForeignTable(string t1, string t2) { }

	[Address(RVA = "0x2307C20", Offset = "0x2307020", Length = "0x7A")]
	[Token(Token = "0x6000146")]
	public static Exception RelationNestedReadOnly() { }

	[Address(RVA = "0x2307CA0", Offset = "0x23070A0", Length = "0xC9")]
	[Token(Token = "0x6000171")]
	public static Exception RelationNotInTheDataSet(string relation) { }

	[Address(RVA = "0x2307D70", Offset = "0x2307170", Length = "0xFA")]
	[Token(Token = "0x6000172")]
	public static Exception RelationOutOfRange(object index) { }

	[Address(RVA = "0x2307E70", Offset = "0x2307270", Length = "0xD0")]
	[Token(Token = "0x600019F")]
	public static Exception RelationParentNameMissing(string rel) { }

	[Address(RVA = "0x2307F40", Offset = "0x2307340", Length = "0xD0")]
	[Token(Token = "0x60001A1")]
	public static Exception RelationTableKeyMissing(string rel) { }

	[Address(RVA = "0x2308010", Offset = "0x2307410", Length = "0x7A")]
	[Token(Token = "0x6000174")]
	public static Exception RelationTableNull() { }

	[Address(RVA = "0x2308090", Offset = "0x2307490", Length = "0x7A")]
	[Token(Token = "0x6000176")]
	public static Exception RelationTableWasRemoved() { }

	[Address(RVA = "0x2308110", Offset = "0x2307510", Length = "0x7A")]
	[Token(Token = "0x6000137")]
	public static Exception RemoveExternalObject() { }

	[Address(RVA = "0x2308190", Offset = "0x2307590", Length = "0xF8")]
	[Token(Token = "0x6000102")]
	public static Exception RemoveParentRow(ForeignKeyConstraint constraint) { }

	[Address(RVA = "0x2308290", Offset = "0x2307690", Length = "0x106")]
	[Token(Token = "0x600016E")]
	public static Exception RemovePrimaryKey(DataTable table) { }

	[Address(RVA = "0x23083A0", Offset = "0x23077A0", Length = "0x81")]
	[Token(Token = "0x600015A")]
	public static Exception RowAlreadyDeleted() { }

	[Address(RVA = "0x2308430", Offset = "0x2307830", Length = "0x7A")]
	[Token(Token = "0x600016A")]
	public static Exception RowAlreadyInOtherCollection() { }

	[Address(RVA = "0x23084B0", Offset = "0x23078B0", Length = "0x7A")]
	[Token(Token = "0x600016B")]
	public static Exception RowAlreadyInTheCollection() { }

	[Address(RVA = "0x2308530", Offset = "0x2307930", Length = "0x81")]
	[Token(Token = "0x6000160")]
	public static Exception RowAlreadyRemoved() { }

	[Address(RVA = "0x23085C0", Offset = "0x23079C0", Length = "0x7A")]
	[Token(Token = "0x600015B")]
	public static Exception RowEmpty() { }

	[Address(RVA = "0x2308640", Offset = "0x2307A40", Length = "0xC9")]
	[Token(Token = "0x600015F")]
	public static Exception RowInsertMissing(string tableName) { }

	[Address(RVA = "0x2308710", Offset = "0x2307B10", Length = "0xCB")]
	[Token(Token = "0x600015E")]
	public static Exception RowInsertTwice(int index, string tableName) { }

	[Address(RVA = "0x23087E0", Offset = "0x2307BE0", Length = "0x7A")]
	[Token(Token = "0x600014D")]
	public static Exception RowNotInTheDataSet() { }

	[Address(RVA = "0x2308860", Offset = "0x2307C60", Length = "0x81")]
	[Token(Token = "0x600014E")]
	public static Exception RowNotInTheTable() { }

	[Address(RVA = "0x23088F0", Offset = "0x2307CF0", Length = "0x106")]
	[Token(Token = "0x600015D")]
	public static Exception RowOutOfRange(int index) { }

	[Address(RVA = "0x2308A00", Offset = "0x2307E00", Length = "0x81")]
	[Token(Token = "0x6000158")]
	public static Exception RowRemovedFromTheTable() { }

	[Address(RVA = "0x2308A90", Offset = "0x2307E90", Length = "0xD0")]
	[Token(Token = "0x6000185")]
	public static Exception SelfnestedDatasetConflictingName(string table) { }

	[Address(RVA = "0x2308B60", Offset = "0x2307F60", Length = "0xC9")]
	[Token(Token = "0x6000165")]
	internal static Exception SetDataSetNameConflicting(string name) { }

	[Address(RVA = "0x2308C30", Offset = "0x2308030", Length = "0x7A")]
	[Token(Token = "0x6000164")]
	internal static Exception SetDataSetNameToEmpty() { }

	[Address(RVA = "0x2308CB0", Offset = "0x23080B0", Length = "0x142")]
	[Token(Token = "0x600011A")]
	public static Exception SetFailed(object value, DataColumn column, Type type, Exception innerException) { }

	[Address(RVA = "0x2308E00", Offset = "0x2308200", Length = "0xD0")]
	[Token(Token = "0x600012C")]
	public static Exception SetFailed(string name) { }

	[Address(RVA = "0x2308ED0", Offset = "0x23082D0", Length = "0x7A")]
	[Token(Token = "0x600012E")]
	public static Exception SetIListObject() { }

	[Address(RVA = "0x2308F50", Offset = "0x2308350", Length = "0x98")]
	[Token(Token = "0x6000144")]
	public static Exception SetParentRowTableMismatch(string t1, string t2) { }

	[Address(RVA = "0x2308FF0", Offset = "0x23083F0", Length = "0x81")]
	[Token(Token = "0x6000199")]
	public static Exception SimpleTypeNotSupported() { }

	[Address(RVA = "0x2309080", Offset = "0x2308480", Length = "0x7A")]
	[Token(Token = "0x6000198")]
	public static Exception StorageSetFailed() { }

	[Address(RVA = "0x2309100", Offset = "0x2308500", Length = "0x7A")]
	[Token(Token = "0x6000187")]
	public static Exception TableAlreadyInOtherDataSet() { }

	[Address(RVA = "0x2309180", Offset = "0x2308580", Length = "0x7A")]
	[Token(Token = "0x6000188")]
	public static Exception TableAlreadyInTheDataSet() { }

	[Address(RVA = "0x2309200", Offset = "0x2308600", Length = "0x7A")]
	[Token(Token = "0x600017F")]
	public static Exception TableCannotAddToSimpleContent() { }

	[Address(RVA = "0x2309280", Offset = "0x2308680", Length = "0xC9")]
	[Token(Token = "0x6000147")]
	public static Exception TableCantBeNestedInTwoTables(string tableName) { }

	[Address(RVA = "0x2309350", Offset = "0x2308750", Length = "0x7A")]
	[Token(Token = "0x600017E")]
	public static Exception TableForeignPrimaryKey() { }

	[Address(RVA = "0x23093D0", Offset = "0x23087D0", Length = "0xC1")]
	[Token(Token = "0x600018C")]
	public static Exception TableInConstraint(DataTable table, Constraint constraint) { }

	[Address(RVA = "0x23094A0", Offset = "0x23088A0", Length = "0x7A")]
	[Token(Token = "0x600018B")]
	public static Exception TableInRelation() { }

	[Address(RVA = "0x2309520", Offset = "0x2308920", Length = "0xC9")]
	[Token(Token = "0x6000191")]
	public static Exception TableNotFound(string tableName) { }

	[Address(RVA = "0x23095F0", Offset = "0x23089F0", Length = "0xC9")]
	[Token(Token = "0x600018A")]
	public static Exception TableNotInTheDataSet(string table) { }

	[Address(RVA = "0x23096C0", Offset = "0x2308AC0", Length = "0x106")]
	[Token(Token = "0x6000189")]
	public static Exception TableOutOfRange(int index) { }

	[Address(RVA = "0x23097D0", Offset = "0x2308BD0", Length = "0x7A")]
	[Token(Token = "0x6000168")]
	public static Exception TablesInDifferentSets() { }

	[Address(RVA = "0x2309850", Offset = "0x2308C50", Length = "0x61")]
	[Token(Token = "0x60000CD")]
	private static void ThrowDataException(string error, Exception innerException) { }

	[Address(RVA = "0x23098C0", Offset = "0x2308CC0", Length = "0x4E")]
	[Token(Token = "0x60001B9")]
	internal static void ThrowMultipleTargetConverter(Exception innerException) { }

	[Address(RVA = "0x2309910", Offset = "0x2308D10", Length = "0x81")]
	[Token(Token = "0x60001B4")]
	public static Exception TooManyIsDataSetAtributeInSchema() { }

	[Address(RVA = "0x2309BE0", Offset = "0x2308FE0", Length = "0x8D")]
	[Token(Token = "0x60000C1")]
	private static void TraceException(string trace, Exception e) { }

	[Address(RVA = "0x23099A0", Offset = "0x2308DA0", Length = "0xB0")]
	[Token(Token = "0x60000C2")]
	internal static Exception TraceExceptionAsReturnValue(Exception e) { }

	[Address(RVA = "0x2309A60", Offset = "0x2308E60", Length = "0xB0")]
	[Token(Token = "0x60000C3")]
	internal static Exception TraceExceptionForCapture(Exception e) { }

	[Address(RVA = "0x2309B20", Offset = "0x2308F20", Length = "0xB0")]
	[Token(Token = "0x60000C4")]
	internal static Exception TraceExceptionWithoutRethrow(Exception e) { }

	[Address(RVA = "0x2309C70", Offset = "0x2309070", Length = "0xF1")]
	[Token(Token = "0x60000DB")]
	public static Exception TypeNotAllowed(Type type) { }

	[Address(RVA = "0x2309D70", Offset = "0x2309170", Length = "0xC9")]
	[Token(Token = "0x6000126")]
	public static Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName) { }

	[Address(RVA = "0x2309E40", Offset = "0x2309240", Length = "0xD0")]
	[Token(Token = "0x60001A3")]
	public static Exception UndefinedDatatype(string name) { }

	[Address(RVA = "0x2309F10", Offset = "0x2309310", Length = "0x7A")]
	[Token(Token = "0x6000119")]
	public static Exception UniqueAndExpression() { }

	[Address(RVA = "0x230A220", Offset = "0x2309620", Length = "0x7A")]
	[Token(Token = "0x60000F9")]
	public static Exception UniqueConstraintViolation() { }

	[Address(RVA = "0x2309F90", Offset = "0x2309390", Length = "0x284")]
	[Token(Token = "0x60000F3")]
	public static string UniqueConstraintViolationText(DataColumn[] columns, Object[] values) { }

	[Address(RVA = "0x230A2A0", Offset = "0x23096A0", Length = "0x7A")]
	[Token(Token = "0x6000154")]
	public static Exception ValueArrayLength() { }

}


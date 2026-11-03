namespace System.Xml.Schema;

[Token(Token = "0x20001BA")]
internal abstract class FacetsChecker
{
	[Token(Token = "0x20001BB")]
	private struct FacetsCompiler
	{
		[Token(Token = "0x20001BC")]
		private struct Map
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000862")]
			internal char match; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000863")]
			internal string replacement; //Field offset: 0x8

			[Address(RVA = "0x25B1620", Offset = "0x25B0A20", Length = "0x13")]
			[Token(Token = "0x6001153")]
			internal Map(char m, string r) { }

		}

		[Token(Token = "0x4000861")]
		private static readonly Map[] c_map; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000856")]
		private DatatypeImplementation datatype; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000857")]
		private RestrictionFacets derivedRestriction; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000858")]
		private RestrictionFlags baseFlags; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000859")]
		private RestrictionFlags baseFixedFlags; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400085A")]
		private RestrictionFlags validRestrictionFlags; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400085B")]
		private XmlSchemaDatatype nonNegativeInt; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400085C")]
		private XmlSchemaDatatype builtInType; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400085D")]
		private XmlTypeCode builtInEnum; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x400085E")]
		private bool firstPattern; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400085F")]
		private StringBuilder regStr; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000860")]
		private XmlSchemaPatternFacet pattern_facet; //Field offset: 0x40

		[Address(RVA = "0x25B1040", Offset = "0x25B0440", Length = "0x30A")]
		[Token(Token = "0x6001152")]
		private static FacetsCompiler() { }

		[Address(RVA = "0x25B1350", Offset = "0x25B0750", Length = "0x2CA")]
		[Token(Token = "0x600113B")]
		public FacetsCompiler(DatatypeImplementation baseDatatype, RestrictionFacets restriction) { }

		[Address(RVA = "0x25ACE60", Offset = "0x25AC260", Length = "0x78")]
		[Token(Token = "0x600114F")]
		private void CheckDupFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

		[Address(RVA = "0x25ACEE0", Offset = "0x25AC2E0", Length = "0x95")]
		[Token(Token = "0x600114E")]
		private void CheckProhibitedFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

		[Address(RVA = "0x25ACF80", Offset = "0x25AC380", Length = "0x6A0")]
		[Token(Token = "0x6001149")]
		private void CheckValue(object value, XmlSchemaFacet facet) { }

		[Address(RVA = "0x25AD630", Offset = "0x25ACA30", Length = "0x1A1")]
		[Token(Token = "0x6001140")]
		internal void CompileEnumerationFacet(XmlSchemaFacet facet, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

		[Address(RVA = "0x25AD7E0", Offset = "0x25ACBE0", Length = "0x56A")]
		[Token(Token = "0x600114A")]
		internal void CompileFacetCombinations() { }

		[Address(RVA = "0x25ADD50", Offset = "0x25AD150", Length = "0x351")]
		[Token(Token = "0x6001147")]
		internal void CompileFractionDigitsFacet(XmlSchemaFacet facet) { }

		[Address(RVA = "0x25AE0B0", Offset = "0x25AD4B0", Length = "0x498")]
		[Token(Token = "0x600113C")]
		internal void CompileLengthFacet(XmlSchemaFacet facet) { }

		[Address(RVA = "0x25AE550", Offset = "0x25AD950", Length = "0x272")]
		[Token(Token = "0x6001143")]
		internal void CompileMaxExclusiveFacet(XmlSchemaFacet facet) { }

		[Address(RVA = "0x25AE7D0", Offset = "0x25ADBD0", Length = "0x268")]
		[Token(Token = "0x6001142")]
		internal void CompileMaxInclusiveFacet(XmlSchemaFacet facet) { }

		[Address(RVA = "0x25AEA40", Offset = "0x25ADE40", Length = "0x405")]
		[Token(Token = "0x600113E")]
		internal void CompileMaxLengthFacet(XmlSchemaFacet facet) { }

		[Address(RVA = "0x25AEE50", Offset = "0x25AE250", Length = "0x278")]
		[Token(Token = "0x6001145")]
		internal void CompileMinExclusiveFacet(XmlSchemaFacet facet) { }

		[Address(RVA = "0x25AF0D0", Offset = "0x25AE4D0", Length = "0x278")]
		[Token(Token = "0x6001144")]
		internal void CompileMinInclusiveFacet(XmlSchemaFacet facet) { }

		[Address(RVA = "0x25AF350", Offset = "0x25AE750", Length = "0x405")]
		[Token(Token = "0x600113D")]
		internal void CompileMinLengthFacet(XmlSchemaFacet facet) { }

		[Address(RVA = "0x25AF760", Offset = "0x25AEB60", Length = "0x1AE")]
		[Token(Token = "0x600113F")]
		internal void CompilePatternFacet(XmlSchemaPatternFacet facet) { }

		[Address(RVA = "0x25AF910", Offset = "0x25AED10", Length = "0x42B")]
		[Token(Token = "0x6001146")]
		internal void CompileTotalDigitsFacet(XmlSchemaFacet facet) { }

		[Address(RVA = "0x25AFD40", Offset = "0x25AF140", Length = "0x46A")]
		[Token(Token = "0x6001141")]
		internal void CompileWhitespaceFacet(XmlSchemaFacet facet) { }

		[Address(RVA = "0x25B01B0", Offset = "0x25AF5B0", Length = "0x5E5")]
		[Token(Token = "0x600114B")]
		private void CopyFacetsFromBaseType() { }

		[Address(RVA = "0x25B07A0", Offset = "0x25AFBA0", Length = "0x344")]
		[Token(Token = "0x6001148")]
		internal void FinishFacetCompile() { }

		[Address(RVA = "0x25B0AF0", Offset = "0x25AFEF0", Length = "0x1B1")]
		[Token(Token = "0x600114C")]
		private object ParseFacetValue(XmlSchemaDatatype datatype, XmlSchemaFacet facet, string code, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

		[Address(RVA = "0x25B0CB0", Offset = "0x25B00B0", Length = "0x2FD")]
		[Token(Token = "0x600114D")]
		private static string Preprocess(string pattern) { }

		[Address(RVA = "0x25B0FB0", Offset = "0x25B03B0", Length = "0x2C")]
		[Token(Token = "0x6001151")]
		private void SetFlag(RestrictionFlags flag) { }

		[Address(RVA = "0x25B0FE0", Offset = "0x25B03E0", Length = "0x5B")]
		[Token(Token = "0x6001150")]
		private void SetFlag(XmlSchemaFacet facet, RestrictionFlags flag) { }

	}


	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600113A")]
	protected FacetsChecker() { }

	[Address(RVA = "0x25AC320", Offset = "0x25AB720", Length = "0x251")]
	[Token(Token = "0x6001128")]
	internal override Exception CheckLexicalFacets(ref string parseString, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x25AC580", Offset = "0x25AB980", Length = "0x167")]
	[Token(Token = "0x6001136")]
	internal Exception CheckPatternFacets(RestrictionFacets restriction, string value) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600112A")]
	internal override Exception CheckValueFacets(decimal value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001134")]
	internal override Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001133")]
	internal override Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001129")]
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001130")]
	internal override Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001132")]
	internal override Exception CheckValueFacets(Byte[] value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600112E")]
	internal override Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600112D")]
	internal override Exception CheckValueFacets(short value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600112C")]
	internal override Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600112B")]
	internal override Exception CheckValueFacets(long value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600112F")]
	internal override Exception CheckValueFacets(double value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001131")]
	internal override Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x25AC6F0", Offset = "0x25ABAF0", Length = "0xF3")]
	[Token(Token = "0x6001135")]
	internal void CheckWhitespaceFacets(ref string s, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x25AC7F0", Offset = "0x25ABBF0", Length = "0x510")]
	[Token(Token = "0x6001138")]
	internal override RestrictionFacets ConstructRestriction(DatatypeImplementation datatype, XmlSchemaObjectCollection facets, XmlNameTable nameTable) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6001137")]
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x25ACD30", Offset = "0x25AC130", Length = "0x130")]
	[Token(Token = "0x6001139")]
	internal static decimal Power(int x, int y) { }

}


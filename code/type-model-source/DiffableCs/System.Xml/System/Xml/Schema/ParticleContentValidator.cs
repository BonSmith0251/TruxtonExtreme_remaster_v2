namespace System.Xml.Schema;

[Token(Token = "0x200016D")]
internal sealed class ParticleContentValidator : ContentValidator
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000770")]
	private SymbolsDictionary symbols; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000771")]
	private Positions positions; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000772")]
	private Stack stack; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000773")]
	private SyntaxTreeNode contentNode; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000774")]
	private bool isPartial; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000775")]
	private int minMaxNodesCount; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000776")]
	private bool enableUpaCheck; //Field offset: 0x40

	[Address(RVA = "0x2588420", Offset = "0x2587820", Length = "0x60")]
	[Token(Token = "0x6000F46")]
	public ParticleContentValidator(XmlSchemaContentType contentType) { }

	[Address(RVA = "0x2588480", Offset = "0x2587880", Length = "0x6E")]
	[Token(Token = "0x6000F47")]
	public ParticleContentValidator(XmlSchemaContentType contentType, bool enableUpaCheck) { }

	[Address(RVA = "0x2585240", Offset = "0x2584640", Length = "0xF9")]
	[Token(Token = "0x6000F52")]
	public void AddChoice() { }

	[Address(RVA = "0x2585340", Offset = "0x2584740", Length = "0xFF")]
	[Token(Token = "0x6000F51")]
	private void AddLeafNode(SyntaxTreeNode node) { }

	[Address(RVA = "0x2585440", Offset = "0x2584840", Length = "0xE9")]
	[Token(Token = "0x6000F57")]
	public void AddLeafRange(decimal min, decimal max) { }

	[Address(RVA = "0x2585530", Offset = "0x2584930", Length = "0xAE")]
	[Token(Token = "0x6000F4F")]
	public void AddName(XmlQualifiedName name, object particle) { }

	[Address(RVA = "0x25855E0", Offset = "0x25849E0", Length = "0xB9")]
	[Token(Token = "0x6000F50")]
	public void AddNamespaceList(NamespaceList namespaceList, object particle) { }

	[Address(RVA = "0x25856A0", Offset = "0x2584AA0", Length = "0x5A")]
	[Token(Token = "0x6000F55")]
	public void AddPlus() { }

	[Address(RVA = "0x2585700", Offset = "0x2584B00", Length = "0x5A")]
	[Token(Token = "0x6000F56")]
	public void AddQMark() { }

	[Address(RVA = "0x2585760", Offset = "0x2584B60", Length = "0xF9")]
	[Token(Token = "0x6000F53")]
	public void AddSequence() { }

	[Address(RVA = "0x2585860", Offset = "0x2584C60", Length = "0x5A")]
	[Token(Token = "0x6000F54")]
	public void AddStar() { }

	[Address(RVA = "0x25858C0", Offset = "0x2584CC0", Length = "0x6A3")]
	[Token(Token = "0x6000F5F")]
	private Int32[][] BuildTransitionTable(BitSet firstpos, BitSet[] followpos, int endMarkerPos) { }

	[Address(RVA = "0x2585F70", Offset = "0x2585370", Length = "0x42B")]
	[Token(Token = "0x6000F5A")]
	private BitSet[] CalculateTotalFollowposForRangeNodes(BitSet firstpos, BitSet[] followpos, out BitSet posWithRangeTerminals) { }

	[Address(RVA = "0x25863A0", Offset = "0x25857A0", Length = "0x22A")]
	[Token(Token = "0x6000F5B")]
	private void CheckCMUPAWithLeafRangeNodes(BitSet curpos) { }

	[Address(RVA = "0x25865D0", Offset = "0x25859D0", Length = "0x289")]
	[Token(Token = "0x6000F5E")]
	private void CheckUniqueParticleAttribution(BitSet curpos) { }

	[Address(RVA = "0x2586860", Offset = "0x2585C60", Length = "0xB3")]
	[Token(Token = "0x6000F5D")]
	private void CheckUniqueParticleAttribution(BitSet firstpos, BitSet[] followpos) { }

	[Address(RVA = "0x2586920", Offset = "0x2585D20", Length = "0x1A2")]
	[Token(Token = "0x6000F4D")]
	public void CloseGroup() { }

	[Address(RVA = "0x2586AD0", Offset = "0x2585ED0", Length = "0x1C2")]
	[Token(Token = "0x6000F58")]
	private void Closure(InteriorNode node) { }

	[Address(RVA = "0x2586CA0", Offset = "0x25860A0", Length = "0x3E")]
	[Token(Token = "0x6000F4A")]
	public virtual bool CompleteValidation(ValidationState context) { }

	[Address(RVA = "0x2586CE0", Offset = "0x25860E0", Length = "0x39")]
	[Token(Token = "0x6000F4E")]
	public bool Exists(XmlQualifiedName name) { }

	[Address(RVA = "0x2586D20", Offset = "0x2586120", Length = "0x1084")]
	[Token(Token = "0x6000F59")]
	public ContentValidator Finish(bool useDFA) { }

	[Address(RVA = "0x2587DB0", Offset = "0x25871B0", Length = "0x41D")]
	[Token(Token = "0x6000F5C")]
	private BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, BitSet[] minmaxFollowPos) { }

	[Address(RVA = "0x25881D0", Offset = "0x25875D0", Length = "0x3E")]
	[Token(Token = "0x6000F48")]
	public virtual void InitValidation(ValidationState context) { }

	[Address(RVA = "0x2588210", Offset = "0x2587610", Length = "0x2C")]
	[Token(Token = "0x6000F4C")]
	public void OpenGroup() { }

	[Address(RVA = "0x2588240", Offset = "0x2587640", Length = "0x193")]
	[Token(Token = "0x6000F4B")]
	public void Start() { }

	[Address(RVA = "0x25883E0", Offset = "0x25877E0", Length = "0x3E")]
	[Token(Token = "0x6000F49")]
	public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

}


namespace System.Xml.Schema;

[Token(Token = "0x2000172")]
internal sealed class AllElementsContentValidator : ContentValidator
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000787")]
	private Hashtable elements; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000788")]
	private Object[] particles; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000789")]
	private BitSet isRequired; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400078A")]
	private int countRequired; //Field offset: 0x30

	[Token(Token = "0x170003FD")]
	public virtual bool IsEmptiable
	{
		[Address(RVA = "0x25950B0", Offset = "0x25944B0", Length = "0x11")]
		[Token(Token = "0x6000F74")]
		 get { } //Length: 17
	}

	[Address(RVA = "0x2594F90", Offset = "0x2594390", Length = "0x119")]
	[Token(Token = "0x6000F72")]
	public AllElementsContentValidator(XmlSchemaContentType contentType, int size, bool isEmptiable) { }

	[Address(RVA = "0x25944C0", Offset = "0x25938C0", Length = "0x14B")]
	[Token(Token = "0x6000F73")]
	public bool AddElement(XmlQualifiedName name, object particle, bool isEmptiable) { }

	[Address(RVA = "0x2594610", Offset = "0x2593A10", Length = "0x4F")]
	[Token(Token = "0x6000F77")]
	public virtual bool CompleteValidation(ValidationState context) { }

	[Address(RVA = "0x2594660", Offset = "0x2593A60", Length = "0x359")]
	[Token(Token = "0x6000F78")]
	public virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	[Address(RVA = "0x25949C0", Offset = "0x2593DC0", Length = "0x3FE")]
	[Token(Token = "0x6000F79")]
	public virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

	[Address(RVA = "0x25950B0", Offset = "0x25944B0", Length = "0x11")]
	[Token(Token = "0x6000F74")]
	public virtual bool get_IsEmptiable() { }

	[Address(RVA = "0x2594DC0", Offset = "0x25941C0", Length = "0x9C")]
	[Token(Token = "0x6000F75")]
	public virtual void InitValidation(ValidationState context) { }

	[Address(RVA = "0x2594E60", Offset = "0x2594260", Length = "0x122")]
	[Token(Token = "0x6000F76")]
	public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

}


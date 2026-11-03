namespace System.Reflection;

[Token(Token = "0x2000507")]
public abstract class TypeInfo : Type, IReflectableType
{

	[Token(Token = "0x170004A6")]
	public override IEnumerable<Type> ImplementedInterfaces
	{
		[Address(RVA = "0x1F6ECE0", Offset = "0x1F6E0E0", Length = "0x1B0")]
		[Token(Token = "0x60023AE")]
		 get { } //Length: 432
	}

	[Address(RVA = "0x1F6D340", Offset = "0x1F6C740", Length = "0x2D")]
	[Token(Token = "0x60023AC")]
	protected TypeInfo() { }

	[Address(RVA = "0x1F6ECE0", Offset = "0x1F6E0E0", Length = "0x1B0")]
	[Token(Token = "0x60023AE")]
	public override IEnumerable<Type> get_ImplementedInterfaces() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x60023AD")]
	private override TypeInfo System.Reflection.IReflectableType.GetTypeInfo() { }

}


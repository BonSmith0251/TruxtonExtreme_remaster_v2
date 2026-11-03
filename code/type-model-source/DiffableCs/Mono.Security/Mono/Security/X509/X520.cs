namespace Mono.Security.X509;

[Token(Token = "0x200001B")]
public class X520
{
	[Token(Token = "0x200001C")]
	internal abstract class AttributeTypeAndValue
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000081")]
		private string oid; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000082")]
		private string attrValue; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000083")]
		private int upperBound; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000084")]
		private byte encoding; //Field offset: 0x24

		[Token(Token = "0x1700004C")]
		public string Value
		{
			[Address(RVA = "0x1E2D730", Offset = "0x1E2CB30", Length = "0xB7")]
			[Token(Token = "0x60000EA")]
			 set { } //Length: 183
		}

		[Address(RVA = "0x1E2D680", Offset = "0x1E2CA80", Length = "0x46")]
		[Token(Token = "0x60000E8")]
		protected AttributeTypeAndValue(string oid, int upperBound) { }

		[Address(RVA = "0x1E2D6D0", Offset = "0x1E2CAD0", Length = "0x54")]
		[Token(Token = "0x60000E9")]
		protected AttributeTypeAndValue(string oid, int upperBound, byte encoding) { }

		[Address(RVA = "0x1E2D2E0", Offset = "0x1E2C6E0", Length = "0x321")]
		[Token(Token = "0x60000EB")]
		internal ASN1 GetASN1(byte encoding) { }

		[Address(RVA = "0x1E2D2D0", Offset = "0x1E2C6D0", Length = "0xC")]
		[Token(Token = "0x60000EC")]
		internal ASN1 GetASN1() { }

		[Address(RVA = "0x1E2D610", Offset = "0x1E2CA10", Length = "0x60")]
		[Token(Token = "0x60000ED")]
		private byte SelectBestEncoding() { }

		[Address(RVA = "0x1E2D730", Offset = "0x1E2CB30", Length = "0xB7")]
		[Token(Token = "0x60000EA")]
		public void set_Value(string value) { }

	}

	[Token(Token = "0x200001D")]
	internal class CommonName : AttributeTypeAndValue
	{

		[Address(RVA = "0x1E30B50", Offset = "0x1E2FF50", Length = "0x60")]
		[Token(Token = "0x60000EE")]
		public CommonName() { }

	}

	[Token(Token = "0x2000028")]
	internal class CountryName : AttributeTypeAndValue
	{

		[Address(RVA = "0x1E310F0", Offset = "0x1E304F0", Length = "0x60")]
		[Token(Token = "0x60000F9")]
		public CountryName() { }

	}

	[Token(Token = "0x2000029")]
	internal class DnQualifier : AttributeTypeAndValue
	{

		[Address(RVA = "0x1E31B10", Offset = "0x1E30F10", Length = "0x60")]
		[Token(Token = "0x60000FA")]
		public DnQualifier() { }

	}

	[Token(Token = "0x2000024")]
	internal class DomainComponent : AttributeTypeAndValue
	{

		[Address(RVA = "0x1E31B70", Offset = "0x1E30F70", Length = "0x60")]
		[Token(Token = "0x60000F5")]
		public DomainComponent() { }

	}

	[Token(Token = "0x2000023")]
	internal class EmailAddress : AttributeTypeAndValue
	{

		[Address(RVA = "0x1E31BD0", Offset = "0x1E30FD0", Length = "0x60")]
		[Token(Token = "0x60000F4")]
		public EmailAddress() { }

	}

	[Token(Token = "0x200002B")]
	internal class GivenName : AttributeTypeAndValue
	{

		[Address(RVA = "0x1E320F0", Offset = "0x1E314F0", Length = "0x60")]
		[Token(Token = "0x60000FC")]
		public GivenName() { }

	}

	[Token(Token = "0x200002C")]
	internal class Initial : AttributeTypeAndValue
	{

		[Address(RVA = "0x1E32150", Offset = "0x1E31550", Length = "0x60")]
		[Token(Token = "0x60000FD")]
		public Initial() { }

	}

	[Token(Token = "0x200001F")]
	internal class LocalityName : AttributeTypeAndValue
	{

		[Address(RVA = "0x1E321C0", Offset = "0x1E315C0", Length = "0x60")]
		[Token(Token = "0x60000F0")]
		public LocalityName() { }

	}

	[Token(Token = "0x2000026")]
	internal class Oid : AttributeTypeAndValue
	{

		[Address(RVA = "0x1E32220", Offset = "0x1E31620", Length = "0x3D")]
		[Token(Token = "0x60000F7")]
		public Oid(string oid) { }

	}

	[Token(Token = "0x2000022")]
	internal class OrganizationalUnitName : AttributeTypeAndValue
	{

		[Address(RVA = "0x1E322C0", Offset = "0x1E316C0", Length = "0x60")]
		[Token(Token = "0x60000F3")]
		public OrganizationalUnitName() { }

	}

	[Token(Token = "0x2000021")]
	internal class OrganizationName : AttributeTypeAndValue
	{

		[Address(RVA = "0x1E32260", Offset = "0x1E31660", Length = "0x60")]
		[Token(Token = "0x60000F2")]
		public OrganizationName() { }

	}

	[Token(Token = "0x200001E")]
	internal class SerialNumber : AttributeTypeAndValue
	{

		[Address(RVA = "0x1E3AB00", Offset = "0x1E39F00", Length = "0x60")]
		[Token(Token = "0x60000EF")]
		public SerialNumber() { }

	}

	[Token(Token = "0x2000020")]
	internal class StateOrProvinceName : AttributeTypeAndValue
	{

		[Address(RVA = "0x1E3BC20", Offset = "0x1E3B020", Length = "0x60")]
		[Token(Token = "0x60000F1")]
		public StateOrProvinceName() { }

	}

	[Token(Token = "0x200002A")]
	internal class Surname : AttributeTypeAndValue
	{

		[Address(RVA = "0x1E3BC80", Offset = "0x1E3B080", Length = "0x60")]
		[Token(Token = "0x60000FB")]
		public Surname() { }

	}

	[Token(Token = "0x2000027")]
	internal class Title : AttributeTypeAndValue
	{

		[Address(RVA = "0x1E3BCE0", Offset = "0x1E3B0E0", Length = "0x60")]
		[Token(Token = "0x60000F8")]
		public Title() { }

	}

	[Token(Token = "0x2000025")]
	internal class UserId : AttributeTypeAndValue
	{

		[Address(RVA = "0x1E3BD40", Offset = "0x1E3B140", Length = "0x60")]
		[Token(Token = "0x60000F6")]
		public UserId() { }

	}


}


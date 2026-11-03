namespace Mono.Btls;

[Token(Token = "0x200009D")]
internal enum MonoBtlsX509NameEntryType : int
{
	Unknown = 0,
	CountryName = 1,
	OrganizationName = 2,
	OrganizationalUnitName = 3,
	CommonName = 4,
	LocalityName = 5,
	StateOrProvinceName = 6,
	StreetAddress = 7,
	SerialNumber = 8,
	DomainComponent = 9,
	UserId = 10,
	Email = 11,
	DnQualifier = 12,
	Title = 13,
	Surname = 14,
	GivenName = 15,
	Initial = 16,
}


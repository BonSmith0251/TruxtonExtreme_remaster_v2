namespace System.Security.Permissions;

[ComVisible(True)]
[Obsolete("CAS support is not available with Silverlight applications.")]
[Token(Token = "0x20002E2")]
public enum SecurityAction : int
{
	Demand = 2,
	Assert = 3,
	Deny = 4,
	PermitOnly = 5,
	LinkDemand = 6,
	InheritanceDemand = 7,
	RequestMinimum = 8,
	RequestOptional = 9,
	RequestRefuse = 10,
}


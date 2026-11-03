namespace Unity.Properties;

[Token(Token = "0x2000009")]
public enum VisitReturnCode : int
{
	Ok = 0,
	NullContainer = 1,
	InvalidContainerType = 2,
	MissingPropertyBag = 3,
	InvalidPath = 4,
	InvalidCast = 5,
	AccessViolation = 6,
}


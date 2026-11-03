namespace Newtonsoft.Json;

[Flags]
[Token(Token = "0x2000011")]
public enum DefaultValueHandling : int
{
	Include = 0,
	Ignore = 1,
	Populate = 2,
	IgnoreAndPopulate = 3,
}


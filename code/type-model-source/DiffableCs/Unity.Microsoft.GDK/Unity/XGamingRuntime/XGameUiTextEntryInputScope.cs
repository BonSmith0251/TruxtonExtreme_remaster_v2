namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200022F")]
public enum XGameUiTextEntryInputScope : uint
{
	Default = 0,
	Url = 1,
	EmailSmtpAddress = 5,
	Number = 29,
	Password = 31,
	TelephoneNumber = 32,
	Alphanumeric = 40,
	Search = 50,
	ChatWithoutEmoji = 68,
}


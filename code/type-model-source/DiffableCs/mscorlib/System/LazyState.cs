namespace System;

[Token(Token = "0x2000107")]
internal enum LazyState : int
{
	NoneViaConstructor = 0,
	NoneViaFactory = 1,
	NoneException = 2,
	PublicationOnlyViaConstructor = 3,
	PublicationOnlyViaFactory = 4,
	PublicationOnlyWait = 5,
	PublicationOnlyException = 6,
	ExecutionAndPublicationViaConstructor = 7,
	ExecutionAndPublicationViaFactory = 8,
	ExecutionAndPublicationException = 9,
}


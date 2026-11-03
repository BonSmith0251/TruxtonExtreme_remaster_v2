namespace System.Resources;

[Token(Token = "0x20004BE")]
internal class FileBasedResourceGroveler : IResourceGroveler
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012BD")]
	private ResourceManagerMediator _mediator; //Field offset: 0x10

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60021BD")]
	public FileBasedResourceGroveler(ResourceManagerMediator mediator) { }

}


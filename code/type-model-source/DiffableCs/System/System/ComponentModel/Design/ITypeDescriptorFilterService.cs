namespace System.ComponentModel.Design;

[Token(Token = "0x20001CD")]
public interface ITypeDescriptorFilterService
{

	[Token(Token = "0x6000B7F")]
	public bool FilterAttributes(IComponent component, IDictionary attributes) { }

	[Token(Token = "0x6000B80")]
	public bool FilterEvents(IComponent component, IDictionary events) { }

	[Token(Token = "0x6000B81")]
	public bool FilterProperties(IComponent component, IDictionary properties) { }

}


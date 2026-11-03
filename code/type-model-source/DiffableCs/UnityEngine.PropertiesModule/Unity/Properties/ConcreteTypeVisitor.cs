namespace Unity.Properties;

[Token(Token = "0x2000048")]
public abstract class ConcreteTypeVisitor : IPropertyBagVisitor
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600012D")]
	protected ConcreteTypeVisitor() { }

	[Address(RVA = "0x7A8580", Offset = "0x7A7980", Length = "0x65")]
	[Token(Token = "0x600012C")]
	private override void Unity.Properties.IPropertyBagVisitor.Visit(IPropertyBag<TContainer> properties, ref TContainer container) { }

	[Token(Token = "0x600012B")]
	protected abstract void VisitContainer(ref TContainer container) { }

}


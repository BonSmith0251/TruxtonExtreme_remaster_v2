namespace System.ComponentModel;

[Token(Token = "0x2000191")]
internal sealed class ReflectEventDescriptor : EventDescriptor
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000663")]
	private Type _type; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000664")]
	private readonly Type _componentClass; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000665")]
	private MethodInfo _addMethod; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000666")]
	private MethodInfo _removeMethod; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000667")]
	private EventInfo _realEvent; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000668")]
	private bool _filledMethods; //Field offset: 0x88

	[Address(RVA = "0x266B530", Offset = "0x266A930", Length = "0x146")]
	[Token(Token = "0x60009E2")]
	public ReflectEventDescriptor(Type componentClass, EventInfo eventInfo) { }

	[Address(RVA = "0x266A990", Offset = "0x2669D90", Length = "0x76")]
	[Token(Token = "0x60009E3")]
	protected virtual void FillAttributes(IList attributes) { }

	[Address(RVA = "0x266AA10", Offset = "0x2669E10", Length = "0x2E3")]
	[Token(Token = "0x60009E4")]
	private void FillEventInfoAttribute(EventInfo realEventInfo, IList attributes) { }

	[Address(RVA = "0x266AD00", Offset = "0x266A100", Length = "0x4FC")]
	[Token(Token = "0x60009E5")]
	private void FillMethods() { }

	[Address(RVA = "0x266B200", Offset = "0x266A600", Length = "0x325")]
	[Token(Token = "0x60009E6")]
	private void FillSingleMethodAttribute(MethodInfo realMethodInfo, IList attributes) { }

}


namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x2000048")]
public struct BindablePropertyChangedEventArgs
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000157")]
	private readonly BindingId m_PropertyName; //Field offset: 0x0

	[Token(Token = "0x17000048")]
	public BindingId propertyName
	{
		[Address(RVA = "0xAEF050", Offset = "0xAEE450", Length = "0x60")]
		[Token(Token = "0x6000219")]
		 get { } //Length: 96
	}

	[Address(RVA = "0x321EF80", Offset = "0x321E380", Length = "0x9F")]
	[Token(Token = "0x6000218")]
	public BindablePropertyChangedEventArgs(in BindingId propertyName) { }

	[Address(RVA = "0xAEF050", Offset = "0xAEE450", Length = "0x60")]
	[Token(Token = "0x6000219")]
	public BindingId get_propertyName() { }

}


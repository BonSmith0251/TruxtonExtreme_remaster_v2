namespace UnityEngine.UIElements;

[Token(Token = "0x2000049")]
public interface INotifyBindablePropertyChanged
{

	[Token(Token = "0x14000001")]
	public event EventHandler<BindablePropertyChangedEventArgs> propertyChanged
	{
		[CompilerGenerated]
		[Token(Token = "0x600021A")]
		 add { } //Length: 0
		[CompilerGenerated]
		[Token(Token = "0x600021B")]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	[Token(Token = "0x600021A")]
	public void add_propertyChanged(EventHandler<BindablePropertyChangedEventArgs> value) { }

	[CompilerGenerated]
	[Token(Token = "0x600021B")]
	public void remove_propertyChanged(EventHandler<BindablePropertyChangedEventArgs> value) { }

}


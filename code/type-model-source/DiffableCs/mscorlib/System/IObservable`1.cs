namespace System;

[Token(Token = "0x20000FA")]
public interface IObservable
{

	[Token(Token = "0x60007B0")]
	public IDisposable Subscribe(IObserver<T> observer) { }

}


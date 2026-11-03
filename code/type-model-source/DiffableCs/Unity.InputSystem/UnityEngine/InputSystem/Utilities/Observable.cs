namespace UnityEngine.InputSystem.Utilities;

[Extension]
[Token(Token = "0x2000257")]
public static class Observable
{
	[CompilerGenerated]
	[Token(Token = "0x2000258")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CB8")]
		public IDisposable subscription; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60015E5")]
		public <>c__DisplayClass6_0`1() { }

		[Address(RVA = "0xA74980", Offset = "0xA73D80", Length = "0x47")]
		[Token(Token = "0x60015E6")]
		internal void <CallOnce>b__0() { }

	}


	[Address(RVA = "0x89D040", Offset = "0x89C440", Length = "0x12E")]
	[Extension]
	[Token(Token = "0x60015E4")]
	public static IDisposable Call(IObservable<TValue> source, Action<TValue> action) { }

	[Address(RVA = "0x89CE40", Offset = "0x89C240", Length = "0x1FA")]
	[Extension]
	[Token(Token = "0x60015E3")]
	public static IDisposable CallOnce(IObservable<TValue> source, Action<TValue> action) { }

	[Address(RVA = "0x2924960", Offset = "0x2923D60", Length = "0xDD")]
	[Extension]
	[Token(Token = "0x60015E1")]
	public static IObservable<InputEventPtr> ForDevice(IObservable<InputEventPtr> source, InputDevice device) { }

	[Address(RVA = "0x89D170", Offset = "0x89C570", Length = "0xDD")]
	[Extension]
	[Token(Token = "0x60015E2")]
	public static IObservable<InputEventPtr> ForDevice(IObservable<InputEventPtr> source) { }

	[Address(RVA = "0x89D360", Offset = "0x89C760", Length = "0x105")]
	[Extension]
	[Token(Token = "0x60015DE")]
	public static IObservable<TResult> Select(IObservable<TSource> source, Func<TSource, TResult> filter) { }

	[Address(RVA = "0x89D250", Offset = "0x89C650", Length = "0x106")]
	[Extension]
	[Token(Token = "0x60015DF")]
	public static IObservable<TResult> SelectMany(IObservable<TSource> source, Func<TSource, IEnumerable`1<TResult>> filter) { }

	[Address(RVA = "0x89D470", Offset = "0x89C870", Length = "0x104")]
	[Extension]
	[Token(Token = "0x60015E0")]
	public static IObservable<TValue> Take(IObservable<TValue> source, int count) { }

	[Address(RVA = "0x89D690", Offset = "0x89CA90", Length = "0x105")]
	[Extension]
	[Token(Token = "0x60015DD")]
	public static IObservable<TValue> Where(IObservable<TValue> source, Func<TValue, Boolean> predicate) { }

}


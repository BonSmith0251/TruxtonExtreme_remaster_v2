namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001EA")]
internal class SelectObservable : IObservable<TResult>
{
	[Token(Token = "0x20001EB")]
	private class Select : IObserver<TSource>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AFD")]
		private SelectObservable<TSource, TResult> m_Observable; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AFE")]
		private readonly IObserver<TResult> m_Observer; //Field offset: 0x0

		[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
		[Token(Token = "0x600124E")]
		public Select(SelectObservable<TSource, TResult> observable, IObserver<TResult> observer) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600124F")]
		public override void OnCompleted() { }

		[Address(RVA = "0xF59500", Offset = "0xF58900", Length = "0x49")]
		[Token(Token = "0x6001250")]
		public override void OnError(Exception error) { }

		[Address(RVA = "0xF59550", Offset = "0xF58950", Length = "0xEE")]
		[Token(Token = "0x6001251")]
		public override void OnNext(TSource evt) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AFB")]
	private readonly IObservable<TSource> m_Source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AFC")]
	private readonly Func<TSource, TResult> m_Filter; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x600124C")]
	public SelectObservable`2(IObservable<TSource> source, Func<TSource, TResult> filter) { }

	[Address(RVA = "0xF59390", Offset = "0xF58790", Length = "0xCF")]
	[Token(Token = "0x600124D")]
	public override IDisposable Subscribe(IObserver<TResult> observer) { }

}


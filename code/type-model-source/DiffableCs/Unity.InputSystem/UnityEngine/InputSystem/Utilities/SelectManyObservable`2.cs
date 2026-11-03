namespace UnityEngine.InputSystem.Utilities;

[Token(Token = "0x200025A")]
internal class SelectManyObservable : IObservable<TResult>
{
	[Token(Token = "0x200025B")]
	private class Select : IObserver<TSource>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CBD")]
		private SelectManyObservable<TSource, TResult> m_Observable; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CBE")]
		private readonly IObserver<TResult> m_Observer; //Field offset: 0x0

		[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
		[Token(Token = "0x60015ED")]
		public Select(SelectManyObservable<TSource, TResult> observable, IObserver<TResult> observer) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60015EE")]
		public override void OnCompleted() { }

		[Address(RVA = "0xF59460", Offset = "0xF58860", Length = "0x49")]
		[Token(Token = "0x60015EF")]
		public override void OnError(Exception error) { }

		[Address(RVA = "0xF59840", Offset = "0xF58C40", Length = "0x3ED")]
		[Token(Token = "0x60015F0")]
		public override void OnNext(TSource evt) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CBB")]
	private readonly IObservable<TSource> m_Source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CBC")]
	private readonly Func<TSource, IEnumerable`1<TResult>> m_Filter; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x60015EB")]
	public SelectManyObservable`2(IObservable<TSource> source, Func<TSource, IEnumerable`1<TResult>> filter) { }

	[Address(RVA = "0xF592C0", Offset = "0xF586C0", Length = "0xC3")]
	[Token(Token = "0x60015EC")]
	public override IDisposable Subscribe(IObserver<TResult> observer) { }

}


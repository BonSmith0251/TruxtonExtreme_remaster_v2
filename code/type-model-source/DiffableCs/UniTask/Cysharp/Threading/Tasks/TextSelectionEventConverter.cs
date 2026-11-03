namespace Cysharp.Threading.Tasks;

[Token(Token = "0x200015C")]
internal class TextSelectionEventConverter : UnityEvent<ValueTuple`3<String, Int32, Int32>>, IDisposable
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000522")]
	private readonly UnityEvent<String, Int32, Int32> innerEvent; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000523")]
	private readonly UnityAction<String, Int32, Int32> invokeDelegate; //Field offset: 0x38

	[Address(RVA = "0x278B510", Offset = "0x278A910", Length = "0xCB")]
	[Token(Token = "0x600084B")]
	public TextSelectionEventConverter(UnityEvent<String, Int32, Int32> unityEvent) { }

	[Address(RVA = "0x278B440", Offset = "0x278A840", Length = "0x48")]
	[Token(Token = "0x600084D")]
	public override void Dispose() { }

	[Address(RVA = "0x278B490", Offset = "0x278A890", Length = "0x78")]
	[Token(Token = "0x600084C")]
	private void InvokeCore(string item1, int item2, int item3) { }

}


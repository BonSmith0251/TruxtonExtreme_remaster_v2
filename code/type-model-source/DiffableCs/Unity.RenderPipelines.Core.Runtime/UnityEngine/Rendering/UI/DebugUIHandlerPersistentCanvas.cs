namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002E7")]
internal class DebugUIHandlerPersistentCanvas : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x20002E8")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000D6F")]
		public Value widget; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600147B")]
		public <>c__DisplayClass3_0() { }

		[Address(RVA = "0x2CBFA90", Offset = "0x2CBEE90", Length = "0x1E")]
		[Token(Token = "0x600147C")]
		internal bool <Toggle>b__0(DebugUIHandlerValue x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002E9")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000D70")]
		public ValueTuple widget; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600147D")]
		public <>c__DisplayClass5_0() { }

		[Address(RVA = "0x2CBFAB0", Offset = "0x2CBEEB0", Length = "0x8")]
		[Token(Token = "0x600147E")]
		internal bool <Toggle>b__0(ValueTuple x) { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D6B")]
	public RectTransform panel; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D6C")]
	public RectTransform valuePrefab; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D6D")]
	private List<DebugUIHandlerValue> m_Items; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000D6E")]
	private List<ValueTuple> m_ValueTupleWidgets; //Field offset: 0x38

	[Address(RVA = "0x2CB40B0", Offset = "0x2CB34B0", Length = "0xBD")]
	[Token(Token = "0x600147A")]
	public DebugUIHandlerPersistentCanvas() { }

	[Address(RVA = "0x2CB37E0", Offset = "0x2CB2BE0", Length = "0x19D")]
	[Token(Token = "0x6001479")]
	internal void Clear() { }

	[Address(RVA = "0x2CB3980", Offset = "0x2CB2D80", Length = "0x40")]
	[Token(Token = "0x6001478")]
	internal bool IsEmpty() { }

	[Address(RVA = "0x2CB39D0", Offset = "0x2CB2DD0", Length = "0x2F8")]
	[Token(Token = "0x6001476")]
	internal void Toggle(Value widget, string displayName = null) { }

	[Address(RVA = "0x2CB3CD0", Offset = "0x2CB30D0", Length = "0x3DC")]
	[Token(Token = "0x6001477")]
	internal void Toggle(ValueTuple widget, Nullable<Int32> forceTupleIndex = null) { }

}


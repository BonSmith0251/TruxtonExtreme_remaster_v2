namespace UnityEngine.UI;

[AddComponentMenu("UI (Canvas)/Button", 30)]
[Token(Token = "0x2000005")]
public class Button : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler
{
	[CompilerGenerated]
	[Token(Token = "0x2000007")]
	private sealed class <OnFinishSubmit>d__9 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000011")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000012")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000013")]
		public Button <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000014")]
		private float <fadeTime>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000015")]
		private float <elapsedTime>5__3; //Field offset: 0x2C

		[Token(Token = "0x17000007")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000019")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000008")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600001B")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000016")]
		public <OnFinishSubmit>d__9(int <>1__state) { }

		[Address(RVA = "0x31EC9B0", Offset = "0x31EBDB0", Length = "0x12D")]
		[Token(Token = "0x6000018")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000019")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600001B")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x31ECAE0", Offset = "0x31EBEE0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600001A")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000017")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000006")]
	internal class ButtonClickedEvent : UnityEvent
	{

		[Address(RVA = "0x1E16870", Offset = "0x1E15C70", Length = "0x7")]
		[Token(Token = "0x6000015")]
		public ButtonClickedEvent() { }

	}

	[FieldOffset(Offset = "0x100")]
	[FormerlySerializedAs("onClick")]
	[SerializeField]
	[Token(Token = "0x4000010")]
	private ButtonClickedEvent m_OnClick; //Field offset: 0x100

	[Token(Token = "0x17000006")]
	public ButtonClickedEvent onClick
	{
		[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
		[Token(Token = "0x600000F")]
		 get { } //Length: 8
		[Address(RVA = "0x20D5820", Offset = "0x20D4C20", Length = "0x13")]
		[Token(Token = "0x6000010")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x31D11E0", Offset = "0x31D05E0", Length = "0x8D")]
	[Token(Token = "0x600000E")]
	protected Button() { }

	[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
	[Token(Token = "0x600000F")]
	public ButtonClickedEvent get_onClick() { }

	[Address(RVA = "0x31D0FD0", Offset = "0x31D03D0", Length = "0x67")]
	[IteratorStateMachine(typeof(<OnFinishSubmit>d__9))]
	[Token(Token = "0x6000014")]
	private IEnumerator OnFinishSubmit() { }

	[Address(RVA = "0x31D1040", Offset = "0x31D0440", Length = "0x27")]
	[Token(Token = "0x6000012")]
	public override void OnPointerClick(PointerEventData eventData) { }

	[Address(RVA = "0x31D1070", Offset = "0x31D0470", Length = "0xD4")]
	[Token(Token = "0x6000013")]
	public override void OnSubmit(BaseEventData eventData) { }

	[Address(RVA = "0x31D1150", Offset = "0x31D0550", Length = "0x8E")]
	[Token(Token = "0x6000011")]
	private void Press() { }

	[Address(RVA = "0x20D5820", Offset = "0x20D4C20", Length = "0x13")]
	[Token(Token = "0x6000010")]
	public void set_onClick(ButtonClickedEvent value) { }

}


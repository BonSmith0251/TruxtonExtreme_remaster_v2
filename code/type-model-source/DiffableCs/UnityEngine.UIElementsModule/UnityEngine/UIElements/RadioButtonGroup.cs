namespace UnityEngine.UIElements;

[Token(Token = "0x2000138")]
public class RadioButtonGroup : BaseField<Int32>, IGroupBox
{
	[CompilerGenerated]
	[Token(Token = "0x200013B")]
	private sealed class <get_choices>d__17 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000607")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000608")]
		private string <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000609")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400060A")]
		public RadioButtonGroup <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400060B")]
		private PooledObject<List`1<RadioButton>> <_>5__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400060C")]
		private List<RadioButton> <radioButtons>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400060D")]
		private Enumerator<RadioButton> <>s__3; //Field offset: 0x48
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400060E")]
		private RadioButton <button>5__4; //Field offset: 0x60

		[Token(Token = "0x1700019E")]
		private override string System.Collections.Generic.IEnumerator<System.String>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600099A")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700019F")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600099C")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000995")]
		public <get_choices>d__17(int <>1__state) { }

		[Address(RVA = "0x33A7F20", Offset = "0x33A7320", Length = "0x41")]
		[Token(Token = "0x6000998")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x33A7F70", Offset = "0x33A7370", Length = "0x41")]
		[Token(Token = "0x6000999")]
		private void <>m__Finally2() { }

		[Address(RVA = "0x33A7A60", Offset = "0x33A6E60", Length = "0x2D1")]
		[Token(Token = "0x6000997")]
		private override bool MoveNext() { }

		[Address(RVA = "0x33A7D40", Offset = "0x33A7140", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x600099D")]
		private override IEnumerator<String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600099A")]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[Address(RVA = "0x33A7D40", Offset = "0x33A7140", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x600099E")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600099C")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x33A7DE0", Offset = "0x33A71E0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600099B")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x33A7E20", Offset = "0x33A7220", Length = "0xF9")]
		[DebuggerHidden]
		[Token(Token = "0x6000996")]
		private override void System.IDisposable.Dispose() { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000139")]
	internal class UxmlFactory : UxmlFactory<RadioButtonGroup, UxmlTraits>
	{

		[Address(RVA = "0x33A8040", Offset = "0x33A7440", Length = "0x39")]
		[Token(Token = "0x6000992")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200013A")]
	internal class UxmlTraits : BaseFieldTraits<Int32, UxmlIntAttributeDescription>
	{
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000606")]
		private UxmlStringAttributeDescription m_Choices; //Field offset: 0xA0

		[Address(RVA = "0x33AB280", Offset = "0x33AA680", Length = "0xA7")]
		[Token(Token = "0x6000994")]
		public UxmlTraits() { }

		[Address(RVA = "0x33AA050", Offset = "0x33A9450", Length = "0x148")]
		[Token(Token = "0x6000993")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40005F9")]
	internal static readonly BindingId choicesProperty; //Field offset: 0x0
	[Token(Token = "0x40005FA")]
	public static readonly string ussClassName; //Field offset: 0x98
	[Token(Token = "0x40005FB")]
	public static readonly string containerUssClassName; //Field offset: 0xA0
	[Token(Token = "0x40005FC")]
	internal static readonly string containerName; //Field offset: 0xA8
	[Token(Token = "0x40005FD")]
	internal static readonly string choicesContainerName; //Field offset: 0xB0
	[FieldOffset(Offset = "0x358")]
	[Token(Token = "0x40005FE")]
	private VisualElement m_ChoiceRadioButtonContainer; //Field offset: 0x358
	[FieldOffset(Offset = "0x360")]
	[Token(Token = "0x40005FF")]
	private VisualElement m_ContentContainer; //Field offset: 0x360
	[FieldOffset(Offset = "0x368")]
	[Token(Token = "0x4000600")]
	private UQueryBuilder<RadioButton> m_GetAllRadioButtonsQuery; //Field offset: 0x368
	[FieldOffset(Offset = "0x398")]
	[Token(Token = "0x4000601")]
	private readonly List<RadioButton> m_RegisteredRadioButtons; //Field offset: 0x398
	[FieldOffset(Offset = "0x3A0")]
	[Token(Token = "0x4000602")]
	private RadioButton m_SelectedRadioButton; //Field offset: 0x3A0
	[FieldOffset(Offset = "0x3A8")]
	[Token(Token = "0x4000603")]
	private EventCallback<ChangeEvent`1<Boolean>> m_RadioButtonValueChangedCallback; //Field offset: 0x3A8
	[FieldOffset(Offset = "0x3B0")]
	[Token(Token = "0x4000604")]
	private bool m_UpdatingButtons; //Field offset: 0x3B0
	[FieldOffset(Offset = "0x3B8")]
	[Token(Token = "0x4000605")]
	private List<String> m_Choices; //Field offset: 0x3B8

	[CreateProperty]
	[Token(Token = "0x1700019B")]
	public IEnumerable<String> choices
	{
		[Address(RVA = "0x3397420", Offset = "0x3396820", Length = "0x71")]
		[IteratorStateMachine(typeof(<get_choices>d__17))]
		[Token(Token = "0x600097F")]
		 get { } //Length: 113
		[Address(RVA = "0x33974D0", Offset = "0x33968D0", Length = "0x142")]
		[Token(Token = "0x6000980")]
		 set { } //Length: 322
	}

	[Token(Token = "0x1700019C")]
	internal List<String> choicesList
	{
		[Address(RVA = "0x33974C0", Offset = "0x33968C0", Length = "0x8")]
		[Token(Token = "0x6000982")]
		internal set { } //Length: 8
	}

	[Token(Token = "0x1700019D")]
	public virtual VisualElement contentContainer
	{
		[Address(RVA = "0x33974A0", Offset = "0x33968A0", Length = "0x12")]
		[Token(Token = "0x6000983")]
		 get { } //Length: 18
	}

	[Address(RVA = "0x3396D90", Offset = "0x3396190", Length = "0x25C")]
	[Token(Token = "0x600098F")]
	private static RadioButtonGroup() { }

	[Address(RVA = "0x3396FF0", Offset = "0x33963F0", Length = "0x412")]
	[Token(Token = "0x6000985")]
	public RadioButtonGroup(string label, List<String> radioButtonChoices = null) { }

	[Address(RVA = "0x3397410", Offset = "0x3396810", Length = "0xD")]
	[Token(Token = "0x6000984")]
	public RadioButtonGroup() { }

	[Address(RVA = "0x33961C0", Offset = "0x33955C0", Length = "0xA")]
	[CompilerGenerated]
	[Token(Token = "0x6000991")]
	private void <ScheduleRadioButtons>b__31_0() { }

	[Address(RVA = "0x33961D0", Offset = "0x33955D0", Length = "0x375")]
	[CompilerGenerated]
	[Token(Token = "0x6000990")]
	internal static bool <set_choices>g__AreListEqual|18_0(List<String> list1, IEnumerable<String> list2) { }

	[Address(RVA = "0x3397420", Offset = "0x3396820", Length = "0x71")]
	[IteratorStateMachine(typeof(<get_choices>d__17))]
	[Token(Token = "0x600097F")]
	public IEnumerable<String> get_choices() { }

	[Address(RVA = "0x33974A0", Offset = "0x33968A0", Length = "0x12")]
	[Token(Token = "0x6000983")]
	public virtual VisualElement get_contentContainer() { }

	[Address(RVA = "0x3395760", Offset = "0x3394B60", Length = "0xC0")]
	[Token(Token = "0x6000988")]
	private void GetAllRadioButtons(List<RadioButton> radioButtons) { }

	[Address(RVA = "0x3395830", Offset = "0x3394C30", Length = "0x262")]
	[Token(Token = "0x6000986")]
	private void RadioButtonValueChangedCallback(ChangeEvent<Boolean> evt) { }

	[Address(RVA = "0x3395AA0", Offset = "0x3394EA0", Length = "0x2EC")]
	[Token(Token = "0x6000981")]
	private void RebuildRadioButtonsFromChoices() { }

	[Address(RVA = "0x3395D90", Offset = "0x3395190", Length = "0x302")]
	[Token(Token = "0x600098B")]
	private void RegisterRadioButton(RadioButton radioButton) { }

	[Address(RVA = "0x33960A0", Offset = "0x33954A0", Length = "0xB9")]
	[Token(Token = "0x600098A")]
	private void ScheduleRadioButtons() { }

	[Address(RVA = "0x33974D0", Offset = "0x33968D0", Length = "0x142")]
	[Token(Token = "0x6000980")]
	public void set_choices(IEnumerable<String> value) { }

	[Address(RVA = "0x33974C0", Offset = "0x33968C0", Length = "0x8")]
	[Token(Token = "0x6000982")]
	internal void set_choicesList(List<String> value) { }

	[Address(RVA = "0x3396160", Offset = "0x3395560", Length = "0x53")]
	[Token(Token = "0x6000987")]
	public virtual void SetValueWithoutNotify(int newValue) { }

	[Address(RVA = "0x3396550", Offset = "0x3395950", Length = "0xBC")]
	[Token(Token = "0x600098D")]
	private override void UnityEngine.UIElements.IGroupBox.OnOptionAdded(IGroupBoxOption option) { }

	[Address(RVA = "0x3396610", Offset = "0x3395A10", Length = "0x197")]
	[Token(Token = "0x600098E")]
	private override void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(IGroupBoxOption option) { }

	[Address(RVA = "0x33967B0", Offset = "0x3395BB0", Length = "0xB1")]
	[Token(Token = "0x600098C")]
	private void UnregisterRadioButton(RadioButton radioButton) { }

	[Address(RVA = "0x3396870", Offset = "0x3395C70", Length = "0x515")]
	[Token(Token = "0x6000989")]
	private void UpdateRadioButtons(bool notify) { }

}


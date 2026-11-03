namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x2000162")]
public abstract class TextValueField : TextInputBaseField<TValueType>, IValueField<TValueType>
{
	[Token(Token = "0x2000163")]
	internal abstract class TextValueInput : TextInputBase<TValueType>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000709")]
		private string <formatString>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x170001DD")]
		protected abstract string allowedCharacters
		{
			[Token(Token = "0x6000AD4")]
			 get { } //Length: 0
		}

		[Token(Token = "0x170001DE")]
		public string formatString
		{
			[Address(RVA = "0x1081820", Offset = "0x1080C20", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x6000AD5")]
			 get { } //Length: 8
			[Address(RVA = "0x10818D0", Offset = "0x1080CD0", Length = "0x13")]
			[CompilerGenerated]
			[Token(Token = "0x6000AD6")]
			 set { } //Length: 19
		}

		[Token(Token = "0x170001DC")]
		private TextValueField<TValueType> textValueFieldParent
		{
			[Address(RVA = "0x1081830", Offset = "0x1080C30", Length = "0x92")]
			[Token(Token = "0x6000AD1")]
			private get { } //Length: 146
		}

		[Address(RVA = "0x1081620", Offset = "0x1080A20", Length = "0xFB")]
		[Token(Token = "0x6000AD2")]
		protected TextValueInput() { }

		[Address(RVA = "0x1080150", Offset = "0x107F550", Length = "0x84")]
		[Token(Token = "0x6000AD3")]
		internal virtual bool AcceptCharacter(char c) { }

		[Token(Token = "0x6000AD7")]
		public abstract void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue) { }

		[Token(Token = "0x6000AD4")]
		protected abstract string get_allowedCharacters() { }

		[Address(RVA = "0x1081820", Offset = "0x1080C20", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000AD5")]
		public string get_formatString() { }

		[Address(RVA = "0x1081830", Offset = "0x1080C30", Length = "0x92")]
		[Token(Token = "0x6000AD1")]
		private TextValueField<TValueType> get_textValueFieldParent() { }

		[Address(RVA = "0x10818D0", Offset = "0x1080CD0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000AD6")]
		public void set_formatString(string value) { }

		[Address(RVA = "0x10804C0", Offset = "0x107F8C0", Length = "0x81")]
		[Token(Token = "0x6000AD8")]
		public void StartDragging() { }

		[Address(RVA = "0x1080700", Offset = "0x107FB00", Length = "0x147")]
		[Token(Token = "0x6000AD9")]
		public void StopDragging() { }

		[Address(RVA = "0x1080FE0", Offset = "0x10803E0", Length = "0x26")]
		[Token(Token = "0x6000ADB")]
		protected virtual TValueType StringToValue(string str) { }

		[Token(Token = "0x6000ADA")]
		protected abstract string ValueToString(TValueType value) { }

	}

	[Token(Token = "0x4000704")]
	internal static readonly BindingId formatStringProperty; //Field offset: 0x0
	[Token(Token = "0x4000705")]
	internal static readonly BindingId supportExpressionsProperty; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000706")]
	private BaseFieldMouseDragger m_Dragger; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000707")]
	private bool m_ForceUpdateDisplay; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000708")]
	private bool m_SupportExpressions; //Field offset: 0x0

	[CreateProperty]
	[Token(Token = "0x170001DB")]
	public string formatString
	{
		[Address(RVA = "0x107EAC0", Offset = "0x107DEC0", Length = "0x88")]
		[Token(Token = "0x6000ABF")]
		 get { } //Length: 136
		[Address(RVA = "0x107F410", Offset = "0x107E810", Length = "0x247")]
		[Token(Token = "0x6000AC0")]
		 set { } //Length: 583
	}

	[CreateProperty]
	[Token(Token = "0x170001DA")]
	public bool supportExpressions
	{
		[Address(RVA = "0x107EBA0", Offset = "0x107DFA0", Length = "0x8")]
		[Token(Token = "0x6000ABD")]
		 get { } //Length: 8
		[Address(RVA = "0x107FE70", Offset = "0x107F270", Length = "0x93")]
		[Token(Token = "0x6000ABE")]
		 set { } //Length: 147
	}

	[Token(Token = "0x170001D9")]
	private TextValueInput<TValueType> textValueInput
	{
		[Address(RVA = "0x107EBE0", Offset = "0x107DFE0", Length = "0x89")]
		[Token(Token = "0x6000ABC")]
		private get { } //Length: 137
	}

	[Address(RVA = "0x107C4A0", Offset = "0x107B8A0", Length = "0x351")]
	[Token(Token = "0x6000AD0")]
	private static TextValueField`1() { }

	[Address(RVA = "0x107DC40", Offset = "0x107D040", Length = "0x1E3")]
	[Token(Token = "0x6000AC1")]
	protected TextValueField`1(string label, int maxLength, TextValueInput<TValueType> textValueInput) { }

	[Address(RVA = "0x6A6830", Offset = "0x6A5C30", Length = "0x10E")]
	[Token(Token = "0x6000AC9")]
	protected void AddLabelDragger() { }

	[Token(Token = "0x6000AC2")]
	public abstract void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000AC8")]
	internal override bool CanTryParse(string textString) { }

	[Address(RVA = "0x1076C80", Offset = "0x1076080", Length = "0xD3")]
	[Token(Token = "0x6000ACA")]
	private void EnableLabelDragger(bool enable) { }

	[Address(RVA = "0x107EAC0", Offset = "0x107DEC0", Length = "0x88")]
	[Token(Token = "0x6000ABF")]
	public string get_formatString() { }

	[Address(RVA = "0x107EBA0", Offset = "0x107DFA0", Length = "0x8")]
	[Token(Token = "0x6000ABD")]
	public bool get_supportExpressions() { }

	[Address(RVA = "0x107EBE0", Offset = "0x107DFE0", Length = "0x89")]
	[Token(Token = "0x6000ABC")]
	private TextValueInput<TValueType> get_textValueInput() { }

	[Address(RVA = "0x10779D0", Offset = "0x1076DD0", Length = "0x2B9")]
	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(BlurEvent), typeof(FocusEvent)})]
	[Token(Token = "0x6000ACC")]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x10782E0", Offset = "0x10776E0", Length = "0xE7")]
	[Token(Token = "0x6000AC7")]
	private void OnIsReadOnlyChanged(bool newValue) { }

	[Address(RVA = "0x1078470", Offset = "0x1077870", Length = "0x1E")]
	[Token(Token = "0x6000ACD")]
	internal virtual void OnViewDataReady() { }

	[Address(RVA = "0x1078540", Offset = "0x1077940", Length = "0x139")]
	[Token(Token = "0x6000ACE")]
	internal virtual void RegisterEditingCallbacks() { }

	[Address(RVA = "0x107F410", Offset = "0x107E810", Length = "0x247")]
	[Token(Token = "0x6000AC0")]
	public void set_formatString(string value) { }

	[Address(RVA = "0x107FE70", Offset = "0x107F270", Length = "0x93")]
	[Token(Token = "0x6000ABE")]
	public void set_supportExpressions(bool value) { }

	[Address(RVA = "0x10798F0", Offset = "0x1078CF0", Length = "0x255")]
	[Token(Token = "0x6000ACB")]
	public virtual void SetValueWithoutNotify(TValueType newValue) { }

	[Address(RVA = "0x107A770", Offset = "0x1079B70", Length = "0x129")]
	[Token(Token = "0x6000AC3")]
	public override void StartDragging() { }

	[Address(RVA = "0x107B1B0", Offset = "0x107A5B0", Length = "0x1CD")]
	[Token(Token = "0x6000AC4")]
	public override void StopDragging() { }

	[Address(RVA = "0x107B510", Offset = "0x107A910", Length = "0x139")]
	[Token(Token = "0x6000ACF")]
	internal virtual void UnregisterEditingCallbacks() { }

	[Address(RVA = "0x107BDB0", Offset = "0x107B1B0", Length = "0x6E")]
	[Token(Token = "0x6000AC6")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal virtual void UpdateTextFromValue() { }

	[Address(RVA = "0x107C1C0", Offset = "0x107B5C0", Length = "0xFB")]
	[Token(Token = "0x6000AC5")]
	internal virtual void UpdateValueFromText() { }

}


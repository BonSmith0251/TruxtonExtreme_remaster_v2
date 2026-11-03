namespace UnityEngine.UIElements;

[Token(Token = "0x2000026")]
internal class BindingUpdater
{
	[Token(Token = "0x2000027")]
	private sealed class CastDataSourceVisitor : ConcreteTypeVisitor
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400005A")]
		private DataBinding <Binding>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400005B")]
		private BindingContext <bindingContext>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x150")]
		[Token(Token = "0x400005C")]
		private BindingResult <result>k__BackingField; //Field offset: 0x150

		[Token(Token = "0x1700002A")]
		public DataBinding Binding
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60000BA")]
			 get { } //Length: 5
			[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60000BB")]
			 set { } //Length: 13
		}

		[Token(Token = "0x1700002B")]
		public BindingContext bindingContext
		{
			[Address(RVA = "0x31F22C0", Offset = "0x31F16C0", Length = "0x90")]
			[CompilerGenerated]
			[Token(Token = "0x60000BC")]
			 get { } //Length: 144
			[Address(RVA = "0x31F2350", Offset = "0x31F1750", Length = "0x8C")]
			[CompilerGenerated]
			[Token(Token = "0x60000BD")]
			 set { } //Length: 140
		}

		[Token(Token = "0x1700002C")]
		public BindingResult result
		{
			[Address(RVA = "0x2EF42F0", Offset = "0x2EF36F0", Length = "0xE")]
			[CompilerGenerated]
			[Token(Token = "0x60000BE")]
			 get { } //Length: 14
			[Address(RVA = "0x31F23E0", Offset = "0x31F17E0", Length = "0x18")]
			[CompilerGenerated]
			[Token(Token = "0x60000BF")]
			 set { } //Length: 24
		}

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60000C2")]
		public CastDataSourceVisitor() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60000BA")]
		public DataBinding get_Binding() { }

		[Address(RVA = "0x31F22C0", Offset = "0x31F16C0", Length = "0x90")]
		[CompilerGenerated]
		[Token(Token = "0x60000BC")]
		public BindingContext get_bindingContext() { }

		[Address(RVA = "0x2EF42F0", Offset = "0x2EF36F0", Length = "0xE")]
		[CompilerGenerated]
		[Token(Token = "0x60000BE")]
		public BindingResult get_result() { }

		[Address(RVA = "0x31F21E0", Offset = "0x31F15E0", Length = "0xDC")]
		[Token(Token = "0x60000C0")]
		public void Reset() { }

		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60000BB")]
		public void set_Binding(DataBinding value) { }

		[Address(RVA = "0x31F2350", Offset = "0x31F1750", Length = "0x8C")]
		[CompilerGenerated]
		[Token(Token = "0x60000BD")]
		public void set_bindingContext(BindingContext value) { }

		[Address(RVA = "0x31F23E0", Offset = "0x31F17E0", Length = "0x18")]
		[CompilerGenerated]
		[Token(Token = "0x60000BF")]
		public void set_result(BindingResult value) { }

		[Address(RVA = "0x9F11F0", Offset = "0x9F05F0", Length = "0x129")]
		[Token(Token = "0x60000C1")]
		protected virtual void VisitContainer(ref TContainer container) { }

	}

	[Token(Token = "0x2000028")]
	private sealed class UIPathVisitor : PathVisitor
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x400005D")]
		private DataBinding <binding>k__BackingField; //Field offset: 0xB8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x400005E")]
		private BindingUpdateStage <direction>k__BackingField; //Field offset: 0xC0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x400005F")]
		private BindingContext <bindingContext>k__BackingField; //Field offset: 0xC8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x200")]
		[Token(Token = "0x4000060")]
		private BindingResult <result>k__BackingField; //Field offset: 0x200

		[Token(Token = "0x1700002D")]
		public DataBinding binding
		{
			[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x60000C3")]
			 get { } //Length: 8
			[Address(RVA = "0x9F1CB0", Offset = "0x9F10B0", Length = "0x13")]
			[CompilerGenerated]
			[Token(Token = "0x60000C4")]
			 set { } //Length: 19
		}

		[Token(Token = "0x1700002F")]
		public BindingContext bindingContext
		{
			[Address(RVA = "0x3210D40", Offset = "0x3210140", Length = "0x92")]
			[CompilerGenerated]
			[Token(Token = "0x60000C7")]
			 get { } //Length: 146
			[Address(RVA = "0x3210DF0", Offset = "0x32101F0", Length = "0x8F")]
			[CompilerGenerated]
			[Token(Token = "0x60000C8")]
			 set { } //Length: 143
		}

		[Token(Token = "0x1700002E")]
		public BindingUpdateStage direction
		{
			[Address(RVA = "0x1BC5710", Offset = "0x1BC4B10", Length = "0x7")]
			[CompilerGenerated]
			[Token(Token = "0x60000C5")]
			 get { } //Length: 7
			[Address(RVA = "0x21439F0", Offset = "0x2142DF0", Length = "0x7")]
			[CompilerGenerated]
			[Token(Token = "0x60000C6")]
			 set { } //Length: 7
		}

		[Token(Token = "0x17000030")]
		public BindingResult result
		{
			[Address(RVA = "0x3210DE0", Offset = "0x32101E0", Length = "0xE")]
			[CompilerGenerated]
			[Token(Token = "0x60000C9")]
			 get { } //Length: 14
			[Address(RVA = "0x3210E80", Offset = "0x3210280", Length = "0x18")]
			[CompilerGenerated]
			[Token(Token = "0x60000CA")]
			 set { } //Length: 24
		}

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60000CD")]
		public UIPathVisitor() { }

		[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000C3")]
		public DataBinding get_binding() { }

		[Address(RVA = "0x3210D40", Offset = "0x3210140", Length = "0x92")]
		[CompilerGenerated]
		[Token(Token = "0x60000C7")]
		public BindingContext get_bindingContext() { }

		[Address(RVA = "0x1BC5710", Offset = "0x1BC4B10", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60000C5")]
		public BindingUpdateStage get_direction() { }

		[Address(RVA = "0x3210DE0", Offset = "0x32101E0", Length = "0xE")]
		[CompilerGenerated]
		[Token(Token = "0x60000C9")]
		public BindingResult get_result() { }

		[Address(RVA = "0x3210C30", Offset = "0x3210030", Length = "0x107")]
		[Token(Token = "0x60000CB")]
		public virtual void Reset() { }

		[Address(RVA = "0x9F1CB0", Offset = "0x9F10B0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000C4")]
		public void set_binding(DataBinding value) { }

		[Address(RVA = "0x3210DF0", Offset = "0x32101F0", Length = "0x8F")]
		[CompilerGenerated]
		[Token(Token = "0x60000C8")]
		public void set_bindingContext(BindingContext value) { }

		[Address(RVA = "0x21439F0", Offset = "0x2142DF0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60000C6")]
		public void set_direction(BindingUpdateStage value) { }

		[Address(RVA = "0x3210E80", Offset = "0x3210280", Length = "0x18")]
		[CompilerGenerated]
		[Token(Token = "0x60000CA")]
		public void set_result(BindingResult value) { }

		[Address(RVA = "0x9FB6C0", Offset = "0x9FAAC0", Length = "0x23C")]
		[Token(Token = "0x60000CC")]
		protected virtual void VisitPath(Property<TContainer, TValue> property, ref TContainer container, ref TValue value) { }

	}

	[Token(Token = "0x4000058")]
	private static readonly CastDataSourceVisitor s_VisitDataSourceAsRootVisitor; //Field offset: 0x0
	[Token(Token = "0x4000059")]
	private static readonly UIPathVisitor s_VisitDataSourceAtPathVisitor; //Field offset: 0x8

	[Address(RVA = "0x31F1DF0", Offset = "0x31F11F0", Length = "0xC4")]
	[Token(Token = "0x60000B9")]
	private static BindingUpdater() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60000B8")]
	public BindingUpdater() { }

	[Address(RVA = "0x31EF7A0", Offset = "0x31EEBA0", Length = "0x218")]
	[Token(Token = "0x60000B6")]
	internal static string GetExtractValueErrorString(VisitReturnCode returnCode, object target, in PropertyPath path) { }

	[Address(RVA = "0x31EF9E0", Offset = "0x31EEDE0", Length = "0x7F")]
	[Token(Token = "0x60000B7")]
	internal static string GetRootDataSourceError(object target) { }

	[Address(RVA = "0x31EFA60", Offset = "0x31EEE60", Length = "0x228")]
	[Token(Token = "0x60000B5")]
	internal static string GetVisitationErrorString(VisitReturnCode returnCode, in BindingContext context) { }

	[Address(RVA = "0x31EFCB0", Offset = "0x31EF0B0", Length = "0x32D")]
	[Token(Token = "0x60000A9")]
	public bool ShouldProcessBindingAtStage(Binding bindingObject, BindingUpdateStage stage, bool versionChanged, bool dirty) { }

	[Address(RVA = "0x31F00F0", Offset = "0x31EF4F0", Length = "0xD3")]
	[Token(Token = "0x60000AB")]
	private bool ShouldProcessBindingAtStage(CustomBinding customBinding, BindingUpdateStage stage, bool versionChanged, bool dirty) { }

	[Address(RVA = "0x31EFFE0", Offset = "0x31EF3E0", Length = "0x104")]
	[Token(Token = "0x60000AA")]
	private static bool ShouldProcessBindingAtStage(DataBinding dataBinding, BindingUpdateStage stage, bool versionChanged, bool dirty) { }

	[Address(RVA = "0x31F01D0", Offset = "0x31EF5D0", Length = "0xA64")]
	[Token(Token = "0x60000B2")]
	private static BindingResult TryUpdateUIWithNonContainer(in BindingContext context, DataBinding binding, object value) { }

	[Address(RVA = "0x31F0CC0", Offset = "0x31F00C0", Length = "0x555")]
	[Token(Token = "0x60000B0")]
	private BindingResult UpdateDataSource(in BindingContext context, DataBinding dataBinding) { }

	[Address(RVA = "0x31F0C80", Offset = "0x31F0080", Length = "0x3C")]
	[Token(Token = "0x60000B1")]
	private BindingResult UpdateDataSource(in BindingContext context, CustomBinding customBinding) { }

	[Address(RVA = "0x31F1220", Offset = "0x31F0620", Length = "0x1A6")]
	[Token(Token = "0x60000AD")]
	public BindingResult UpdateSource(in BindingContext context, Binding bindingObject) { }

	[Address(RVA = "0x31F13D0", Offset = "0x31F07D0", Length = "0x46")]
	[Token(Token = "0x60000AF")]
	private BindingResult UpdateUI(in BindingContext context, CustomBinding customBinding) { }

	[Address(RVA = "0x31F18B0", Offset = "0x31F0CB0", Length = "0x1A2")]
	[Token(Token = "0x60000AC")]
	public BindingResult UpdateUI(in BindingContext context, Binding bindingObject) { }

	[Address(RVA = "0x31F1420", Offset = "0x31F0820", Length = "0x48B")]
	[Token(Token = "0x60000AE")]
	private BindingResult UpdateUI(in BindingContext context, DataBinding dataBinding) { }

	[Address(RVA = "0x797A00", Offset = "0x796E00", Length = "0x3C6")]
	[Token(Token = "0x60000B4")]
	private static ValueTuple<Boolean, VisitReturnCode, VisitReturnCode, BindingResult> VisitAtPath(DataBinding dataBinding, BindingUpdateStage direction, ref TContainer container, in PropertyPath path, in BindingContext context) { }

	[Address(RVA = "0x31F1A60", Offset = "0x31F0E60", Length = "0x386")]
	[Token(Token = "0x60000B3")]
	private static ValueTuple<Boolean, VisitReturnCode, BindingResult> VisitRoot(DataBinding dataBinding, ref object container, in BindingContext context) { }

}

